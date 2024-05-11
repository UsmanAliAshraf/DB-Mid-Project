namespace itcrafts.UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            panel1 = new Panel();
            CloseBtn = new Button();
            panel2 = new Panel();
            LogInBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 37);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 48);
            label1.TabIndex = 1;
            label1.Text = "ELECTRA PULSE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(19, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(47, 0, 47, 0);
            label2.Size = new Size(643, 61);
            label2.TabIndex = 2;
            label2.Text = "Efficient Management System for Electronic Device Manufacturing";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(145, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 4;
            label3.Text = "Username";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(145, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameInput.Location = new Point(266, 16);
            UsernameInput.Margin = new Padding(4, 3, 4, 3);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(230, 25);
            UsernameInput.TabIndex = 6;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordInput.Location = new Point(266, 61);
            PasswordInput.Margin = new Padding(4, 3, 4, 3);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(230, 25);
            PasswordInput.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(PasswordInput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(UsernameInput);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(19, 230);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 107);
            panel1.TabIndex = 8;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.None;
            CloseBtn.Location = new Point(196, 10);
            CloseBtn.Margin = new Padding(4, 3, 4, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(122, 33);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(LogInBtn);
            panel2.Controls.Add(CloseBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(19, 337);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 54);
            panel2.TabIndex = 9;
            // 
            // LogInBtn
            // 
            LogInBtn.Anchor = AnchorStyles.None;
            LogInBtn.Location = new Point(326, 10);
            LogInBtn.Margin = new Padding(4, 3, 4, 3);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(122, 33);
            LogInBtn.TabIndex = 0;
            LogInBtn.Text = "Start";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += StartClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(681, 433);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            Opacity = 0.8D;
            Padding = new Padding(19, 37, 19, 37);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogInBtn;
    }
}