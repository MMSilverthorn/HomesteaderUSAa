﻿namespace HomesteaderUSA
{
    partial class Health
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Health));
            HealthDGV = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            DashboardTab = new Label();
            panel4 = new Panel();
            BreedTabLabel = new Label();
            panel1 = new Panel();
            MilkTab = new Label();
            panel7 = new Panel();
            AnimalTabLabel = new Label();
            panel9 = new Panel();
            HealthTab = new Label();
            panel10 = new Panel();
            ProductLogTab = new Label();
            panel3 = new Panel();
            SidePanel = new Panel();
            label4 = new Label();
            CloseProgram = new Label();
            label1 = new Label();
            label3 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            textBox8 = new TextBox();
            label14 = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            label15 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Date = new DateTimePicker();
            label10 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)HealthDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            SidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // HealthDGV
            // 
            HealthDGV.BackgroundColor = SystemColors.ButtonFace;
            HealthDGV.BorderStyle = BorderStyle.Fixed3D;
            HealthDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            HealthDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HealthDGV.Location = new Point(214, 323);
            HealthDGV.Name = "HealthDGV";
            HealthDGV.RowTemplate.Height = 25;
            HealthDGV.Size = new Size(922, 363);
            HealthDGV.TabIndex = 32;
            HealthDGV.CellContentClick += HealthDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 30;
            label2.Text = "Health";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DashboardTab
            // 
            DashboardTab.AutoSize = true;
            DashboardTab.BackColor = Color.Maroon;
            DashboardTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardTab.ForeColor = SystemColors.ButtonFace;
            DashboardTab.Location = new Point(54, 17);
            DashboardTab.Name = "DashboardTab";
            DashboardTab.Size = new Size(100, 19);
            DashboardTab.TabIndex = 12;
            DashboardTab.Text = "Dashboard";
            DashboardTab.Click += DashboardTab_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardTab);
            panel4.Location = new Point(0, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 60);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // BreedTabLabel
            // 
            BreedTabLabel.AutoSize = true;
            BreedTabLabel.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BreedTabLabel.ForeColor = SystemColors.ButtonFace;
            BreedTabLabel.Location = new Point(40, 18);
            BreedTabLabel.Name = "BreedTabLabel";
            BreedTabLabel.Size = new Size(122, 19);
            BreedTabLabel.TabIndex = 12;
            BreedTabLabel.Text = "Breeding Log";
            BreedTabLabel.Click += BreedTabLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BreedTabLabel);
            panel1.Location = new Point(0, 509);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 60);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // MilkTab
            // 
            MilkTab.AutoSize = true;
            MilkTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MilkTab.ForeColor = SystemColors.ButtonFace;
            MilkTab.Location = new Point(40, 20);
            MilkTab.Name = "MilkTab";
            MilkTab.Size = new Size(148, 19);
            MilkTab.TabIndex = 12;
            MilkTab.Text = "Milk Production";
            MilkTab.Click += MilkTab_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Maroon;
            panel7.Controls.Add(MilkTab);
            panel7.Location = new Point(0, 267);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 60);
            panel7.TabIndex = 12;
            panel7.Paint += panel7_Paint;
            // 
            // AnimalTabLabel
            // 
            AnimalTabLabel.AutoSize = true;
            AnimalTabLabel.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AnimalTabLabel.ForeColor = SystemColors.ButtonFace;
            AnimalTabLabel.Location = new Point(63, 20);
            AnimalTabLabel.Name = "AnimalTabLabel";
            AnimalTabLabel.Size = new Size(77, 19);
            AnimalTabLabel.TabIndex = 11;
            AnimalTabLabel.Text = "Animals";
            AnimalTabLabel.Click += AnimalTabLabel_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Maroon;
            panel9.Controls.Add(AnimalTabLabel);
            panel9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel9.Location = new Point(0, 189);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 60);
            panel9.TabIndex = 13;
            panel9.Paint += panel9_Paint;
            // 
            // HealthTab
            // 
            HealthTab.AutoSize = true;
            HealthTab.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HealthTab.ForeColor = Color.Maroon;
            HealthTab.Location = new Point(40, 23);
            HealthTab.Name = "HealthTab";
            HealthTab.Size = new Size(132, 25);
            HealthTab.TabIndex = 12;
            HealthTab.Text = "Health Log";
            HealthTab.Click += HealthTab_Click;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonFace;
            panel10.Controls.Add(HealthTab);
            panel10.Location = new Point(0, 427);
            panel10.Name = "panel10";
            panel10.Size = new Size(209, 60);
            panel10.TabIndex = 9;
            panel10.Paint += panel10_Paint;
            // 
            // ProductLogTab
            // 
            ProductLogTab.AutoSize = true;
            ProductLogTab.BackColor = Color.Transparent;
            ProductLogTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductLogTab.ForeColor = SystemColors.ButtonFace;
            ProductLogTab.Location = new Point(48, 20);
            ProductLogTab.Name = "ProductLogTab";
            ProductLogTab.Size = new Size(114, 19);
            ProductLogTab.TabIndex = 12;
            ProductLogTab.Text = "Product Log";
            ProductLogTab.Click += ProductLogTab_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(ProductLogTab);
            panel3.Location = new Point(0, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 60);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Maroon;
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel10);
            SidePanel.Controls.Add(panel9);
            SidePanel.Controls.Add(panel7);
            SidePanel.Controls.Add(panel1);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(0, -7);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(209, 708);
            SidePanel.TabIndex = 29;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(84, 665);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "Ver 1.0";
            label4.Click += label4_Click;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1116, 7);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 28;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(497, 7);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 27;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(227, 297);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 31;
            label3.Text = " Health  Log";
            label3.Click += label3_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1003, 262);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 39);
            Clear.TabIndex = 49;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Maroon;
            Delete.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(897, 262);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 48;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Maroon;
            Edit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = SystemColors.ButtonFace;
            Edit.Location = new Point(793, 262);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 39);
            Edit.TabIndex = 47;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            Save.BackColor = Color.Maroon;
            Save.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(697, 262);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 46;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(829, 212);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 23);
            textBox8.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(936, 173);
            label14.Name = "label14";
            label14.Size = new Size(56, 19);
            label14.TabIndex = 42;
            label14.Text = "Notes";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(262, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 24);
            comboBox1.TabIndex = 90;
            comboBox1.Text = "Choose One";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(335, 214);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(134, 23);
            textBox7.TabIndex = 89;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(372, 180);
            label15.Name = "label15";
            label15.Size = new Size(46, 19);
            label15.TabIndex = 88;
            label15.Text = "Cost";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(511, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 23);
            textBox5.TabIndex = 87;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(849, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(103, 23);
            textBox6.TabIndex = 86;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(553, 180);
            label12.Name = "label12";
            label12.Size = new Size(37, 19);
            label12.TabIndex = 85;
            label12.Text = "Vet";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Maroon;
            label13.Location = new Point(849, 108);
            label13.Name = "label13";
            label13.Size = new Size(97, 19);
            label13.TabIndex = 84;
            label13.Text = "Treatment";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(694, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 83;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(566, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(103, 23);
            textBox4.TabIndex = 82;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(694, 108);
            label8.Name = "label8";
            label8.Size = new Size(91, 19);
            label8.TabIndex = 81;
            label8.Text = "Diagnosis";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(566, 108);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 80;
            label9.Text = "Event";
            // 
            // Date
            // 
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(995, 140);
            Date.Name = "Date";
            Date.Size = new Size(102, 23);
            Date.TabIndex = 79;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(1007, 108);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 78;
            label10.Text = "Date ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(406, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 77;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(406, 108);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 76;
            label6.Text = "Animal Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(262, 108);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 75;
            label5.Text = "Animal Id";
            // 
            // Health
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 694);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(label15);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(Date);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(HealthDGV);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Health";
            Text = "Health";
            Load += Health_Load;
            ((System.ComponentModel.ISupportInitialize)HealthDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HealthDGV;
        private Label label2;
        private PictureBox pictureBox1;
        private Label DashboardTab;
        private Panel panel4;
        private Label BreedTabLabel;
        private Panel panel1;
        private Label MilkTab;
        private Panel panel7;
        private Label AnimalTabLabel;
        private Panel panel9;
        private Label HealthTab;
        private Panel panel10;
        private Label ProductLogTab;
        private Panel panel3;
        private Panel SidePanel;
        private Label label4;
        private Label CloseProgram;
        private Label label1;
        private Label label3;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
        private TextBox textBox8;
        private Label label14;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private Label label15;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private DateTimePicker Date;
        private Label label10;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
    }
}