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

    
    public partial class ClassView : Form
    {
        static string cnnStr = @"Data source=DESKTOP-GLUM27H\SQLEXPRESS; Initial catalog=AttendancyPortal; Integrated Security=true;";
        SqlConnection cn = new SqlConnection(cnnStr);

        SqlCommand cmd;
        SqlDataReader dr;
        static string SqlQuery;

        public ClassView()
        {
            InitializeComponent();
        }

        void bindData()
        {
            SqlDataAdapter adpater = new SqlDataAdapter("select * from Class", cn);
            DataSet ds = new DataSet();
            adpater.Fill(ds, "Class");
            DGV.DataSource = ds.Tables["Class"];
        }

        private void DataGridview_Load(object sender, EventArgs e)
        {
            bindData();
              
        }


        string className;
        void getClassName()
        {
            SqlQuery = "select className from Class where className = @className";
            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@className", txtClassName.Text);


            cn.Open();

            if (cmd.ExecuteScalar() != null)
            {
                className = cmd.ExecuteScalar().ToString();
            }

            cn.Close();
 

        }

        int ID;
        void getClassID()
        {


            SqlQuery = "select classID from Class where classID = @classid";

            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue(@"classid", txtclassID.Text);

            cn.Open();

            if (cmd.ExecuteScalar() != null)
            {
                ID = int.Parse(cmd.ExecuteScalar().ToString());
            }


            cmd.Dispose();
            cn.Close();

        }
         
 
 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text != "") 
            {
                getClassName();
                if(className == txtClassName.Text)
                {
                    MessageBox.Show("pls insert an other className...");
                }
                else
                {
                    
                    SqlQuery = " insert into Class(className) values(@classname)";
                    cmd = new SqlCommand(SqlQuery, cn);
                    cmd.Parameters.AddWithValue("@Classname", txtClassName.Text);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cn.Close();

                    bindData();
                }
            }
            else
            {
                MessageBox.Show("pls insert ClassName..");
            }
        }

        void deleteStudet()
        {
            SqlQuery = "delete Student where Class_id = @classID";

            cmd = new SqlCommand(SqlQuery, cn);
            cmd.Parameters.AddWithValue("@classID", txtclassID.Text);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
             

            getClassID();

            if (txtclassID.Text != "")
            {

                if (txtclassID.Text != ID.ToString())
                {
                    MessageBox.Show("pls insert valid ID");
                }
                else
                {
                    deleteStudet();
                  
                    SqlQuery = "delete  Class where classID = @classID";

                    cmd = new SqlCommand(SqlQuery, cn);
                    cmd.Parameters.AddWithValue("@classID", txtclassID.Text);

                     
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    
                   MessageBox.Show("deleted");
                    cn.Close();
                    bindData();

                    
                }
            }
            else
            {
                MessageBox.Show("pls insert ID..");
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV.Rows[e.RowIndex];

                txtclassID.Text = row.Cells[0].Value.ToString();
                txtClassName.Text = row.Cells[1].Value.ToString();
                

            }
        }


       


         
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getClassID();
            if (txtClassName.Text != "")
            {


                if (txtclassID.Text != "")
                {
                    if(txtclassID.Text != ID.ToString())
                    {
                        MessageBox.Show("pls insert valid ID");
                    }
                    else
                    {
                        SqlQuery = "update Class set className = '" + txtClassName.Text + "'where  classID = '" + txtclassID.Text + "'";

                        cmd = new SqlCommand(SqlQuery, cn);
                        cmd.Parameters.AddWithValue("@className", txtClassName.Text);


                        cn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Updated");
                        cn.Close();

                        bindData();
                    }
                }
                else
                {
                    MessageBox.Show("pls select ID..");
                }
            }
            else
            {
                MessageBox.Show("pls insert ClassName and ID..");
            }
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        
         

        
         

        

        

        
        

         

         
    }
}
