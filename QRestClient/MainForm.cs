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
        double maxRAM = 0;
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        SignalGenerator SG;

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            SG = new SignalGenerator();

            this.FormClosing += FormClosingMethod;

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            cpuCounter.NextValue();
            ramCounter.NextValue();
            maxRAM = GetPhysicalMemory();
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

        private double GetPhysicalMemory()
        {
            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);

            double memory = 0;
            foreach (ManagementObject item in searcher.Get())
            {
                memory = double.Parse(item["TotalVisibleMemorySize"].ToString());
            }
            return memory;
        }

        private void FormClosingMethod(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CPU_W_On = fTWorkloadC.Checked;
            Properties.Settings.Default.CPU_T_On = fTTemperatureC.Checked;

            Properties.Settings.Default.GPU_W_On = fTWorkloadG.Checked;
            Properties.Settings.Default.GPU_T_On = fTTemperatureG.Checked;

            Properties.Settings.Default.Mem_W_On = ftWorkloadM.Checked;

            Properties.Settings.Default.Save();

            cpuCounter.Dispose();
            ramCounter.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (fTWorkloadC.Checked)
                fPBWorkloadC.Value = (int)cpuCounter.NextValue();

            if (ftWorkloadM.Checked)
            {
                var usedRam = (maxRAM - (ramCounter.NextValue() * 1000)) * 100 / maxRAM;
                fPBWorkloadM.Value = Convert.ToInt32(usedRam - 2); //Some broken calc.. most likely maxRAM
            }
            if (fTWorkloadC.Checked || ftWorkloadM.Checked)
                SG.DrawPercentBarAsync("CPU Performance", new Vector2(2, 1), "#FF0000", "SET_COLOR", (int)fPBWorkloadC.Value / 10);
                //SG.sendSignalHorizontalRowAsync("CPU Performance", new Vector2(2, 1), "#FF0000", "SET_COLOR", (int)fPBWorkloadC.Value/10);
        }

        private void FClose_Click(object sender, EventArgs e)
        {

            cpuCounter.Dispose();
            ramCounter.Dispose();
            this.Close();
        }
    }
}
