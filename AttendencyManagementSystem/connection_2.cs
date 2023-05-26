using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AttendencyManagementSystem
{
    class connection
    {
         //varibales
        static string cnnStr = @"Data source=DESKTOP-GLUM27H\SQLEXPRESS; Initial catalog=AttendancyDB; Integrated Security=true;";
            SqlConnection cn = new SqlConnection(cnnStr);

            public void openCon()
            {
                cn.Open();
            }
            public void closeCon()
            {
                cn.Close();
            }

            public SqlConnection CN
            {
                get { return cn; }
            }
        }

    }

