using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace atomiki_ergasia_2
{
    public partial class Form1 : Form
    {
        String name;        //String variable to store the name that user gave on login/register form

        int old_height, old_width;      //Variables to use in form resize

        Graphics g;
        public Pen p;           //Objects for drawing stuff

        bool drawing = false;           //Variable that enables/disables free style drawing during panel1 mouse move

        int mx, my, height, width;          //mx,my are the mouse's coordinates at the moment when mouse is down. The others, represent the width/height of the requested shape

        int shape = 1;           //shape id
        int prev_shape;          //we set the shape id here, in order to obtain it back after the auto drawing option
        Color prev_color;        //we set the p color here, in order to obtain it back in case where the user chose to use the eraser tool
        bool is_eraser = false;  //bool variable that tells if eraser tool is on

        //for house auto drawing

        int hx, hy, i = 0;          //hx,hy are the coordinates where the user choose to start the auto draw. i is the counter to specify the action, on each timer1 tick
        Pen p1;                     //exclusive pen for house


        //for snowflake auto drawing

        int snx, sny, j = 0;          //snx,sny --> starting coordinates, j--> timer2 counter
        int indx = 1;               //another counter, to use in sp1 iterration
        Pen p2;                    //exclusive pen for snowflake
        List<Point> sp1;         //list for snowflake central lines points
        List<Point> sp2;          //list for snowflake hexagon points
        List<Point> sp3;         //list for snowflake spikes points


        //for christmas tree auto drawing

        int tx, ty, k=0;            //tx,ty --> starting coordinates, k--> timer3 counter
        Pen p3;                     //exclusive pen for christmas tree
        List<Point> tp1;         //list for tree perimeter points
        List<Point> tp2;          //list for other tree line points
        List<Point> tc;         //list for tree finary points


        //for "happy new year!" text auto drawing

        int txtx, txty, l=0;     //txtx,txty --> starting coordinates, l--> timer4 counter
        int tmpx, tmpy;          //coordinates to specify in each step, the current letter's starting posision
        Pen p4;                 //exclusive pen for text

        public Form1(String name) //constractor that sets the name form variable
        {
            InitializeComponent();
            this.name = name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            old_height = this.Height;
            old_width = this.Width; //starting values for these variables

            button1.Location = new Point(button1.Location.X, button1.Location.Y);
            button2.Location = new Point(panel1.Width / 3 - button2.Width / 2, button2.Location.Y);
            button3.Location = new Point(panel1.Width / 2, button3.Location.Y);
            button4.Location = new Point(button4.Location.X, button4.Location.Y); //button allignments

            g = panel1.CreateGraphics();
            p = new Pen(Color.Black); //initializing draw objects

            shapesToolStripMenuItem.Image = freestyleToolStripMenuItem.Image; //starting shape choice image

        }

        private void Form1_Resize(object sender, EventArgs e) //in each form resize:
        {
            panel1.Size = new Size(panel1.Width + this.Width - old_width, panel1.Height + this.Height - old_height); //add at panel1 width and height the amount equal to 
            //the form's added width/height after resize

            button1.Location = new Point(button1.Location.X, button1.Location.Y + this.Height - old_height);
            button2.Location = new Point(panel1.Width/3 - button2.Width/2, button2.Location.Y + this.Height - old_height);
            button3.Location = new Point(panel1.Width/2, button3.Location.Y + this.Height - old_height);
            button4.Location = new Point(button4.Location.X + this.Width - old_width, button4.Location.Y + this.Height - old_height); //reallign buttons

            old_height = this.Height;
            old_width = this.Width; //set the new form width/height to these variables

            g = panel1.CreateGraphics(); //recreate graphics for the new (resized) panel1

        }

        public void Setpwidth(int w) //a function to set everything that has to do with the current pen size
        {
            switch (w) //depends to the chosen width, we are checking the correct toolStripMenuItem and we disable the others
            {
                case 1:
                    toolStripMenuItem1.Checked = true;
                    toolStripMenuItem3.Checked = toolStripMenuItem2.Checked = false;
                    penSizeToolStripMenuItem.Font = toolStripMenuItem1.Font;
                    break;

                case 2:
                    toolStripMenuItem2.Checked = true;
                    toolStripMenuItem1.Checked = toolStripMenuItem3.Checked = false;
                    penSizeToolStripMenuItem.Font = toolStripMenuItem2.Font;
                    break;

                case 3:
                    toolStripMenuItem3.Checked = true;
                    toolStripMenuItem1.Checked = toolStripMenuItem2.Checked = false;
                    penSizeToolStripMenuItem.Font = toolStripMenuItem3.Font;
                    break;

                default:
                    toolStripMenuItem1.Checked = toolStripMenuItem2.Checked = toolStripMenuItem3.Checked = false;
                    penSizeToolStripMenuItem.Font = toolStripMenuItem3.Font;
                    break;

            }

            p.Width = w; //we set the p width equal to the chosen value
        }
        

        private int abs(int num) //a function that returns the absolute value of num
        {
            if (num >= 0)
                return num;
            else
                return -num;
        }

        //function to draw circle with the help of DrawEllipse. We compare the absolute values of given width and height. The circle
        //is going to have dimensions equal to the greater of these values.

        private void DrawCircle(Pen p, int x, int y, int w, int h, Graphics g) 
        {
            //if abs(h) > abs(w) and we are drawing with direction top-left --> bottom-right or bottom-right --> top-left
            if (abs(h) > abs(w) && ((h>0 && w>=0) || (h < 0 && w <= 0))) 
                g.DrawEllipse(p, x, y, h, h);

            //if abs(h) > abs(w) and we are drawing with direction bottom-left --> top-right or top-right-- > bottom-left
            else if (abs(h) > abs(w) && ((h > 0 && w < 0) || (h < 0 && w > 0))) 
                g.DrawEllipse(p, x, y, -h, h);

            //if abs(h) < abs(w) and we are drawing with direction bottom-left --> top-right or top-right-- > bottom-left
            else if (abs(h) < abs(w) && ((h >= 0 && w < 0) || (h <= 0 && w > 0)))
                g.DrawEllipse(p, x, y, w, -w);

            else 
                g.DrawEllipse(p, x, y, w, w);
        }

        //We create a function that can draw a rectangle from all directions (DrawRectangle cant take negative width/height parameters).
        //We are using user's mouse coordinates as parameters for making it able to draw the rectangle correct.
        //The idea is, to draw the rectangle from the acceptable direction(top-left --> bottom-right)
        //independently of the user's direction

        private void DrawRectangleplus(Pen p, int x, int y, int w, int h, MouseEventArgs e, Graphics g)
        {
            //if direction is top-left --> bottom-right 
            if (h >= 0 && w >= 0)
                g.DrawRectangle(p, x, y, w, h);

            //if direction is bottom-left --> top-right 
            else if (h < 0 && w >= 0)
                g.DrawRectangle(p, x, e.Y, w, -h);

            //if direction is top-right --> bottom-left
            else if (h < 0 && w < 0)
                g.DrawRectangle(p, e.X, e.Y, -w, -h);

            else
                g.DrawRectangle(p, e.X, y, -w, h);
        }

        //Function to draw squares(identical to the circle function above)

        private void DrawSquare(Pen p, int x, int y, int w, int h, MouseEventArgs e, Graphics g)
        {
            //if abs(h) > abs(w) and we are drawing with direction top-left --> bottom-right or bottom-right --> top-left
            if (abs(h) > abs(w) && ((h > 0 && w >= 0) || (h < 0 && w <= 0)))
                DrawRectangleplus(p, x, y, h, h, e, g);

            //if abs(h) > abs(w) and we are drawing with direction bottom-left --> top-right or top-right-- > bottom-left
            else if (abs(h) > abs(w) && ((h > 0 && w < 0) || (h < 0 && w > 0)))
                DrawRectangleplus(p, x, y, -h, h, e, g);

            //if abs(h) < abs(w) and we are drawing with direction bottom-left --> top-right or top-right-- > bottom-left
            else if (abs(h) < abs(w) && ((h >= 0 && w < 0) || (h <= 0 && w > 0)))
                DrawRectangleplus(p, x, y, w, -w, e, g);

            else
                DrawRectangleplus(p, x, y, w, w, e, g);
        }
      
        //function to draw 3 lines, in order to shape a right triangle

        private void DrawRighttriangle(Pen p, int x, int y, MouseEventArgs e, Graphics g)
        {
            g.DrawLine(p, x, y, e.X, e.Y);
            g.DrawLine(p, e.X, e.Y, x, e.Y);
            g.DrawLine(p, x, e.Y, x, y);
        }      

        private void timer1_Tick(object sender, EventArgs e) //timer for House
        {           
            if (i == 0) //on every first tick
            {
                p1 = new Pen(p.Color,p.Width); //set the exclusive's pen color and width equal to main p color and width

                button2.Enabled = button3.Enabled = button4.Enabled = true; //enable the other design buttons(they had been disabled during starting coordinates selection)
                shape = prev_shape; //store back previous shape id to shape id(shape id was changed when we chose a auto design)
                panel1.Cursor = Cursors.Default; //set the cursor to default(it had been set to cross when we chose a auto design)
            }

            //in dependence of counter, we are making the corresponding lines

            if (i < 5)
                g.DrawLine(p1, hx + 50 * i, hy, hx + 50 * (i + 1), hy);
            
            else if (i >= 5 && i < 10)            
                g.DrawLine(p1, hx + 250, hy - 50 * (i - 5), hx + 250, hy - 50 * (i - 4));
           
            else if (i >= 10 && i < 15)          
                g.DrawLine(p1, hx + 250 - 50 * (i - 10), hy - 250, hx + 250 - 50 * (i - 9), hy - 250);
            
            else if (i >= 15 && i < 20)           
                g.DrawLine(p1, hx, hy - 250 + 50 * (i - 15), hx, hy - 250 + 50 * (i - 14));
            
            else if (i >= 20 && i < 22)            
                g.DrawLine(p1, hx + 100, hy - 50 * (i - 20), hx + 100, hy - 50 * (i - 19));
           
            else if (i == 22)           
                g.DrawLine(p1, hx + 100, hy - 100, hx + 150, hy - 100);
            
            else if (i >= 23 && i < 25)
                g.DrawLine(p1, hx + 150, hy - 100 + 50 * (i - 23), hx + 150, hy - 100 + 50 * (i - 22));

            else if (i == 25)
                DrawCircle(p1, hx + 150, hy - 50, -10, 10, g);

            else if(i>=26 && i<29)
                g.DrawLine(p1, hx + 50 + 25*(i-26), hy - 150, hx + 50 + 25 * (i - 26), hy - 200);

            else if(i>=29 && i<32)
                g.DrawLine(p1, hx + 50, hy - 150 - 25*(i-29), hx + 100, hy - 150 - 25 * (i - 29));
           
            else if (i >= 32 && i<35)
                g.DrawLine(p1, hx + 150, hy - 150 - 25 * (i - 32), hx + 200, hy - 150 - 25 * (i - 32));
           
            else if (i >= 35 && i<38)
                g.DrawLine(p1, hx + 150 + 25*(i-35), hy - 150, hx + 150 + 25 * (i - 35), hy - 200);
            
            else if(i>=38 && i<40)
                g.DrawLine(p1, hx + 50*(i-38) , hy - 250 -50*(i - 38), hx + 50 * (i - 37), hy - 250 - 50 * (i - 37));

            else if (i == 40)
            {
                g.DrawLine(p1, hx + 100, hy - 350, hx + 125, hy - 375);
                g.DrawLine(p1, hx + 125, hy - 375, hx + 150, hy - 350);
            }
                
            else if (i >= 41 && i < 43)
                g.DrawLine(p1, hx + 150 + 50 * (i - 41), hy - 350 + 50 * (i - 41), hx + 150 + 50 * (i - 40), hy - 350 + 50 * (i - 40));

            if(i == 42)
            {
                timer1.Enabled = false;
                button1.Text = "Draw house"; //in last step, disable timer and set back button text to default
            }

            i++; //add one to step counter in each tick end

        }
        
        private void timer2_Tick(object sender, EventArgs e) //timer for Snowflake
        {
            if (j == 0)
            {
                p2 = new Pen(p.Color,p.Width);

                button1.Enabled = button3.Enabled = button4.Enabled = true;
                shape = prev_shape;
                panel1.Cursor = Cursors.Default;

                indx = 1;

                sp1 = new List<Point>() { new Point(snx, sny), new Point(snx, sny + 75), new Point(snx + 65, sny + 38), new Point(snx + 65, sny - 38),
                    new Point(snx , sny - 75), new Point(snx - 65, sny - 38), new Point(snx - 65, sny + 38) };      //list for snowflake central lines points

                sp2 = new List<Point>() { new Point(snx, sny + 50), new Point(snx + 43, sny + 25), new Point(snx + 43, sny - 25), new Point(snx, sny - 50),
                    new Point(snx -43, sny - 25), new Point(snx-43, sny + 25)};         //list for snowflake hexagon points

                sp3 = new List<Point>() {new Point(snx - 35, sny + 110), new Point(snx, sny + 125), new Point(snx + 35, sny + 110),
                    new Point(snx + 65, sny + 88), new Point(snx + 100, sny + 73),new Point(snx +115, sny + 38),
                    new Point(snx +115, sny - 38), new Point(snx + 100, sny - 73),new Point(snx + 65, sny - 88),
                    new Point(snx + 35, sny - 110), new Point(snx, sny - 125), new Point(snx - 35, sny - 110),
                    new Point(snx - 65, sny - 88), new Point(snx - 100, sny - 73),new Point(snx -115, sny - 38),
                    new Point(snx -115, sny + 38), new Point(snx - 100, sny + 73),new Point(snx - 65, sny + 88)};  //list for snowflake spikes point
            }

            if (j <6)           
                g.DrawLine(p2, sp1[0], sp1[j + 1]);
            
            else if(j>=6 && j < 11)            
                g.DrawLine(p2, sp2[j - 6], sp2[j - 5]);                              
            
            else if (j == 11)
                g.DrawLine(p2, sp2[5], sp2[0]);

            else if(j>= 12 && j < 30)
            {
                if (j == 15 || j == 18 || j == 21 || j == 24 || j == 27)
                    indx++;

                g.DrawLine(p2, sp1[indx], sp3[j - 12]);               
            }

            if (j == 29)
            {
                timer2.Enabled = false;
                button2.Text = "Draw snowflake";
            }

            j++;
        }

        private void timer3_Tick(object sender, EventArgs e) //timer for christmas tree
        {
            if (k == 0)
            {
                p3 = new Pen(p.Color,p.Width);

                button1.Enabled = button2.Enabled = button4.Enabled = true;
                shape = prev_shape;
                panel1.Cursor = Cursors.Default;

                tp1 = new List<Point>() {new Point(tx,ty), new Point(tx + 50, ty), new Point(tx+50, ty+50), new Point(tx, ty+50),new Point(tx,ty), new Point(tx-50, ty),new Point(tx - 100, ty),
                    new Point(tx - 75, ty -50), new Point(tx - 50, ty - 100),new Point(tx - 25, ty -150),new Point(tx , ty -200), new Point(tx + 25, ty -250),
                    new Point(tx + 25, ty -275),new Point(tx, ty - 250),new Point(tx + 25, ty - 325),new Point(tx + 50, ty -250),new Point(tx + 25, ty -275),
                    new Point(tx -12, ty -300),new Point(tx + 62, ty -300),new Point(tx + 25, ty -275),new Point(tx + 25, ty -250),
                    new Point(tx + 50, ty -200),new Point(tx + 75, ty -150),new Point(tx + 100, ty -100),new Point(tx + 125, ty -50),new Point(tx + 150, ty),
                    new Point(tx + 100, ty),new Point(tx + 50, ty)};   //list for tree perimeter points

                tp2 = new List<Point>() { new Point(tx-75, ty-50), new Point(tx+125, ty-50), new Point(tx-50, ty-100), new Point(tx+100, ty-100),
                    new Point(tx-25, ty-150),new Point(tx+75, ty-150),new Point(tx, ty-200),new Point(tx+50, ty-200)};    //list for other tree lines points

                tc = new List<Point>() { new Point(tx - 62, ty-38), new Point(tx - 12, ty - 38), new Point(tx + 38, ty - 38), new Point(tx + 88, ty - 38),
                    new Point(tx - 37, ty - 88),new Point(tx + 12, ty - 88),new Point(tx + 62, ty - 88),
                    new Point(tx - 12, ty - 138),new Point(tx + 37, ty - 138),
                    new Point(tx + 12, ty - 188)};       //list for tree finary points
            }

            if (k < 27)
                g.DrawLine(p3, tp1[k], tp1[k + 1]);

            else if (k >= 27 && k <= 33)
                g.DrawLine(p3, tp2[k - 27], tp2[k - 26]);
            
            else if (k >= 34 && k < 44)
                g.DrawEllipse(p3, tc[k-34].X, tc[k - 34].Y, 25, 25);
            
            if (k == 43)
            {
                timer3.Enabled = false;
                button3.Text = "Draw christmas tree";
            }

            if (k < 27 || k >= 33)
                k++;
            else
                k += 2;               
        }

        private void timer4_Tick(object sender, EventArgs e) //timer for happy birthday text
        {
            if (l == 0)
            {
                p4 = new Pen(p.Color, p.Width);

                button1.Enabled = button2.Enabled = button3.Enabled = true;
                shape = prev_shape;
                panel1.Cursor = Cursors.Default;

                tmpx = txtx;
                tmpy = txty;
            }

            if (l == 0) //H
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx, tmpy - 50);
                g.DrawLine(p4, tmpx, tmpy - 25, tmpx + 25 , tmpy - 25);
                g.DrawLine(p4, tmpx + 25, tmpy, tmpx + 25, tmpy - 50);

                tmpx += 50;

            }else if (l == 1 || l == 10) //A
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx + 12, tmpy - 50);
                g.DrawLine(p4, tmpx + 12, tmpy - 50, tmpx + 25, tmpy);
                g.DrawLine(p4, tmpx + 6, tmpy - 25, tmpx + 19, tmpy - 25);

                tmpx += 50;
            }
            else if(l == 2 || l==3 || l==11) //P or R
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx, tmpy - 50);
                g.DrawRectangle(p4, tmpx, tmpy - 50, 25, 25);

                if (l == 2)
                    tmpx += 50;

                else if (l == 11)
                {
                    g.DrawLine(p4, tmpx, tmpy - 25, tmpx + 25, tmpy);
                    tmpx += 50;
                }          
                
                else
                    tmpx += 75;
            }
            else if (l == 4 || l==8) //Y
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx, tmpy - 25);
                g.DrawLine(p4, tmpx, tmpy - 25, tmpx - 25 , tmpy - 50);
                g.DrawLine(p4, tmpx, tmpy - 25, tmpx + 25, tmpy - 50);

                if (l == 4)
                {
                    tmpx -= 225;
                    tmpy += 100;
                }
                else
                    tmpx += 50;
            }
            else if (l == 5) //N
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx, tmpy - 50);
                g.DrawLine(p4, tmpx, tmpy -50 , tmpx +25, tmpy);
                g.DrawLine(p4, tmpx +25, tmpy, tmpx +25, tmpy - 50);

                tmpx += 50;
            }
            else if (l == 6 || l==9) //E
            {
                g.DrawLine(p4, tmpx, tmpy, tmpx, tmpy - 50);
                g.DrawLine(p4, tmpx, tmpy, tmpx + 25, tmpy);
                g.DrawLine(p4, tmpx, tmpy - 25, tmpx + 25, tmpy -25);               
                g.DrawLine(p4, tmpx, tmpy - 50, tmpx + 25, tmpy - 50);

                tmpx += 50;
            }
            else if (l == 7) //W
            {
                g.DrawLine(p4, tmpx, tmpy - 50, tmpx + 6, tmpy);
                g.DrawLine(p4, tmpx + 6, tmpy, tmpx + 12, tmpy - 25);
                g.DrawLine(p4, tmpx + 12, tmpy - 25, tmpx + 18 , tmpy);
                g.DrawLine(p4, tmpx + 18, tmpy, tmpx + 24, tmpy - 50);

                tmpx += 100;
            }

            else if (l == 12)
            {
                g.DrawEllipse(p4, tmpx, tmpy - 25, 25, 25);
                g.DrawLine(p4, tmpx + 12, tmpy - 25, tmpx + 12, tmpy - 75);

                timer4.Enabled = false;
                button4.Text = "Happy new year!";
            }

            l++;
        }

        private void buttons_Click(object sender, EventArgs e) //A function that supports all 4 buttons
        {
            if (!((Button)sender).Text.Equals("Cancel")) //we cast the sender to Button type and we check if it's text is "Cancel"
            { 
                //if its not

                prev_shape = shape; //store the current shape id

                panel1.Cursor = Cursors.Cross; //make the cursor cross inside panel1

                ((Button)sender).Text = "Cancel"; //make the pressed button text "cancel"

                switch (((Button)sender).Name) 
                {
                    //set the shape id equal to the id that corresponds to the pressed button design
                    //disable the other buttons

                    case "button1":
                        shape = 8;
                        button2.Enabled = button3.Enabled = button4.Enabled = false;
                        break;

                    case "button2":
                        shape = 9;
                        button1.Enabled = button3.Enabled = button4.Enabled = false;
                        break;
                       
                    case "button3":
                        shape = 10;
                        button1.Enabled = button2.Enabled = button4.Enabled = false;
                        break;

                    case "button4":
                        shape = 11;
                        button1.Enabled = button2.Enabled = button3.Enabled = false;
                        break;
                }
            }
            else //else button text is "cancel"
            {
                shape = prev_shape; //store back the previous shape id

                panel1.Cursor = Cursors.Default; //set cursor to default

                switch (((Button)sender).Name)
                {
                    //in dependence of the pressed button
                    //disable the corresponding timer
                    //enable the buttons
                    //change the pressed button text to default

                    case "button1":
                        timer1.Enabled = false;
                        button2.Enabled = button3.Enabled = button4.Enabled = true;
                        ((Button)sender).Text = "Draw house";
                        break;

                    case "button2":
                        timer2.Enabled = false;
                        button1.Enabled = button3.Enabled = button4.Enabled = true;
                        ((Button)sender).Text = "Draw snowflake";
                        break;

                    case "button3":
                        timer3.Enabled = false;
                        button1.Enabled = button2.Enabled = button4.Enabled = true;
                        ((Button)sender).Text = "Draw christmas tree";
                        break;

                    case "button4":
                        timer4.Enabled = false;
                        button1.Enabled = button2.Enabled = button3.Enabled = true;
                        ((Button)sender).Text = "Happy new year!";
                        break;
                }

            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //on panel1 mousedown
        {
            mx = e.X;
            my = e.Y; //store the current mouse coordinates

            if (shape == 1) //if the choice is freestyle, set drawing = true to make drawing available during mousemove
                drawing = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //on panel1 mousemove
        {
            if(drawing) //if drawing is enabled
            {
                g.DrawLine(p, mx, my, e.X, e.Y);
                mx = e.X;
                my = e.Y; //draw during mousemove

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) //on panel1 mouseup
        {
            height = e.Y - my;
            width = e.X - mx; //initialize the height/width variables

            String conn_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Users.mdb";
            OleDbConnection conn = new OleDbConnection(conn_str); //connect to database
            OleDbCommand cmd1; 
            OleDbCommand cmd2; //two commands for every case
            DateTime last_time = DateTime.Now; //get current date time

            switch (shape) //if the id corresponds to:
            {
                case 1: //freestyle
                    drawing = false; //disable freestyle
                    break;

                case 2:  //line segment               
                    g.DrawLine(p, mx, my, e.X, e.Y); //draw
                   
                    conn.Open(); //open database

                    cmd1 = new OleDbCommand("update Users set Number_of_line_segments = Number_of_line_segments + 1 where Username=@un", conn);
                    //add one to the Number_of_line_segments column value. The line depends on username 

                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_line_timestamp=@time where Username=@un", conn); //store the new timestamp for this shape in database
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();
                    
                    conn.Close(); //close database

                    break;

                case 3: //ellipse
                    g.DrawEllipse(p, mx, my, width, height);

                    conn.Open();

                    cmd1 = new OleDbCommand("update Users set Number_of_ellipses = Number_of_ellipses + 1 where Username=@un", conn);
                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_ellipse_timestamp=@time where Username=@un", conn);
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    break;

                case 4: //circle
                    DrawCircle(p, mx, my, width, height, g);

                    conn.Open();

                    cmd1 = new OleDbCommand("update Users set Number_of_circles = Number_of_circles + 1 where Username=@un", conn);
                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_circle_timestamp=@time where Username=@un", conn);
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    break;

                case 5: //square
                    DrawSquare(p, mx, my, width, height, e, g);

                    conn.Open();

                    cmd1 = new OleDbCommand("update Users set Number_of_squares = Number_of_squares + 1 where Username=@un", conn);
                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_square_timestamp=@time where Username=@un", conn);
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    break;

                case 6: //rectangle
                    DrawRectangleplus(p, mx, my, width, height, e, g);

                    conn.Open();

                    cmd1 = new OleDbCommand("update Users set Number_of_rectangles = Number_of_rectangles + 1 where Username=@un", conn);
                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_rectangle_timestamp=@time where Username=@un", conn);
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    break;

                case 7: //right triangle
                    DrawRighttriangle(p, mx, my, e, g);

                    conn.Open();

                    cmd1 = new OleDbCommand("update Users set Number_of_right_triangles = Number_of_right_triangles + 1 where Username=@un", conn);
                    cmd1.Parameters.AddWithValue("@un", name);
                    cmd1.ExecuteNonQuery();

                    cmd2 = new OleDbCommand("update Users set Last_triangle_timestamp=@time where Username=@un", conn);
                    cmd2.Parameters.AddWithValue("@time", last_time);
                    cmd2.Parameters.AddWithValue("@un", name);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    break;

                case 8: //House
                    hx = e.X;
                    hy = e.Y; //store the chosen starting coordinates for design

                    i = 0; //reset corresponding counter

                    timer1.Enabled = true; //enable corresponding timer
                    break;

                case 9: //Snowflake
                    snx = e.X;
                    sny = e.Y;

                    j = 0;

                    timer2.Enabled = true;
                    break;

                case 10: //Christmas tree
                    tx = e.X;
                    ty = e.Y;

                    k = 0;                    

                    timer3.Enabled = true;
                    break;

                case 11: //happy new year text
                    txtx = e.X;
                    txty = e.Y;

                    l = 0;

                    timer4.Enabled = true;
                    break;
            }
           
        }     

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) //This function executes for all colorToolStripMenuItem choices
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender; //Cast sender object to ToolStripMenuItem type and store it in t

            switch (t.Name) 
            {
                //In dependence of t.Name:
                //Check the correct ToolStripMenuItem
                //Uncheck the other ToolStripMenuItems
                //Set the correct p.Color

                case "redToolStripMenuItem":

                    redToolStripMenuItem.Checked = true;

                    greenToolStripMenuItem.Checked = blueToolStripMenuItem.Checked =
                    blackToolStripMenuItem.Checked = chooseColorToolStripMenuItem.Checked =
                    false;

                    p.Color = Color.Red;
                    break;

                case "greenToolStripMenuItem":

                    greenToolStripMenuItem.Checked = true;

                    redToolStripMenuItem.Checked = blueToolStripMenuItem.Checked =
                    blackToolStripMenuItem.Checked = chooseColorToolStripMenuItem.Checked =
                    false;

                    p.Color = Color.Green;
                    break;

                case "blueToolStripMenuItem":

                    blueToolStripMenuItem.Checked = true;

                    redToolStripMenuItem.Checked = greenToolStripMenuItem.Checked =
                    blackToolStripMenuItem.Checked = chooseColorToolStripMenuItem.Checked =
                    false;

                    p.Color = Color.Blue;
                    break;

                case "blackToolStripMenuItem":

                    blackToolStripMenuItem.Checked = true;

                    redToolStripMenuItem.Checked = greenToolStripMenuItem.Checked =
                    blueToolStripMenuItem.Checked = chooseColorToolStripMenuItem.Checked =
                    false;

                    p.Color = Color.Black;
                    break;

                case "chooseColorToolStripMenuItem":

                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        redToolStripMenuItem.Checked = greenToolStripMenuItem.Checked =
                        blueToolStripMenuItem.Checked = blackToolStripMenuItem.Checked =
                        false;

                        p.Color = colorDialog1.Color;
                        chooseColorToolStripMenuItem.ForeColor = p.Color;

                        //in this case we are unchecking all the colorToolStripMenuItems and we set the chooseColorToolStripMenuItem fore color
                        //equal to the chosen color
                    }

                    break;
            }

            colorToolStripMenuItem.ForeColor = t.ForeColor; //Set fore color of colorToolStripMenuItem, equal to the chosen color

        }

        private void penSizeToolStripMenuItem_Click(object sender, EventArgs e) //for all penSizeToolStripMenuItems
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;

            switch (t.Name) //execute the Setpwidth function with the correct Width parameter that corresponds to the user's choice 
            {
                case "toolStripMenuItem1":
                    Setpwidth(1);                    
                    break;

                case "toolStripMenuItem2":
                    Setpwidth(2);
                    break;

                case "toolStripMenuItem3":
                    Setpwidth(3);
                    break;

                case "chooseSizeToolStripMenuItem":
                    Form2 f2 = new Form2((int)p.Width); //if user wants to choose size, open form2 with the current p.Width value as constructor parameter
                    f2.Show();
                    break;
            }
        }
      
        private void shapesToolStripMenuItem_Click(object sender, EventArgs e) //for all shapesToolStripMenuItems
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender; //get chosen ToolStripMenuItem object

            colorToolStripMenuItem.Enabled = true; //In case we had disabled colorToolStripMenuItem(eraser choice) we are enabling it again when the user chooses another shape

            if (is_eraser) //if we chose eraser before this choice , is_eraser is true
            {
                p.Color = prev_color; //set back the previous color
                is_eraser = false; //set is_eraser false
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true; //enable all buttons again(they had been disabled during eraser choice)
            }
                
            //In dependence of the user's shape choice, set the corresponding id

            switch (t.Name)
            {
                case "freestyleToolStripMenuItem":

                    shape = 1;
                    break;

                case "lineToolStripMenuItem":

                    shape = 2;
                    break;

                case "ellipseToolStripMenuItem":

                    shape = 3;
                    break;

                case "circleToolStripMenuItem":

                    shape = 4;
                    break;

                case "squareToolStripMenuItem":

                    shape = 5;
                    break;

                case "rectangleToolStripMenuItem":

                    shape = 6;
                    break;

                case "rightTriangleToolStripMenuItem":

                    shape = 7;
                    break;

                case "eraserToolStripMenuItem":
                  
                    button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false; //disable all buttons as we dont want the user to use them during eraser function

                    colorToolStripMenuItem.Enabled = false; //Disable color choice during eraser function

                    is_eraser = true; //set is_eraser true

                    prev_color = p.Color; //store current color on prev_color
                    p.Color = Color.White; //set current color to white 

                    shape = 1; //eraser is freestyle with white color 
                    break;
            }

            freestyleToolStripMenuItem.Checked = lineToolStripMenuItem.Checked =
            ellipseToolStripMenuItem.Checked = circleToolStripMenuItem.Checked =
            squareToolStripMenuItem.Checked = rectangleToolStripMenuItem.Checked =
            rightTriangleToolStripMenuItem.Checked = eraserToolStripMenuItem.Checked = false; 

            t.Checked = true; //Uncheck all shapesToolStripMenuItems and check the one that user chose

            shapesToolStripMenuItem.Image = t.Image; //set shapesToolStripMenuItem image equal to the shape image the user chose

        }

        private void cleanUpToolStripMenuItem_Click(object sender, EventArgs e) //Clean up item
        {
            g.Clear(Color.White); //fill panel1 whith white color
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e) //user details item
        {
            Form4 f4 = new Form4(name); //open form4 with the current username as Constractor parameter
            f4.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //on form3 closing
        {
            ((Form3)Application.OpenForms[0]).Show(); //show the login form
        }
    }
}
