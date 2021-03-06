﻿using System;
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
        static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand();

        private List<sign> signs;
        private int correct_answers;
        private int current_sign;
        private int id;

        public exerciceInputSign(int id)
        {
            InitializeComponent();

            current_sign = 0;
            correct_answers = 0;

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

            textFinalScore.Hide();
            this.id = id;

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

            if (current_sign + 1 == signs.Count())
            {
                buttonNext.Text = "End";
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            textSignName.Show();
            buttonNext.Show();
            inputSign.Enabled = false;
            buttonValidate.Enabled = false;

            if (inputSign.Text.ToUpper() == textSignName.Text.ToUpper())
            {
                correct_answers++;
            }

            if (current_sign + 1 == signs.Count())
            {
                textScore.Text = correct_answers + "/" + signs.Count();
                float score = ((float)correct_answers / (float)signs.Count()) * 100;
                textFinalScore.Text = Math.Round(score).ToString() + "%";
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
                report_score(id);
                this.Close();
            }
        }

        private void inputSign_TextChanged(object sender, EventArgs e)
        {
            buttonValidate.Enabled = true;
        }

        private void report_score(int id)
        {
            cmd.CommandType = CommandType.Text;

            float score = ((float)correct_answers / (float)signs.Count()) * 100;

            cmd.CommandText = "UPDATE Progress SET [Mark] = @Mark WHERE [IdExercice] = @IdExercice AND [IdLesson] = @IdLesson";
            cmd.Parameters.AddWithValue("@Mark", Math.Round(Math.Round(score)));
            cmd.Parameters.AddWithValue("@IdLesson", id);
            cmd.Parameters.AddWithValue("@IdExercice", "1");

            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textSignName_Click(object sender, EventArgs e)
        {

        }
    }
}
