using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;
using XRPCLib;
using JRPC_Client;
using System.Diagnostics.Eventing.Reader;

namespace EssenseTU6
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        XRPC jtag = new XRPC();
        IXboxConsole jtag2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                jtag.Connect();
                if(jtag.activeConnection == true)
                {
                    jtag.Notify(XRPC.XNotiyLogo.FLASHING_XBOX_LOGO, "Connected to Essence TU6");
                    MessageBox.Show("Connected successfully!");
                }
                else
                {
                    MessageBox.Show("Failed! Make sure your RGH is the default console in 360 Neighborhood");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Essence TU6 by Xela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Must be using Essence TU6 patch*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect and Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Username";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Essence TU6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();
            Form1 f1 = new Form1();

            if (textBox1.Text == "admin" && jtag2.Connect(out jtag2))
            {
                    MessageBox.Show("Connected successfully!");
                    m.Show();
                }
                else if (!jtag2.Connect(out jtag2))
                {
                    MessageBox.Show("Failed! Make sure your RGH is the default console in 360 Neighborhood");
                }
            else
            {
                MessageBox.Show("Wrong Username!");
            }
         }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
