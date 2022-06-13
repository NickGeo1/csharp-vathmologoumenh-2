namespace atomiki_ergasia_2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcircletimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastlinetimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastellipsetimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastsquaretimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastrectangletimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasttriangletimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet1 = new atomiki_ergasia_2.UsersDataSet();
            this.usersTableAdapter1 = new atomiki_ergasia_2.UsersDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "User details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.lastcircletimestampDataGridViewTextBoxColumn,
            this.lastlinetimestampDataGridViewTextBoxColumn,
            this.lastellipsetimestampDataGridViewTextBoxColumn,
            this.lastsquaretimestampDataGridViewTextBoxColumn,
            this.lastrectangletimestampDataGridViewTextBoxColumn,
            this.lasttriangletimestampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(987, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number_of_ellipses";
            this.dataGridViewTextBoxColumn2.HeaderText = "Number_of_ellipses";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number_of_circles";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number_of_circles";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number_of_rectangles";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number_of_rectangles";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Number_of_squares";
            this.dataGridViewTextBoxColumn5.HeaderText = "Number_of_squares";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Number_of_line_segments";
            this.dataGridViewTextBoxColumn6.HeaderText = "Number_of_line_segments";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Number_of_right_triangles";
            this.dataGridViewTextBoxColumn7.HeaderText = "Number_of_right_triangles";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // lastcircletimestampDataGridViewTextBoxColumn
            // 
            this.lastcircletimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_circle_timestamp";
            this.lastcircletimestampDataGridViewTextBoxColumn.HeaderText = "Last_circle_timestamp";
            this.lastcircletimestampDataGridViewTextBoxColumn.Name = "lastcircletimestampDataGridViewTextBoxColumn";
            this.lastcircletimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastlinetimestampDataGridViewTextBoxColumn
            // 
            this.lastlinetimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_line_timestamp";
            this.lastlinetimestampDataGridViewTextBoxColumn.HeaderText = "Last_line_timestamp";
            this.lastlinetimestampDataGridViewTextBoxColumn.Name = "lastlinetimestampDataGridViewTextBoxColumn";
            this.lastlinetimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastellipsetimestampDataGridViewTextBoxColumn
            // 
            this.lastellipsetimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_ellipse_timestamp";
            this.lastellipsetimestampDataGridViewTextBoxColumn.HeaderText = "Last_ellipse_timestamp";
            this.lastellipsetimestampDataGridViewTextBoxColumn.Name = "lastellipsetimestampDataGridViewTextBoxColumn";
            this.lastellipsetimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastsquaretimestampDataGridViewTextBoxColumn
            // 
            this.lastsquaretimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_square_timestamp";
            this.lastsquaretimestampDataGridViewTextBoxColumn.HeaderText = "Last_square_timestamp";
            this.lastsquaretimestampDataGridViewTextBoxColumn.Name = "lastsquaretimestampDataGridViewTextBoxColumn";
            this.lastsquaretimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastrectangletimestampDataGridViewTextBoxColumn
            // 
            this.lastrectangletimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_rectangle_timestamp";
            this.lastrectangletimestampDataGridViewTextBoxColumn.HeaderText = "Last_rectangle_timestamp";
            this.lastrectangletimestampDataGridViewTextBoxColumn.Name = "lastrectangletimestampDataGridViewTextBoxColumn";
            this.lastrectangletimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lasttriangletimestampDataGridViewTextBoxColumn
            // 
            this.lasttriangletimestampDataGridViewTextBoxColumn.DataPropertyName = "Last_triangle_timestamp";
            this.lasttriangletimestampDataGridViewTextBoxColumn.HeaderText = "Last_triangle_timestamp";
            this.lasttriangletimestampDataGridViewTextBoxColumn.Name = "lasttriangletimestampDataGridViewTextBoxColumn";
            this.lasttriangletimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet1;
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "UsersDataSet";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "User details";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Resize += new System.EventHandler(this.Form4_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UsersDataSet usersDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcircletimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastlinetimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastellipsetimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastsquaretimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastrectangletimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasttriangletimestampDataGridViewTextBoxColumn;
    }
}