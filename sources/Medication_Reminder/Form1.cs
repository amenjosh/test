using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Medication_Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this is a comment for a test
            // this is another comment for a test
            //third comment
            string name = textBox1.Text.ToString();

            string room = textBox2.Text.ToString();
            Int32 rno = Int32.Parse(room);

            string bedno = textBox7.Text.ToString();
            Int32 bed = Int32.Parse(bedno);

            string medicine = textBox3.Text.ToString();
            string time = textBox4.Text.ToString();
            string dosage = textBox5.Text.ToString();

            string connString = "Server=localhost;Port=3306;Database=medication_reminder;Uid=root;password=root";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Insert into medication(Name,Room_Number,Bed_Number,Medicine,Time_for_medication,Dosage)values('" + name + "','" + rno + "','" + bed +"','"+ medicine + "','" + time + "','" + dosage + "')";

            conn.Open();
            command.ExecuteNonQuery();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=3306;Database=medication_reminder;Uid=root;password=root";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

           // string idd = textBox6.Text.ToString();
            //Int32 id = Int32.Parse(idd);
            //command.CommandText = "Select * from medication where Patient_ID="+id+"";

            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { 
            textBox1.Text = (reader["Name"].ToString());
            textBox2.Text = (reader["Room_Number"].ToString());
            textBox7.Text = (reader["Bed_Number"].ToString());
            textBox3.Text = (reader["Medicine"].ToString());
            textBox4.Text = (reader["Time_for_medication"].ToString());
            textBox5.Text = (reader["Dosage"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
