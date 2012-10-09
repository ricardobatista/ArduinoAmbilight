namespace Ambilight
{
    partial class FormAmbilight
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
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 71);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(12, 100);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(93, 71);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(93, 52);
            this.picColor.TabIndex = 14;
            this.picColor.TabStop = false;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(6, 16);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(92, 13);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 21);
            this.cmbPortName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComPort);
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 50);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // FormAmbilight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 135);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAmbilight";
            this.Text = "Ambilight by @ricbat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAmbilight_FormClosing);
            this.Load += new System.EventHandler(this.FormAmbilight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

