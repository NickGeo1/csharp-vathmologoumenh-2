using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergasia_2
{
    public partial class Form4 : Form
    {
        String name; //username

        int old_width;
        int old_height; //for resize


        public Form4(String name) 
        {
            InitializeComponent();
            this.name = name; //set the username
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(dataGridView1.Width + this.Width - old_width, dataGridView1.Height + this.Height - old_height); //resize table

            old_height = this.Height;
            old_width = this.Width;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            old_height = this.Height;
            old_width = this.Width; //for resize

            // TODO: This line of code loads data into the 'usersDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.usersDataSet1.Users);

            int rows = this.usersDataSet1.Users.Rows.Count; //set the amount of database rows in rows variable

            //in a loop that executes rows - 1 times(we want to remove all database rows in form database table except the one that has the current username) 

            for (int i = 0; i < rows - 1; i++) 
            {
                //if first column and row value(first username) in form database table is not equal to username 
                if (!this.usersDataSet1.Users.Rows[0].ItemArray[0].ToString().Equals(name))             
                    this.usersDataSet1.Users.Rows.RemoveAt(0);   //remove first row from form table            
                else
                    this.usersDataSet1.Users.Rows.RemoveAt(1); //else this row has the username, so remove the next row                            
            }
        }
    }
}
