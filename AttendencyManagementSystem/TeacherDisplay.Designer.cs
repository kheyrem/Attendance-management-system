namespace AttendencyManagementSystem
{
    partial class TeacherDisplay
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comoboxGender = new System.Windows.Forms.ComboBox();
            this.txtteacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVteacherPasscode = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnpassADD = new FontAwesome.Sharp.IconButton();
            this.TeacherID = new System.Windows.Forms.ComboBox();
            this.la = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.techID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherPasscode)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(160, 118);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(666, 104);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teachers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gender";
            // 
            // comoboxGender
            // 
            this.comoboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comoboxGender.FormattingEnabled = true;
            this.comoboxGender.Location = new System.Drawing.Point(516, 91);
            this.comoboxGender.Name = "comoboxGender";
            this.comoboxGender.Size = new System.Drawing.Size(117, 21);
            this.comoboxGender.TabIndex = 29;
            // 
            // txtteacherName
            // 
            this.txtteacherName.Location = new System.Drawing.Point(287, 92);
            this.txtteacherName.Name = "txtteacherName";
            this.txtteacherName.Size = new System.Drawing.Size(155, 20);
            this.txtteacherName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Teacher Name";
            // 
            // DGVteacherPasscode
            // 
            this.DGVteacherPasscode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVteacherPasscode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVteacherPasscode.Location = new System.Drawing.Point(160, 371);
            this.DGVteacherPasscode.Name = "DGVteacherPasscode";
            this.DGVteacherPasscode.Size = new System.Drawing.Size(666, 104);
            this.DGVteacherPasscode.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 38;
            this.btnUpdate.Location = new System.Drawing.Point(446, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 41);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 38;
            this.btnDelete.Location = new System.Drawing.Point(606, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 41);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 38;
            this.btnAdd.Location = new System.Drawing.Point(288, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 41);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnpassADD
            // 
            this.btnpassADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.btnpassADD.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnpassADD.FlatAppearance.BorderSize = 0;
            this.btnpassADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnpassADD.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpassADD.ForeColor = System.Drawing.Color.White;
            this.btnpassADD.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnpassADD.IconColor = System.Drawing.Color.White;
            this.btnpassADD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpassADD.IconSize = 38;
            this.btnpassADD.Location = new System.Drawing.Point(428, 494);
            this.btnpassADD.Name = "btnpassADD";
            this.btnpassADD.Size = new System.Drawing.Size(117, 41);
            this.btnpassADD.TabIndex = 35;
            this.btnpassADD.Text = "Add";
            this.btnpassADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpassADD.UseVisualStyleBackColor = false;
            this.btnpassADD.Click += new System.EventHandler(this.btnpassADD_Click);
            // 
            // TeacherID
            // 
            this.TeacherID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherID.FormattingEnabled = true;
            this.TeacherID.Location = new System.Drawing.Point(272, 344);
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.Size = new System.Drawing.Size(182, 21);
            this.TeacherID.TabIndex = 39;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(179, 344);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(87, 19);
            this.la.TabIndex = 38;
            this.la.Text = "Teacher ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(400, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "Passcode";
            // 
            // techID
            // 
            this.techID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.techID.FormattingEnabled = true;
            this.techID.Location = new System.Drawing.Point(738, 92);
            this.techID.Name = "techID";
            this.techID.Size = new System.Drawing.Size(88, 21);
            this.techID.TabIndex = 42;
            this.techID.SelectedIndexChanged += new System.EventHandler(this.techID_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Teacher ID";
            // 
            // TeacherDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(956, 560);
            this.Controls.Add(this.techID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeacherID);
            this.Controls.Add(this.la);
            this.Controls.Add(this.btnpassADD);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGVteacherPasscode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comoboxGender);
            this.Controls.Add(this.txtteacherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherDisplay";
            this.Text = "TeacherDisplay";
            this.Load += new System.EventHandler(this.TeacherDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVteacherPasscode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comoboxGender;
        private System.Windows.Forms.TextBox txtteacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVteacherPasscode;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnpassADD;
        private System.Windows.Forms.ComboBox TeacherID;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox techID;
        private System.Windows.Forms.Label label5;
    }
}