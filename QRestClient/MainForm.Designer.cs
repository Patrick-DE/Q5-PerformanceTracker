namespace QTracker
{
    partial class MainForm
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
            this.Skin = new FlatUI.FormSkin();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tpCPU = new System.Windows.Forms.TabPage();
            this.fLbMessageT = new FlatUI.FlatLabel();
            this.fLbNameT = new FlatUI.FlatLabel();
            this.fTTemperatureC = new FlatUI.FlatToggle();
            this.fLbTemperatureC = new FlatUI.FlatLabel();
            this.fPBTemperatureC = new FlatUI.FlatProgressBar();
            this.fTbNameT = new FlatUI.FlatTextBox();
            this.fTbMessageT = new FlatUI.FlatTextBox();
            this.fBtnColorT = new FlatUI.FlatButton();
            this.fCbEffectT = new FlatUI.FlatComboBox();
            this.fTbSpeedT = new FlatUI.FlatTextBox();
            this.fLbEffectT = new FlatUI.FlatLabel();
            this.fLbSpeedT = new FlatUI.FlatLabel();
            this.fLbMessageC = new FlatUI.FlatLabel();
            this.fLbNameC = new FlatUI.FlatLabel();
            this.fTWorkloadC = new FlatUI.FlatToggle();
            this.fLbWorkloadC = new FlatUI.FlatLabel();
            this.fPBWorkloadC = new FlatUI.FlatProgressBar();
            this.fTbNameC = new FlatUI.FlatTextBox();
            this.fTbMessageC = new FlatUI.FlatTextBox();
            this.fBtnColorC = new FlatUI.FlatButton();
            this.fCbEffectC = new FlatUI.FlatComboBox();
            this.fTbSpeedC = new FlatUI.FlatTextBox();
            this.fLbEffectC = new FlatUI.FlatLabel();
            this.fLbSpeedC = new FlatUI.FlatLabel();
            this.tpGPU = new System.Windows.Forms.TabPage();
            this.fLbMessage2 = new FlatUI.FlatLabel();
            this.fLbNameG2 = new FlatUI.FlatLabel();
            this.fTTemperatureG = new FlatUI.FlatToggle();
            this.fLbTemperatureG = new FlatUI.FlatLabel();
            this.fPBTemperatureG = new FlatUI.FlatProgressBar();
            this.fTbNameG2 = new FlatUI.FlatTextBox();
            this.fTbMessageG2 = new FlatUI.FlatTextBox();
            this.fBtnColorG2 = new FlatUI.FlatButton();
            this.fCbEffectG2 = new FlatUI.FlatComboBox();
            this.fTbSpeedG2 = new FlatUI.FlatTextBox();
            this.fLbEffectG2 = new FlatUI.FlatLabel();
            this.fLbSpeedG2 = new FlatUI.FlatLabel();
            this.fLbMessageG = new FlatUI.FlatLabel();
            this.fLbNameG = new FlatUI.FlatLabel();
            this.fTWorkloadG = new FlatUI.FlatToggle();
            this.fLbWorkloadG = new FlatUI.FlatLabel();
            this.fPBWorkloadG = new FlatUI.FlatProgressBar();
            this.fTbNameG = new FlatUI.FlatTextBox();
            this.fTbMessageG = new FlatUI.FlatTextBox();
            this.fBtnColorG = new FlatUI.FlatButton();
            this.fCbEffectG = new FlatUI.FlatComboBox();
            this.fTbSpeedG = new FlatUI.FlatTextBox();
            this.fLbEffectG = new FlatUI.FlatLabel();
            this.fLbSpeedG = new FlatUI.FlatLabel();
            this.tpMemory = new System.Windows.Forms.TabPage();
            this.fLbMessageM = new FlatUI.FlatLabel();
            this.fLbNameM = new FlatUI.FlatLabel();
            this.ftWorkloadM = new FlatUI.FlatToggle();
            this.fLbWorkloadM = new FlatUI.FlatLabel();
            this.fPBWorkloadM = new FlatUI.FlatProgressBar();
            this.fTbNameM = new FlatUI.FlatTextBox();
            this.fTbMessageM = new FlatUI.FlatTextBox();
            this.fBtnColorM = new FlatUI.FlatButton();
            this.fCbEffectM = new FlatUI.FlatComboBox();
            this.fTbSpeedM = new FlatUI.FlatTextBox();
            this.fLbEffectM = new FlatUI.FlatLabel();
            this.fLbSpeedM = new FlatUI.FlatLabel();
            this.fStatusBar = new FlatUI.FlatStatusBar();
            this.fClose = new FlatUI.FlatClose();
            this.fMin = new FlatUI.FlatMini();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Skin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tpCPU.SuspendLayout();
            this.tpGPU.SuspendLayout();
            this.tpMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Skin
            // 
            this.Skin.BackColor = System.Drawing.Color.White;
            this.Skin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Skin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Skin.Controls.Add(this.flatTabControl1);
            this.Skin.Controls.Add(this.fStatusBar);
            this.Skin.Controls.Add(this.fClose);
            this.Skin.Controls.Add(this.fMin);
            this.Skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Skin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Skin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Skin.HeaderMaximize = false;
            this.Skin.Location = new System.Drawing.Point(0, 0);
            this.Skin.Name = "Skin";
            this.Skin.Size = new System.Drawing.Size(708, 450);
            this.Skin.TabIndex = 0;
            this.Skin.Text = "QTracker";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tpCPU);
            this.flatTabControl1.Controls.Add(this.tpGPU);
            this.flatTabControl1.Controls.Add(this.tpMemory);
            this.flatTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 36);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(708, 391);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 15;
            // 
            // tpCPU
            // 
            this.tpCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpCPU.Controls.Add(this.fLbMessageT);
            this.tpCPU.Controls.Add(this.fLbNameT);
            this.tpCPU.Controls.Add(this.fTTemperatureC);
            this.tpCPU.Controls.Add(this.fLbTemperatureC);
            this.tpCPU.Controls.Add(this.fPBTemperatureC);
            this.tpCPU.Controls.Add(this.fTbNameT);
            this.tpCPU.Controls.Add(this.fTbMessageT);
            this.tpCPU.Controls.Add(this.fBtnColorT);
            this.tpCPU.Controls.Add(this.fCbEffectT);
            this.tpCPU.Controls.Add(this.fTbSpeedT);
            this.tpCPU.Controls.Add(this.fLbEffectT);
            this.tpCPU.Controls.Add(this.fLbSpeedT);
            this.tpCPU.Controls.Add(this.fLbMessageC);
            this.tpCPU.Controls.Add(this.fLbNameC);
            this.tpCPU.Controls.Add(this.fTWorkloadC);
            this.tpCPU.Controls.Add(this.fLbWorkloadC);
            this.tpCPU.Controls.Add(this.fPBWorkloadC);
            this.tpCPU.Controls.Add(this.fTbNameC);
            this.tpCPU.Controls.Add(this.fTbMessageC);
            this.tpCPU.Controls.Add(this.fBtnColorC);
            this.tpCPU.Controls.Add(this.fCbEffectC);
            this.tpCPU.Controls.Add(this.fTbSpeedC);
            this.tpCPU.Controls.Add(this.fLbEffectC);
            this.tpCPU.Controls.Add(this.fLbSpeedC);
            this.tpCPU.Location = new System.Drawing.Point(4, 44);
            this.tpCPU.Name = "tpCPU";
            this.tpCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tpCPU.Size = new System.Drawing.Size(700, 343);
            this.tpCPU.TabIndex = 0;
            this.tpCPU.Text = "CPU";
            // 
            // fLbMessageT
            // 
            this.fLbMessageT.AutoSize = true;
            this.fLbMessageT.BackColor = System.Drawing.Color.Transparent;
            this.fLbMessageT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbMessageT.ForeColor = System.Drawing.Color.White;
            this.fLbMessageT.Location = new System.Drawing.Point(399, 262);
            this.fLbMessageT.Name = "fLbMessageT";
            this.fLbMessageT.Size = new System.Drawing.Size(95, 30);
            this.fLbMessageT.TabIndex = 30;
            this.fLbMessageT.Text = "Message";
            // 
            // fLbNameT
            // 
            this.fLbNameT.AutoSize = true;
            this.fLbNameT.BackColor = System.Drawing.Color.Transparent;
            this.fLbNameT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbNameT.ForeColor = System.Drawing.Color.White;
            this.fLbNameT.Location = new System.Drawing.Point(401, 222);
            this.fLbNameT.Name = "fLbNameT";
            this.fLbNameT.Size = new System.Drawing.Size(69, 30);
            this.fLbNameT.TabIndex = 29;
            this.fLbNameT.Text = "Name";
            // 
            // fTTemperatureC
            // 
            this.fTTemperatureC.BackColor = System.Drawing.Color.Transparent;
            this.fTTemperatureC.Checked = false;
            this.fTTemperatureC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fTTemperatureC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fTTemperatureC.Location = new System.Drawing.Point(406, 10);
            this.fTTemperatureC.Name = "fTTemperatureC";
            this.fTTemperatureC.Options = FlatUI.FlatToggle._Options.Style1;
            this.fTTemperatureC.Size = new System.Drawing.Size(76, 33);
            this.fTTemperatureC.TabIndex = 28;
            this.fTTemperatureC.Text = "fTWorkload";
            // 
            // fLbTemperatureC
            // 
            this.fLbTemperatureC.AutoSize = true;
            this.fLbTemperatureC.BackColor = System.Drawing.Color.Transparent;
            this.fLbTemperatureC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbTemperatureC.ForeColor = System.Drawing.Color.White;
            this.fLbTemperatureC.Location = new System.Drawing.Point(488, 10);
            this.fLbTemperatureC.Name = "fLbTemperatureC";
            this.fLbTemperatureC.Size = new System.Drawing.Size(129, 30);
            this.fLbTemperatureC.TabIndex = 27;
            this.fLbTemperatureC.Text = "Temperature";
            // 
            // fPBTemperatureC
            // 
            this.fPBTemperatureC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.fPBTemperatureC.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.fPBTemperatureC.Location = new System.Drawing.Point(406, 49);
            this.fPBTemperatureC.Maximum = 100;
            this.fPBTemperatureC.Name = "fPBTemperatureC";
            this.fPBTemperatureC.Pattern = true;
            this.fPBTemperatureC.PercentSign = false;
            this.fPBTemperatureC.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fPBTemperatureC.ShowBalloon = true;
            this.fPBTemperatureC.Size = new System.Drawing.Size(278, 42);
            this.fPBTemperatureC.TabIndex = 19;
            this.fPBTemperatureC.Value = 0;
            // 
            // fTbNameT
            // 
            this.fTbNameT.BackColor = System.Drawing.Color.Transparent;
            this.fTbNameT.FocusOnHover = false;
            this.fTbNameT.Location = new System.Drawing.Point(509, 222);
            this.fTbNameT.MaxLength = 50;
            this.fTbNameT.Multiline = false;
            this.fTbNameT.Name = "fTbNameT";
            this.fTbNameT.ReadOnly = false;
            this.fTbNameT.Size = new System.Drawing.Size(175, 29);
            this.fTbNameT.TabIndex = 26;
            this.fTbNameT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbNameT.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbNameT.UseSystemPasswordChar = false;
            // 
            // fTbMessageT
            // 
            this.fTbMessageT.BackColor = System.Drawing.Color.Transparent;
            this.fTbMessageT.FocusOnHover = false;
            this.fTbMessageT.Location = new System.Drawing.Point(509, 262);
            this.fTbMessageT.MaxLength = 50;
            this.fTbMessageT.Multiline = false;
            this.fTbMessageT.Name = "fTbMessageT";
            this.fTbMessageT.ReadOnly = false;
            this.fTbMessageT.Size = new System.Drawing.Size(175, 29);
            this.fTbMessageT.TabIndex = 25;
            this.fTbMessageT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbMessageT.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbMessageT.UseSystemPasswordChar = false;
            // 
            // fBtnColorT
            // 
            this.fBtnColorT.BackColor = System.Drawing.Color.Transparent;
            this.fBtnColorT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fBtnColorT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBtnColorT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fBtnColorT.Location = new System.Drawing.Point(484, 300);
            this.fBtnColorT.Name = "fBtnColorT";
            this.fBtnColorT.Rounded = false;
            this.fBtnColorT.Size = new System.Drawing.Size(106, 32);
            this.fBtnColorT.TabIndex = 24;
            this.fBtnColorT.Text = "Color";
            this.fBtnColorT.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // fCbEffectT
            // 
            this.fCbEffectT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fCbEffectT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fCbEffectT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fCbEffectT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fCbEffectT.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fCbEffectT.ForeColor = System.Drawing.Color.White;
            this.fCbEffectT.FormattingEnabled = true;
            this.fCbEffectT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fCbEffectT.ItemHeight = 18;
            this.fCbEffectT.Items.AddRange(new object[] {
            "None",
            "Color",
            "Blink",
            "Breathe",
            "Color Cycle"});
            this.fCbEffectT.Location = new System.Drawing.Point(509, 146);
            this.fCbEffectT.Name = "fCbEffectT";
            this.fCbEffectT.Size = new System.Drawing.Size(175, 24);
            this.fCbEffectT.TabIndex = 20;
            // 
            // fTbSpeedT
            // 
            this.fTbSpeedT.BackColor = System.Drawing.Color.Transparent;
            this.fTbSpeedT.FocusOnHover = false;
            this.fTbSpeedT.Location = new System.Drawing.Point(509, 181);
            this.fTbSpeedT.MaxLength = 3;
            this.fTbSpeedT.Multiline = false;
            this.fTbSpeedT.Name = "fTbSpeedT";
            this.fTbSpeedT.ReadOnly = false;
            this.fTbSpeedT.Size = new System.Drawing.Size(175, 29);
            this.fTbSpeedT.TabIndex = 23;
            this.fTbSpeedT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbSpeedT.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbSpeedT.UseSystemPasswordChar = false;
            // 
            // fLbEffectT
            // 
            this.fLbEffectT.AutoSize = true;
            this.fLbEffectT.BackColor = System.Drawing.Color.Transparent;
            this.fLbEffectT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbEffectT.ForeColor = System.Drawing.Color.White;
            this.fLbEffectT.Location = new System.Drawing.Point(401, 140);
            this.fLbEffectT.Name = "fLbEffectT";
            this.fLbEffectT.Size = new System.Drawing.Size(66, 30);
            this.fLbEffectT.TabIndex = 21;
            this.fLbEffectT.Text = "Effect";
            // 
            // fLbSpeedT
            // 
            this.fLbSpeedT.AutoSize = true;
            this.fLbSpeedT.BackColor = System.Drawing.Color.Transparent;
            this.fLbSpeedT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbSpeedT.ForeColor = System.Drawing.Color.White;
            this.fLbSpeedT.Location = new System.Drawing.Point(401, 180);
            this.fLbSpeedT.Name = "fLbSpeedT";
            this.fLbSpeedT.Size = new System.Drawing.Size(70, 30);
            this.fLbSpeedT.TabIndex = 22;
            this.fLbSpeedT.Text = "Speed";
            // 
            // fLbMessageC
            // 
            this.fLbMessageC.AutoSize = true;
            this.fLbMessageC.BackColor = System.Drawing.Color.Transparent;
            this.fLbMessageC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbMessageC.ForeColor = System.Drawing.Color.White;
            this.fLbMessageC.Location = new System.Drawing.Point(13, 262);
            this.fLbMessageC.Name = "fLbMessageC";
            this.fLbMessageC.Size = new System.Drawing.Size(95, 30);
            this.fLbMessageC.TabIndex = 18;
            this.fLbMessageC.Text = "Message";
            // 
            // fLbNameC
            // 
            this.fLbNameC.AutoSize = true;
            this.fLbNameC.BackColor = System.Drawing.Color.Transparent;
            this.fLbNameC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbNameC.ForeColor = System.Drawing.Color.White;
            this.fLbNameC.Location = new System.Drawing.Point(15, 222);
            this.fLbNameC.Name = "fLbNameC";
            this.fLbNameC.Size = new System.Drawing.Size(69, 30);
            this.fLbNameC.TabIndex = 17;
            this.fLbNameC.Text = "Name";
            // 
            // fTWorkloadC
            // 
            this.fTWorkloadC.BackColor = System.Drawing.Color.Transparent;
            this.fTWorkloadC.Checked = false;
            this.fTWorkloadC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fTWorkloadC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fTWorkloadC.Location = new System.Drawing.Point(20, 10);
            this.fTWorkloadC.Name = "fTWorkloadC";
            this.fTWorkloadC.Options = FlatUI.FlatToggle._Options.Style1;
            this.fTWorkloadC.Size = new System.Drawing.Size(76, 33);
            this.fTWorkloadC.TabIndex = 16;
            // 
            // fLbWorkloadC
            // 
            this.fLbWorkloadC.AutoSize = true;
            this.fLbWorkloadC.BackColor = System.Drawing.Color.Transparent;
            this.fLbWorkloadC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbWorkloadC.ForeColor = System.Drawing.Color.White;
            this.fLbWorkloadC.Location = new System.Drawing.Point(102, 10);
            this.fLbWorkloadC.Name = "fLbWorkloadC";
            this.fLbWorkloadC.Size = new System.Drawing.Size(101, 30);
            this.fLbWorkloadC.TabIndex = 15;
            this.fLbWorkloadC.Text = "Workload";
            // 
            // fPBWorkloadC
            // 
            this.fPBWorkloadC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.fPBWorkloadC.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.fPBWorkloadC.Location = new System.Drawing.Point(20, 49);
            this.fPBWorkloadC.Maximum = 100;
            this.fPBWorkloadC.Name = "fPBWorkloadC";
            this.fPBWorkloadC.Pattern = true;
            this.fPBWorkloadC.PercentSign = false;
            this.fPBWorkloadC.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fPBWorkloadC.ShowBalloon = true;
            this.fPBWorkloadC.Size = new System.Drawing.Size(278, 42);
            this.fPBWorkloadC.TabIndex = 4;
            this.fPBWorkloadC.Value = 0;
            // 
            // fTbNameC
            // 
            this.fTbNameC.BackColor = System.Drawing.Color.Transparent;
            this.fTbNameC.FocusOnHover = false;
            this.fTbNameC.Location = new System.Drawing.Point(123, 222);
            this.fTbNameC.MaxLength = 50;
            this.fTbNameC.Multiline = false;
            this.fTbNameC.Name = "fTbNameC";
            this.fTbNameC.ReadOnly = false;
            this.fTbNameC.Size = new System.Drawing.Size(175, 29);
            this.fTbNameC.TabIndex = 14;
            this.fTbNameC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbNameC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbNameC.UseSystemPasswordChar = false;
            // 
            // fTbMessageC
            // 
            this.fTbMessageC.BackColor = System.Drawing.Color.Transparent;
            this.fTbMessageC.FocusOnHover = false;
            this.fTbMessageC.Location = new System.Drawing.Point(123, 262);
            this.fTbMessageC.MaxLength = 50;
            this.fTbMessageC.Multiline = false;
            this.fTbMessageC.Name = "fTbMessageC";
            this.fTbMessageC.ReadOnly = false;
            this.fTbMessageC.Size = new System.Drawing.Size(175, 29);
            this.fTbMessageC.TabIndex = 13;
            this.fTbMessageC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbMessageC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbMessageC.UseSystemPasswordChar = false;
            // 
            // fBtnColorC
            // 
            this.fBtnColorC.BackColor = System.Drawing.Color.Transparent;
            this.fBtnColorC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fBtnColorC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBtnColorC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fBtnColorC.Location = new System.Drawing.Point(98, 300);
            this.fBtnColorC.Name = "fBtnColorC";
            this.fBtnColorC.Rounded = false;
            this.fBtnColorC.Size = new System.Drawing.Size(106, 32);
            this.fBtnColorC.TabIndex = 12;
            this.fBtnColorC.Text = "Color";
            this.fBtnColorC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.fBtnColorC.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // fCbEffectC
            // 
            this.fCbEffectC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fCbEffectC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fCbEffectC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fCbEffectC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fCbEffectC.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fCbEffectC.ForeColor = System.Drawing.Color.White;
            this.fCbEffectC.FormattingEnabled = true;
            this.fCbEffectC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fCbEffectC.ItemHeight = 18;
            this.fCbEffectC.Items.AddRange(new object[] {
            "None",
            "Color",
            "Blink",
            "Breathe",
            "Color Cycle"});
            this.fCbEffectC.Location = new System.Drawing.Point(123, 146);
            this.fCbEffectC.Name = "fCbEffectC";
            this.fCbEffectC.Size = new System.Drawing.Size(175, 24);
            this.fCbEffectC.TabIndex = 7;
            // 
            // fTbSpeedC
            // 
            this.fTbSpeedC.BackColor = System.Drawing.Color.Transparent;
            this.fTbSpeedC.FocusOnHover = false;
            this.fTbSpeedC.Location = new System.Drawing.Point(123, 181);
            this.fTbSpeedC.MaxLength = 3;
            this.fTbSpeedC.Multiline = false;
            this.fTbSpeedC.Name = "fTbSpeedC";
            this.fTbSpeedC.ReadOnly = false;
            this.fTbSpeedC.Size = new System.Drawing.Size(175, 29);
            this.fTbSpeedC.TabIndex = 10;
            this.fTbSpeedC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbSpeedC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbSpeedC.UseSystemPasswordChar = false;
            // 
            // fLbEffectC
            // 
            this.fLbEffectC.AutoSize = true;
            this.fLbEffectC.BackColor = System.Drawing.Color.Transparent;
            this.fLbEffectC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbEffectC.ForeColor = System.Drawing.Color.White;
            this.fLbEffectC.Location = new System.Drawing.Point(15, 140);
            this.fLbEffectC.Name = "fLbEffectC";
            this.fLbEffectC.Size = new System.Drawing.Size(66, 30);
            this.fLbEffectC.TabIndex = 8;
            this.fLbEffectC.Text = "Effect";
            // 
            // fLbSpeedC
            // 
            this.fLbSpeedC.AutoSize = true;
            this.fLbSpeedC.BackColor = System.Drawing.Color.Transparent;
            this.fLbSpeedC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbSpeedC.ForeColor = System.Drawing.Color.White;
            this.fLbSpeedC.Location = new System.Drawing.Point(15, 180);
            this.fLbSpeedC.Name = "fLbSpeedC";
            this.fLbSpeedC.Size = new System.Drawing.Size(70, 30);
            this.fLbSpeedC.TabIndex = 9;
            this.fLbSpeedC.Text = "Speed";
            // 
            // tpGPU
            // 
            this.tpGPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpGPU.Controls.Add(this.fLbMessage2);
            this.tpGPU.Controls.Add(this.fLbNameG2);
            this.tpGPU.Controls.Add(this.fTTemperatureG);
            this.tpGPU.Controls.Add(this.fLbTemperatureG);
            this.tpGPU.Controls.Add(this.fPBTemperatureG);
            this.tpGPU.Controls.Add(this.fTbNameG2);
            this.tpGPU.Controls.Add(this.fTbMessageG2);
            this.tpGPU.Controls.Add(this.fBtnColorG2);
            this.tpGPU.Controls.Add(this.fCbEffectG2);
            this.tpGPU.Controls.Add(this.fTbSpeedG2);
            this.tpGPU.Controls.Add(this.fLbEffectG2);
            this.tpGPU.Controls.Add(this.fLbSpeedG2);
            this.tpGPU.Controls.Add(this.fLbMessageG);
            this.tpGPU.Controls.Add(this.fLbNameG);
            this.tpGPU.Controls.Add(this.fTWorkloadG);
            this.tpGPU.Controls.Add(this.fLbWorkloadG);
            this.tpGPU.Controls.Add(this.fPBWorkloadG);
            this.tpGPU.Controls.Add(this.fTbNameG);
            this.tpGPU.Controls.Add(this.fTbMessageG);
            this.tpGPU.Controls.Add(this.fBtnColorG);
            this.tpGPU.Controls.Add(this.fCbEffectG);
            this.tpGPU.Controls.Add(this.fTbSpeedG);
            this.tpGPU.Controls.Add(this.fLbEffectG);
            this.tpGPU.Controls.Add(this.fLbSpeedG);
            this.tpGPU.Location = new System.Drawing.Point(4, 44);
            this.tpGPU.Name = "tpGPU";
            this.tpGPU.Padding = new System.Windows.Forms.Padding(3);
            this.tpGPU.Size = new System.Drawing.Size(700, 343);
            this.tpGPU.TabIndex = 2;
            this.tpGPU.Text = "GPU";
            // 
            // fLbMessage2
            // 
            this.fLbMessage2.AutoSize = true;
            this.fLbMessage2.BackColor = System.Drawing.Color.Transparent;
            this.fLbMessage2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbMessage2.ForeColor = System.Drawing.Color.White;
            this.fLbMessage2.Location = new System.Drawing.Point(399, 262);
            this.fLbMessage2.Name = "fLbMessage2";
            this.fLbMessage2.Size = new System.Drawing.Size(95, 30);
            this.fLbMessage2.TabIndex = 54;
            this.fLbMessage2.Text = "Message";
            // 
            // fLbNameG2
            // 
            this.fLbNameG2.AutoSize = true;
            this.fLbNameG2.BackColor = System.Drawing.Color.Transparent;
            this.fLbNameG2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbNameG2.ForeColor = System.Drawing.Color.White;
            this.fLbNameG2.Location = new System.Drawing.Point(401, 222);
            this.fLbNameG2.Name = "fLbNameG2";
            this.fLbNameG2.Size = new System.Drawing.Size(69, 30);
            this.fLbNameG2.TabIndex = 53;
            this.fLbNameG2.Text = "Name";
            // 
            // fTTemperatureG
            // 
            this.fTTemperatureG.BackColor = System.Drawing.Color.Transparent;
            this.fTTemperatureG.Checked = false;
            this.fTTemperatureG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fTTemperatureG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fTTemperatureG.Location = new System.Drawing.Point(406, 10);
            this.fTTemperatureG.Name = "fTTemperatureG";
            this.fTTemperatureG.Options = FlatUI.FlatToggle._Options.Style1;
            this.fTTemperatureG.Size = new System.Drawing.Size(76, 33);
            this.fTTemperatureG.TabIndex = 52;
            this.fTTemperatureG.Text = "fTWorkload";
            // 
            // fLbTemperatureG
            // 
            this.fLbTemperatureG.AutoSize = true;
            this.fLbTemperatureG.BackColor = System.Drawing.Color.Transparent;
            this.fLbTemperatureG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbTemperatureG.ForeColor = System.Drawing.Color.White;
            this.fLbTemperatureG.Location = new System.Drawing.Point(488, 10);
            this.fLbTemperatureG.Name = "fLbTemperatureG";
            this.fLbTemperatureG.Size = new System.Drawing.Size(129, 30);
            this.fLbTemperatureG.TabIndex = 51;
            this.fLbTemperatureG.Text = "Temperature";
            // 
            // fPBTemperatureG
            // 
            this.fPBTemperatureG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.fPBTemperatureG.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.fPBTemperatureG.Location = new System.Drawing.Point(406, 49);
            this.fPBTemperatureG.Maximum = 100;
            this.fPBTemperatureG.Name = "fPBTemperatureG";
            this.fPBTemperatureG.Pattern = true;
            this.fPBTemperatureG.PercentSign = false;
            this.fPBTemperatureG.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fPBTemperatureG.ShowBalloon = true;
            this.fPBTemperatureG.Size = new System.Drawing.Size(278, 42);
            this.fPBTemperatureG.TabIndex = 43;
            this.fPBTemperatureG.Value = 0;
            // 
            // fTbNameG2
            // 
            this.fTbNameG2.BackColor = System.Drawing.Color.Transparent;
            this.fTbNameG2.FocusOnHover = false;
            this.fTbNameG2.Location = new System.Drawing.Point(509, 222);
            this.fTbNameG2.MaxLength = 50;
            this.fTbNameG2.Multiline = false;
            this.fTbNameG2.Name = "fTbNameG2";
            this.fTbNameG2.ReadOnly = false;
            this.fTbNameG2.Size = new System.Drawing.Size(175, 29);
            this.fTbNameG2.TabIndex = 50;
            this.fTbNameG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbNameG2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbNameG2.UseSystemPasswordChar = false;
            // 
            // fTbMessageG2
            // 
            this.fTbMessageG2.BackColor = System.Drawing.Color.Transparent;
            this.fTbMessageG2.FocusOnHover = false;
            this.fTbMessageG2.Location = new System.Drawing.Point(509, 262);
            this.fTbMessageG2.MaxLength = 50;
            this.fTbMessageG2.Multiline = false;
            this.fTbMessageG2.Name = "fTbMessageG2";
            this.fTbMessageG2.ReadOnly = false;
            this.fTbMessageG2.Size = new System.Drawing.Size(175, 29);
            this.fTbMessageG2.TabIndex = 49;
            this.fTbMessageG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbMessageG2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbMessageG2.UseSystemPasswordChar = false;
            // 
            // fBtnColorG2
            // 
            this.fBtnColorG2.BackColor = System.Drawing.Color.Transparent;
            this.fBtnColorG2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fBtnColorG2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBtnColorG2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fBtnColorG2.Location = new System.Drawing.Point(484, 300);
            this.fBtnColorG2.Name = "fBtnColorG2";
            this.fBtnColorG2.Rounded = false;
            this.fBtnColorG2.Size = new System.Drawing.Size(106, 32);
            this.fBtnColorG2.TabIndex = 48;
            this.fBtnColorG2.Text = "Color";
            this.fBtnColorG2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // fCbEffectG2
            // 
            this.fCbEffectG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fCbEffectG2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fCbEffectG2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fCbEffectG2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fCbEffectG2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fCbEffectG2.ForeColor = System.Drawing.Color.White;
            this.fCbEffectG2.FormattingEnabled = true;
            this.fCbEffectG2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fCbEffectG2.ItemHeight = 18;
            this.fCbEffectG2.Items.AddRange(new object[] {
            "None",
            "Color",
            "Blink",
            "Breathe",
            "Color Cycle"});
            this.fCbEffectG2.Location = new System.Drawing.Point(509, 146);
            this.fCbEffectG2.Name = "fCbEffectG2";
            this.fCbEffectG2.Size = new System.Drawing.Size(175, 24);
            this.fCbEffectG2.TabIndex = 44;
            // 
            // fTbSpeedG2
            // 
            this.fTbSpeedG2.BackColor = System.Drawing.Color.Transparent;
            this.fTbSpeedG2.FocusOnHover = false;
            this.fTbSpeedG2.Location = new System.Drawing.Point(509, 181);
            this.fTbSpeedG2.MaxLength = 3;
            this.fTbSpeedG2.Multiline = false;
            this.fTbSpeedG2.Name = "fTbSpeedG2";
            this.fTbSpeedG2.ReadOnly = false;
            this.fTbSpeedG2.Size = new System.Drawing.Size(175, 29);
            this.fTbSpeedG2.TabIndex = 47;
            this.fTbSpeedG2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbSpeedG2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbSpeedG2.UseSystemPasswordChar = false;
            // 
            // fLbEffectG2
            // 
            this.fLbEffectG2.AutoSize = true;
            this.fLbEffectG2.BackColor = System.Drawing.Color.Transparent;
            this.fLbEffectG2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbEffectG2.ForeColor = System.Drawing.Color.White;
            this.fLbEffectG2.Location = new System.Drawing.Point(401, 140);
            this.fLbEffectG2.Name = "fLbEffectG2";
            this.fLbEffectG2.Size = new System.Drawing.Size(66, 30);
            this.fLbEffectG2.TabIndex = 45;
            this.fLbEffectG2.Text = "Effect";
            // 
            // fLbSpeedG2
            // 
            this.fLbSpeedG2.AutoSize = true;
            this.fLbSpeedG2.BackColor = System.Drawing.Color.Transparent;
            this.fLbSpeedG2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbSpeedG2.ForeColor = System.Drawing.Color.White;
            this.fLbSpeedG2.Location = new System.Drawing.Point(401, 180);
            this.fLbSpeedG2.Name = "fLbSpeedG2";
            this.fLbSpeedG2.Size = new System.Drawing.Size(70, 30);
            this.fLbSpeedG2.TabIndex = 46;
            this.fLbSpeedG2.Text = "Speed";
            // 
            // fLbMessageG
            // 
            this.fLbMessageG.AutoSize = true;
            this.fLbMessageG.BackColor = System.Drawing.Color.Transparent;
            this.fLbMessageG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbMessageG.ForeColor = System.Drawing.Color.White;
            this.fLbMessageG.Location = new System.Drawing.Point(13, 262);
            this.fLbMessageG.Name = "fLbMessageG";
            this.fLbMessageG.Size = new System.Drawing.Size(95, 30);
            this.fLbMessageG.TabIndex = 42;
            this.fLbMessageG.Text = "Message";
            // 
            // fLbNameG
            // 
            this.fLbNameG.AutoSize = true;
            this.fLbNameG.BackColor = System.Drawing.Color.Transparent;
            this.fLbNameG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbNameG.ForeColor = System.Drawing.Color.White;
            this.fLbNameG.Location = new System.Drawing.Point(15, 222);
            this.fLbNameG.Name = "fLbNameG";
            this.fLbNameG.Size = new System.Drawing.Size(69, 30);
            this.fLbNameG.TabIndex = 41;
            this.fLbNameG.Text = "Name";
            // 
            // fTWorkloadG
            // 
            this.fTWorkloadG.BackColor = System.Drawing.Color.Transparent;
            this.fTWorkloadG.Checked = false;
            this.fTWorkloadG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fTWorkloadG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fTWorkloadG.Location = new System.Drawing.Point(20, 10);
            this.fTWorkloadG.Name = "fTWorkloadG";
            this.fTWorkloadG.Options = FlatUI.FlatToggle._Options.Style1;
            this.fTWorkloadG.Size = new System.Drawing.Size(76, 33);
            this.fTWorkloadG.TabIndex = 40;
            // 
            // fLbWorkloadG
            // 
            this.fLbWorkloadG.AutoSize = true;
            this.fLbWorkloadG.BackColor = System.Drawing.Color.Transparent;
            this.fLbWorkloadG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbWorkloadG.ForeColor = System.Drawing.Color.White;
            this.fLbWorkloadG.Location = new System.Drawing.Point(102, 10);
            this.fLbWorkloadG.Name = "fLbWorkloadG";
            this.fLbWorkloadG.Size = new System.Drawing.Size(101, 30);
            this.fLbWorkloadG.TabIndex = 39;
            this.fLbWorkloadG.Text = "Workload";
            // 
            // fPBWorkloadG
            // 
            this.fPBWorkloadG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.fPBWorkloadG.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.fPBWorkloadG.Location = new System.Drawing.Point(20, 49);
            this.fPBWorkloadG.Maximum = 100;
            this.fPBWorkloadG.Name = "fPBWorkloadG";
            this.fPBWorkloadG.Pattern = true;
            this.fPBWorkloadG.PercentSign = false;
            this.fPBWorkloadG.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fPBWorkloadG.ShowBalloon = true;
            this.fPBWorkloadG.Size = new System.Drawing.Size(278, 42);
            this.fPBWorkloadG.TabIndex = 31;
            this.fPBWorkloadG.Value = 0;
            // 
            // fTbNameG
            // 
            this.fTbNameG.BackColor = System.Drawing.Color.Transparent;
            this.fTbNameG.FocusOnHover = false;
            this.fTbNameG.Location = new System.Drawing.Point(123, 222);
            this.fTbNameG.MaxLength = 50;
            this.fTbNameG.Multiline = false;
            this.fTbNameG.Name = "fTbNameG";
            this.fTbNameG.ReadOnly = false;
            this.fTbNameG.Size = new System.Drawing.Size(175, 29);
            this.fTbNameG.TabIndex = 38;
            this.fTbNameG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbNameG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbNameG.UseSystemPasswordChar = false;
            // 
            // fTbMessageG
            // 
            this.fTbMessageG.BackColor = System.Drawing.Color.Transparent;
            this.fTbMessageG.FocusOnHover = false;
            this.fTbMessageG.Location = new System.Drawing.Point(123, 262);
            this.fTbMessageG.MaxLength = 50;
            this.fTbMessageG.Multiline = false;
            this.fTbMessageG.Name = "fTbMessageG";
            this.fTbMessageG.ReadOnly = false;
            this.fTbMessageG.Size = new System.Drawing.Size(175, 29);
            this.fTbMessageG.TabIndex = 37;
            this.fTbMessageG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbMessageG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbMessageG.UseSystemPasswordChar = false;
            // 
            // fBtnColorG
            // 
            this.fBtnColorG.BackColor = System.Drawing.Color.Transparent;
            this.fBtnColorG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fBtnColorG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBtnColorG.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fBtnColorG.Location = new System.Drawing.Point(98, 300);
            this.fBtnColorG.Name = "fBtnColorG";
            this.fBtnColorG.Rounded = false;
            this.fBtnColorG.Size = new System.Drawing.Size(106, 32);
            this.fBtnColorG.TabIndex = 36;
            this.fBtnColorG.Text = "Color";
            this.fBtnColorG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // fCbEffectG
            // 
            this.fCbEffectG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fCbEffectG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fCbEffectG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fCbEffectG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fCbEffectG.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fCbEffectG.ForeColor = System.Drawing.Color.White;
            this.fCbEffectG.FormattingEnabled = true;
            this.fCbEffectG.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fCbEffectG.ItemHeight = 18;
            this.fCbEffectG.Items.AddRange(new object[] {
            "None",
            "Color",
            "Blink",
            "Breathe",
            "Color Cycle"});
            this.fCbEffectG.Location = new System.Drawing.Point(123, 146);
            this.fCbEffectG.Name = "fCbEffectG";
            this.fCbEffectG.Size = new System.Drawing.Size(175, 24);
            this.fCbEffectG.TabIndex = 32;
            // 
            // fTbSpeedG
            // 
            this.fTbSpeedG.BackColor = System.Drawing.Color.Transparent;
            this.fTbSpeedG.FocusOnHover = false;
            this.fTbSpeedG.Location = new System.Drawing.Point(123, 181);
            this.fTbSpeedG.MaxLength = 3;
            this.fTbSpeedG.Multiline = false;
            this.fTbSpeedG.Name = "fTbSpeedG";
            this.fTbSpeedG.ReadOnly = false;
            this.fTbSpeedG.Size = new System.Drawing.Size(175, 29);
            this.fTbSpeedG.TabIndex = 35;
            this.fTbSpeedG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbSpeedG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbSpeedG.UseSystemPasswordChar = false;
            // 
            // fLbEffectG
            // 
            this.fLbEffectG.AutoSize = true;
            this.fLbEffectG.BackColor = System.Drawing.Color.Transparent;
            this.fLbEffectG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbEffectG.ForeColor = System.Drawing.Color.White;
            this.fLbEffectG.Location = new System.Drawing.Point(15, 140);
            this.fLbEffectG.Name = "fLbEffectG";
            this.fLbEffectG.Size = new System.Drawing.Size(66, 30);
            this.fLbEffectG.TabIndex = 33;
            this.fLbEffectG.Text = "Effect";
            // 
            // fLbSpeedG
            // 
            this.fLbSpeedG.AutoSize = true;
            this.fLbSpeedG.BackColor = System.Drawing.Color.Transparent;
            this.fLbSpeedG.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbSpeedG.ForeColor = System.Drawing.Color.White;
            this.fLbSpeedG.Location = new System.Drawing.Point(15, 180);
            this.fLbSpeedG.Name = "fLbSpeedG";
            this.fLbSpeedG.Size = new System.Drawing.Size(70, 30);
            this.fLbSpeedG.TabIndex = 34;
            this.fLbSpeedG.Text = "Speed";
            // 
            // tpMemory
            // 
            this.tpMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpMemory.Controls.Add(this.fLbMessageM);
            this.tpMemory.Controls.Add(this.fLbNameM);
            this.tpMemory.Controls.Add(this.ftWorkloadM);
            this.tpMemory.Controls.Add(this.fLbWorkloadM);
            this.tpMemory.Controls.Add(this.fPBWorkloadM);
            this.tpMemory.Controls.Add(this.fTbNameM);
            this.tpMemory.Controls.Add(this.fTbMessageM);
            this.tpMemory.Controls.Add(this.fBtnColorM);
            this.tpMemory.Controls.Add(this.fCbEffectM);
            this.tpMemory.Controls.Add(this.fTbSpeedM);
            this.tpMemory.Controls.Add(this.fLbEffectM);
            this.tpMemory.Controls.Add(this.fLbSpeedM);
            this.tpMemory.Location = new System.Drawing.Point(4, 44);
            this.tpMemory.Name = "tpMemory";
            this.tpMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemory.Size = new System.Drawing.Size(700, 343);
            this.tpMemory.TabIndex = 1;
            this.tpMemory.Text = "Memory";
            // 
            // fLbMessageM
            // 
            this.fLbMessageM.AutoSize = true;
            this.fLbMessageM.BackColor = System.Drawing.Color.Transparent;
            this.fLbMessageM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbMessageM.ForeColor = System.Drawing.Color.White;
            this.fLbMessageM.Location = new System.Drawing.Point(200, 262);
            this.fLbMessageM.Name = "fLbMessageM";
            this.fLbMessageM.Size = new System.Drawing.Size(95, 30);
            this.fLbMessageM.TabIndex = 42;
            this.fLbMessageM.Text = "Message";
            // 
            // fLbNameM
            // 
            this.fLbNameM.AutoSize = true;
            this.fLbNameM.BackColor = System.Drawing.Color.Transparent;
            this.fLbNameM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbNameM.ForeColor = System.Drawing.Color.White;
            this.fLbNameM.Location = new System.Drawing.Point(202, 222);
            this.fLbNameM.Name = "fLbNameM";
            this.fLbNameM.Size = new System.Drawing.Size(69, 30);
            this.fLbNameM.TabIndex = 41;
            this.fLbNameM.Text = "Name";
            // 
            // ftWorkloadM
            // 
            this.ftWorkloadM.BackColor = System.Drawing.Color.Transparent;
            this.ftWorkloadM.Checked = false;
            this.ftWorkloadM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ftWorkloadM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ftWorkloadM.Location = new System.Drawing.Point(207, 10);
            this.ftWorkloadM.Name = "ftWorkloadM";
            this.ftWorkloadM.Options = FlatUI.FlatToggle._Options.Style1;
            this.ftWorkloadM.Size = new System.Drawing.Size(76, 33);
            this.ftWorkloadM.TabIndex = 40;
            // 
            // fLbWorkloadM
            // 
            this.fLbWorkloadM.AutoSize = true;
            this.fLbWorkloadM.BackColor = System.Drawing.Color.Transparent;
            this.fLbWorkloadM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbWorkloadM.ForeColor = System.Drawing.Color.White;
            this.fLbWorkloadM.Location = new System.Drawing.Point(289, 10);
            this.fLbWorkloadM.Name = "fLbWorkloadM";
            this.fLbWorkloadM.Size = new System.Drawing.Size(101, 30);
            this.fLbWorkloadM.TabIndex = 39;
            this.fLbWorkloadM.Text = "Workload";
            // 
            // fPBWorkloadM
            // 
            this.fPBWorkloadM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.fPBWorkloadM.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.fPBWorkloadM.Location = new System.Drawing.Point(207, 49);
            this.fPBWorkloadM.Maximum = 100;
            this.fPBWorkloadM.Name = "fPBWorkloadM";
            this.fPBWorkloadM.Pattern = true;
            this.fPBWorkloadM.PercentSign = false;
            this.fPBWorkloadM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fPBWorkloadM.ShowBalloon = true;
            this.fPBWorkloadM.Size = new System.Drawing.Size(278, 42);
            this.fPBWorkloadM.TabIndex = 31;
            this.fPBWorkloadM.Value = 0;
            // 
            // fTbNameM
            // 
            this.fTbNameM.BackColor = System.Drawing.Color.Transparent;
            this.fTbNameM.FocusOnHover = false;
            this.fTbNameM.Location = new System.Drawing.Point(310, 222);
            this.fTbNameM.MaxLength = 50;
            this.fTbNameM.Multiline = false;
            this.fTbNameM.Name = "fTbNameM";
            this.fTbNameM.ReadOnly = false;
            this.fTbNameM.Size = new System.Drawing.Size(175, 29);
            this.fTbNameM.TabIndex = 38;
            this.fTbNameM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbNameM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbNameM.UseSystemPasswordChar = false;
            // 
            // fTbMessageM
            // 
            this.fTbMessageM.BackColor = System.Drawing.Color.Transparent;
            this.fTbMessageM.FocusOnHover = false;
            this.fTbMessageM.Location = new System.Drawing.Point(310, 262);
            this.fTbMessageM.MaxLength = 50;
            this.fTbMessageM.Multiline = false;
            this.fTbMessageM.Name = "fTbMessageM";
            this.fTbMessageM.ReadOnly = false;
            this.fTbMessageM.Size = new System.Drawing.Size(175, 29);
            this.fTbMessageM.TabIndex = 37;
            this.fTbMessageM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbMessageM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbMessageM.UseSystemPasswordChar = false;
            // 
            // fBtnColorM
            // 
            this.fBtnColorM.BackColor = System.Drawing.Color.Transparent;
            this.fBtnColorM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fBtnColorM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fBtnColorM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fBtnColorM.Location = new System.Drawing.Point(285, 300);
            this.fBtnColorM.Name = "fBtnColorM";
            this.fBtnColorM.Rounded = false;
            this.fBtnColorM.Size = new System.Drawing.Size(106, 32);
            this.fBtnColorM.TabIndex = 36;
            this.fBtnColorM.Text = "Color";
            this.fBtnColorM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // fCbEffectM
            // 
            this.fCbEffectM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fCbEffectM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fCbEffectM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fCbEffectM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fCbEffectM.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fCbEffectM.ForeColor = System.Drawing.Color.White;
            this.fCbEffectM.FormattingEnabled = true;
            this.fCbEffectM.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fCbEffectM.ItemHeight = 18;
            this.fCbEffectM.Items.AddRange(new object[] {
            "None",
            "Color",
            "Blink",
            "Breathe",
            "Color Cycle"});
            this.fCbEffectM.Location = new System.Drawing.Point(310, 146);
            this.fCbEffectM.Name = "fCbEffectM";
            this.fCbEffectM.Size = new System.Drawing.Size(175, 24);
            this.fCbEffectM.TabIndex = 32;
            // 
            // fTbSpeedM
            // 
            this.fTbSpeedM.BackColor = System.Drawing.Color.Transparent;
            this.fTbSpeedM.FocusOnHover = false;
            this.fTbSpeedM.Location = new System.Drawing.Point(310, 181);
            this.fTbSpeedM.MaxLength = 3;
            this.fTbSpeedM.Multiline = false;
            this.fTbSpeedM.Name = "fTbSpeedM";
            this.fTbSpeedM.ReadOnly = false;
            this.fTbSpeedM.Size = new System.Drawing.Size(175, 29);
            this.fTbSpeedM.TabIndex = 35;
            this.fTbSpeedM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fTbSpeedM.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fTbSpeedM.UseSystemPasswordChar = false;
            // 
            // fLbEffectM
            // 
            this.fLbEffectM.AutoSize = true;
            this.fLbEffectM.BackColor = System.Drawing.Color.Transparent;
            this.fLbEffectM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbEffectM.ForeColor = System.Drawing.Color.White;
            this.fLbEffectM.Location = new System.Drawing.Point(202, 140);
            this.fLbEffectM.Name = "fLbEffectM";
            this.fLbEffectM.Size = new System.Drawing.Size(66, 30);
            this.fLbEffectM.TabIndex = 33;
            this.fLbEffectM.Text = "Effect";
            // 
            // fLbSpeedM
            // 
            this.fLbSpeedM.AutoSize = true;
            this.fLbSpeedM.BackColor = System.Drawing.Color.Transparent;
            this.fLbSpeedM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLbSpeedM.ForeColor = System.Drawing.Color.White;
            this.fLbSpeedM.Location = new System.Drawing.Point(202, 180);
            this.fLbSpeedM.Name = "fLbSpeedM";
            this.fLbSpeedM.Size = new System.Drawing.Size(70, 30);
            this.fLbSpeedM.TabIndex = 34;
            this.fLbSpeedM.Text = "Speed";
            // 
            // fStatusBar
            // 
            this.fStatusBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fStatusBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fStatusBar.ForeColor = System.Drawing.Color.White;
            this.fStatusBar.Location = new System.Drawing.Point(0, 427);
            this.fStatusBar.Name = "fStatusBar";
            this.fStatusBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.fStatusBar.ShowTimeDate = false;
            this.fStatusBar.Size = new System.Drawing.Size(708, 23);
            this.fStatusBar.TabIndex = 3;
            this.fStatusBar.Text = "Made by Sh4d0w | Design by itsEzz";
            this.fStatusBar.TextColor = System.Drawing.Color.White;
            // 
            // fClose
            // 
            this.fClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fClose.BackColor = System.Drawing.Color.White;
            this.fClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.fClose.Location = new System.Drawing.Point(678, 12);
            this.fClose.Name = "fClose";
            this.fClose.Size = new System.Drawing.Size(18, 18);
            this.fClose.TabIndex = 2;
            this.fClose.Text = "flatClose1";
            this.fClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.fClose.Click += new System.EventHandler(this.FClose_Click);
            // 
            // fMin
            // 
            this.fMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fMin.BackColor = System.Drawing.Color.White;
            this.fMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fMin.Font = new System.Drawing.Font("Marlett", 12F);
            this.fMin.Location = new System.Drawing.Point(654, 12);
            this.fMin.Name = "fMin";
            this.fMin.Size = new System.Drawing.Size(18, 18);
            this.fMin.TabIndex = 1;
            this.fMin.Text = "flatMini1";
            this.fMin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(708, 450);
            this.MinimumSize = new System.Drawing.Size(708, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QTracker";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Skin.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tpCPU.ResumeLayout(false);
            this.tpCPU.PerformLayout();
            this.tpGPU.ResumeLayout(false);
            this.tpGPU.PerformLayout();
            this.tpMemory.ResumeLayout(false);
            this.tpMemory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin Skin;
        private FlatUI.FlatClose fClose;
        private FlatUI.FlatMini fMin;
        private FlatUI.FlatStatusBar fStatusBar;
        private FlatUI.FlatProgressBar fPBWorkloadC;
        private FlatUI.FlatLabel fLbEffectC;
        private FlatUI.FlatComboBox fCbEffectC;
        private FlatUI.FlatTextBox fTbSpeedC;
        private FlatUI.FlatLabel fLbSpeedC;
        private FlatUI.FlatButton fBtnColorC;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tpCPU;
        private FlatUI.FlatTextBox fTbNameC;
        private FlatUI.FlatTextBox fTbMessageC;
        private System.Windows.Forms.TabPage tpMemory;
        private System.Windows.Forms.TabPage tpGPU;
        private FlatUI.FlatLabel fLbMessageT;
        private FlatUI.FlatLabel fLbNameT;
        private FlatUI.FlatToggle fTTemperatureC;
        private FlatUI.FlatLabel fLbTemperatureC;
        private FlatUI.FlatProgressBar fPBTemperatureC;
        private FlatUI.FlatTextBox fTbNameT;
        private FlatUI.FlatTextBox fTbMessageT;
        private FlatUI.FlatButton fBtnColorT;
        private FlatUI.FlatComboBox fCbEffectT;
        private FlatUI.FlatTextBox fTbSpeedT;
        private FlatUI.FlatLabel fLbEffectT;
        private FlatUI.FlatLabel fLbSpeedT;
        private FlatUI.FlatLabel fLbMessageC;
        private FlatUI.FlatLabel fLbNameC;
        private FlatUI.FlatToggle fTWorkloadC;
        private FlatUI.FlatLabel fLbWorkloadC;
        private FlatUI.FlatLabel fLbMessage2;
        private FlatUI.FlatLabel fLbNameG2;
        private FlatUI.FlatToggle fTTemperatureG;
        private FlatUI.FlatLabel fLbTemperatureG;
        private FlatUI.FlatProgressBar fPBTemperatureG;
        private FlatUI.FlatTextBox fTbNameG2;
        private FlatUI.FlatTextBox fTbMessageG2;
        private FlatUI.FlatButton fBtnColorG2;
        private FlatUI.FlatComboBox fCbEffectG2;
        private FlatUI.FlatTextBox fTbSpeedG2;
        private FlatUI.FlatLabel fLbEffectG2;
        private FlatUI.FlatLabel fLbSpeedG2;
        private FlatUI.FlatLabel fLbMessageG;
        private FlatUI.FlatLabel fLbNameG;
        private FlatUI.FlatToggle fTWorkloadG;
        private FlatUI.FlatLabel fLbWorkloadG;
        private FlatUI.FlatProgressBar fPBWorkloadG;
        private FlatUI.FlatTextBox fTbNameG;
        private FlatUI.FlatTextBox fTbMessageG;
        private FlatUI.FlatButton fBtnColorG;
        private FlatUI.FlatComboBox fCbEffectG;
        private FlatUI.FlatTextBox fTbSpeedG;
        private FlatUI.FlatLabel fLbEffectG;
        private FlatUI.FlatLabel fLbSpeedG;
        private FlatUI.FlatLabel fLbMessageM;
        private FlatUI.FlatLabel fLbNameM;
        private FlatUI.FlatToggle ftWorkloadM;
        private FlatUI.FlatLabel fLbWorkloadM;
        private FlatUI.FlatProgressBar fPBWorkloadM;
        private FlatUI.FlatTextBox fTbNameM;
        private FlatUI.FlatTextBox fTbMessageM;
        private FlatUI.FlatButton fBtnColorM;
        private FlatUI.FlatComboBox fCbEffectM;
        private FlatUI.FlatTextBox fTbSpeedM;
        private FlatUI.FlatLabel fLbEffectM;
        private FlatUI.FlatLabel fLbSpeedM;
        private System.Windows.Forms.Timer timer1;
    }
}

