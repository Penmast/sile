using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class sign : Form
    {
        private static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        private SqlConnection conn = new SqlConnection(connectionstring);
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;

        public sign(int id_sign, int id_in_lesson, int max_lesson)
        {
            InitializeComponent();


            /* RETRIEVE FROM DATABAASE */
            cmd.CommandText = "select * from signs where Id = " + id_sign;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        title.Text = name;

                        try
                        {
                            string image_res = (string)reader["image"];

                            object oj = Resources.ResourceManager.GetObject(image_res);
                            image_sign.Image = (Image)oj;
                        }
                        catch (InvalidCastException ice)
                        {
                            //MessageBox.Show(ice.Message);
                        }
                    }
                }
                catch (InvalidOperationException ed)
                {
                    MessageBox.Show(ed.Message);
                }

                conn.Close();
            }
            catch (SqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
            }
            /*********************/

            progress.Text = id_in_lesson + "/" + max_lesson;
        }
    }
}
