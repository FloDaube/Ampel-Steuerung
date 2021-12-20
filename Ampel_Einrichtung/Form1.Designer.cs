
namespace Ampel_Einrichtung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_State = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_AutoScroll = new System.Windows.Forms.CheckBox();
            this.richTextBox_SerialMonitor = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Ampel1 = new System.Windows.Forms.Panel();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.label_UploadSettings = new System.Windows.Forms.Label();
            this.button_SendSettings = new System.Windows.Forms.Button();
            this.numericUpDown_RR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RG = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_Read = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_State);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Ports);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindung";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(49, 43);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(90, 13);
            this.label_State.TabIndex = 4;
            this.label_State.Text = "Keine verbindung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(52, 19);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Ports.TabIndex = 1;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(160, 59);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(64, 23);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Verbinden";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox_AutoScroll);
            this.groupBox2.Controls.Add(this.richTextBox_SerialMonitor);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Monitor";
            // 
            // checkBox_AutoScroll
            // 
            this.checkBox_AutoScroll.AutoSize = true;
            this.checkBox_AutoScroll.Checked = true;
            this.checkBox_AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AutoScroll.Location = new System.Drawing.Point(6, 19);
            this.checkBox_AutoScroll.Name = "checkBox_AutoScroll";
            this.checkBox_AutoScroll.Size = new System.Drawing.Size(77, 17);
            this.checkBox_AutoScroll.TabIndex = 1;
            this.checkBox_AutoScroll.Text = "Auto Scroll";
            this.checkBox_AutoScroll.UseVisualStyleBackColor = true;
            // 
            // richTextBox_SerialMonitor
            // 
            this.richTextBox_SerialMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_SerialMonitor.Location = new System.Drawing.Point(6, 42);
            this.richTextBox_SerialMonitor.Name = "richTextBox_SerialMonitor";
            this.richTextBox_SerialMonitor.ReadOnly = true;
            this.richTextBox_SerialMonitor.Size = new System.Drawing.Size(449, 99);
            this.richTextBox_SerialMonitor.TabIndex = 0;
            this.richTextBox_SerialMonitor.Text = "";
            this.richTextBox_SerialMonitor.TextChanged += new System.EventHandler(this.richTextBox_SerialMonitor_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.panel_Ampel1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(256, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(113, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 172);
            this.panel1.TabIndex = 1;
            // 
            // panel_Ampel1
            // 
            this.panel_Ampel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Ampel1.Location = new System.Drawing.Point(6, 22);
            this.panel_Ampel1.Name = "panel_Ampel1";
            this.panel_Ampel1.Size = new System.Drawing.Size(101, 172);
            this.panel_Ampel1.TabIndex = 0;
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.label_UploadSettings);
            this.groupBox_Settings.Controls.Add(this.button_SendSettings);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_RR);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_Y);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_RG);
            this.groupBox_Settings.Controls.Add(this.label5);
            this.groupBox_Settings.Controls.Add(this.label4);
            this.groupBox_Settings.Controls.Add(this.label3);
            this.groupBox_Settings.Enabled = false;
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 110);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(238, 131);
            this.groupBox_Settings.TabIndex = 3;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Einstellungen";
            // 
            // label_UploadSettings
            // 
            this.label_UploadSettings.AutoSize = true;
            this.label_UploadSettings.Location = new System.Drawing.Point(35, 106);
            this.label_UploadSettings.Name = "label_UploadSettings";
            this.label_UploadSettings.Size = new System.Drawing.Size(111, 13);
            this.label_UploadSettings.TabIndex = 7;
            this.label_UploadSettings.Text = "Erfolgreich übertragen";
            // 
            // button_SendSettings
            // 
            this.button_SendSettings.Location = new System.Drawing.Point(149, 101);
            this.button_SendSettings.Name = "button_SendSettings";
            this.button_SendSettings.Size = new System.Drawing.Size(75, 23);
            this.button_SendSettings.TabIndex = 6;
            this.button_SendSettings.Text = "Übertragen";
            this.button_SendSettings.UseVisualStyleBackColor = true;
            this.button_SendSettings.Click += new System.EventHandler(this.button_SendSettings_Click);
            // 
            // numericUpDown_RR
            // 
            this.numericUpDown_RR.Location = new System.Drawing.Point(104, 75);
            this.numericUpDown_RR.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_RR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_RR.Name = "numericUpDown_RR";
            this.numericUpDown_RR.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_RR.TabIndex = 5;
            this.numericUpDown_RR.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Location = new System.Drawing.Point(104, 49);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Y.TabIndex = 4;
            this.numericUpDown_Y.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_RG
            // 
            this.numericUpDown_RG.Location = new System.Drawing.Point(104, 23);
            this.numericUpDown_RG.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown_RG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_RG.Name = "numericUpDown_RG";
            this.numericUpDown_RG.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_RG.TabIndex = 3;
            this.numericUpDown_RG.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doppel Rot Dauer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gelb Dauer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rot Grün Dauer";
            // 
            // timer_Read
            // 
            this.timer_Read.Tick += new System.EventHandler(this.timer_Read_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 406);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ampel einrichtung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_SerialMonitor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel_Ampel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.NumericUpDown numericUpDown_RR;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.NumericUpDown numericUpDown_RG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_SendSettings;
        private System.Windows.Forms.Label label_UploadSettings;
        private System.Windows.Forms.CheckBox checkBox_AutoScroll;
        private System.Windows.Forms.Timer timer_Read;
    }
}

