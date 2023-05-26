namespace AttendencyManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenue = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.BtnSheet = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnTeachers = new FontAwesome.Sharp.IconButton();
            this.btnLockOut = new FontAwesome.Sharp.IconButton();
            this.btnStudent = new FontAwesome.Sharp.IconButton();
            this.btnClass = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDashboardTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnreset = new FontAwesome.Sharp.IconButton();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelDashMenue = new System.Windows.Forms.Panel();
            this.panelMenue.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDashboardTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.Linen;
            this.panelMenue.Controls.Add(this.iconButton2);
            this.panelMenue.Controls.Add(this.BtnSheet);
            this.panelMenue.Controls.Add(this.iconButton1);
            this.panelMenue.Controls.Add(this.BtnTeachers);
            this.panelMenue.Controls.Add(this.btnLockOut);
            this.panelMenue.Controls.Add(this.btnStudent);
            this.panelMenue.Controls.Add(this.btnClass);
            this.panelMenue.Controls.Add(this.btndashboard);
            this.panelMenue.Controls.Add(this.panel1);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(220, 649);
            this.panelMenue.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Linen;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(0, 452);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(220, 50);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Text = "Report";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_2);
            // 
            // BtnSheet
            // 
            this.BtnSheet.BackColor = System.Drawing.Color.Linen;
            this.BtnSheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSheet.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.BtnSheet.FlatAppearance.BorderSize = 0;
            this.BtnSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.BtnSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSheet.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSheet.ForeColor = System.Drawing.Color.Black;
            this.BtnSheet.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.BtnSheet.IconColor = System.Drawing.Color.Black;
            this.BtnSheet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSheet.IconSize = 40;
            this.BtnSheet.Location = new System.Drawing.Point(0, 402);
            this.BtnSheet.Name = "BtnSheet";
            this.BtnSheet.Size = new System.Drawing.Size(220, 50);
            this.BtnSheet.TabIndex = 11;
            this.BtnSheet.Text = "Attend";
            this.BtnSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSheet.UseVisualStyleBackColor = false;
            this.BtnSheet.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Linen;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(0, 352);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 50);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Course";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // BtnTeachers
            // 
            this.BtnTeachers.BackColor = System.Drawing.Color.Linen;
            this.BtnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeachers.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.BtnTeachers.FlatAppearance.BorderSize = 0;
            this.BtnTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeachers.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeachers.ForeColor = System.Drawing.Color.Black;
            this.BtnTeachers.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.BtnTeachers.IconColor = System.Drawing.Color.Black;
            this.BtnTeachers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTeachers.IconSize = 40;
            this.BtnTeachers.Location = new System.Drawing.Point(0, 302);
            this.BtnTeachers.Name = "BtnTeachers";
            this.BtnTeachers.Size = new System.Drawing.Size(220, 50);
            this.BtnTeachers.TabIndex = 10;
            this.BtnTeachers.Text = "Teachers";
            this.BtnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTeachers.UseVisualStyleBackColor = false;
            this.BtnTeachers.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLockOut
            // 
            this.btnLockOut.BackColor = System.Drawing.Color.Linen;
            this.btnLockOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLockOut.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnLockOut.FlatAppearance.BorderSize = 0;
            this.btnLockOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnLockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockOut.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOut.ForeColor = System.Drawing.Color.Black;
            this.btnLockOut.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnLockOut.IconColor = System.Drawing.Color.Black;
            this.btnLockOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLockOut.IconSize = 38;
            this.btnLockOut.Location = new System.Drawing.Point(0, 600);
            this.btnLockOut.Name = "btnLockOut";
            this.btnLockOut.Size = new System.Drawing.Size(220, 49);
            this.btnLockOut.TabIndex = 9;
            this.btnLockOut.Text = "Lock Out";
            this.btnLockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLockOut.UseVisualStyleBackColor = false;
            this.btnLockOut.Click += new System.EventHandler(this.btnLockOut_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Linen;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Black;
            this.btnStudent.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnStudent.IconColor = System.Drawing.Color.Black;
            this.btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudent.IconSize = 40;
            this.btnStudent.Location = new System.Drawing.Point(0, 252);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(220, 50);
            this.btnStudent.TabIndex = 7;
            this.btnStudent.Text = "Students";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.Linen;
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.Black;
            this.btnClass.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnClass.IconColor = System.Drawing.Color.Black;
            this.btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClass.IconSize = 38;
            this.btnClass.Location = new System.Drawing.Point(0, 202);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnClass.Size = new System.Drawing.Size(220, 50);
            this.btnClass.TabIndex = 6;
            this.btnClass.Text = "Classes";
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.Linen;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.Black;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btndashboard.IconColor = System.Drawing.Color.Black;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.IconSize = 38;
            this.btndashboard.Location = new System.Drawing.Point(0, 152);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(220, 50);
            this.btndashboard.TabIndex = 4;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 152);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDashboardTop
            // 
            this.panelDashboardTop.BackColor = System.Drawing.Color.Linen;
            this.panelDashboardTop.Controls.Add(this.pictureBox2);
            this.panelDashboardTop.Controls.Add(this.btnreset);
            this.panelDashboardTop.Controls.Add(this.lbltime);
            this.panelDashboardTop.Controls.Add(this.lbldate);
            this.panelDashboardTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardTop.Location = new System.Drawing.Point(220, 0);
            this.panelDashboardTop.Name = "panelDashboardTop";
            this.panelDashboardTop.Size = new System.Drawing.Size(1066, 58);
            this.panelDashboardTop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Linen;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnreset.IconColor = System.Drawing.Color.Black;
            this.btnreset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreset.IconSize = 38;
            this.btnreset.Location = new System.Drawing.Point(968, 12);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(46, 38);
            this.btnreset.TabIndex = 5;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(502, 17);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(46, 19);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "Time";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(273, 17);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(42, 19);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Date";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelDashMenue
            // 
            this.panelDashMenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashMenue.Location = new System.Drawing.Point(220, 58);
            this.panelDashMenue.Name = "panelDashMenue";
            this.panelDashMenue.Size = new System.Drawing.Size(1066, 591);
            this.panelDashMenue.TabIndex = 4;
            this.panelDashMenue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashMenue_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1286, 649);
            this.Controls.Add(this.panelDashMenue);
            this.Controls.Add(this.panelDashboardTop);
            this.Controls.Add(this.panelMenue);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenue.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDashboardTop.ResumeLayout(false);
            this.panelDashboardTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconButton btnStudent;
        private FontAwesome.Sharp.IconButton btnClass;
        private FontAwesome.Sharp.IconButton btnLockOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDashboardTop;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer timerTime;
        private FontAwesome.Sharp.IconButton btnreset;
        private System.Windows.Forms.Panel panelDashMenue;
        private FontAwesome.Sharp.IconButton BtnTeachers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnSheet;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

