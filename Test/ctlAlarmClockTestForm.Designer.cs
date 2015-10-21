namespace Test
{
    partial class ctlAlarmClockTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
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
        private void InitializeComponent ()
        {
            this.ctlAlarmClock1 = new ctlClockLib.ctlAlarmClock();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblChangeAlarmHere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            this.ctlAlarmClock1.AlarmSet = false;
            this.ctlAlarmClock1.AlarmTime = new System.DateTime(((long)(0)));
            this.ctlAlarmClock1.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.Location = new System.Drawing.Point(70, 114);
            this.ctlAlarmClock1.Name = "ctlAlarmClock1";
            this.ctlAlarmClock1.Size = new System.Drawing.Size(151, 46);
            this.ctlAlarmClock1.TabIndex = 0;
            // 
            // dtpTest
            // 
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTest.Location = new System.Drawing.Point(42, 42);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(200, 20);
            this.dtpTest.TabIndex = 1;
            this.dtpTest.ValueChanged += new System.EventHandler(this.dtpTest_ValueChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(67, 80);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 2;
            // 
            // lblChangeAlarmHere
            // 
            this.lblChangeAlarmHere.AutoSize = true;
            this.lblChangeAlarmHere.Location = new System.Drawing.Point(39, 26);
            this.lblChangeAlarmHere.Name = "lblChangeAlarmHere";
            this.lblChangeAlarmHere.Size = new System.Drawing.Size(182, 13);
            this.lblChangeAlarmHere.TabIndex = 3;
            this.lblChangeAlarmHere.Text = "Set the alarm by typing in a new time:";
            // 
            // ctlAlarmClockTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblChangeAlarmHere);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dtpTest);
            this.Controls.Add(this.ctlAlarmClock1);
            this.Name = "ctlAlarmClockTestForm";
            this.Text = "Test Alarm Clock Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlClockLib.ctlAlarmClock ctlAlarmClock1;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblChangeAlarmHere;
    }
}

