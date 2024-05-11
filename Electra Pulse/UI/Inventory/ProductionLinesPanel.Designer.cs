﻿namespace itcrafts.UI
{
    partial class ProductionLinesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionLinesPanel));
            pictureBox1 = new PictureBox();
            Title = new Label();
            GoBackBtn = new Button();
            UsersTable = new DataGridView();
            label1 = new Label();
            Name = new TextBox();
            label2 = new Label();
            CreateButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            Description = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersTable).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 25);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(105, 25);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(285, 59);
            Title.TabIndex = 13;
            Title.Text = "Production Lines Panel";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GoBackBtn
            // 
            GoBackBtn.Location = new Point(236, 434);
            GoBackBtn.Margin = new Padding(4);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(206, 31);
            GoBackBtn.TabIndex = 16;
            GoBackBtn.Text = "Go Back";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBack;
            // 
            // MaterialTable
            // 
            UsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTable.Location = new Point(490, 107);
            UsersTable.Name = "MaterialTable";
            UsersTable.Size = new Size(560, 358);
            UsersTable.TabIndex = 17;
            UsersTable.RowHeaderMouseClick += HandleRowClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 107);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // Name
            // 
            Name.Location = new Point(23, 136);
            Name.Name = "Name";
            Name.Size = new Size(419, 25);
            Name.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 20;
            label2.Text = "Description";
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(22, 395);
            CreateButton.Margin = new Padding(4);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(206, 31);
            CreateButton.TabIndex = 24;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(22, 434);
            UpdateButton.Margin = new Padding(4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(206, 31);
            UpdateButton.TabIndex = 25;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateClick;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(236, 395);
            DeleteButton.Margin = new Padding(4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(206, 31);
            DeleteButton.TabIndex = 26;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteClick;
            // 
            // Description
            // 
            Description.Location = new Point(22, 211);
            Description.Name = "Description";
            Description.Size = new Size(420, 93);
            Description.TabIndex = 27;
            Description.Text = "";
            // 
            // ProductionLinesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1073, 493);
            ControlBox = false;
            Controls.Add(Description);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(CreateButton);
            Controls.Add(label2);
            Controls.Add(Name);
            Controls.Add(label1);
            Controls.Add(UsersTable);
            Controls.Add(GoBackBtn);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Opacity = 0.9D;
            Padding = new Padding(19, 42, 19, 42);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private Button GoBackBtn;
        private DataGridView UsersTable;
        private Label label1;
        private TextBox Name;
        private Label label2;
        private Button CreateButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private RichTextBox Description;
    }
}