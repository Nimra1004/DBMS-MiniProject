namespace MiniProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add_Students = new System.Windows.Forms.Label();
            this.Manage_student = new System.Windows.Forms.Button();
            this.Projectbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageEvaluation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageAdvisor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.advisorpicbox = new System.Windows.Forms.PictureBox();
            this.AddEvaluationIcon = new System.Windows.Forms.PictureBox();
            this.Add_Project = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mnage = new System.Windows.Forms.Button();
            this.Managebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ManagePanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEvaluationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_Students
            // 
            this.Add_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Students.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Students.ForeColor = System.Drawing.Color.Navy;
            this.Add_Students.Location = new System.Drawing.Point(53, 103);
            this.Add_Students.Name = "Add_Students";
            this.Add_Students.Size = new System.Drawing.Size(107, 27);
            this.Add_Students.TabIndex = 5;
            this.Add_Students.Text = "Students\r\n";
            // 
            // Manage_student
            // 
            this.Manage_student.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Manage_student.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Manage_student.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Manage_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage_student.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_student.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Manage_student.Location = new System.Drawing.Point(3, 88);
            this.Manage_student.Name = "Manage_student";
            this.Manage_student.Size = new System.Drawing.Size(136, 58);
            this.Manage_student.TabIndex = 6;
            this.Manage_student.Text = "Manage\r\nStudents";
            this.Manage_student.UseVisualStyleBackColor = false;
            this.Manage_student.Click += new System.EventHandler(this.Manage_student_Click);
            // 
            // Projectbutton
            // 
            this.Projectbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Projectbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Projectbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Projectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Projectbutton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projectbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Projectbutton.Location = new System.Drawing.Point(3, 148);
            this.Projectbutton.Name = "Projectbutton";
            this.Projectbutton.Size = new System.Drawing.Size(136, 57);
            this.Projectbutton.TabIndex = 8;
            this.Projectbutton.Text = "Manage \r\nProject";
            this.Projectbutton.UseVisualStyleBackColor = false;
            this.Projectbutton.Click += new System.EventHandler(this.Projectbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(58, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Projects";
            // 
            // ManageEvaluation
            // 
            this.ManageEvaluation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManageEvaluation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageEvaluation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ManageEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageEvaluation.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEvaluation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageEvaluation.Location = new System.Drawing.Point(3, 264);
            this.ManageEvaluation.Name = "ManageEvaluation";
            this.ManageEvaluation.Size = new System.Drawing.Size(136, 57);
            this.ManageEvaluation.TabIndex = 11;
            this.ManageEvaluation.Text = "Manage \r\nEvaluations";
            this.ManageEvaluation.UseVisualStyleBackColor = false;
            this.ManageEvaluation.Click += new System.EventHandler(this.ManageEvaluation_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(57, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Evaluations";
            // 
            // ManageAdvisor
            // 
            this.ManageAdvisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManageAdvisor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageAdvisor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ManageAdvisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManageAdvisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageAdvisor.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAdvisor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageAdvisor.Location = new System.Drawing.Point(3, 207);
            this.ManageAdvisor.Name = "ManageAdvisor";
            this.ManageAdvisor.Size = new System.Drawing.Size(136, 55);
            this.ManageAdvisor.TabIndex = 14;
            this.ManageAdvisor.Text = "Manage \r\nAdvisor";
            this.ManageAdvisor.UseVisualStyleBackColor = false;
            this.ManageAdvisor.Click += new System.EventHandler(this.ManageAdvisor_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(57, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Advisor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 580);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ManagePanel
            // 
            this.ManagePanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagePanel.BackColor = System.Drawing.Color.Transparent;
            this.ManagePanel.Controls.Add(this.label1);
            this.ManagePanel.Controls.Add(this.Manage_student);
            this.ManagePanel.Controls.Add(this.ManageEvaluation);
            this.ManagePanel.Controls.Add(this.Projectbutton);
            this.ManagePanel.Controls.Add(this.ManageAdvisor);
            this.ManagePanel.Location = new System.Drawing.Point(511, 114);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.Size = new System.Drawing.Size(194, 364);
            this.ManagePanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Data";
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DataPanel.BackColor = System.Drawing.Color.Transparent;
            this.DataPanel.Controls.Add(this.label5);
            this.DataPanel.Controls.Add(this.advisorpicbox);
            this.DataPanel.Controls.Add(this.AddEvaluationIcon);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.Add_Project);
            this.DataPanel.Controls.Add(this.pictureBox1);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.Add_Students);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Location = new System.Drawing.Point(511, 112);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(219, 364);
            this.DataPanel.TabIndex = 19;
            this.DataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(32, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Add Data";
            // 
            // advisorpicbox
            // 
            this.advisorpicbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advisorpicbox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.advisorpicbox.Image = ((System.Drawing.Image)(resources.GetObject("advisorpicbox.Image")));
            this.advisorpicbox.Location = new System.Drawing.Point(11, 203);
            this.advisorpicbox.Name = "advisorpicbox";
            this.advisorpicbox.Size = new System.Drawing.Size(42, 42);
            this.advisorpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.advisorpicbox.TabIndex = 8;
            this.advisorpicbox.TabStop = false;
            this.advisorpicbox.Click += new System.EventHandler(this.advisorpicbox_Click_1);
            // 
            // AddEvaluationIcon
            // 
            this.AddEvaluationIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEvaluationIcon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddEvaluationIcon.Image = ((System.Drawing.Image)(resources.GetObject("AddEvaluationIcon.Image")));
            this.AddEvaluationIcon.Location = new System.Drawing.Point(12, 254);
            this.AddEvaluationIcon.Name = "AddEvaluationIcon";
            this.AddEvaluationIcon.Size = new System.Drawing.Size(42, 43);
            this.AddEvaluationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddEvaluationIcon.TabIndex = 7;
            this.AddEvaluationIcon.TabStop = false;
            this.AddEvaluationIcon.Click += new System.EventHandler(this.AddEvaluationIcon_Click_1);
            // 
            // Add_Project
            // 
            this.Add_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Project.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Add_Project.Image = ((System.Drawing.Image)(resources.GetObject("Add_Project.Image")));
            this.Add_Project.Location = new System.Drawing.Point(11, 148);
            this.Add_Project.Name = "Add_Project";
            this.Add_Project.Size = new System.Drawing.Size(42, 43);
            this.Add_Project.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Project.TabIndex = 6;
            this.Add_Project.TabStop = false;
            this.Add_Project.Click += new System.EventHandler(this.Add_Project_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 295);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // mnage
            // 
            this.mnage.BackColor = System.Drawing.Color.SandyBrown;
            this.mnage.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnage.Location = new System.Drawing.Point(577, 22);
            this.mnage.Name = "mnage";
            this.mnage.Size = new System.Drawing.Size(128, 62);
            this.mnage.TabIndex = 1;
            this.mnage.Text = "Manage Data\r\n";
            this.mnage.UseVisualStyleBackColor = false;
            this.mnage.Click += new System.EventHandler(this.mnage_Click);
            // 
            // Managebtn
            // 
            this.Managebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Managebtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managebtn.Location = new System.Drawing.Point(436, 22);
            this.Managebtn.Name = "Managebtn";
            this.Managebtn.Size = new System.Drawing.Size(128, 62);
            this.Managebtn.TabIndex = 21;
            this.Managebtn.Text = "ADD Data\r\n";
            this.Managebtn.UseVisualStyleBackColor = false;
            this.Managebtn.Click += new System.EventHandler(this.Managebtn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(724, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 62);
            this.button1.TabIndex = 22;
            this.button1.Text = "EXIT\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Managebtn);
            this.Controls.Add(this.mnage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ManagePanel);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ManagePanel.ResumeLayout(false);
            this.ManagePanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEvaluationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Add_Students;
        private System.Windows.Forms.Button Manage_student;
        private System.Windows.Forms.Button Projectbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ManageEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ManageAdvisor;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ManagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.PictureBox advisorpicbox;
        private System.Windows.Forms.PictureBox AddEvaluationIcon;
        private System.Windows.Forms.PictureBox Add_Project;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button mnage;
        private System.Windows.Forms.Button Managebtn;
        private System.Windows.Forms.Button button1;
    }
}

