namespace HastaneProjem
{
    partial class Doktorgiris
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Location = new Point(152, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SeaShell;
            textBox2.Location = new Point(152, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(152, 189);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 9;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 70);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 10;
            label1.Text = "Doktor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 136);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 11;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 12;
            label3.Text = "Kullanıcı adı ya da şifre yanlış";
            // 
            // button2
            // 
            button2.Location = new Point(152, 238);
            button2.Name = "button2";
            button2.Size = new Size(142, 29);
            button2.TabIndex = 14;
            button2.Text = "Ana Menüye Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Doktorgiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(381, 346);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Doktorgiris";
            Text = "Doktor Girişi";
            Load += Doktorgiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}