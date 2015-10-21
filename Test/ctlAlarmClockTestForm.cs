// Filename: ctlAlarmClockTestForm.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 21/10/2015
// Description: Test Alarm Clock composite control
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ctlAlarmClockTestForm : Form
    {
        public ctlAlarmClockTestForm ()
        {
            InitializeComponent();
        }

        private void dtpTest_ValueChanged ( object sender, EventArgs e )
        {
            // Set the alarm clock time using the dateTimePicker
            ctlAlarmClock1.AlarmTime = dtpTest.Value;
            ctlAlarmClock1.AlarmSet = true;
            lblTest.Text = $"Alarm Time is now set to {ctlAlarmClock1.AlarmTime.ToShortTimeString()}";
        }
    }
}
