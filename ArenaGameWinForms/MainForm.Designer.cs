namespace ArenaGameWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bNewGame = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ListBoxKnight = new ListBox();
            ListBoxRogue = new ListBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // bNewGame
            // 
            bNewGame.Location = new Point(694, 12);
            bNewGame.Name = "bNewGame";
            bNewGame.Size = new Size(172, 29);
            bNewGame.TabIndex = 0;
            bNewGame.Text = "New Game";
            bNewGame.UseVisualStyleBackColor = true;
            bNewGame.Click += bNewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(530, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
           
            // 
            // ListBoxKnight
            // 
            ListBoxKnight.FormattingEnabled = true;
            ListBoxKnight.Location = new Point(29, 245);
            ListBoxKnight.Name = "ListBoxKnight";
            ListBoxKnight.Size = new Size(313, 324);
            ListBoxKnight.TabIndex = 3;
            ListBoxKnight.SelectedIndexChanged += ListBoxKnight_SelectedIndexChanged;
            // 
            // ListBoxRogue
            // 
            ListBoxRogue.FormattingEnabled = true;
            ListBoxRogue.Location = new Point(459, 245);
            ListBoxRogue.Name = "ListBoxRogue";
            ListBoxRogue.Size = new Size(313, 324);
            ListBoxRogue.TabIndex = 4;
            ListBoxRogue.SelectedIndexChanged += ListBoxRogue_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1200, 245);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(291, 324);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(770, 245);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(291, 324);
            listBox2.TabIndex = 7;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1271, 92);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(875, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 601);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(ListBoxRogue);
            Controls.Add(ListBoxKnight);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bNewGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox ListBoxKnight;
        private ListBox ListBoxRogue;
        private ListBox listBox1;
        private ListBox listBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
