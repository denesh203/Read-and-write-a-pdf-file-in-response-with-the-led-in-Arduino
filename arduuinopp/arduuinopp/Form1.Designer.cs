namespace arduuinopp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            stop = new Button();
            addnline = new Button();
            button1 = new Button();
            pdf2 = new Button();
            pdf1 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            textBox3 = new TextBox();
            save = new Button();
            connection = new Button();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            pdf1ToolStripMenuItem = new ToolStripMenuItem();
            pdf2ToolStripMenuItem = new ToolStripMenuItem();
            communicationToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(23, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 467);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1138, 76);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 8;
            label6.Text = "LAMP:-";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.SpringGreen;
            textBox4.Location = new Point(1204, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(40, 79);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 6;
            label5.Text = "FILE DIR:-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1101, 16);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 5;
            label3.Text = "年月日:-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1175, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 16);
            label1.Name = "label1";
            label1.Size = new Size(498, 40);
            label1.TabIndex = 3;
            label1.Text = "OPEN PDF FIle in RichTextbox in C#";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(40, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1227, 339);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(23, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 125);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(stop);
            panel4.Controls.Add(addnline);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pdf2);
            panel4.Controls.Add(pdf1);
            panel4.Location = new Point(667, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 104);
            panel4.TabIndex = 1;
            // 
            // stop
            // 
            stop.Location = new Point(433, 29);
            stop.Name = "stop";
            stop.Size = new Size(103, 43);
            stop.TabIndex = 3;
            stop.Text = "STOP";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // addnline
            // 
            addnline.Location = new Point(303, 29);
            addnline.Name = "addnline";
            addnline.Size = new Size(103, 43);
            addnline.TabIndex = 2;
            addnline.Text = "newline";
            addnline.UseVisualStyleBackColor = true;
            addnline.Click += addnline_Click;
            // 
            // button1
            // 
            button1.Location = new Point(315, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pdf2
            // 
            pdf2.Location = new Point(166, 29);
            pdf2.Name = "pdf2";
            pdf2.Size = new Size(131, 43);
            pdf2.TabIndex = 1;
            pdf2.Text = "pdf2";
            pdf2.UseVisualStyleBackColor = true;
            pdf2.Click += pdf2_Click;
            // 
            // pdf1
            // 
            pdf1.Location = new Point(31, 29);
            pdf1.Name = "pdf1";
            pdf1.Size = new Size(129, 43);
            pdf1.TabIndex = 0;
            pdf1.Text = "pdf1";
            pdf1.UseVisualStyleBackColor = true;
            pdf1.Click += pdf1_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(save);
            panel3.Controls.Add(connection);
            panel3.Location = new Point(14, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(640, 107);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(342, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(282, 89);
            panel5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 23);
            label4.Name = "label4";
            label4.Size = new Size(181, 24);
            label4.TabIndex = 6;
            label4.Text = "Read from Arduino";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 3;
            // 
            // save
            // 
            save.Location = new Point(174, 14);
            save.Name = "save";
            save.Size = new Size(146, 63);
            save.TabIndex = 1;
            save.Text = "保存";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // connection
            // 
            connection.Location = new Point(25, 14);
            connection.Name = "connection";
            connection.Size = new Size(143, 63);
            connection.TabIndex = 0;
            connection.Text = "接続";
            connection.UseVisualStyleBackColor = true;
            connection.Click += connection_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutUsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1341, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pdf1ToolStripMenuItem, pdf2ToolStripMenuItem, communicationToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // pdf1ToolStripMenuItem
            // 
            pdf1ToolStripMenuItem.Name = "pdf1ToolStripMenuItem";
            pdf1ToolStripMenuItem.Size = new Size(159, 22);
            pdf1ToolStripMenuItem.Text = "pdf1";
            pdf1ToolStripMenuItem.Click += pdf1ToolStripMenuItem_Click;
            // 
            // pdf2ToolStripMenuItem
            // 
            pdf2ToolStripMenuItem.Name = "pdf2ToolStripMenuItem";
            pdf2ToolStripMenuItem.Size = new Size(159, 22);
            pdf2ToolStripMenuItem.Text = "pdf2";
            pdf2ToolStripMenuItem.Click += pdf2ToolStripMenuItem_Click;
            // 
            // communicationToolStripMenuItem
            // 
            communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            communicationToolStripMenuItem.Size = new Size(159, 22);
            communicationToolStripMenuItem.Text = "communication";
            communicationToolStripMenuItem.Click += communicationToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(67, 20);
            aboutUsToolStripMenuItem.Text = "About us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1341, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private Panel panel4;
        private Button pdf2;
        private Button pdf1;
        private Panel panel3;
        private Button connection;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button addnline;
        private Button save;
        private TextBox textBox2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem pdf1ToolStripMenuItem;
        private ToolStripMenuItem pdf2ToolStripMenuItem;
        private ToolStripMenuItem communicationToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label2;
        private Button stop;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Panel panel5;
        private Label label6;
    }
}
