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

        private void btn0_Click(object sender, EventArgs e)
        {
            string colorX = "Red";
            //Color = Color.FromName.
            btn0.Visible = true;
            btn0.BackColor = Color.FromName(colorX);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
           pic1.BackColor = Color.FromName(colors[computerPix[0]]);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic2.BackColor = Color.FromName(colors[computerPix[1]]);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            pic3.BackColor = Color.FromName(colors[computerPix[2]]);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            pic4.BackColor = Color.FromName(colors[computerPix[3]]);
        }
    }
}
