using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AttendencyManagementSystem
{
    public partial class loginForm : Form
    {

        // Creating object form class


        static string cnnStr = @"Data source=DESKTOP-GLUM27H\SQLEXPRESS; Initial catalog=AttendancyPortal; Integrated Security=true;";
        SqlConnection cn = new SqlConnection(cnnStr);

        SqlCommand cmd;
        SqlDataReader dr;
        static string SqlQuery;
        
        public void conn(){
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public loginForm()
        {
            InitializeComponent();
        }


        private void picEyeHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picEyeHide, "Show password");
        }

        private void picEyeeShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picEyeeShow, "Hide password");
        }

        private void picEyeeShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picEyeeShow.Hide();
            picEyeHide.Show();

        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeeShow.Show();
            picEyeHide.Hide();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

            txtUserName.Focus();
            picEyeHide.Hide();
 



        }

         

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picClose, "Close");
        }

        private void picMinimized_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimized, "Minimize");
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picEyeeShow, "Maximize");
        }

        private void picMinimized_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }

        private void picMinimized_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMinimized, "Minimize");
        }

        private void picMaximize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picMaximize, "Maximize");
        }

        // check user

        string userName;
        void checkUserName()
        {
            SqlQuery = "select userName from Users where userName = @username";
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);


            cn.Open();
            
              
            if(cmd.ExecuteScalar() != null){
                userName = cmd.ExecuteScalar().ToString();
            }
     
                 conn();

        }

        // check userpassword

        string userpassowrd;
        void checkUserPass()
        {
            SqlQuery = "select userPass from Users where userPass = @userPass";
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@userPass", txtPassword.Text);


            cn.Open();

            if (cmd.ExecuteScalar() != null)
            {
                userpassowrd = cmd.ExecuteScalar().ToString();
            }
            
            conn();

        }




        


        // check  studentID

        int TeacherID = 0;
        void checTeacherID()
        {
            SqlQuery = " select lecturer_Id from passcode where  lecturer_Id = @LectuareID";
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@LectuareID", txtUserName.Text);


            cn.Open();
            if (cmd.ExecuteScalar() != null)
            {

                TeacherID =  int.Parse(cmd.ExecuteScalar().ToString());
            }
             
           
            conn();

        }

        // check stdPassword

        int TeacherPass = 0;
        void checkTeacherPass()
        {
            SqlQuery = "select Passcode  from passcode where lecturer_Id  = @lecturer_Id";
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@lecturer_Id", txtUserName.Text);


            cn.Open();
           
            if (cmd.ExecuteScalar() != null)
            {
                TeacherPass =  int.Parse(cmd.ExecuteScalar().ToString());

            }
          
            conn();

        }




        private void btnLockOut_Click(object sender, EventArgs e)
        {


             if(txtUserName.Text != "" || txtPassword.Text != "")
                {

                    // checking admin

                    checkUserName(); //call
                    if (txtUserName.Text == userName)
                    {

                        
                        checkUserPass(); 
                        if (txtPassword.Text == userpassowrd)
                        {
                            
                             MainForm mainform = new MainForm();
                             mainform.Show();
                             this.Close();

                        }   

                        else
                        {
                            MessageBox.Show("invalid password.");
                        }

                         
                    }

                    

                    else  
                    {
                        checTeacherID();
                        if (TeacherID.ToString() == txtUserName.Text)
                        {
                            checkTeacherPass();

                            if (TeacherPass.ToString() == txtPassword.Text)
                            {
                                AttendanceySheet mainform = new AttendanceySheet(txtUserName.Text);
                                mainform.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("inavlid Teacher passowrd");
                            }

                        }
                        else
                        {
                            MessageBox.Show("invalid Teacher username ");
                        }
                          
                         
                    }

                     


     

                }

                else
                {
                    MessageBox.Show("pls fill the txtbox..");
                }

            



        }
    }
}
