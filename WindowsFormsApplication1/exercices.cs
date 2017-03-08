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

namespace WindowsFormsApplication1
{
    public partial class exercices : Form
    {

        static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        List<int> idsLesson;
        List<int> idsExercice;

        public exercices()
        {
            InitializeComponent();
            idsLesson = new List<int>();
            idsExercice = new List<int>();

            cmd.CommandText = "select name, Id from Exercices;";
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
                        listExercices.Items.Add(name);
                        idsExercice.Add((int)reader["Id"]);
                    }
                }
                catch (InvalidOperationException ed)
                {
                    MessageBox.Show(ed.Message);
                }


                conn.Close();
            }
            catch(SqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
            }

            cmd.CommandText = "select name, Id from lessons;";
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
                        int id = (int)reader["Id"];
                        idsLesson.Add(id);
                        listLessons.Items.Add(name);
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

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ecranprincipal menuform = new ecranprincipal();
            this.Hide();
            menuform.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            switch ( listExercices.SelectedIndex )
            {
                case 3:
                    exercice_mcq exercice_mcqForm = new exercice_mcq(idsLesson[listLessons.SelectedIndex]);
                    exercice_mcqForm.Show();
                    break;

                case 0:
                    exerciceMemory exerciceMemoryForm = new exerciceMemory(idsLesson[ listLessons.SelectedIndex ]);
                    exerciceMemoryForm.Show();
                    break;

                case 1:
                    exerciceInputSign exerciceInputSignForm = new exerciceInputSign(idsLesson[listLessons.SelectedIndex]);
                    exerciceInputSignForm.Show();
                    break;

                case 5:
                    exerciceImageMultipleChoices exerciceMultipleChoicesForm = new exerciceImageMultipleChoices(idsLesson[listLessons.SelectedIndex], 0);
                    exerciceMultipleChoicesForm.Show();
                    break;

                case 6:
                    exerciceImageMultipleChoices exerciceMultipleChoicesForm2 = new exerciceImageMultipleChoices(idsLesson[listLessons.SelectedIndex], 1);
                    exerciceMultipleChoicesForm2.Show();
                    break;

                case 7:
                    exerciceImageMultipleChoices exerciceMultipleChoicesForm3 = new exerciceImageMultipleChoices(idsLesson[listLessons.SelectedIndex], 2);
                    exerciceMultipleChoicesForm3.Show();
                    break;
            }
        }

        private void listExercices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLessons.SelectedIndex != -1) show_description();
        }

        private void listLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listExercices.SelectedIndex != -1) show_description();
        }


        private void show_description()
        {
            string descriptionText = "";

            string sqlcommand = "select description from Exercices where name = \'" + listExercices.SelectedItem.ToString() + "\';";
            cmd.CommandText = sqlcommand;

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
                        try
                        {
                            string description = (string)reader["description"];
                            descriptionText = description;
                        }
                        catch (InvalidCastException)
                        {
                            descriptionText = "No description available";
                        }
                    }
                }
                catch (InvalidOperationException ed)
                {
                    MessageBox.Show(ed.Message);
                }


                conn.Close();
            }
            catch (SqlException err)
            {
                conn = null;
                MessageBox.Show(err.Message);
            }

            sqlcommand = "select Mark from Progress where IdLesson = " + idsLesson[listLessons.SelectedIndex] + " and IdExercice = " + idsExercice[listExercices.SelectedIndex];
            cmd.CommandText = sqlcommand;

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
                        try
                        {
                            int mark = reader["Mark"] as int? ?? default(int);
                            descriptionText += Environment.NewLine + Environment.NewLine + mark + "/100";
                        }
                        catch (InvalidCastException)
                        {
                            descriptionText += "No mark available";
                        }
                    }
                }
                catch (InvalidOperationException ed)
                {
                    MessageBox.Show(ed.Message);
                }


                conn.Close();
            }
            catch (SqlException err)
            {
                conn = null;
                MessageBox.Show(err.Message);
            }

            descriptionBox.Text = descriptionText;
        }
    }
}
