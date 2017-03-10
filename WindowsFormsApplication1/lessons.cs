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
    public partial class lessons : Form
    {
        static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sile_db.mdf;Integrated Security=True");
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        List<int> ids;

        public lessons()
        {
            InitializeComponent();

            ids = new List<int>();

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
                        ids.Add((int)reader["Id"]);
                        listBox1.Items.Add(name);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlcommand = "select description from lessons where name = \'" + listBox1.SelectedItem.ToString() + "\';";
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
                            textBox1.Text = description;
                        }
                        catch(InvalidCastException)
                        {
                            textBox1.Text = "No description available";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ecranprincipal menuform = new ecranprincipal();
            menuform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            lessonMenu lessonmenuform = new lessonMenu( ids[ listBox1.SelectedIndex ] );
            lessonmenuform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
