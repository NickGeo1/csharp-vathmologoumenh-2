namespace atomiki_ergasia_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freestyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.cleanUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.penSizeToolStripMenuItem,
            this.cleanUpToolStripMenuItem,
            this.userDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freestyleToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.rightTriangleToolStripMenuItem,
            this.eraserToolStripMenuItem});
            this.shapesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.shapesToolStripMenuItem.Text = "Design";
            // 
            // freestyleToolStripMenuItem
            // 
            this.freestyleToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.freestyleToolStripMenuItem.Checked = true;
            this.freestyleToolStripMenuItem.CheckOnClick = true;
            this.freestyleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.freestyleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("freestyleToolStripMenuItem.Image")));
            this.freestyleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.freestyleToolStripMenuItem.Name = "freestyleToolStripMenuItem";
            this.freestyleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.freestyleToolStripMenuItem.Text = "Freestyle";
            this.freestyleToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.lineToolStripMenuItem.CheckOnClick = true;
            this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
            this.lineToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lineToolStripMenuItem.Text = "Line segment";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.CheckOnClick = true;
            this.ellipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripMenuItem.Image")));
            this.ellipseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.CheckOnClick = true;
            this.circleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("circleToolStripMenuItem.Image")));
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.squareToolStripMenuItem.CheckOnClick = true;
            this.squareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("squareToolStripMenuItem.Image")));
            this.squareToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.CheckOnClick = true;
            this.rectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripMenuItem.Image")));
            this.rectangleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // rightTriangleToolStripMenuItem
            // 
            this.rightTriangleToolStripMenuItem.CheckOnClick = true;
            this.rightTriangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rightTriangleToolStripMenuItem.Image")));
            this.rightTriangleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.rightTriangleToolStripMenuItem.Name = "rightTriangleToolStripMenuItem";
            this.rightTriangleToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.rightTriangleToolStripMenuItem.Text = "Right triangle";
            this.rightTriangleToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eraserToolStripMenuItem.Image")));
            this.eraserToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eraserToolStripMenuItem.Text = "Eraser";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.chooseColorToolStripMenuItem});
            this.colorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.colorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.CheckOnClick = true;
            this.redToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.redToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.CheckOnClick = true;
            this.greenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.CheckOnClick = true;
            this.blueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Checked = true;
            this.blackToolStripMenuItem.CheckOnClick = true;
            this.blackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            this.chooseColorToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.chooseColorToolStripMenuItem.Text = "Choose color...";
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // penSizeToolStripMenuItem
            // 
            this.penSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.chooseSizeToolStripMenuItem});
            this.penSizeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.penSizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.penSizeToolStripMenuItem.Name = "penSizeToolStripMenuItem";
            this.penSizeToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.penSizeToolStripMenuItem.Text = "Pen size";
            this.penSizeToolStripMenuItem.Click += new System.EventHandler(this.penSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItem1.Text = "1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.penSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.penSizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 26);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.penSizeToolStripMenuItem_Click);
            // 
            // chooseSizeToolStripMenuItem
            // 
            this.chooseSizeToolStripMenuItem.Name = "chooseSizeToolStripMenuItem";
            this.chooseSizeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.chooseSizeToolStripMenuItem.Text = "Choose size...";
            this.chooseSizeToolStripMenuItem.Click += new System.EventHandler(this.penSizeToolStripMenuItem_Click);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.userDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.userDetailsToolStripMenuItem.Text = "User details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 497);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(12, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Draw house";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(200, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Draw snowflake";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(453, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Draw christmas tree";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttons_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(746, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Happy new year!";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttons_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // cleanUpToolStripMenuItem
            // 
            this.cleanUpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cleanUpToolStripMenuItem.Name = "cleanUpToolStripMenuItem";
            this.cleanUpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.cleanUpToolStripMenuItem.Text = "Clean up";
            this.cleanUpToolStripMenuItem.Click += new System.EventHandler(this.cleanUpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(963, 577);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(930, 550);
            this.Name = "Form1";
            this.Text = "Drawing app";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freestyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penSizeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem chooseSizeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem rightTriangleToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanUpToolStripMenuItem;
    }
}

