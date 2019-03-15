namespace MiniProject
{
    partial class ManageProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProject));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit_Panel = new System.Windows.Forms.Panel();
            this.gg = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Edit_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Project_Title,
            this.Description,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(1, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Project_Title
            // 
            this.Project_Title.HeaderText = "Project Title";
            this.Project_Title.Name = "Project_Title";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "EDIT";
            this.Edit.Name = "Edit";
            this.Edit.Text = "EDIT";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "DELETE";
            this.Delete.Name = "Delete";
            this.Delete.Text = "DELETE";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Projects";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TitleTxt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 112);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BackColor = System.Drawing.Color.CadetBlue;
            this.DescriptionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.DescriptionTxt.Location = new System.Drawing.Point(110, 31);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(192, 75);
            this.DescriptionTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 81);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description\r\n";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTxt.BackColor = System.Drawing.Color.CadetBlue;
            this.TitleTxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleTxt.Location = new System.Drawing.Point(110, 3);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(192, 22);
            this.TitleTxt.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Submit.AutoSize = true;
            this.Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.Window;
            this.Submit.Location = new System.Drawing.Point(227, 227);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(71, 28);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Update";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.AutoSize = true;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.Cancel.Location = new System.Drawing.Point(155, 227);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(70, 28);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "  Clear  \r\n";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(301, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(86, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "UPDATE PROJECTS";
            // 
            // Edit_Panel
            // 
            this.Edit_Panel.BackColor = System.Drawing.Color.CadetBlue;
            this.Edit_Panel.Controls.Add(this.label4);
            this.Edit_Panel.Controls.Add(this.textBox1);
            this.Edit_Panel.Controls.Add(this.button2);
            this.Edit_Panel.Controls.Add(this.Cancel);
            this.Edit_Panel.Controls.Add(this.Submit);
            this.Edit_Panel.Controls.Add(this.tableLayoutPanel1);
            this.Edit_Panel.Location = new System.Drawing.Point(391, 87);
            this.Edit_Panel.Name = "Edit_Panel";
            this.Edit_Panel.Size = new System.Drawing.Size(407, 333);
            this.Edit_Panel.TabIndex = 13;
            this.Edit_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Edit_Panel_Paint);
            // 
            // gg
            // 
            this.gg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gg.Image = ((System.Drawing.Image)(resources.GetObject("gg.Image")));
            this.gg.Location = new System.Drawing.Point(49, 12);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(42, 40);
            this.gg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gg.TabIndex = 15;
            this.gg.TabStop = false;
            this.gg.Click += new System.EventHandler(this.gg_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(1, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 40);
            this.label8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.label8.TabIndex = 14;
            this.label8.TabStop = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 62);
            this.button1.TabIndex = 24;
            this.button1.Text = "EXIT\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Edit_Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.Load += new System.EventHandler(this.ManageProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Edit_Panel.ResumeLayout(false);
            this.Edit_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Edit_Panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox gg;
        private System.Windows.Forms.PictureBox label8;
        private System.Windows.Forms.Button button1;
    }
}