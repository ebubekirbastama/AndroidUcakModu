using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AndroidUcakModu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProcessStartInfo pinfo = new ProcessStartInfo();
        Process proc = new Process();
        private void button1_Click(object sender, EventArgs e)
        {
            changeIP("shell am start -a android.settings.AIRPLANE_MODE_SETTINGS");
            changeIP("shell input keyevent 21 && input keyevent 22 && input keyevent 23");
        }

        void changeIP(string cml)
        {
            pinfo.FileName = Application.StartupPath + "\\adb.exe";
            pinfo.Arguments = cml;
            proc.StartInfo = pinfo;
            proc.Start();
        }
    }
}
