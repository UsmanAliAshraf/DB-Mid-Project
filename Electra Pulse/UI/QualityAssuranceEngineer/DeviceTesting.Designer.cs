﻿namespace itcrafts.UI
{
    partial class DeviceTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceTesting));
            pictureBox1 = new PictureBox();
            Title = new Label();
            GoBackBtn = new Button();
            DeviceTestsTable = new DataGridView();
            label1 = new Label();
            TitleBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CreateButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            BodyBox = new RichTextBox();
            label4 = new Label();
            DeviceBox = new ComboBox();
            PerformanceBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeviceTestsTable).BeginInit();
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
            Title.Size = new Size(195, 59);
            Title.TabIndex = 13;
            Title.Text = "Device Testing";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += Title_Click;
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
            // DeviceDefectsTable
            // 
            DeviceTestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeviceTestsTable.Location = new Point(490, 107);
            DeviceTestsTable.Name = "DeviceDefectsTable";
            DeviceTestsTable.Size = new Size(560, 358);
            DeviceTestsTable.TabIndex = 17;
            DeviceTestsTable.RowHeaderMouseClick += HandleRowClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 107);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 18;
            label1.Text = "Device";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(23, 207);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(206, 25);
            TitleBox.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 20;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(246, 107);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 22;
            label3.Text = "Body";
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
            // BodyBox
            // 
            BodyBox.Location = new Point(246, 136);
            BodyBox.Name = "BodyBox";
            BodyBox.Size = new Size(196, 165);
            BodyBox.TabIndex = 27;
            BodyBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 247);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 28;
            label4.Text = "Performance";
            label4.Click += label4_Click;
            // 
            // DeviceBox
            // 
            DeviceBox.FormattingEnabled = true;
            DeviceBox.Location = new Point(23, 136);
            DeviceBox.Name = "DeviceBox";
            DeviceBox.Size = new Size(205, 25);
            DeviceBox.TabIndex = 30;
            // 
            // PerformanceBox
            // 
            PerformanceBox.FormattingEnabled = true;
            PerformanceBox.Location = new Point(23, 276);
            PerformanceBox.Name = "PerformanceBox";
            PerformanceBox.Size = new Size(206, 25);
            PerformanceBox.TabIndex = 31;
            // 
            // DeviceTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1073, 493);
            ControlBox = false;
            Controls.Add(PerformanceBox);
            Controls.Add(DeviceBox);
            Controls.Add(label4);
            Controls.Add(BodyBox);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(CreateButton);
            Controls.Add(label3);
            Controls.Add(TitleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeviceTestsTable);
            Controls.Add(GoBackBtn);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeviceTesting";
            Opacity = 0.9D;
            Padding = new Padding(19, 42, 19, 42);
            StartPosition = FormStartPosition.CenterScreen;
            Load += DeviceTesting_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeviceTestsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private Button GoBackBtn;
        private DataGridView DeviceTestsTable;
        private Label label1;
        private TextBox TitleBox;
        private Label label2;
        private Label label3;
        private Button CreateButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private RichTextBox BodyBox;
        private Label label4;
        private ComboBox DeviceBox;
        private ComboBox PerformanceBox;
    }
}