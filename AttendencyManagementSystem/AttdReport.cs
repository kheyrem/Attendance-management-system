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
using DGVPrinterHelper;

namespace AttendencyManagementSystem
{
    public partial class AttdReport : Form
    {


        static string cnnStr = @"Data source=DESKTOP-GLUM27H\SQLEXPRESS; Initial catalog=AttendancyPortal; Integrated Security=true;";
        SqlConnection cn = new SqlConnection(cnnStr);

        SqlCommand cmd;
        SqlDataReader dr;
        static string SqlQuery;


        public AttdReport()
        {
            InitializeComponent();
             
        }

        

        void bindData()
        {
            SqlDataAdapter adpater = new SqlDataAdapter("select Attendance.AttendanceID, Attendance.student_ID, Attendance.Class_id, AllCourses.Course_Name, AllCourses.Course_ID, Attendance.StatusAttd from Attendance join AllCourses on AllCourses.Course_ID = Attendance.Course_ID", cn);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Attendance");
            DGV.DataSource = ds.Tables["Attendance"];
        }
        private void AttdReport_Load(object sender, EventArgs e)
        {
            getClass();
            getCourese();
        }

        void getCourese()
        {
            comboBoxCourse.Items.Add("Select Course");
            comboBoxCourse.SelectedIndex = 0;

            SqlQuery = "SELECT Course_Name FROM AllCourses";
            cn.Open();
            cmd = new SqlCommand(SqlQuery, cn);

            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                comboBoxCourse.Items.Add(dr.GetValue(0).ToString());

            }

            dr.Dispose();
            cmd.Dispose();
            cn.Close();


        }

        void getClass()
        {


            SqlDataAdapter adpater = new SqlDataAdapter("select 0 as  classID,'Select Class' as className union select distinct class.classID,Class.className from Course join Class on Class.classID=Course.Class_id", cn);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "class");
            comboxClass.DataSource = ds.Tables[0];
            comboxClass.ValueMember = "classID";
            comboxClass.DisplayMember = "className";
        }

         
 

         

         

         
        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print();

            

        }

        void print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Student Attendance Sheet Report"; // header
            printer.SubTitle = "jamhuuriya University";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Copyright @JUST 2022";
            printer.PrintDataGridView(DGV);

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            bindData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlQuery = "select * from Attendance where student_ID = @id";
            cn.Open();
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@id", comoboxid.Text);
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Attendance");
            DGV.DataSource = ds.Tables[0];


            ds.Dispose();
            cmd.Dispose();
            cn.Close();

        }


        private void ShowClass_Click(object sender, EventArgs e)
        {
            SqlQuery = "select AttendanceID, student_ID, Class_id, className, AttDATE, StatusAttd from Attendance  join Class on Class.classID = Attendance.Class_id  join AllCourses on AllCourses.Course_ID = Attendance.Course_ID where className  = @Classname";
            cn.Open();

            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@Classname", comboxClass.Text);
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Attendance");
            DGV.DataSource = ds.Tables[0];

            adpater.Dispose();
            ds.Dispose();
            cmd.Dispose();
            cn.Close();
        }

        private void btnSelectClassname_Click(object sender, EventArgs e)
        {
            comoboxid.Items.Clear();
            comoboxid.Items.Add("Select ID");
            comoboxid.SelectedIndex = 0;

            SqlQuery = "select Std_id  from Student join Class on Class.classID = Student.Class_id  where className = @classname";

            cn.Open();
            cmd = new SqlCommand(SqlQuery, cn);

            cmd.Parameters.AddWithValue(@"classname", comboxClass.Text);



            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                comoboxid.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Dispose();
            cmd.Dispose();
            cn.Close();

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            SqlQuery = "select * from Attendance where AttDATE between @date1 and @date2";
            cn.Open();
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@date1",  dateTimePickerto.Value);
            cmd.Parameters.AddWithValue("@date2", dateTimePickerfrom.Value);
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Attendance");
            DGV.DataSource = ds.Tables[0];


            ds.Dispose();
            cmd.Dispose();
            cn.Close();
        }

        private void btnBycourse_Click(object sender, EventArgs e)
        {
            
            SqlQuery = "SELECT Attendance.AttendanceID,Attendance.student_ID, Class_id,Attendance.AttDATE,Course_Name, Attendance.StatusAttd FROM AllCourses join Attendance on Attendance.Course_ID = AllCourses.Course_ID where Course_Name = @coursename ";
            cn.Open();
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@coursename", comboBoxCourse.Text);
           
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Attendance");
            adpater.Fill(ds, "AllCourses");
            DGV.DataSource = ds.Tables[0];
            DGV.DataSource = ds.Tables[1];


            ds.Dispose();
            cmd.Dispose();
            cn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

         

         

        
        
         
         
         
    }
}
