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
    public partial class exerciceImageMultipleChoices : Form
    {
        private List<sign> signs;
        private int current_sign;
        private float score;
        private int id;
        private int difficulty;

        private int correct_image;

        private List<PictureBox> images;

        static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public exerciceImageMultipleChoices(int id)
        {
            InitializeComponent();
            get_signs(id);

            difficulty = 2;
            current_sign = 0;

            images = new List<PictureBox>();
            images.Add(image1);
            images.Add(image2);
            images.Add(image3);
            images.Add(image4);

            buttonNext.Hide();
            textFinalScore.Hide();

            fill_page_new(current_sign);
           
        }

        struct sign
        {
            public Image image;
            public int id;
            public string name;
        }

        private void get_signs(int id)
        {
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

        private void fill_page_new(int id_sign)
        {
            images[correct_image].BorderStyle = BorderStyle.None;

            /* Fill random images */
            List <sign> random_signs = take_random_signs(signs[id_sign]);

            Random rnd = new Random();
            correct_image = rnd.Next(difficulty + 2);
            images[correct_image].Image = signs[current_sign].image;
             
            int j = 0;
            for( int i = 0; i<difficulty+2; i++)
            {
                if ( i != correct_image )
                {
                    images[i].Image = random_signs[j].image;
                    j++;
                }
            }
            /* */
            

            textSignName.Text = signs[current_sign].name;
            textProgress.Text = current_sign + 1 + "/" + signs.Count();
            textCorrectAnswers.Text = score + "/" + current_sign;
            buttonNext.Hide();

        }

        private List<sign> take_random_signs(sign current_sign)
        {
            Random rnd = new Random();
            List<sign> random_signs = new List<sign>();
            sign rnd_sign;

            while ( random_signs.Count() < (difficulty+1) )
            {
                do
                {
                    rnd_sign = copy_sign(signs[rnd.Next(0, signs.Count())]);
                } while (rnd_sign.id == current_sign.id || sign_already_there(random_signs, rnd_sign));

                random_signs.Add(rnd_sign);
            }

            return random_signs;
        }

        private bool sign_already_there(List<sign> randoms, sign s)
        {
            foreach ( sign random in randoms )
            {
                if (random.id == s.id)
                    return true;
            }
            return false; 
        }

        private sign copy_sign(sign original)
        {
            sign new_sign;
            new_sign.id = original.id;
            new_sign.image = original.image;
            new_sign.name = original.name;
            return new_sign;
        }

        private void check_answer(object sender, EventArgs e)
        {
            PictureBox pic_chosen = sender as PictureBox;

            images[correct_image].BorderStyle = BorderStyle.FixedSingle;

            if ( pic_chosen.Image == signs[current_sign].image )
            {
                score++;
            }


            if (current_sign + 1 == signs.Count())
            {
                buttonNext.Text = "End";
                textFinalScore.Text = Math.Round((score / signs.Count()) * 100) + "%";
                textFinalScore.Show();
            }

            buttonNext.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (current_sign + 1 != signs.Count())
            {
                current_sign++;
                fill_page_new(current_sign);
            }

            else
            {
                this.Close();
            }

        }
    }
}
