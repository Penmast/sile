﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class lessonMenu : Form
    {
        private static string connectionstring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projet\sile\WindowsFormsApplication1\sile_db.mdf;Integrated Security=True");
        private SqlConnection conn = new SqlConnection(connectionstring);
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;

        private imagename[] imageContainer;
        private int counter;
        private int page;
        private int max_page;

        private int id;

        public const int NUM_ON_PAGE = 6;


        public lessonMenu(int _id)
        {
            InitializeComponent();
            id = _id;

            initialize();
            fill_imagename();
        }

        private void initialize()
        {
            imageContainer = new imagename[6];
            imageContainer[0] = imagename1;
            imageContainer[1] = imagename2;
            imageContainer[2] = imagename3;
            imageContainer[3] = imagename4;
            imageContainer[4] = imagename5;
            imageContainer[5] = imagename6;
            counter = 0;
            page = 0;
            max_page = find_max_page();

            buttonPrevious.Enabled = false;
            if ( (page+1) == max_page || max_page == 0) buttonNext.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            lessons lessonsForm = new lessons();
            lessonsForm.Show();
        }

        private void clear()
        {
            for(int i = 0; i < NUM_ON_PAGE; i++)
            {
                imageContainer[i].title = "";
                imageContainer[i].pic = null;
            }

            counter = 0;
        }

        private void fill_imagename()
        {
            cmd.CommandText = "select * from signs where Id in ( select idSign from asso_Lessons_Sign where idLessons =" + id + ") order by  id offset " + page*NUM_ON_PAGE + " rows fetch next " + NUM_ON_PAGE + " rows only;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;


            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();


                try
                {
                    while (reader.Read() || counter < NUM_ON_PAGE * (page+1))
                    {
                        string name = (string)reader["name"];
                        imageContainer[counter].title = name;

                        try
                        {
                            string image_res = (string)reader["image"];

                            object oj = Resources.ResourceManager.GetObject(image_res);
                            imageContainer[counter].pic = (Image)oj;
                        }
                        catch (InvalidCastException ice)
                        {
                            //MessageBox.Show(ice.Message);
                        }

                        counter++;
                    }
                }
                catch (InvalidOperationException ed)
                {
                    //MessageBox.Show(ed.Message);
                }


                conn.Close();
            }
            catch (SqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            page++;
            clear();
            fill_imagename();

            buttonPrevious.Enabled = true;
            if ( (page+1) == max_page) buttonNext.Enabled = false;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            page--;
            clear();
            fill_imagename();

            if (page == 0) buttonPrevious.Enabled = false;
            buttonNext.Enabled = true;
        }

        private int find_max_page()
        {
            cmd.CommandText = "select COUNT(*) as num from signs where Id in ( select idSign from asso_Lessons_Sign where idLessons =" + id + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                reader.Read();
                int row_num = (int)reader["num"];
                
                conn.Close();
                return row_num / NUM_ON_PAGE;
            }
            catch (SqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
