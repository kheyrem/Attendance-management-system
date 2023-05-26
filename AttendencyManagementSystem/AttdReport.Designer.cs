namespace AttendencyManagementSystem
{
    partial class AttdReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttdReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBycourse = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectClassname = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comoboxid = new System.Windows.Forms.ComboBox();
            this.comboxClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowClass = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerto = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerfrom = new System.Windows.Forms.DateTimePicker();
            this.btnview = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(975, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBycourse);
            this.panel1.Controls.Add(this.comboBoxCourse);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSelectClassname);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comoboxid);
            this.panel1.Controls.Add(this.comboxClass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ShowClass);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerto);
            this.panel1.Controls.Add(this.dateTimePickerfrom);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 594);
            this.panel1.TabIndex = 58;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBycourse
            // 
            this.btnBycourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnBycourse.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBycourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBycourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBycourse.ForeColor = System.Drawing.Color.White;
            this.btnBycourse.Location = new System.Drawing.Point(417, 154);
            this.btnBycourse.Name = "btnBycourse";
            this.btnBycourse.Size = new System.Drawing.Size(108, 37);
            this.btnBycourse.TabIndex = 79;
            this.btnBycourse.Text = "By Course";
            this.btnBycourse.UseVisualStyleBackColor = false;
            this.btnBycourse.Click += new System.EventHandler(this.btnBycourse_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(412, 113);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourse.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(409, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "By Course:";
            // 
            // btnSelectClassname
            // 
            this.btnSelectClassname.BackColor = System.Drawing.Color.Green;
            this.btnSelectClassname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectClassname.ForeColor = System.Drawing.Color.White;
            this.btnSelectClassname.Location = new System.Drawing.Point(223, 111);
            this.btnSelectClassname.Name = "btnSelectClassname";
            this.btnSelectClassname.Size = new System.Drawing.Size(56, 23);
            this.btnSelectClassname.TabIndex = 76;
            this.btnSelectClassname.Text = "Select";
            this.btnSelectClassname.UseVisualStyleBackColor = false;
            this.btnSelectClassname.Click += new System.EventHandler(this.btnSelectClassname_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(167, 550);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(700, 2);
            this.textBox1.TabIndex = 75;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(167, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(700, 2);
            this.textBox2.TabIndex = 74;
            // 
            // comoboxid
            // 
            this.comoboxid.FormattingEnabled = true;
            this.comoboxid.Location = new System.Drawing.Point(285, 111);
            this.comoboxid.Name = "comoboxid";
            this.comoboxid.Size = new System.Drawing.Size(121, 21);
            this.comoboxid.TabIndex = 73;
            // 
            // comboxClass
            // 
            this.comboxClass.FormattingEnabled = true;
            this.comboxClass.Location = new System.Drawing.Point(75, 111);
            this.comboxClass.Name = "comboxClass";
            this.comboxClass.Size = new System.Drawing.Size(142, 21);
            this.comboxClass.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(337, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 33);
            this.label5.TabIndex = 71;
            this.label5.Text = "Student Attendance Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(373, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Copyright @JUST 2022 ";
            // 
            // ShowClass
            // 
            this.ShowClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.ShowClass.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ShowClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowClass.ForeColor = System.Drawing.Color.White;
            this.ShowClass.Location = new System.Drawing.Point(303, 154);
            this.ShowClass.Name = "ShowClass";
            this.ShowClass.Size = new System.Drawing.Size(108, 37);
            this.ShowClass.TabIndex = 70;
            this.ShowClass.Text = "Show Class";
            this.ShowClass.UseVisualStyleBackColor = false;
            this.ShowClass.Click += new System.EventHandler(this.ShowClass_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(189, 154);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(108, 37);
            this.btnShowAll.TabIndex = 68;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(75, 154);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(108, 37);
            this.btnShow.TabIndex = 67;
            this.btnShow.Text = "Show ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(72, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Class Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(282, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(680, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(665, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "From:";
            // 
            // dateTimePickerto
            // 
            this.dateTimePickerto.Location = new System.Drawing.Point(719, 86);
            this.dateTimePickerto.Name = "dateTimePickerto";
            this.dateTimePickerto.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerto.TabIndex = 61;
            // 
            // dateTimePickerfrom
            // 
            this.dateTimePickerfrom.Location = new System.Drawing.Point(719, 123);
            this.dateTimePickerfrom.Name = "dateTimePickerfrom";
            this.dateTimePickerfrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerfrom.TabIndex = 62;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnview.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(806, 154);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(113, 37);
            this.btnview.TabIndex = 60;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(75, 210);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(844, 330);
            this.DGV.TabIndex = 59;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AttdReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1100, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttdReport";
            this.Text = "AttdReport";
            this.Load += new System.EventHandler(this.AttdReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectClassname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comoboxid;
        private System.Windows.Forms.ComboBox comboxClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ShowClass;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerto;
        private System.Windows.Forms.DateTimePicker dateTimePickerfrom;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView DGV;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBycourse;
    }
}