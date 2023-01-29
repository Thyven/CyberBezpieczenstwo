using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberBezpieczenstwo.PopUpForms
{

    public class Images
    {
        public int ID { get; set; }
        public Color color { get; set; }
        public string text { get; set; }

        public List<Image> imageSet = new List<Image>();

    }




    public partial class CaptchaForm : Form
    {
        private List<Panel> squares;
        private Random rand;
        int numSquares;
        int size;
        int squareCountter;
        int numberOfCorrectSquares;





        // List of squares and their ID
        private Dictionary<Panel, int> squaresDictionary = new Dictionary<Panel, int>();

        // Get random panel image to be correct
        static private Random r = new Random();
        int correctPanel = r.Next(0, 3);

        // Reverse control main form
        private Validator validator;

        List<Images> colorPalette = new List<Images>
            {
                new Images { ID = 0, text = "Pociągi", imageSet = FillImageList(@"IMG\Train\")},
                new Images { ID = 1, text = "Auta",  imageSet = FillImageList(@"IMG\Auto\") },
                new Images { ID = 2, text = "Rowery", imageSet = FillImageList(@"IMG\bike\")},
                new Images { ID = 3, text = "Busy", imageSet = FillImageList(@"IMG\bus\") }
            };



        public CaptchaForm(Validator parent)
        {
            validator = parent as Validator;


            this.BringToFront();

            InitializeComponent();

            // Set the form properties
            this.Size = new Size(800, 800);

            // Initialize variables
            this.squares = new List<Panel>();
            this.rand = new Random();
            this.numSquares = 16;
            this.size = (int)(this.ClientSize.Width * 0.8) / (int)Math.Sqrt(numSquares);
            // Create the squares
            for (int i = 0; i < numSquares; i++)
            {
                Panel square = new Panel();
                Images img1 = RandomImages();
                squaresDictionary.Add(square, img1.ID);
                square.BackgroundImage = img1.imageSet[rand.Next(0,3)];
                square.BackgroundImageLayout = ImageLayout.Stretch;

                square.BorderStyle = BorderStyle.FixedSingle;
                square.Size = new Size(size, size);
                square.Click += new EventHandler(OnSquareClick);
                this.squares.Add(square);
                groupBox1.Controls.Add(square);
            }

            // Position the squares on the form
            int x = (int)(this.groupBox1.Width * 0.01), y = (int)(this.groupBox1.Height * 0.01);
            for (int i = 0; i < this.squares.Count; i++)
            {
                this.squares[i].Location = new Point(x, y);
                x += this.squares[i].Width;
                if (x + this.squares[i].Width > this.groupBox1.Width)
                {
                    x = (int)(this.groupBox1.Width * 0.01);
                    y += this.squares[i].Height;
                }
            }

            // Text
            label1.Text = $"Zaznacz wszystkie: {colorPalette[correctPanel].text}";
        }
        private Images RandomImages()
        {
            squareCountter++;
            int index = rand.Next(0, 3);
            if (squareCountter == 14) colorPalette[index] = colorPalette[correctPanel];
            return colorPalette[index];
        }

        static public List<Image> FillImageList(string directory)
        {
            List<Image> imageSet = new List<Image>();
            string[] jpgFiles = Directory.GetFiles(directory, "*.*");

            for (int i = 0; i < jpgFiles.Length; i++)
            {
                Image image = Image.FromFile(jpgFiles[i]);
                imageSet.Add(image);
            }
            return imageSet;
        }

        private void OnSquareClick(object sender, EventArgs e)
        {

            Panel square = sender as Panel;

            if (square.BorderStyle == BorderStyle.FixedSingle)
            {
                Debug.WriteLine($"Correct Panel: {correctPanel}");
                Debug.WriteLine($"Selected: {squaresDictionary[square]}");

                if (squaresDictionary[square] == correctPanel)
                {
                    numberOfCorrectSquares++;
                    Debug.WriteLine($"Correct: {numberOfCorrectSquares}");
                }
                square.BorderStyle = BorderStyle.Fixed3D; // adds a 3D border
                square.Cursor = Cursors.No; // changes the cursor to a "no" cursor
            }
            else
            {
                square.BorderStyle = BorderStyle.FixedSingle; // remove the border
                square.Cursor = Cursors.Hand; // changes the cursor to a "hand" cursor

                if (squaresDictionary[square] == correctPanel)
                {
                    numberOfCorrectSquares--;
                    Debug.WriteLine($"Correct: {numberOfCorrectSquares}");
                }
            }
        }


        // Check how many black
        private int CountSquaresWithID(int id)
        {
            int count = 0;
            foreach (var square in squaresDictionary)
            {
                if (square.Value == id)
                {
                    count++;
                }
            }
            return count;
        }

        private void ResetLabelError()
        {
            try
            {
                this.Invoke((Action)delegate
                {
                    this.Enabled = true;
                });
                groupBox1.Invoke((Action)delegate
                {
                    groupBox1.Enabled = true;
                });
            }
            catch (Exception)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var howManyCorrect = CountSquaresWithID(correctPanel);
            Debug.WriteLine($"!!! corr number:{howManyCorrect} !!!");

            if (howManyCorrect == numberOfCorrectSquares)
            {
                Debug.WriteLine("!!! PASS !!!");

                this.validator.captcha = true;
                this.validator.Enabled = true;
                this.Close();
            }
            else
            {
                Debug.WriteLine("!!! FAILL !!!");
                this.Enabled = false;
                groupBox1.Enabled = false;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }
        }

        private void CaptchaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.validator.Enabled = true;
        }
    }
}
