using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaverLoggerPing
{
    public partial class Form1 : Form
    {
        string scorciatoiaDir = "";
        bool cliccato = false;
        string hostdapingare;
        public Form1()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void btn_start_ping_Click(object sender, EventArgs e)
        {
            if(txt_dir.Text == "desktop" || txt_dir.Text == "Desktop"){
                scorciatoiaDir = "desktop";
            }
            if (!Directory.Exists(txt_dir.Text))
            {
                MessageBox.Show("The Directory for saving the log file doesn't exist", "Dir Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();
                var result = ping.Send(txt_host.Text);
                //Console.WriteLine("[OK] ping to '" + txt_host.Text + "' in " + result.RoundtripTime + "ms");
            }
            catch{
                MessageBox.Show("The DNS or IP of the host you entered is NOT valid: \nIt's not possible to communicate with the Host", "Host Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hostdapingare = txt_host.Text;
            cliccato = false;
            lbl_status.ForeColor = System.Drawing.Color.Green;
            lbl_status.Text = "PINGING";

            btn_start_ping.Enabled = false;
            btn_save_dir.Enabled = false;
            btn_save_host.Enabled = false;
            btn_reset.Enabled = false;
            numeric_time.Enabled = false;
            checkbox_write.Enabled = false;
            checkbox_write_failure.Enabled = false;
            Thread thread = new Thread(Pinging);
            thread.Start();
        }
        
        private void Pinging()
        {
            DateTime now = DateTime.Now;
            string log = @"\log (" + now.Day + "." + now.Month + "." + now.Year + " - " + now.Hour + "." + now.Minute + ").txt";
            string nomeFile = txt_dir.Text + log;
            bool rowOfError = false;

            while (cliccato == false)
            { 
            StreamWriter sw = new StreamWriter(nomeFile, true);
            if (cliccato == true)
                {
                    Console.WriteLine("salvo e chiudo");
                    sw.Close();
                    return;
                }
                try
                {
                    var ping = new System.Net.NetworkInformation.Ping();
                    var result = ping.Send(hostdapingare);

                    if (rowOfError == true)
                    {
                        rowOfError = false;
                        Action safeWrite = delegate { txt_log.AppendText("\r\n"); };
                        txt_log.Invoke(safeWrite);
                        sw.WriteLine(" ");
                    }

                    if (checkbox_view_failure.Checked == false)
                    {
                        if (txt_log.InvokeRequired)
                        {
                            Action safeWrite = delegate { txt_log.AppendText("[OK " + DateTime.Now.ToString("HH:mm:ss") + "] ping to '" + txt_host.Text + "' in " + result.RoundtripTime + "ms \r\n"); };
                            txt_log.Invoke(safeWrite);
                        }
                        if (checkbox_write.Checked == true)
                            if (checkbox_write_failure.Checked == false)
                            {
                                sw.WriteLine("[OK Data: " + DateTime.Now.ToString("dd:MM:yyyy") + " Time: " + DateTime.Now.ToString("HH:mm:ss") + "] ping to '" + txt_host.Text + "' in " + result.RoundtripTime + "ms");
                                sw.Close();
                            }
                                
                        
                        Thread.Sleep((int)numeric_time.Value * 1000);
                    }                    
                }
                catch
                {
                    rowOfError = true;
                    if (txt_log.InvokeRequired)
                    {
                        Action safeWrite = delegate { txt_log.AppendText("[ERROR " + DateTime.Now.ToString("HH:mm:ss") + "] could not PING! \r\n"); };
                        txt_log.Invoke(safeWrite);
                    }
                    if (checkbox_write.Checked == true)
                    {
                        sw.WriteLine("[ERROR Data: " + DateTime.Now.ToString("dd:MM:yyyy") + " Time: " + DateTime.Now.ToString("HH:mm:ss") + "] could not PING!");
                        sw.Close();
                    }
                        
                    Thread.Sleep((int)numeric_time.Value * 1000);
                }
                sw.Close();
            }
        }

        private void btn_save_dir_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName; //Console.WriteLine(userName);
            string fileDir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing\config.txt";
            string line = File.ReadLines(fileDir).First();
            string[] configs = line.Split('|');

            StreamWriter sw = new StreamWriter(fileDir);
            sw.WriteLine(txt_dir.Text + "|" + configs[1]);
            sw.Close();
        }

        private void btn_save_host_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName; //Console.WriteLine(userName);
            string dir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing";
            string fileDir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing\config.txt";
            string line = File.ReadLines(fileDir).First();
            string[] configs = line.Split('|');

            StreamWriter sw = new StreamWriter(fileDir);
            sw.WriteLine(configs[0] + "|" + txt_host.Text);
            sw.Close();
        }

        private void LoadConfig(){
            string userName = Environment.UserName; //Console.WriteLine(userName);
            string dir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing";
            string fileDir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing\config.txt";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                StreamWriter sw = new StreamWriter(fileDir);
                string tmp = @"C:\Users\" + userName + @"\Desktop";
                sw.WriteLine(tmp + "|google.com");
                sw.Close();
            } else
            {
                try
                {
                    StreamReader sr = new StreamReader(fileDir);
                    string readingLine = sr.ReadLine();
                    sr.Close();
                    if(readingLine == ""){
                        StreamWriter sw = new StreamWriter(fileDir);
                        string tmp = @"C:\Users\" + userName + @"\Desktop";
                        sw.WriteLine(tmp + "|google.com");
                        sw.Close();
                    }
                }
                catch{ }
            }

            try{
                string line = File.ReadLines(fileDir).First();
                string[] configs = line.Split('|');

                txt_dir.Text = configs[0];
                txt_host.Text = configs[1];
            }catch{
                txt_dir.Text = "Error getting the config";
                txt_host.Text = "Error getting the config";
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try{
                DialogResult result = MessageBox.Show("Are you sure?", "Reset config file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes){
                    string userName = Environment.UserName; //Console.WriteLine(userName);
                    string fileDir = @"C:\Users\" + userName + @"\Documents\FaverLoggerPing\config.txt";
                    StreamWriter sw = new StreamWriter(fileDir);
                    string tmp = @"C:\Users\" + userName + @"\Desktop";
                    sw.WriteLine(tmp + "|google.com");
                    sw.Close();
                    txt_dir.Text = @"C:\Users\Tizfaver\Desktop";
                    txt_host.Text = @"google.com";
                } else{ }
            }catch{
                MessageBox.Show("Impossible to reset the config file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_stop_pinging_Click(object sender, EventArgs e)
        {
            lbl_status.ForeColor = System.Drawing.Color.Red;
            lbl_status.Text = "NOT PINGING";
            cliccato = true;
            btn_start_ping.Enabled = true;
            btn_save_dir.Enabled = true;
            btn_save_host.Enabled = true;
            btn_reset.Enabled = true;
            numeric_time.Enabled = true;
            checkbox_write.Enabled = true;
            checkbox_write_failure.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try{
                txt_log.Text = "";
            }catch{ }
        }

        private void checkbox_write_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_write.Checked == true)
                btn_stop_pinging.Text = "Stop and Save";
            else
                btn_stop_pinging.Text = "Stop";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliccato = true;
        }
    }
}
