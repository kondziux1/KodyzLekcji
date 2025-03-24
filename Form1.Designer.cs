namespace MojeDźwiękiApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblWykonawca = new Label();
            lblTytul = new Label();
            lblSzczegoly = new Label();
            button1 = new Button();
            lblPobrania = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(688, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 72);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += buttonPrevious_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 205);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 70);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += buttonNext_Click;
            // 
            // lblWykonawca
            // 
            lblWykonawca.AutoSize = true;
            lblWykonawca.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblWykonawca.ForeColor = Color.White;
            lblWykonawca.Location = new Point(334, 124);
            lblWykonawca.Name = "lblWykonawca";
            lblWykonawca.RightToLeft = RightToLeft.Yes;
            lblWykonawca.Size = new Size(193, 67);
            lblWykonawca.TabIndex = 3;
            lblWykonawca.Text = "Gorillaz";
            lblWykonawca.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTytul
            // 
            lblTytul.AutoSize = true;
            lblTytul.Font = new Font("Segoe UI", 40F, FontStyle.Italic, GraphicsUnit.Pixel, 1, true);
            lblTytul.ForeColor = Color.White;
            lblTytul.Location = new Point(334, 205);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(297, 54);
            lblTytul.TabIndex = 4;
            lblTytul.Text = "\"The Now Now\"";
            // 
            // lblSzczegoly
            // 
            lblSzczegoly.AutoSize = true;
            lblSzczegoly.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSzczegoly.ForeColor = Color.FromArgb(97, 217, 24);
            lblSzczegoly.Location = new Point(352, 296);
            lblSzczegoly.Name = "lblSzczegoly";
            lblSzczegoly.Size = new Size(34, 28);
            lblSzczegoly.TabIndex = 5;
            lblSzczegoly.Text = "11";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(97, 217, 24);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(246, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 7;
            button1.Text = "Pobierz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblPobrania
            // 
            lblPobrania.AutoSize = true;
            lblPobrania.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPobrania.ForeColor = Color.FromArgb(97, 217, 24);
            lblPobrania.Location = new Point(126, 358);
            lblPobrania.Name = "lblPobrania";
            lblPobrania.Size = new Size(100, 28);
            lblPobrania.TabIndex = 8;
            lblPobrania.Text = "11000102";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPobrania);
            Controls.Add(button1);
            Controls.Add(lblSzczegoly);
            Controls.Add(lblTytul);
            Controls.Add(lblWykonawca);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "MojeDźwięki, Wykonał: XXXXXXXX";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblWykonawca;
        private Label lblTytul;
        private Label lblSzczegoly;
        private Button button1;
        private Label lblPobrania;
    }
}
