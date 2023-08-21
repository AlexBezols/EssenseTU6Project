using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;
using XDevkit;
using JRPC_Client;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;

namespace EssenseTU6
{
    public partial class Main : Form
    {
        XRPC jtag = new XRPC();
        IXboxConsole jtag2;
        IW4Offsets offsets = new IW4Offsets();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked && jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC72CE360, Encoding.ASCII.GetBytes("viewmodel_knife_melee_stab" + "\0"));
                jtag2.XNotify("Always Knife Lunge set!");
            }
            else
            {
                jtag2.SetMemory(0xC72CE360, Encoding.ASCII.GetBytes("viewmodel_knife_melee_slice" + "\0"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(jtag2.Connect(out jtag2))
            {
                MessageBox.Show("Connection successful");
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC72CE360, Encoding.ASCII.GetBytes("viewmodel_riotshield_melee" + "\0"));
                jtag2.XNotify("Always Riot Shield Bash Set!");
            }
            else
            {
                jtag2.SetMemory(0xC72CE360, Encoding.ASCII.GetBytes("viewmodel_knife_melee_slice" + "\0"));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.cod-gamer.net//index.php?title=Call_of_Duty_6:Les_titres");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xA51C4707, Encoding.ASCII.GetBytes(textBox2.Text + "\0"));
                jtag2.XNotify("Custom Title Set!");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC8CB7390, Encoding.ASCII.GetBytes("viewmodel_spas12_grip_pullout" + "\0"));
                jtag2.XNotify("AA12 Barrel Roll Set");
            }
            else
            {
                jtag2.SetMemory(0xC8CB7390, Encoding.ASCII.GetBytes("viewmodel_aa12_grip_pullout" + "\0"));
                jtag2.XNotify("AA12 Barrel Roll Reset");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xA50E21E6, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA4723024, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA4723300, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA4724760, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA473B024, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA473B300, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                //jtag2.SetMemory(0xA473C760, Encoding.ASCII.GetBytes(textBox3.Text + "\0"));
                jtag2.XNotify("Title Text Set!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Thank you @shieldlol for helping me with this");
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/GKdzBw6R");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked && jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC7E357A8, Encoding.ASCII.GetBytes("viewmodel_riotshield_sprint_loop" + "\0"));
                jtag2.XNotify("Riotshield Auto Sprint Set");
            }
            else
            {
                jtag2.SetMemory(0xC7E357A8, Encoding.ASCII.GetBytes("viewmodel_riotshield_pullout" + "\0"));
                jtag2.XNotify("Riotshield Auto Sprint Reset");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked && jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC8B0B4B1, new byte[] { 0xB6 });
                jtag2.XNotify("Fake Heartbeat Sensor Set");
            }
            else
            {
                jtag2.SetMemory(0xC8B0B4B1, new byte[] { 0xD6 });
                jtag2.XNotify("Fake Heartbeat Sensor Reset");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if(jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC2E4C810, Encoding.ASCII.GetBytes(textBox4.Text + "\0"));
                MessageBox.Show("Renamed Bot!");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked && jtag2.Connect(out jtag2))
            {
                jtag2.SetMemory(0xC8CB92D4, Encoding.ASCII.GetBytes("viewmodel_knifethrow_hold" + "\0"));
                jtag2.XNotify("AA12 Always Nac Set");
            }
            else
            {
                jtag2.SetMemory(0xC8CB92D4, Encoding.ASCII.GetBytes("viewmodel_aa12_putaway" + "\0"));
                jtag2.XNotify("AA12 Always Nac Reset");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/xelamann");
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.Text == "cheytac_mp" && button2.Visible == false)
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(20);
                //row1
                dataGridView1.Rows[0].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[0].Cells[1].Value = "viewmodel_cheytac_idle";
                //row2
                dataGridView1.Rows[1].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[1].Cells[1].Value = "viewmodel_cheytac_fire";
                //row3
                dataGridView1.Rows[2].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[2].Cells[1].Value = "viewmodel_cheytac_rechamber";
                //row4
                dataGridView1.Rows[3].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[3].Cells[1].Value = "viewmodel_cheytac_reload";
                //row5
                dataGridView1.Rows[4].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[4].Cells[1].Value = "viewmodel_cheytac_reload_empty";
                //row6
                dataGridView1.Rows[5].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[5].Cells[1].Value = "viewmodel_cheytac_pullout";
                //row7
                dataGridView1.Rows[6].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[6].Cells[1].Value = "viewmodel_cheytac_putaway";
                //row8
                dataGridView1.Rows[7].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[7].Cells[1].Value = "viewmodel_cheytac_pullout_quick";
                //row9
                dataGridView1.Rows[8].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[8].Cells[1].Value = "viewmodel_cheytac_putaway_quick";
                //row10
                dataGridView1.Rows[9].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[9].Cells[1].Value = "viewmodel_cheytac_sprint_in";
                //row11
                dataGridView1.Rows[10].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[10].Cells[1].Value = "viewmodel_cheytac_sprint_loop";
                //row12
                dataGridView1.Rows[11].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[11].Cells[1].Value = "viewmodel_cheytac_sprint_out";
                //row13
                dataGridView1.Rows[12].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[12].Cells[1].Value = "viewmodel_cheytac_rechamber_ads";
                //row14
                dataGridView1.Rows[13].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[13].Cells[1].Value = "viewmodel_cheytac_ADS_up";
                //row15
                dataGridView1.Rows[14].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[14].Cells[1].Value = "viewmodel_cheytac_ADS_down";
                //row16
                dataGridView1.Rows[15].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[15].Cells[1].Value = "viewmodel_cheytac_fire_ads";
                //row17
                dataGridView1.Rows[16].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[16].Cells[1].Value = "viewmodel_cheytac_acog_ADS_up";
                //row18
                dataGridView1.Rows[17].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[17].Cells[1].Value = "viewmodel_cheytac_acog_ADS_down";
                //row19
                dataGridView1.Rows[18].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[18].Cells[1].Value = "viewmodel_cheytac_thermal_ADS_up";
                //row20
                dataGridView1.Rows[19].Cells[0].Value = "cheytac_mp";
                dataGridView1.Rows[19].Cells[1].Value = "viewmodel_cheytac_thermal_ADS_down";





                button2.Visible = true;
                button10.Visible = false;
                button3.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[2].Value !=null && jtag2.Connect(out jtag2)) // row1
            {
                jtag2.SetMemory(offsets.CheytacIdle, Encoding.ASCII.GetBytes(dataGridView1.Rows[0].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[0].Cells[1].Value + " Changed To " + dataGridView1.Rows[0].Cells[2].Value);
            }
            if(dataGridView1.Rows[1].Cells[2].Value != null && jtag2.Connect(out jtag2)) //row 2
            {
                jtag2.SetMemory(offsets.CheytacFire, Encoding.ASCII.GetBytes(dataGridView1.Rows[1].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[1].Cells[1].Value + " Changed To " + dataGridView1.Rows[1].Cells[2].Value);
            }
            if(dataGridView1.Rows[2].Cells[2].Value !=null && jtag2.Connect(out jtag2)) // row 3
            {
                jtag2.SetMemory(offsets.CheytacRechamber, Encoding.ASCII.GetBytes(dataGridView1.Rows[2].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[2].Cells[1].Value + " Changed To " + dataGridView1.Rows[2].Cells[2].Value);
            }
            if (dataGridView1.Rows[3].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 4
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_reload, Encoding.ASCII.GetBytes(dataGridView1.Rows[3].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[3].Cells[1].Value + " Changed To " + dataGridView1.Rows[3].Cells[2].Value);
            }
            if (dataGridView1.Rows[4].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 5
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_reload_empty, Encoding.ASCII.GetBytes(dataGridView1.Rows[4].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[4].Cells[1].Value + " Changed To " + dataGridView1.Rows[4].Cells[2].Value);
            }
            if (dataGridView1.Rows[5].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 6
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[5].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[5].Cells[1].Value + " Changed To " + dataGridView1.Rows[5].Cells[2].Value);
            }
            if (dataGridView1.Rows[6].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 7
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_putaway, Encoding.ASCII.GetBytes(dataGridView1.Rows[6].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[6].Cells[1].Value + " Changed To " + dataGridView1.Rows[6].Cells[2].Value);
            }
            if (dataGridView1.Rows[7].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 8
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_pullout_quick, Encoding.ASCII.GetBytes(dataGridView1.Rows[7].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[7].Cells[1].Value + " Changed To " + dataGridView1.Rows[7].Cells[2].Value);
            }
            if (dataGridView1.Rows[8].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 9
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_putaway_quick, Encoding.ASCII.GetBytes(dataGridView1.Rows[8].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[8].Cells[1].Value + " Changed To " + dataGridView1.Rows[8].Cells[2].Value);
            }
            if (dataGridView1.Rows[9].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 10
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_sprint_in, Encoding.ASCII.GetBytes(dataGridView1.Rows[9].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[9].Cells[1].Value + " Changed To " + dataGridView1.Rows[9].Cells[2].Value);
            }
            if (dataGridView1.Rows[10].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 11
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_sprint_loop, Encoding.ASCII.GetBytes(dataGridView1.Rows[10].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[10].Cells[1].Value + " Changed To " + dataGridView1.Rows[10].Cells[2].Value);
            }
            if (dataGridView1.Rows[11].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 12
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_sprint_out, Encoding.ASCII.GetBytes(dataGridView1.Rows[11].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[11].Cells[1].Value + " Changed To " + dataGridView1.Rows[11].Cells[2].Value);
            }
            if (dataGridView1.Rows[12].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_rechamber_ads, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[12].Cells[1].Value + " Changed To " + dataGridView1.Rows[12].Cells[2].Value);
            }
            if (dataGridView1.Rows[13].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 14
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[13].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_ads_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[13].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[13].Cells[1].Value + " Changed To " + dataGridView1.Rows[13].Cells[2].Value);
            }
            if (dataGridView1.Rows[14].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 15
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[14].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_ads_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[14].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[14].Cells[1].Value + " Changed To " + dataGridView1.Rows[14].Cells[2].Value);
            }
            if (dataGridView1.Rows[15].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 16
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_fire_ads, Encoding.ASCII.GetBytes(dataGridView1.Rows[15].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[15].Cells[1].Value + " Changed To " + dataGridView1.Rows[15].Cells[2].Value);
            }
            if (dataGridView1.Rows[16].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 17
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_acog_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[16].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_acog_ads_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[16].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[16].Cells[1].Value + " Changed To " + dataGridView1.Rows[16].Cells[2].Value);
            }
            if (dataGridView1.Rows[17].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 18
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_acog_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[17].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_acog_ads_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[17].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[17].Cells[1].Value + " Changed To " + dataGridView1.Rows[17].Cells[2].Value);
            }
            if (dataGridView1.Rows[18].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 19
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_thermal_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[18].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_thermal_ads_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[18].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[18].Cells[1].Value + " Changed To " + dataGridView1.Rows[18].Cells[2].Value);
            }
            if (dataGridView1.Rows[19].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 20
            {
                jtag2.SetMemory(offsets.viewmodel_cheytac_thermal_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[19].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_cheytac_thermal_ads_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[19].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[19].Cells[1].Value + " Changed To " + dataGridView1.Rows[19].Cells[2].Value);
            }
            else if(!jtag2.Connect(out jtag2))
            {
                MessageBox.Show("Console is not connected");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row1
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_idle, Encoding.ASCII.GetBytes(dataGridView1.Rows[0].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[0].Cells[1].Value + " Changed To " + dataGridView1.Rows[0].Cells[2].Value);
            }
            if (dataGridView1.Rows[1].Cells[2].Value != null && jtag2.Connect(out jtag2)) //row 2
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_fire, Encoding.ASCII.GetBytes(dataGridView1.Rows[1].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[1].Cells[1].Value + " Changed To " + dataGridView1.Rows[1].Cells[2].Value);
            }
            if (dataGridView1.Rows[2].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 3
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_reload, Encoding.ASCII.GetBytes(dataGridView1.Rows[2].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[2].Cells[1].Value + " Changed To " + dataGridView1.Rows[2].Cells[2].Value);
            }
            if (dataGridView1.Rows[3].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 4
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_reload_empty, Encoding.ASCII.GetBytes(dataGridView1.Rows[3].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[3].Cells[1].Value + " Changed To " + dataGridView1.Rows[3].Cells[2].Value);
            }
            if (dataGridView1.Rows[4].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 5
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[4].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[4].Cells[1].Value + " Changed To " + dataGridView1.Rows[4].Cells[2].Value);
            }
            if (dataGridView1.Rows[5].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 6
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_putaway, Encoding.ASCII.GetBytes(dataGridView1.Rows[5].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[5].Cells[1].Value + " Changed To " + dataGridView1.Rows[5].Cells[2].Value);
            }
            if (dataGridView1.Rows[6].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 7
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_pullout_quick, Encoding.ASCII.GetBytes(dataGridView1.Rows[6].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[6].Cells[1].Value + " Changed To " + dataGridView1.Rows[6].Cells[2].Value);
            }
            if (dataGridView1.Rows[7].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 8
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_putaway_quick, Encoding.ASCII.GetBytes(dataGridView1.Rows[7].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[7].Cells[1].Value + " Changed To " + dataGridView1.Rows[7].Cells[2].Value);
            }
            if (dataGridView1.Rows[8].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 9
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_sprint_in, Encoding.ASCII.GetBytes(dataGridView1.Rows[8].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[8].Cells[1].Value + " Changed To " + dataGridView1.Rows[8].Cells[2].Value);
            }
            if (dataGridView1.Rows[9].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 10
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_sprint_loop, Encoding.ASCII.GetBytes(dataGridView1.Rows[9].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[9].Cells[1].Value + " Changed To " + dataGridView1.Rows[9].Cells[2].Value);
            }
            if (dataGridView1.Rows[10].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 11
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_sprint_out, Encoding.ASCII.GetBytes(dataGridView1.Rows[10].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[10].Cells[1].Value + " Changed To " + dataGridView1.Rows[10].Cells[2].Value);
            }
            if (dataGridView1.Rows[11].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 12
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_ads_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[11].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_barrett_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[11].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[11].Cells[1].Value + " Changed To " + dataGridView1.Rows[11].Cells[2].Value);
            }
            if (dataGridView1.Rows[12].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_barrett_ads_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_barrett_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[12].Cells[1].Value + " Changed To " + dataGridView1.Rows[12].Cells[2].Value);
            }
            else if (!jtag2.Connect(out jtag2))
            {
                MessageBox.Show("Console is not connected");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.Text == "cheytac_mp")
            {
                MessageBox.Show("cheytac_mp Loaded! Please click button to the right to load the info into the grid.");
                button1.Visible = true;
                button8.Visible = false;
                button9.Visible = false;
                button11.Visible = false;
            }
            if(comboBox1.Text == "barrett_mp")
            {
                MessageBox.Show("barrett_mp Loaded! Please click button to the right to load the info into the grid.");
                button1.Visible = false;
                button8.Visible = true;
                button9.Visible = false;
                button11.Visible = false;
            }
            if (comboBox1.Text == "m21_mp")
            {
                MessageBox.Show("m21_mp Loaded! Please click button to the right to load the info into the grid.");
                button1.Visible = false;
                button8.Visible = false;
                button9.Visible = true;
                button11.Visible = false;
            }
            if (comboBox1.Text == "wa2000_mp")
            {
                MessageBox.Show("wa2000_mp Loaded! Please click button to the right to load the info into the grid.");
                button1.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button11.Visible = true;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "barrett_mp" && button3.Visible == false)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(12);
                //row1
                dataGridView1.Rows[0].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[0].Cells[1].Value = "viewmodel_barrett_idle";
                //row2
                dataGridView1.Rows[1].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[1].Cells[1].Value = "viewmodel_barrett_fire";
                //row3
                dataGridView1.Rows[2].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[2].Cells[1].Value = "viewmodel_barrett_reload";
                //row4
                dataGridView1.Rows[3].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[3].Cells[1].Value = "viewmodel_barrett_reload_empty";
                //row5
                dataGridView1.Rows[4].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[4].Cells[1].Value = "viewmodel_barrett_pullout";
                //row6
                dataGridView1.Rows[5].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[5].Cells[1].Value = "viewmodel_barrett_putaway";
                //row7
                dataGridView1.Rows[6].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[6].Cells[1].Value = "viewmodel_barrett_pullout_quick";
                //row8
                dataGridView1.Rows[7].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[7].Cells[1].Value = "viewmodel_barrett_putaway_quick";
                //row9
                dataGridView1.Rows[8].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[8].Cells[1].Value = "viewmodel_barrett_sprint_in";
                //row10
                dataGridView1.Rows[9].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[9].Cells[1].Value = "viewmodel_barrett_sprint_loop";
                //row11
                dataGridView1.Rows[10].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[10].Cells[1].Value = "viewmodel_barrett_sprint_out";
                //row12
                dataGridView1.Rows[11].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[11].Cells[1].Value = "viewmodel_barrett_ads_up";
                //row13
                dataGridView1.Rows[12].Cells[0].Value = "barrett_mp";
                dataGridView1.Rows[12].Cells[1].Value = "viewmodel_barrett_ads_down";

                button3.Visible = true;
                button10.Visible = false;
                button2.Visible = false;
                panel2.Visible = false;
                panel5.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;

            }
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "m21_mp" && button10.Visible == false)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(18);
                //row1
                dataGridView1.Rows[0].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[0].Cells[1].Value = "viewmodel_M14ebr_idle";
                //row2
                dataGridView1.Rows[1].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[1].Cells[1].Value = "viewmodel_M14ebr_fire";
                //row3
                dataGridView1.Rows[2].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[2].Cells[1].Value = "viewmodel_M14ebr_fire_last";
                //row4
                dataGridView1.Rows[3].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[3].Cells[1].Value = "viewmodel_M14ebr_reload";
                //row5
                dataGridView1.Rows[4].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[4].Cells[1].Value = "viewmodel_M14ebr_reload_empty";
                //row6
                dataGridView1.Rows[5].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[5].Cells[1].Value = "viewmodel_M14ebr_pullout";
                //row7
                dataGridView1.Rows[6].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[6].Cells[1].Value = "viewmodel_M14ebr_pullout_first";
                //row8
                dataGridView1.Rows[7].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[7].Cells[1].Value = "viewmodel_M14ebr_putaway";
                //row9
                dataGridView1.Rows[8].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[8].Cells[1].Value = "viewmodel_M14ebr_pullout_fast";
                //row10
                dataGridView1.Rows[9].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[9].Cells[1].Value = "viewmodel_M14ebr_sprint_in";
                //row11
                dataGridView1.Rows[10].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[10].Cells[1].Value = "viewmodel_M14ebr_sprint_loop";
                //row12
                dataGridView1.Rows[11].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[11].Cells[1].Value = "viewmodel_M14ebr_sprint_out";
                //row13
                dataGridView1.Rows[12].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[12].Cells[1].Value = "viewmodel_M14ebr_fire_ads";
                //row14
                dataGridView1.Rows[13].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[13].Cells[1].Value = "viewmodel_M14ebr_scope_ADS_up";
                //row15
                dataGridView1.Rows[14].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[14].Cells[1].Value = "viewmodel_M14ebr_scope_ADS_down";
                //row16
                dataGridView1.Rows[15].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[15].Cells[1].Value = "viewmodel_M14ebr_acog_ADS_up";
                //row17
                dataGridView1.Rows[16].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[16].Cells[1].Value = "viewmodel_M14ebr_acog_ADS_down";
                //row18
                dataGridView1.Rows[17].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[17].Cells[1].Value = "viewmodel_M14ebr_thermal_ADS_up";
                //row19
                dataGridView1.Rows[18].Cells[0].Value = "m21_mp";
                dataGridView1.Rows[18].Cells[1].Value = "viewmodel_M14ebr_thermal_ADS_down";

                button10.Visible = true;
                button3.Visible = false;
                button2.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = true;


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row1
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_idle, Encoding.ASCII.GetBytes(dataGridView1.Rows[0].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[0].Cells[1].Value + " Changed To " + dataGridView1.Rows[0].Cells[2].Value);
            }
            if (dataGridView1.Rows[1].Cells[2].Value != null && jtag2.Connect(out jtag2)) //row 2
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_fire, Encoding.ASCII.GetBytes(dataGridView1.Rows[1].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[1].Cells[1].Value + " Changed To " + dataGridView1.Rows[1].Cells[2].Value);
            }
            if (dataGridView1.Rows[2].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 3
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_fire_last, Encoding.ASCII.GetBytes(dataGridView1.Rows[2].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[2].Cells[1].Value + " Changed To " + dataGridView1.Rows[2].Cells[2].Value);
            }
            if (dataGridView1.Rows[3].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 4
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_reload, Encoding.ASCII.GetBytes(dataGridView1.Rows[3].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[3].Cells[1].Value + " Changed To " + dataGridView1.Rows[3].Cells[2].Value);
            }
            if (dataGridView1.Rows[4].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 5
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_reload_empty, Encoding.ASCII.GetBytes(dataGridView1.Rows[4].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[4].Cells[1].Value + " Changed To " + dataGridView1.Rows[4].Cells[2].Value);
            }
            if (dataGridView1.Rows[5].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 6
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[5].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[5].Cells[1].Value + " Changed To " + dataGridView1.Rows[5].Cells[2].Value);
            }
            if (dataGridView1.Rows[6].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 7
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_pullout_first, Encoding.ASCII.GetBytes(dataGridView1.Rows[6].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[6].Cells[1].Value + " Changed To " + dataGridView1.Rows[6].Cells[2].Value);
            }
            if (dataGridView1.Rows[7].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 8
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_putaway, Encoding.ASCII.GetBytes(dataGridView1.Rows[7].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[7].Cells[1].Value + " Changed To " + dataGridView1.Rows[7].Cells[2].Value);
            }
            if (dataGridView1.Rows[8].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 9
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_pullout_fast, Encoding.ASCII.GetBytes(dataGridView1.Rows[8].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[8].Cells[1].Value + " Changed To " + dataGridView1.Rows[8].Cells[2].Value);
            }
            if (dataGridView1.Rows[9].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 10
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_sprint_in, Encoding.ASCII.GetBytes(dataGridView1.Rows[9].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[9].Cells[1].Value + " Changed To " + dataGridView1.Rows[9].Cells[2].Value);
            }
            if (dataGridView1.Rows[10].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 11
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_sprint_loop, Encoding.ASCII.GetBytes(dataGridView1.Rows[10].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[10].Cells[1].Value + " Changed To " + dataGridView1.Rows[10].Cells[2].Value);
            }
            if (dataGridView1.Rows[11].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 12
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_sprint_out, Encoding.ASCII.GetBytes(dataGridView1.Rows[11].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[11].Cells[1].Value + " Changed To " + dataGridView1.Rows[11].Cells[2].Value);
            }
            if (dataGridView1.Rows[12].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_fire_ads, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[12].Cells[1].Value + " Changed To " + dataGridView1.Rows[12].Cells[2].Value);
            }
            if (dataGridView1.Rows[13].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_scope_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[13].Cells[1].Value + " Changed To " + dataGridView1.Rows[13].Cells[2].Value);
            }
            if (dataGridView1.Rows[14].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_scope_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[14].Cells[1].Value + " Changed To " + dataGridView1.Rows[14].Cells[2].Value);
            }
            if (dataGridView1.Rows[15].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_acog_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[15].Cells[1].Value + " Changed To " + dataGridView1.Rows[15].Cells[2].Value);
            }
            if (dataGridView1.Rows[16].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_acog_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[16].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[16].Cells[1].Value + " Changed To " + dataGridView1.Rows[16].Cells[2].Value);
            }
            if (dataGridView1.Rows[17].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_thermal_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[17].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[17].Cells[1].Value + " Changed To " + dataGridView1.Rows[17].Cells[2].Value);
            }
            if (dataGridView1.Rows[18].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_M14ebr_thermal_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[18].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[18].Cells[1].Value + " Changed To " + dataGridView1.Rows[18].Cells[2].Value);
            }
            else if (!jtag2.Connect(out jtag2))
            {
                MessageBox.Show("Console is not connected");
            }
        }

        public bool sprintincheck = false;
        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            
            if(jtag2.Connect(out jtag2) && sprintincheck == false)
            {
                jtag2.SetMemory(offsets.iSprintInTimeCheytac, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                sprintincheck = true;
            }
            else if(sprintincheck == true)
            {
                jtag2.SetMemory(offsets.iSprintInTimeCheytac, new byte[] { 0x01 , 0x2C });
                MessageBox.Show("Reset");
                sprintincheck = false;
            }

        }

        public bool droptimecheck = false;
        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && droptimecheck == false)
            {
                jtag2.SetMemory(offsets.iDropTimeCheytac, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                droptimecheck = true;
            }
            else if (droptimecheck == true)
            {
                jtag2.SetMemory(offsets.iDropTimeCheytac, new byte[] { 0x04 , 0x50});
                MessageBox.Show("Reset");
                droptimecheck = false;
            }
        }

        public bool instantshot = false;
        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && instantshot == false)
            {
                jtag2.SetMemory(offsets.iRaiseTimeCheytac, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                instantshot = true;
            }
            else if (instantshot == true)
            {
                jtag2.SetMemory(offsets.iRaiseTimeCheytac, new byte[] { 0x03 , 0xE8 });
                MessageBox.Show("Reset");
                instantshot = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "wa2000_mp" && button12.Visible == false)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(13);
                //row1
                dataGridView1.Rows[0].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[0].Cells[1].Value = "viewmodel_wa2000_hb_open_idle";
                //row2
                dataGridView1.Rows[1].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[1].Cells[1].Value = "viewmodel_wa2000_hb_open_fire";
                //row3
                dataGridView1.Rows[2].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[2].Cells[1].Value = "viewmodel_wa2000_hb_open_reload";
                //row4
                dataGridView1.Rows[3].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[3].Cells[1].Value = "viewmodel_wa2000_hb_open_reload_empty";
                //row5
                dataGridView1.Rows[4].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[4].Cells[1].Value = "viewmodel_wa2000_hb_open_pullout";
                //row6
                dataGridView1.Rows[5].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[5].Cells[1].Value = "viewmodel_wa2000_hb_open_first_time_pullout";
                //row7
                dataGridView1.Rows[6].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[6].Cells[1].Value = "viewmodel_wa2000_hb_open_putaway";
                //row8
                dataGridView1.Rows[7].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[7].Cells[1].Value = "viewmodel_wa2000_hb_open_quick_pullout";
                //row9
                dataGridView1.Rows[8].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[8].Cells[1].Value = "viewmodel_wa2000_hb_open_quick_putaway";
                //row10
                dataGridView1.Rows[9].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[9].Cells[1].Value = "viewmodel_wa2000_hb_open_sprint_in";
                //row11
                dataGridView1.Rows[10].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[10].Cells[1].Value = "viewmodel_wa2000_hb_open_sprint_loop";
                //row12
                dataGridView1.Rows[11].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[11].Cells[1].Value = "viewmodel_wa2000_hb_open_sprint_out";
                //row13
                dataGridView1.Rows[12].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[12].Cells[1].Value = "viewmodel_wa2000_ads_up";
                //row14
                dataGridView1.Rows[13].Cells[0].Value = "wa2000_mp";
                dataGridView1.Rows[13].Cells[1].Value = "viewmodel_wa2000_ads_down";

                button12.Visible = true;
                button10.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row1
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_idle, Encoding.ASCII.GetBytes(dataGridView1.Rows[0].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[0].Cells[1].Value + " Changed To " + dataGridView1.Rows[0].Cells[2].Value);
            }
            if (dataGridView1.Rows[1].Cells[2].Value != null && jtag2.Connect(out jtag2)) //row 2
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_fire, Encoding.ASCII.GetBytes(dataGridView1.Rows[1].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[1].Cells[1].Value + " Changed To " + dataGridView1.Rows[1].Cells[2].Value);
            }
            if (dataGridView1.Rows[2].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 3
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_reload, Encoding.ASCII.GetBytes(dataGridView1.Rows[2].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[2].Cells[1].Value + " Changed To " + dataGridView1.Rows[2].Cells[2].Value);
            }
            if (dataGridView1.Rows[3].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 4
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_reload_empty, Encoding.ASCII.GetBytes(dataGridView1.Rows[3].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[3].Cells[1].Value + " Changed To " + dataGridView1.Rows[3].Cells[2].Value);
            }
            if (dataGridView1.Rows[4].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 5
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[4].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[4].Cells[1].Value + " Changed To " + dataGridView1.Rows[4].Cells[2].Value);
            }
            if (dataGridView1.Rows[5].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 6
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_first_time_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[5].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[5].Cells[1].Value + " Changed To " + dataGridView1.Rows[5].Cells[2].Value);
            }
            if (dataGridView1.Rows[6].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 7
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_putaway, Encoding.ASCII.GetBytes(dataGridView1.Rows[6].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[6].Cells[1].Value + " Changed To " + dataGridView1.Rows[6].Cells[2].Value);
            }
            if (dataGridView1.Rows[7].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 8
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_quick_pullout, Encoding.ASCII.GetBytes(dataGridView1.Rows[7].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[7].Cells[1].Value + " Changed To " + dataGridView1.Rows[7].Cells[2].Value);
            }
            if (dataGridView1.Rows[8].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 9
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_quick_putaway, Encoding.ASCII.GetBytes(dataGridView1.Rows[8].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[8].Cells[1].Value + " Changed To " + dataGridView1.Rows[8].Cells[2].Value);
            }
            if (dataGridView1.Rows[9].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 10
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_sprint_in, Encoding.ASCII.GetBytes(dataGridView1.Rows[9].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[9].Cells[1].Value + " Changed To " + dataGridView1.Rows[9].Cells[2].Value);
            }
            if (dataGridView1.Rows[10].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 11
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_sprint_loop, Encoding.ASCII.GetBytes(dataGridView1.Rows[10].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[10].Cells[1].Value + " Changed To " + dataGridView1.Rows[10].Cells[2].Value);
            }
            if (dataGridView1.Rows[11].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 12
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_hb_open_sprint_out, Encoding.ASCII.GetBytes(dataGridView1.Rows[11].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[11].Cells[1].Value + " Changed To " + dataGridView1.Rows[11].Cells[2].Value);
            }
            if (dataGridView1.Rows[12].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_ads_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_wa2000_ADS_up, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[12].Cells[1].Value + " Changed To " + dataGridView1.Rows[12].Cells[2].Value);
            }
            if (dataGridView1.Rows[13].Cells[2].Value != null && jtag2.Connect(out jtag2)) // row 13
            {
                jtag2.SetMemory(offsets.viewmodel_wa2000_ads_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.SetMemory(offsets.viewmodel_wa2000_ADS_down, Encoding.ASCII.GetBytes(dataGridView1.Rows[12].Cells[2].Value + "\0"));
                jtag2.XNotify(dataGridView1.Rows[13].Cells[1].Value + " Changed To " + dataGridView1.Rows[13].Cells[2].Value);
            }
            else if (!jtag2.Connect(out jtag2))
            {
                MessageBox.Show("Console is not connected");
            }
        }

        public bool barretadelia = false;
        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && barretadelia == false)
            {
                jtag2.SetMemory(offsets.iRaiseTimeBarrett, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                barretadelia = true;
            }
            else if (barretadelia == true)
            {
                jtag2.SetMemory(offsets.iRaiseTimeBarrett, new byte[] { 0x01 , 0x2C });
                MessageBox.Show("Reset");
                barretadelia = false;
            }
        }

        public bool barrettnac = false;
        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && barrettnac == false)
            {
                jtag2.SetMemory(offsets.iDropTimeBarrett, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                barrettnac = true;
            }
            else if (barrettnac == true)
            {
                jtag2.SetMemory(offsets.iDropTimeBarrett, new byte[] { 0x02 , 0xBB });
                MessageBox.Show("Reset");
                barrettnac = false;
            }
        }

        public bool barrettinstantshot = false;
        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && barrettinstantshot == false)
            {
                jtag2.SetMemory(offsets.iRaiseTimeBarrett, new byte[] { 0x00 , 0x00 });
                MessageBox.Show("Success");
                barrettinstantshot = true;
            }
            else if (barrettinstantshot == true)
            {
                jtag2.SetMemory(offsets.iRaiseTimeBarrett, new byte[] { 0x03, 0xE8 });
                MessageBox.Show("Reset");
                barrettinstantshot = false;
            }
        }

        public bool m21adelia = false;
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && m21adelia == false)
            {
                jtag2.SetMemory(offsets.iSprintInTimeM21, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                m21adelia = true;
            }
            else if (m21adelia == true)
            {
                jtag2.SetMemory(offsets.iSprintInTimeM21, new byte[] { 0x01, 0x2C });
                MessageBox.Show("Reset");
                m21adelia = false;
            }
        }

        public bool m21nac = false;
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && m21nac == false)
            {
                jtag2.SetMemory(offsets.iDropTimeM21, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                m21nac = true;
            }
            else if (m21nac == true)
            {
                jtag2.SetMemory(offsets.iDropTimeM21, new byte[] { 0x02, 0x58 });
                MessageBox.Show("Reset");
                m21nac = false;
            }
        }

        public bool m21instantshot = false;
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && m21instantshot == false)
            {
                jtag2.SetMemory(offsets.iRaiseTimeM21, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                m21instantshot = true;
            }
            else if (m21instantshot == true)
            {
                jtag2.SetMemory(offsets.iRaiseTimeM21, new byte[] { 0x03, 0xB5 });
                MessageBox.Show("Reset");
                m21instantshot = false;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool wa2kadelia = false;
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && wa2kadelia == false)
            {
                jtag2.SetMemory(offsets.iSprintInTimeWA, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                wa2kadelia = true;
            }
            else if (wa2kadelia == true)
            {
                jtag2.SetMemory(offsets.iSprintInTimeWA, new byte[] { 0x01, 0x2C });
                MessageBox.Show("Reset");
                wa2kadelia = false;
            }
        }

        public bool wa2knac = false;
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && wa2knac == false)
            {
                jtag2.SetMemory(offsets.iDropTimeWA, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                wa2knac = true;
            }
            else if (wa2knac == true)
            {
                jtag2.SetMemory(offsets.iDropTimeWA, new byte[] { 0x04, 0xB0 });
                MessageBox.Show("Reset");
                wa2knac = false;
            }
        }

        public bool wa2kinstantshoot = false;
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (jtag2.Connect(out jtag2) && wa2kinstantshoot == false)
            {
                jtag2.SetMemory(offsets.iFirstRaiseTimeWA, new byte[] { 0x00, 0x00 });
                MessageBox.Show("Success");
                wa2kinstantshoot = true;
            }
            else if (wa2kinstantshoot == true)
            {
                jtag2.SetMemory(offsets.iFirstRaiseTimeWA, new byte[] { 0x04, 0xE2 });
                MessageBox.Show("Reset");
                wa2kinstantshoot = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "m4_mp")
            {
                MessageBox.Show("m4_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = true;
            }
            if (comboBox2.Text == "famas_mp")
            {
                MessageBox.Show("famas_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "scar_mp")
            {
                MessageBox.Show("scar_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "tavor_mp")
            {
                MessageBox.Show("tavor_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "fal_mp")
            {
                MessageBox.Show("fal_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "m16_mp")
            {
                MessageBox.Show("m16_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "masada_mp")
            {
                MessageBox.Show("masada_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "fn2000_mp")
            {
                MessageBox.Show("fn2000_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
            if (comboBox2.Text == "ak47_mp")
            {
                MessageBox.Show("ak47_mp Loaded! Please click button to the right to load the info into the grid.");
                M4Button.Visible = false;
            }
        }

        private void M4Button_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "m4_mp" && M4SaveButton.Visible == false)
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(23);
                //row1
                dataGridView2.Rows[0].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[0].Cells[1].Value = "viewmodel_M4_idle";
                //row2
                dataGridView2.Rows[1].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[1].Cells[1].Value = "viewmodel_M4_fire";
                //row3
                dataGridView2.Rows[2].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[2].Cells[1].Value = "viewmodel_M4_reload";
                //row4
                dataGridView2.Rows[3].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[3].Cells[1].Value = "viewmodel_M4_reload_empty";
                //row5
                dataGridView2.Rows[4].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[4].Cells[1].Value = "viewmodel_M4_pullout";
                //row6
                dataGridView2.Rows[5].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[5].Cells[1].Value = "viewmodel_m4_first_time_pullout";
                //row7
                dataGridView2.Rows[6].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[6].Cells[1].Value = "viewmodel_M4_putaway";
                //row8
                dataGridView2.Rows[7].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[7].Cells[1].Value = "viewmodel_M4_quick_pullout";
                //row9
                dataGridView2.Rows[8].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[8].Cells[1].Value = "viewmodel_M4_quick_putaway";
                //row10
                dataGridView2.Rows[9].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[9].Cells[1].Value = "viewmodel_M4_sprint_in";
                //row11
                dataGridView2.Rows[10].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[10].Cells[1].Value = "viewmodel_M4_sprint_loop";
                //row12
                dataGridView2.Rows[11].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[11].Cells[1].Value = "viewmodel_M4_sprint_out";
                //row13
                dataGridView2.Rows[12].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[12].Cells[1].Value = "viewmodel_M4_shotgun_shotty_idle";
                //row14
                dataGridView2.Rows[13].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[13].Cells[1].Value = "viewmodel_M4_shotgun_shotty_fire";
                //row15
                dataGridView2.Rows[14].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[14].Cells[1].Value = "viewmodel_M4_shotgun_shotty_rechamber";
                //row16
                dataGridView2.Rows[15].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[15].Cells[1].Value = "viewmodel_M4_shotgun_shotty_reload_loop";
                //row17
                dataGridView2.Rows[16].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[16].Cells[1].Value = "viewmodel_M4_shotgun_shotty_reload_start";
                //row18
                dataGridView2.Rows[17].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[17].Cells[1].Value = "viewmodel_M4_shotgun_shotty_reload_end";
                //row19
                dataGridView2.Rows[18].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[18].Cells[1].Value = "viewmodel_M4_shotgun_shotty_pullout";
                //row20
                dataGridView2.Rows[19].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[19].Cells[1].Value = "viewmodel_M4_shotgun_shotty_putaway";
                //row21
                dataGridView2.Rows[20].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[20].Cells[1].Value = "viewmodel_M4_shotgun_bullet_2_shotty";
                //row22
                dataGridView2.Rows[21].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[21].Cells[1].Value = "viewmodel_M4_shotgun_shotty_sprint_in";
                //row23
                dataGridView2.Rows[22].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[22].Cells[1].Value = "viewmodel_M4_shotgun_shotty_sprint_loop";
                //row24
                dataGridView2.Rows[23].Cells[0].Value = "m4_mp";
                dataGridView2.Rows[23].Cells[1].Value = "viewmodel_M4_shotgun_shotty_sprint_out";

                M4SaveButton.Visible = true;
                M4Panel.Visible = true;

            }
        }
    }
    
}
