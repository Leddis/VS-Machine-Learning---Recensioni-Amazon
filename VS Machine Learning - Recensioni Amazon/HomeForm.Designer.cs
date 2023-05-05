namespace VS_Machine_Learning___Recensioni_Amazon
{
    partial class HomeForm
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
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "Form1";
        //}

        private void InitializeComponent()
        {
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 204);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(406, 273);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 342);
            button1.Name = "button1";
            button1.Size = new Size(406, 39);
            button1.TabIndex = 2;
            button1.Text = "Recensisci";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AmazonLogo;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(345, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "INFO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 393);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "Amazon";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;


        #endregion

        private PictureBox pictureBox1;
        private Button button2;
    }
}