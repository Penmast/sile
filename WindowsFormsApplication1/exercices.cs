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

namespace WindowsFormsApplication1
{
    public partial class exercices : Form
    {

        static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        List<int> idsLesson;

        public exercices()
        {
            InitializeComponent();
            idsLesson = new List<int>();

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
                case 0:
                    exercice_mcq exercice_mcqForm = new exercice_mcq(idsLesson[listLessons.SelectedIndex]);
                    exercice_mcqForm.Show();
                    break;

                case 1:
                    exerciceMemory exerciceMemoryForm = new exerciceMemory(idsLesson[ listLessons.SelectedIndex ]);
                    exerciceMemoryForm.Show();
                    break;

                case 2:
                    exerciceInputSign exerciceInputSignForm = new exerciceInputSign(idsLesson[listLessons.SelectedIndex]);
                    exerciceInputSignForm.Show();
                    break;

                case 3:
                    exerciceImageMultipleChoices exerciceMultipleChoicesForm = new exerciceImageMultipleChoices(idsLesson[listLessons.SelectedIndex]);
                    exerciceMultipleChoicesForm.Show();
                    break;
            }
        }
    }
}
