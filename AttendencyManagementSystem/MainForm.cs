using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Bunifu.UI;
using Bunifu.Charts;

namespace AttendencyManagementSystem
{
    public partial class MainForm : Form
    {


        private IconButton currentBtn;
        private Panel leftBorderBtn;


        public MainForm()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            panelMenue.Controls.Add(leftBorderBtn);


            panelDashMenue.Controls.Clear();
            DashboardMainForm d = new DashboardMainForm();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();



            

        }

        // Structs 

        private struct RGBColor
        {
           public static Color color1 = Color.FromArgb(0, 0, 255);
           public static Color color2 = Color.FromArgb(0, 128, 0);
           public static Color color3 = Color.FromArgb(128, 0, 128);
           public static Color color4 = Color.FromArgb(0, 128, 128);
           public static Color color5 = Color.FromArgb(0, 0, 128);
           public static Color color6 = Color.FromArgb(255, 0, 0);
           public static Color color7 = Color.FromArgb(255, 0, 255);
           public static Color color8 = Color.FromArgb(47, 79, 79);
           public static Color color9 = Color.FromArgb(47, 0, 50);
        }

        // methods

        private void AvtivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {

                DisableButton();

                // button

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(250, 240, 230);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // left border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
 



            }

        }

        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(250, 240, 230);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                 
            }
        }

        private void btnLoguOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerTime.Start();

        }

        private void btnLockOut_Click(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color6);
            DialogResult dialogresult = MessageBox.Show("Are your want to Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogresult == DialogResult.Yes)
            {
                this.Close();
                loginForm lg = new loginForm();
                lg.Show();

            }

            else
            {
                reset();

            }



            
            
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
             
            AvtivateButton(sender, RGBColor.color1);
            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            DashboardMainForm d = new DashboardMainForm();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
             
            AvtivateButton(sender, RGBColor.color2);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
             
            AvtivateButton(sender, RGBColor.color3);

            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            ClassView d = new ClassView();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();
           
             
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            AvtivateButton(sender, RGBColor.color4);

            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            Student d = new Student();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();
            

            

            
        }

         
         
         

        void reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color8);

            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            TeacherDisplay tech = new TeacherDisplay();
            tech.TopLevel = false;
            panelDashMenue.Controls.Add(tech);
            tech.Dock = DockStyle.Fill;
            tech.Show();
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color7);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color5);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color9);

            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            Course d = new Course();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();

        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color4);

            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            AttendanceAdmin d = new AttendanceAdmin();
            d.TopLevel = false;
            panelDashMenue.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();



        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color3);
        }

        private void panelDashMenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click_2(object sender, EventArgs e)
        {
            AvtivateButton(sender, RGBColor.color9);


            panelDashboardTop.Visible = true;
            panelDashMenue.Controls.Clear();
            AttdReport attd = new AttdReport();
            attd.TopLevel = false;
            panelDashMenue.Controls.Add(attd);
            attd.Dock = DockStyle.Fill;
            attd.Show();


        }

        
        

         
    }
}
