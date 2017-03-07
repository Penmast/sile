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
        private float score;

        public exerciceMemory(int id)
        {
            InitializeComponent();
            
            current_sign = 0;
            get_signs(id);

            /* shuffle signs */
            Random rnd = new Random();
            for (int i = signs.Count(); i > 1; i--)
            {
                int pos = rnd.Next(i);
                var x = signs[i - 1];
                signs[i - 1] = signs[pos];
                signs[pos] = x;
            }
            /* */

            textScore.Hide();
            fill_page_new(current_sign);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            //MessageBox.Show(ice.Message);
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
            buttonEasy.Hide();
            buttonHard.Hide();
            buttonMedium.Hide();
            buttonNotFound.Hide();
            buttonEnd.Hide();
            textAsk.Hide();
            buttonShow.Show();

            textTitle.Text = signs[id_sign].name;
            imageSign.Image = null;

            textProgress.Text = (current_sign+1) + "/" + signs.Count();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            buttonEasy.Show();
            buttonHard.Show();
            buttonMedium.Show();
            buttonNotFound.Show();
            textAsk.Show();
            buttonShow.Hide();

            if (current_sign + 1 == signs.Count())
            {
                buttonEnd.Text = "End";
            }

            imageSign.Image = signs[current_sign].image;
        }

        private void add_to_score(object sender, EventArgs e)
        {
            Button button_pressed = sender as Button;

            switch ( button_pressed.Name )
            {
                case "buttonEasy":
                    score += 3;
                    break;

                case "buttonMedium":
                    score += 2;
                    break;

                case "buttonHard":
                    score += 1;
                    break;

                case "buttonNotFound":
                    score += 0;
                    break;
            }

            if (current_sign + 1 == signs.Count())
            {
                score = score / (signs.Count() * 3);
                textScore.Text = Math.Round((score*100)).ToString() + "%";
                textScore.Show();
                buttonEnd.Show();
            }

            else
            {
                current_sign++;
                fill_page_new(current_sign);
                textProgress.Text = current_sign + 1 + "/" + signs.Count();
            }
        }

       
    }
}
