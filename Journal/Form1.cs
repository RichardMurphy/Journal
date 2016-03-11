using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MonthlyCalander
{
    public partial class Form1 : Form
    {
        string selectedDate;
        SQLiteConnection my_dbConnection;        
        bool recordExists, isMonthly = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                        
            //get note for selected date
            labelDate.Text = monthCalendar1.SelectionStart.ToString("ddd dd-M-yyyy");
            selectedDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                                  
            my_dbConnection = new SQLiteConnection("Data Source=myDiary.db;Version=3;");
            my_dbConnection.Open();

            string search = "SELECT NOTE FROM diary WHERE DATE = '" + selectedDate + "';";
            SQLiteCommand command = new SQLiteCommand(search, my_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            textBoxNotes.Text = reader["NOTE"].ToString();

            recordExists = true;
            if (textBoxNotes.Text.Length == 0)
            {
                recordExists = false;
            }

            my_dbConnection.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = monthCalendar1.SelectionEnd.ToString("ddd dd-M-yyyy");            
            selectedDate = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");

            my_dbConnection = new SQLiteConnection("Data Source=myDiary.db;Version=3;");
            my_dbConnection.Open();

            string search;

            TimeSpan range = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart; //add monthly record            
            
            if (range.ToString() == "6.00:00:00")
            {               
                search = "SELECT NOTE FROM monthly WHERE DATE = '" + selectedDate + "';";
                labelDate.Text = monthCalendar1.SelectionEnd.ToString("MMMM");
                isMonthly = true;
            }
            else
            {
                search = "SELECT NOTE FROM diary WHERE DATE = '" + selectedDate + "';";
                isMonthly = false;
            }               
            
            SQLiteCommand command = new SQLiteCommand(search, my_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            textBoxNotes.Text = reader["NOTE"].ToString();            

            my_dbConnection.Close();
        }

        private void buttonSaveRecord_Click(object sender, EventArgs e)
        {
            selectedDate = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
           
            my_dbConnection = new SQLiteConnection("Data Source=myDiary.db;Version=3;");
            my_dbConnection.Open();

            string search;
            if (isMonthly)
            {
                search = "SELECT DATE FROM monthly WHERE DATE = '" + selectedDate + "';";
            }
            else
            {
                search = "SELECT DATE FROM diary WHERE DATE = '" + selectedDate + "';";
            }

           
            SQLiteCommand command = new SQLiteCommand(search, my_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            string sql;
            if (isMonthly)
            {
                if (reader["DATE"].ToString() == selectedDate)
                {
                    sql = "UPDATE monthly SET NOTE = '" + textBoxNotes.Text + "' WHERE DATE = '" + selectedDate + "';";
                }
                else
                {
                    sql = "INSERT INTO monthly VALUES ('" + selectedDate + "','" + textBoxNotes.Text + "');";
                }
            }
            else
            {
                if (reader["DATE"].ToString() == selectedDate)
                {
                    sql = "UPDATE diary SET NOTE = '" + textBoxNotes.Text + "' WHERE DATE = '" + selectedDate + "';";
                }
                else
                {
                    sql = "INSERT INTO diary VALUES ('" + selectedDate + "','" + textBoxNotes.Text + "');";
                }
            }

            command = new SQLiteCommand(sql, my_dbConnection);
            command.ExecuteNonQuery();
            my_dbConnection.Close();
            MessageBox.Show("Record saved for: " + labelDate.Text);
        }
    }
}
