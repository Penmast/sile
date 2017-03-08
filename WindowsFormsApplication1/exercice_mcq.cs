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
    public partial class exercice_mcq : Form
    {
        private List<sign> signs;
        private int current_sign;
        private int score;
        private int answer;

        public exercice_mcq(int id)
        {
            InitializeComponent();

            current_sign = 0;
            get_signs(id);

            showExercice();
            //            textScore.Hide();
            //          fill_page_new(current_sign);
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

        private List<int> randomPosition(int current_sign)
        {
            List<int> position = new List<int>();
            Random rnd = new Random();
            int answer_position = rnd.Next(0, 4);
            answer = answer_position;
            bool redo = true;
            int num = 0;
            for (int i = 0; i<5; i++)
            {
                if (i != answer_position)
                {
                    do
                    {
                        redo = true;
                        num = rnd.Next(0, signs.Count());
                        
                        bool alreadyExist = position.Contains(num);
                        if (!alreadyExist && num!=answer_position)
                        {
                            position.Add(num);
                            redo = false;
                        }
                    } while (redo);
                }
                else
                {
                    position.Add(current_sign);
                }
                Console.WriteLine(i);
            }
            position.OrderBy(item => rnd.Next());
            return position;
        }

        private void showExercice()
        {
            pictureBox.Image = signs[current_sign].image;
            List<int> list = randomPosition(current_sign);
            radioButton_choice1.Text = signs[list[0]].name;
            radioButton_choice2.Text = signs[list[1]].name;
            radioButton_choice3.Text = signs[list[2]].name;
            radioButton_choice4.Text = signs[list[3]].name;
            radioButton_choice5.Text = signs[list[4]].name;
            
        }

        private int getCheckRadioButton()
        {
            int i = 0;
            if (radioButton_choice1.Checked)
            {
                i = 0;
            }
            if (radioButton_choice2.Checked)
            {
                i = 1;
            }
            if (radioButton_choice3.Checked)
            {
                i = 2;
            }
            if (radioButton_choice4.Checked)
            {
                i = 3;
            }
            if (radioButton_choice5.Checked)
            {
                i = 4;
            }
            return i;
        }

        private void add_to_score()
        {
            if (answer == getCheckRadioButton() )
            {
                score++;
            }
            score_text.Text = score.ToString();

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (current_sign+1<signs.Count())
            {
                add_to_score();
                current_sign++;
                showExercice();
            } else
            {

            }

        }

    }
}
