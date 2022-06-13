using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergasia_2
{
    public partial class Form3 : Form
    {
        String conn_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb"; //connection string
        OleDbConnection conn; //connection variable

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Resize(object sender, EventArgs e) //Form objects reallignment in resize
        {
            textBox1.Location = new Point(this.Width / 2 - textBox1.Width / 2, (this.Height - 127) / 2 - 25);
            textBox2.Location = new Point(this.Width / 2 - textBox2.Width / 2, (this.Height - 127) / 2 + 100); //textbox allignment

            label1.Location = new Point(textBox1.Location.X - 8, textBox1.Location.Y - textBox1.Height);
            label2.Location = new Point(textBox2.Location.X - 8, textBox2.Location.Y - textBox2.Height); //label allignment

            button1.Location = new Point(textBox1.Location.X + textBox1.Width / 2 - button1.Width / 2, textBox1.Location.Y + textBox1.Height + 10);
            button2.Location = new Point(textBox2.Location.X + textBox2.Width / 2 - button2.Width / 2, textBox2.Location.Y + textBox2.Height + 10); //button allignment
        }

        private void Form3_Load(object sender, EventArgs e) //Form objects allignement on load
        {
            textBox1.Location = new Point(this.Width / 2 - textBox1.Width/2, (this.Height -127) / 2 - 25);
            textBox2.Location = new Point(this.Width / 2 - textBox2.Width / 2, (this.Height - 127) / 2 + 100); 

            label1.Location = new Point(textBox1.Location.X - 8, textBox1.Location.Y - textBox1.Height);
            label2.Location = new Point(textBox2.Location.X - 8, textBox2.Location.Y - textBox2.Height); 

            button1.Location = new Point(textBox1.Location.X + textBox1.Width/2 - button1.Width/2, textBox1.Location.Y + textBox1.Height + 10);
            button2.Location = new Point(textBox2.Location.X + textBox2.Width / 2 - button2.Width / 2, textBox2.Location.Y + textBox2.Height + 10); 

            conn = new OleDbConnection(conn_str);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Check in every textbox input change, if it is null or if the name contains space characters 
        {
            if (textBox1.Text.Equals("") || textBox1.Text.Contains(" ")) //if yes deactivate button
                button1.Enabled = false;
            else
                button1.Enabled = true; //else activate it
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("") || textBox2.Text.Contains(" "))
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) //New username
        {
            conn.Open(); //open database
            String q1 = "Select Username from Users where Username = @un1"; //select the given username from the database if exists
            OleDbCommand cmd1 = new OleDbCommand(q1, conn); 
            cmd1.Parameters.AddWithValue("@un1", textBox1.Text);
            OleDbDataReader r1 = cmd1.ExecuteReader();
            if (r1.Read()) //if username exists, r1.Read() returns true
            {
                MessageBox.Show("This username already exists!");
            }
            else //else r1.Read() returns false
            {
                MessageBox.Show("Welcome " + textBox1.Text + "!");
                String q2 = "INSERT INTO Users(Username) VALUES(@un1)"; //insert given new username into database
                OleDbCommand cmd2 = new OleDbCommand(q2, conn);
                cmd2.Parameters.AddWithValue("@un1", textBox1.Text);
                cmd2.ExecuteNonQuery();
                Form1 f1 = new Form1(textBox1.Text); //open form1 and send as parameter the given username
                f1.Show();                
                this.Hide();
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)//Existing username
        {
            conn.Open();
            String q3 = "Select Username from Users where Username = @un2"; //select the given username from the database if exists
            OleDbCommand cmd3 = new OleDbCommand(q3, conn);
            cmd3.Parameters.AddWithValue("@un2", textBox2.Text);
            OleDbDataReader r2 = cmd3.ExecuteReader();
            if (r2.Read()) //if name exists
            {
                MessageBox.Show("Welcome back "+ textBox2.Text+"!");
                Form1 f1 = new Form1(r2[0].ToString());  //open form1 and send as parameter the given username
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This username does not exist!");
            }

            conn.Close();
        }

        
    }
}
