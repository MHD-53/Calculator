namespace Calculator
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
            this.pnl_title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txb_display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_title.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.Controls.Add(this.label1);
            this.pnl_title.Controls.Add(this.button2);
            this.pnl_title.Controls.Add(this.button1);
            this.pnl_title.Controls.Add(this.btn_exit);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(361, 40);
            this.pnl_title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "MHD\'s Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(211, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "__";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(261, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "#";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.Location = new System.Drawing.Point(311, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 40);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txb_display
            // 
            this.txb_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_display.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.txb_display.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txb_display.Location = new System.Drawing.Point(3, 96);
            this.txb_display.Margin = new System.Windows.Forms.Padding(0);
            this.txb_display.Multiline = true;
            this.txb_display.Name = "txb_display";
            this.txb_display.ReadOnly = true;
            this.txb_display.Size = new System.Drawing.Size(361, 50);
            this.txb_display.TabIndex = 4;
            this.txb_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_display.TextChanged += new System.EventHandler(this.txb_display_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ce, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_c, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_equal, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_min, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_mul, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_point, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_div, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 385);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.btn_0_Click);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_ce
            // 
            this.btn_ce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ce.FlatAppearance.BorderSize = 0;
            this.btn_ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ce.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ce.ForeColor = System.Drawing.Color.Black;
            this.btn_ce.Location = new System.Drawing.Point(291, 101);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(66, 88);
            this.btn_ce.TabIndex = 16;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = false;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_c.FlatAppearance.BorderSize = 0;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Gadugi", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.Black;
            this.btn_c.Location = new System.Drawing.Point(291, 7);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(66, 88);
            this.btn_c.TabIndex = 15;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.Color.Black;
            this.btn_equal.Location = new System.Drawing.Point(291, 195);
            this.btn_equal.Name = "btn_equal";
            this.tableLayoutPanel1.SetRowSpan(this.btn_equal, 2);
            this.btn_equal.Size = new System.Drawing.Size(66, 183);
            this.btn_equal.TabIndex = 17;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(220, 195);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(65, 88);
            this.btn_min.TabIndex = 14;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_min.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_min.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_mul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_mul.FlatAppearance.BorderSize = 0;
            this.btn_mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mul.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.Location = new System.Drawing.Point(220, 101);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(65, 88);
            this.btn_mul.TabIndex = 13;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_mul.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_mul.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(220, 289);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 89);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_add.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_add.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_point.FlatAppearance.BorderSize = 0;
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_point.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(149, 289);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(65, 89);
            this.btn_point.TabIndex = 10;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_point.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_point.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btn_0, 2);
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(7, 289);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(136, 89);
            this.btn_0.TabIndex = 9;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_0.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_0.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(149, 195);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 88);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(78, 195);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 88);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(7, 195);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 88);
            this.btn_1.TabIndex = 6;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(149, 101);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 88);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_6.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_6.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(78, 101);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 88);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_5.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_5.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(7, 101);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 88);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_4.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(78, 7);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 88);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_8.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_8.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(7, 7);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 88);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_7.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_7.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(149, 7);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 88);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_9.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_9.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_div.FlatAppearance.BorderSize = 0;
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_div.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(220, 7);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(65, 88);
            this.btn_div.TabIndex = 12;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_0_Click);
            this.btn_div.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_div.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(361, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txb_display);
            this.Controls.Add(this.pnl_title);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

