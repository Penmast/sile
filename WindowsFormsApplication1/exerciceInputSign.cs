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
    public partial class exerciceInputSign : Form
    {
        private List<sign> signs;
        private int correct_answers;
        private int current_sign;

        public exerciceInputSign(int id)
        {
            InitializeComponent();

            current_sign = 0;
            correct_answers = 0;

            get_signs(id);

            textFinalScore.Hide();

            fill_new_sign(current_sign);
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
                    while (reader.Read())
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

        private void fill_new_sign(int id_sign)
        {
            textSignName.Hide();
            textSignName.Text = signs[current_sign].name;
            imageSign.Image = signs[current_sign].image;
            inputSign.Text = "";
            inputSign.Enabled = true;
            buttonNext.Hide();
            buttonValidate.Enabled = false;
            textScore.Text = correct_answers + "/" + (current_sign);
            textProgress.Text = current_sign + 1 + "/" + signs.Count();

            if( current_sign+1 == signs.Count() )
            {
                buttonNext.Text= "End";
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            textSignName.Show();
            buttonNext.Show();
            inputSign.Enabled = false;
            buttonValidate.Enabled = false;

            if ( inputSign.Text.ToUpper() == textSignName.Text.ToUpper() )
            {
                correct_answers++;
            }

            if (current_sign + 1 == signs.Count())
            {
                textScore.Text = correct_answers + "/" + signs.Count();
                double score = (correct_answers / signs.Count()) * 100;
                textFinalScore.Text = Math.Round( score ).ToString();
                textFinalScore.Show();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (current_sign + 1 != signs.Count())
            {
                current_sign++;
                fill_new_sign(current_sign);

            }

            else
            {
                this.Close();
            }
        }

        private void inputSign_TextChanged(object sender, EventArgs e)
        {
            buttonValidate.Enabled = true;
        }
    }
}
