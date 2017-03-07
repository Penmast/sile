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
    public partial class exerciceMemory : Form
    {
        private List<sign> signs;
        private int current_sign;

        public exerciceMemory(int id)
        {
            InitializeComponent();
            buttonEasy.Hide();
            buttonHard.Hide();
            buttonMedium.Hide();
            buttonNext.Hide();
            textAsk.Hide();
            textScore.Hide();

            // signs 
            current_sign = 0;
            get_signs(id);
            fill_page_new(current_sign);
        }

        private void exerciceMemory_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        struct sign
        {
            public Image image;
            public int id;
            public string name;
        }

        private void get_signs(int id)
        {
            string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;


            cmd.CommandText = "select * from signs where Id in ( select idSign from asso_Lessons_Sign where idLessons =" + id + ");";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            signs = new List<sign>();
            sign new_sign;

            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();


                try
                {
                    while (reader.Read() )
                    {
                        new_sign.id = (int)reader["Id"];
                        new_sign.name = (string)reader["name"];

                        try
                        {
                            string image_res = (string)reader["image"];
                            object oj = Resources.ResourceManager.GetObject(image_res);
                            new_sign.image = (Image)oj;
                        }
                        catch (InvalidCastException ice)
                        {
                            MessageBox.Show(ice.Message);
                            new_sign.image = null;
                        }

                        signs.Add(new_sign);
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
        }

        /* takes a sign id as argument, */
        private void fill_page_new(int id_sign)
        {
            textTitle.Text = signs[id_sign].name;
            imageSign.Image = null;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            buttonEasy.Show();
            buttonHard.Show();
            buttonMedium.Show();
            buttonNext.Show();
            textAsk.Show();

            imageSign.Image = signs[current_sign].image;
        }
    }
}
