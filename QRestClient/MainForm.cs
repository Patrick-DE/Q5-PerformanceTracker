using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTracker
{
    public partial class MainForm : Form
    {
        SignalGenerator SG;

        //Test VAR for TASKS
        bool firstTime = true;

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            SG = new SignalGenerator(false);

            this.FormClosing += FormClosingMethod;

            timer1.Start();
        }

        private void LoadSettings()
        {
            fTWorkloadC.Checked = Properties.Settings.Default.CPU_W_On;
            fTTemperatureC.Checked = Properties.Settings.Default.CPU_T_On;

            fTWorkloadG.Checked = Properties.Settings.Default.GPU_W_On;
            fTTemperatureG.Checked = Properties.Settings.Default.GPU_T_On;

            ftWorkloadM.Checked = Properties.Settings.Default.Mem_W_On;
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            Color c = Color.White;
            ColorDialog clrDialog = new ColorDialog();
            if (clrDialog.ShowDialog() == DialogResult.OK)
                c = clrDialog.Color;
            string hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (fTWorkloadC.Checked)
            {
                //fPBWorkloadC.Value = (int)cpuCounter.NextValue();
                fPBWorkloadC.Value = Convert.ToInt32(new ManagementObjectSearcher("SELECT PercentProcessorTime FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name='_Total'").Get().Cast<ManagementObject>().First().Properties["PercentProcessorTime"].Value.ToString());
            }

            if (ftWorkloadM.Checked)
            {
                int memFree = Convert.ToInt32(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().Cast<ManagementObject>().First().Properties["FreePhysicalMemory"].Value.ToString());
                int memTotal = Convert.ToInt32(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().Cast<ManagementObject>().First().Properties["TotalVisibleMemorySize"].Value.ToString());
                fPBWorkloadM.Value = (memTotal - memFree) * 100 / memTotal;
            }
            if ((fTWorkloadC.Checked || ftWorkloadM.Checked) && firstTime) {
                ///Send signal mapped on (default) 10 keys
                SG.DrawPercentBarAsync("CPU Performance", new Vector2(2, 1), "#FF0000", "SET_COLOR", (int)fPBWorkloadC.Value / 10);
                //SG.SendSignal("Crash Test", new Vector2(2, 1), "#FF0000", "SET_COLOR");
                //firstTime = false;
            }
            //SG.sendSignalHorizontalRowAsync("CPU Performance", new Vector2(2, 1), "#FF0000", "SET_COLOR", (int)fPBWorkloadC.Value/10);
        }
        private void FormClosingMethod(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CPU_W_On = fTWorkloadC.Checked;
            Properties.Settings.Default.CPU_T_On = fTTemperatureC.Checked;

            Properties.Settings.Default.GPU_W_On = fTWorkloadG.Checked;
            Properties.Settings.Default.GPU_T_On = fTTemperatureG.Checked;

            Properties.Settings.Default.Mem_W_On = ftWorkloadM.Checked;

            Properties.Settings.Default.Save();
        }

        private void FClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
