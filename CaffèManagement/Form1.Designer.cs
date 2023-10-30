namespace CaffèManagement
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(269, 33);
            label1.TabIndex = 1;
            label1.Text = "Cafè Pirandello";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(132, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(132, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 280);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(89, 353);
            button1.Name = "button1";
            button1.Size = new Size(204, 34);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(143, 408);
            label4.Name = "label4";
            label4.Size = new Size(87, 34);
            label4.TabIndex = 8;
            label4.Text = "Guest";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(427, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 497);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(37, 183);
            label5.Name = "label5";
            label5.Size = new Size(392, 43);
            label5.TabIndex = 3;
            label5.Text = "Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(190, 219);
            label6.Name = "label6";
            label6.Size = new Size(239, 43);
            label6.TabIndex = 4;
            label6.Text = "By Nelexiad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 494);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label label5;
    }
}