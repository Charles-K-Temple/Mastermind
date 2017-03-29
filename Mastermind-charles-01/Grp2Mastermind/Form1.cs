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

        int[] computerPix = new int[4];
        int[] playerPix = new int[4];

        int PointerColor = 0;
        int TryCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SEED = rng.Next(13, 137);
            computerPix = RNGArray.GenerateNonRepeatingNumbers(SEED, 8, 4);
            string str = "";
            for (int i = 0; i < computerPix.Length; i++)
            {
                str += "  :  ";
                str += computerPix[i].ToString();
            }
            textBox1.Text = str;
            ShowSolution();
        }
        public void GenerateTryButtons(int y)
        {
            TryCount++;
            for (int x = 0; x < 4; x++)
            {
                CreateButton(300 + 57 * x, 636 - 57 * y, "btn" + x + y, Color.LightGray);
            }
            CreateGuessButton(592, 636 - 57 * y, "Guess", "btnGuess", Color.LightBlue);

        }
        public Button CreateButton(int xCoord, int yCoord, string name, Color color)
        {
            Button btn = new Button();
            btn.Location = new Point(xCoord, yCoord);
            btn.Show();
            btn.Name = name;
            //btn.Text = text;
            btn.Size = new Size(30, 30);
            btn.BackColor = color;
            //event handler
            Controls.Add(btn);
            btn.Visible = true;
            btn.Click += new EventHandler(ColorButtonClick);
            return btn;
        }
        public Button CreateGuessButton(int xCoord, int yCoord, string text, string name, Color color)
        {
            Button btn = new Button();
            btn.Location = new Point(xCoord, yCoord);
            btn.Show();
            btn.Name = name;
            //btn.Text = text;
            btn.Size = new Size(58, 30);
            btn.BackColor = color;
            //event handler
            Controls.Add(btn);
            btn.Visible = true;
            btn.Click += new EventHandler(btnGuess_Click);
            return btn;
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string colorX = ColorClass.color(PointerColor);

            button.Visible = true;
            button.BackColor = Color.FromName(colorX);
            //here you can check which button was clicked by the sender
            char i = button.Name[3];
            int x = Convert.ToInt32("" + i);
            txtValueCheck.Text = button.Name;
            playerPix[x] = PointerColor;
        }

        private void ShowSolution()
        {
            pic1.BackColor = Color.FromName(ColorClass.color(computerPix[0]));
            pic2.BackColor = Color.FromName(ColorClass.color(computerPix[1]));
            pic3.BackColor = Color.FromName(ColorClass.color(computerPix[2]));
            pic4.BackColor = Color.FromName(ColorClass.color(computerPix[3]));
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

        List<PlayerClass> playerList = new List<PlayerClass>();

        // validate the player name
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            PlayerClass newPlayer = new PlayerClass();
            newPlayer.Name = name;
            playerList.Add(newPlayer); // creates a new player object

            if (name == "")
            {
                MessageBox.Show("Please enter a valid name", "Error");
                txtName.Focus();
                txtName.Clear();
            }

            else
            {
                MessageBox.Show("success");
                //this.Size = new Size(900, 750);
                txtName.Visible = false;
                txtName.Enabled = false;
                lblEnterName.Visible = false;
                btnEnter.Visible = false;

                btn1.Enabled = true;
                btn0.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btnBlack.Enabled = true;
                btnBlue.Enabled = true;
                btnGreen.Enabled = true;
                btnOrange.Enabled = true;
                btnRed.Enabled = true;
                btnViolet.Enabled = true;
                btnWhite.Enabled = true;
                btnYellow.Enabled = true;
                pic1.Enabled = true;
                pic2.Enabled = true;
                pic3.Enabled = true;
                pic4.Enabled = true;
                button1.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            TryCount++;
            int M = WinCondition.Matches(computerPix, playerPix);
            int I = WinCondition.InOrder(computerPix, playerPix);
            bool W = WinCondition.Winner(computerPix, playerPix);
            txtWinTest.Text = "M: " + M + "  I: " + I + "  W:" + W;
            // do peg programming here
            // 
        }

        private void btnGenButtons_Click(object sender, EventArgs e)
        {
            GenerateTryButtons(TryCount);
            picGameBoard.SendToBack();
        }
    }
}
