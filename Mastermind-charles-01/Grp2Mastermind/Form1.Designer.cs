namespace Grp2Mastermind
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picGameBoard = new System.Windows.Forms.PictureBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnViolet = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnGuessOLD = new System.Windows.Forms.Button();
            this.btnGenButtons = new System.Windows.Forms.Button();
            this.txtWinTest = new System.Windows.Forms.TextBox();
            this.txtValueCheck = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(65, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(72, 241);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 1;
            // 
            // picGameBoard
            // 
            this.picGameBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGameBoard.BackgroundImage")));
            this.picGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGameBoard.Enabled = false;
            this.picGameBoard.InitialImage = null;
            this.picGameBoard.Location = new System.Drawing.Point(256, 10);
            this.picGameBoard.Name = "picGameBoard";
            this.picGameBoard.Size = new System.Drawing.Size(418, 767);
            this.picGameBoard.TabIndex = 2;
            this.picGameBoard.TabStop = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gainsboro;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn0.Enabled = false;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(300, 636);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(30, 30);
            this.btn0.TabIndex = 3;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Visible = false;
            this.btn0.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Enabled = false;
            this.pic1.Location = new System.Drawing.Point(292, 37);
            this.pic1.Margin = new System.Windows.Forms.Padding(4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(32, 28);
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Enabled = false;
            this.pic2.Location = new System.Drawing.Point(350, 37);
            this.pic2.Margin = new System.Windows.Forms.Padding(4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(32, 28);
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Enabled = false;
            this.pic3.Location = new System.Drawing.Point(407, 37);
            this.pic3.Margin = new System.Windows.Forms.Padding(4);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(32, 28);
            this.pic3.TabIndex = 6;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic4.Enabled = false;
            this.pic4.Location = new System.Drawing.Point(464, 37);
            this.pic4.Margin = new System.Windows.Forms.Padding(4);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(32, 28);
            this.pic4.TabIndex = 7;
            this.pic4.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.Enabled = false;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(357, 636);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 8;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2.Enabled = false;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(414, 636);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 30);
            this.btn2.TabIndex = 9;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3.Enabled = false;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(471, 636);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 10;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRed.Enabled = false;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.White;
            this.btnRed.Location = new System.Drawing.Point(49, 624);
            this.btnRed.Margin = new System.Windows.Forms.Padding(2);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(61, 55);
            this.btnRed.TabIndex = 11;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlue.Enabled = false;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Location = new System.Drawing.Point(124, 624);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(61, 55);
            this.btnBlue.TabIndex = 12;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreen.Enabled = false;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.White;
            this.btnGreen.Location = new System.Drawing.Point(49, 552);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(61, 55);
            this.btnGreen.TabIndex = 13;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYellow.Enabled = false;
            this.btnYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.ForeColor = System.Drawing.Color.Black;
            this.btnYellow.Location = new System.Drawing.Point(124, 552);
            this.btnYellow.Margin = new System.Windows.Forms.Padding(2);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(61, 55);
            this.btnYellow.TabIndex = 14;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhite.Enabled = false;
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.Location = new System.Drawing.Point(49, 475);
            this.btnWhite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(61, 55);
            this.btnWhite.TabIndex = 15;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlack.Enabled = false;
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(124, 475);
            this.btnBlack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(61, 55);
            this.btnBlack.TabIndex = 16;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrange.Enabled = false;
            this.btnOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrange.ForeColor = System.Drawing.Color.Black;
            this.btnOrange.Location = new System.Drawing.Point(49, 398);
            this.btnOrange.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(61, 55);
            this.btnOrange.TabIndex = 17;
            this.btnOrange.Text = "Orange";
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = System.Drawing.Color.Violet;
            this.btnViolet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViolet.Enabled = false;
            this.btnViolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolet.ForeColor = System.Drawing.Color.Black;
            this.btnViolet.Location = new System.Drawing.Point(124, 398);
            this.btnViolet.Margin = new System.Windows.Forms.Padding(2);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(61, 55);
            this.btnViolet.TabIndex = 18;
            this.btnViolet.Text = "Violet";
            this.btnViolet.UseVisualStyleBackColor = false;
            this.btnViolet.Click += new System.EventHandler(this.btnViolet_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(13, 52);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 19;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 20;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(65, 75);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnGuessOLD
            // 
            this.btnGuessOLD.Location = new System.Drawing.Point(592, 636);
            this.btnGuessOLD.Name = "btnGuessOLD";
            this.btnGuessOLD.Size = new System.Drawing.Size(58, 30);
            this.btnGuessOLD.TabIndex = 22;
            this.btnGuessOLD.Text = "Guess";
            this.btnGuessOLD.UseVisualStyleBackColor = true;
            this.btnGuessOLD.Visible = false;
            this.btnGuessOLD.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnGenButtons
            // 
            this.btnGenButtons.Location = new System.Drawing.Point(65, 298);
            this.btnGenButtons.Name = "btnGenButtons";
            this.btnGenButtons.Size = new System.Drawing.Size(75, 48);
            this.btnGenButtons.TabIndex = 23;
            this.btnGenButtons.Text = "Buttons";
            this.btnGenButtons.UseVisualStyleBackColor = true;
            this.btnGenButtons.Click += new System.EventHandler(this.btnGenButtons_Click);
            // 
            // txtWinTest
            // 
            this.txtWinTest.Location = new System.Drawing.Point(25, 704);
            this.txtWinTest.Name = "txtWinTest";
            this.txtWinTest.Size = new System.Drawing.Size(210, 20);
            this.txtWinTest.TabIndex = 24;
            // 
            // txtValueCheck
            // 
            this.txtValueCheck.Location = new System.Drawing.Point(72, 743);
            this.txtValueCheck.Name = "txtValueCheck";
            this.txtValueCheck.Size = new System.Drawing.Size(100, 20);
            this.txtValueCheck.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 791);
            this.Controls.Add(this.txtValueCheck);
            this.Controls.Add(this.txtWinTest);
            this.Controls.Add(this.btnGenButtons);
            this.Controls.Add(this.btnGuessOLD);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnViolet);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGameBoard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picGameBoard;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnViolet;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnGuessOLD;
        private System.Windows.Forms.Button btnGenButtons;
        private System.Windows.Forms.TextBox txtWinTest;
        private System.Windows.Forms.TextBox txtValueCheck;
    }
}

