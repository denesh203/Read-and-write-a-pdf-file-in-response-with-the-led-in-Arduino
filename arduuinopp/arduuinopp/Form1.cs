using System.IO.Ports;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
namespace arduuinopp
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();

        }
        private System.Windows.Forms.Timer timer;
       // private int clickCount = 0;
        //private const int maxClicks = 10;
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();

            serialPort.PortName = "COM46";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            



        }
        
        
        private void connection_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    MessageBox.Show("sucessfully connected");
                    int delayMilliseconds = 50;
                    Thread.Sleep(delayMilliseconds);

                    timer = new System.Windows.Forms.Timer();
                    timer.Interval = 50; // Set the interval to 100 milliseconds
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
                else
                {
                    serialPort.Close();
                    MessageBox.Show("serial port close");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Trigger the click event of Button A
            button1.PerformClick();
            //UpdateRichTextBox("");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            string data = serialPort.ReadExisting();
            
            // Perform actions based on the received data
            if (data.Contains("Switch 2 is ON!"))
            {
                // Click Button A
                pdf2.PerformClick();
                textBox3.Text = "Switch 2 is ON!";
            }
            else if (data.Contains("Switch 1 is ON!"))
            {
                // Click Button B
                pdf1.PerformClick();
                textBox3.Text = "Switch 1 is ON!";
            }
            else
            {
                richTextBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
           
        }
        private void pdf1_Click(object sender, EventArgs e)
        {
            string pdfFilePath = @"D:\RunningProject\Arduinoproject\test.pdf";
            textBox1.Text = "D:\\RunningProject\\Arduinoproject\\";
            textBox2.Text = "test1.pdf";
            try
            {
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(pdfFilePath);
                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    // Read page
                    sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                richTextBox1.Text = sb.ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            addnline.PerformClick();

        }
        //private System.Windows.Forms.Timer timer;
        private void pdf2_Click(object sender, EventArgs e)
        {
            string pdfFilePath = @"D:\RunningProject\Arduinoproject\test2.pdf";
            textBox1.Text = "D:\\RunningProject\\Arduinoproject\\";
            textBox2.Text = "test2.pdf";
            try
            {
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(pdfFilePath);
                StringBuilder sb = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    // Read page
                    sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                richTextBox1.Text = sb.ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //int delayMilliseconds = 2000;
            //Thread.Sleep(delayMilliseconds);

            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = 2000; // Set the interval to 100 milliseconds
            //timer.Tick += Timer_Tick;
            //timer.Start();
            //// Trigger the click event of Button A
            addnline.PerformClick();

        }
       
        private void addnline_Click(object sender, EventArgs e)
        {
            string newText;
          if (textBox2.Text=="test2.pdf")
            {
                newText = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ":- " + "Switch 2 is ON!";
                textBox4.BackColor = Color.Red;

            }
            else
            {
                newText = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ":- " + "Switch 1 is ON!";
                textBox4.BackColor = Color.Red;
            }
            
            // Add the new line to the RichTextBox
            richTextBox1.AppendText(newText + Environment.NewLine);
        }

        private void save_Click(object sender, EventArgs e)
        {
           
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }
        private void pdf1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf1.PerformClick();
        }

        private void pdf2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf2.PerformClick();
        }

        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is the Demo apps designed by Humantact");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy/MM/dd");
            textBox4.BackColor = Color.Green;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Green;
           // if (timer != null)
            //{
            //    timer.Stop();
            //    timer.Dispose();
            //}
        }
        //private void UpdateRichTextBox(string newText)
        //{
        //    //richTextBox1.AppendText(newText + Environment.NewLine);

        //    // Scroll to the caret to show the latest text
        //    richTextBox1.SelectionStart = richTextBox1.Text.Length;
        //    richTextBox1.ScrollToCaret();
        //}

        //private System.Windows.Forms.Timer timer1;

       

       


    }
}
