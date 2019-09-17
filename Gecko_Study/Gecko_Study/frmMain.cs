using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace Gecko_Study
{
    public partial class frmMain : Form
    {

        public frmMain()
        {

            InitializeComponent();
            NameProcessBrowser = new List<string>();
            NameProcessGame = new List<string>();
            key = new List<string>();

        }

        int Numrd;
        List<String> key;
        Process[] processList;
        List<string> Namelist;
     
        List<string> NameProcessBrowser;
        List<string> NameProcessGame;
    
        private void frmMain_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            loadBrowser();
            loadGame();
            key.Add("jkGgJnNaIuq2hnm!>Sjksddjskaqsw7sxcm].addsssdfergfsaja?>,aas.asjdhh");
            key.Add("jkGgJnNaIuq2hndm!>Sjdksdjskaqfw7sxcm],asssdfsdfdfgssaaja?>,aas,asjdh");
            key.Add("jkGgJnNaIsuq2hnm!>Sjksdjskaqw7sxxscm],asasssdfdfsdfaja?>,aaas.adsjdh");
            key.Add("jkGgJnNaIuq2hnnm!>Sjksdjskaqw7sxdcm].asacswdfdfvberja?>,aas.asjdhssah");
            key.Add("jkGgJnNaIuq2hnm!>Sjksddjskaqsw74sxcm].addssdfergfsaja?>,aas.asjdhh");
            key.Add("jkGgJnNaIuq2hndm!>Sjdksdjskesaqfw7sxcm],assdfsdfdfgssaaja?>,aas,asjdh");
            key.Add("jkGgJnNaIsuq2hnm!>Sjksdjskaqww7sxxscm],aesasdfdfsdfaja?>,aaas.adsjdh");
            key.Add("jkGgJnNaIuq2hnnm!>Sjksddsjskaqw7sxcm].asteacsdfdfvberja?>,aas.asjdhssah");
            key.Add("jkGgJnNaIuq2hndm!>Sjksddjsskaqsw7sxcmr].adtdssdfergfsaja?>,aas.asjdhh");
            key.Add("jkGgJnNaIuq2hndmd!>Sjdksdjskaqfw7srxcm],assdfsdfdfgssaaja?>,aas,asjdh");
            key.Add("jkGgJnNaIsuq2hnsm!>Sjksdjskaqw7sxxrsecm],asasdfdfsdfaja?>,aaas.adsjdh");
            key.Add("jkGgJnNaIuq2hndnm!>Sjksddjskaqwr7sxcm].asacsdfdfvberja?>,aas.asjdhssah");
            key.Add("jkGgJnNaIuq2hnsms!>sSjksddjskaqsw7stxcm].addssdfergfsaja?>,aas.asjdhh");
            key.Add("jkGgJnNaIuq2hvndm!>Sjdksdjskaqfw7sxtcm],assdfsdfdfgssaaja?>,aas,asjdh");
            key.Add("jkGgJnNaIsuqc2hsnm!>Sjksdjskaqw7sxtxscm],asasdfdfsdfaja?>,aaas.adsjdh");
            key.Add("jkGgJnNaIuhq2hnnm!>Sjksdjskaqw7sxcmt].asacsdfdfvberja?>,aas.asjdhssah");
            key.Add("jkGgJnNaIuq2hnm!>Sjkhfsddjskaqsw7sxcm].addsstdfergfsaja?>,aas.asjdhh");
            key.Add("jkGgJnNaIuq2hndm!>Sjfdksdjskaqfw7sxcm],assdfsdfdfgssaaja?>,aas,asjdh");
            key.Add("jkGgJnNaIsuq2hnm!>Sjfksdjskaqw7sxxscm],asasdfdfsdfaja?>,aaas.adsjdh");
            key.Add("jkGgJnNaIuq2hnnm!>Sjfksdjskaqw7sxcm].asacsdfgdfvberja?>,aas.asjdhssah");

            Random rd = new Random();
            Numrd = rd.Next(0, 21);
             lbkey.Text = key[Numrd];
            //   timer2.Enabled = true;
        }

        private void btnBGCD_Click(object sender, EventArgs e)
        {
            frmBGCD f = new frmBGCD("https://www.youtube.com/channel/UCxzJqh3ovAqYFUHi8W8mMQw/videos");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBGCD f = new frmBGCD("https://www.youtube.com/watch?v=DHvSSTFRcn4&list=PLlSyE2TKmdTTYtYsAdhwO63yZqND5KDp6&index=9");
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnStackOverFlow_Click(object sender, EventArgs e)
        {
            
            frmBGCD f = new frmBGCD("https://stackoverflow.com/");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnWebcoban_Click(object sender, EventArgs e)
        {
            frmBGCD f = new frmBGCD("http://webcoban.vn");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnClassRoom_Click(object sender, EventArgs e)
        {
            frmBGCD f = new frmBGCD("https://classroom.google.com/u/2/c/NzAzODAwNjg5N1pa");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            frmBGCD f = new frmBGCD("https://gmail.com");
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void killProcess(string name)
        {
            try
            {
                if (!name.Equals(""))
                {
                    foreach (var process in Process.GetProcessesByName(name))
                    {
                        process.Kill();

                    }
                }
            }
            catch
            { }
        }

        private void killTaskManager()
        {
            killProcess("taskmgr");
        }


        private void loadBrowser()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath+"\\Databrowser.ini"))
                {
                    string line;

                    // doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        NameProcessBrowser.Add(line);
                    }
                }
            }
            catch (Exception e)
            { }
        }

        private void loadGame()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "Datagame.ini"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        NameProcessGame.Add(line);
                    }
                }
            }
            catch (Exception e)
            { }
    
        }

        bool isWordIn(string word, string WORD)
        {
            WORD = WORD.ToLower();
            word = word.ToLower();
            for (int i = 0; i <= WORD.Length - word.Length; i++)
                if (WORD.Substring(i, word.Length) == word)
                    return true;
            return false;
        }

        private void killOpenBrowser()
        {
            for (int j = 0; j < NameProcessBrowser.Count; j++)
                for (int i = 0; i < Namelist.Count; i++)
                {
                    if (isWordIn(NameProcessBrowser[j], Namelist[i]))
                    {
                        killProcess(Namelist[i]);

                        break;
                    }
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Namelist = new List<string>();
            processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                Namelist.Add(process.ProcessName);
            }
            timer2.Enabled = true;
        }


        private void killOpenGame()
        {
            for (int j = 0; j < NameProcessGame.Count; j++)
                for (int i = 0; i < Namelist.Count; i++)
                {
                    if (isWordIn(NameProcessGame[j], Namelist[i]))
                    {
                        killProcess(Namelist[i]);
                      
                        break;
                    }
                }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmMain.ModifierKeys == Keys.Alt || frmMain.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;

            }


            if (!check())
            {
                e.Cancel = true;
                textBox1.Focus();
            }
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            killOpenBrowser();
            killOpenGame();
            killTaskManager();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        bool check()
        {
            if (textBox1.Text.Trim().Equals(lbkey.Text))
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (check())
                this.Close();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
        
        }
    }
}
