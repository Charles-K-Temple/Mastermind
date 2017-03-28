using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grp2Mastermind
{
    public partial class Form1 : Form
    {
        // Seed the RNG.
        Random rng = new Random();
        string[] colors = new string[] { "blank", "Red", "Blue", "Green", "Yellow", "White", "Black", "Orange", "Violet" };
        int[] computerPix = new int[4];
        int PointerColor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SEED = rng.Next(13, 137);
            computerPix = GenerateNonRepeatingNumbers(SEED, 1, 8);
            string str = "";
            for (int i = 0; i < 4; i++)
            {
                str += "  :  ";
                str += computerPix[i].ToString();
            }
            textBox1.Text = str;
            ShowSolution();
        }

        /*
         * The following is mostly lifted from
         * http://stackoverflow.com/questions/22737687/how-to-create-an-array-of-non-repeating-random-numbers
         * with some design changes to suit our needs
         * 
         * */
        public int[] GenerateNonRepeatingNumbers(int seed, int min, int range)
        {
            // Make sure range is an appropriate value
            if (range <= 0)
            {
                throw new ArgumentException("Range must be greater than zero.");
            }

            // Make an array to hold our numbers
            int[] numbers = new int[range];

            // Seed the RNG.
            // Random rng = new Random(seed);

            // Fill the array with all numbers from min to min + range
            for (int i = 0; i < range; numbers[i] = min + i++) { }

            int
                a = 0, // Swap index
                t = 0; // Temporary value storage

            // Scramble the values
            for (int i = 0; i < range; i++)
            {
                // Get a random index that isn't i
                while ((a = rng.Next(range)) == i) { };
                // Store the old value at i
                t = numbers[i];
                // Change the old value to the value at the random index
                numbers[i] = numbers[a];
                // Set value at random index to our old value from numbers[i]
                numbers[a] = t;
            }

            return numbers;
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string colorX = colors[PointerColor];
            button.Visible = true;
            button.BackColor = Color.FromName(colorX);
            //here you can check which button was clicked by the sender
        }

        private void ShowSolution()
        {
            pic1.BackColor = Color.FromName(colors[computerPix[0]]);
            pic2.BackColor = Color.FromName(colors[computerPix[1]]);
            pic3.BackColor = Color.FromName(colors[computerPix[2]]);
            pic4.BackColor = Color.FromName(colors[computerPix[3]]);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            PointerColor = 1;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            PointerColor = 2;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            PointerColor = 3;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            PointerColor = 4;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            PointerColor = 5;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            PointerColor = 6;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            PointerColor = 7;
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            PointerColor = 8;
        }
    }
}
