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
    public partial class lessons : Form
    {
        public lessons()
        {
            InitializeComponent();
            string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projet\sile\WindowsFormsApplication1\sile_db.mdf;Integrated Security=True");
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select name from lessons;";
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ecranprincipal menuform = new ecranprincipal();
            this.Hide();
            menuform.Show();
        }
    }
}
