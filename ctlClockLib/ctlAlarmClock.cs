// Filename: ctlAlarmClock.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 21/10/2015
// Description: inherit from ctlClock
// Revisions    - add color flash functionality on alarm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ctlClockLib
{
    public partial class ctlAlarmClock : ctlClockLib.ctlClock
    {
        // Private Instance Variables
        private DateTime _dteAlarmTime;
        private bool _blnAlarmSet;
        private bool _blnColorTicker;       // flash alarm if true

        // Public Properties
        // These properties will be declared as public to alllow future devs to accesss them

        // store value of date and time alarm is set to
        public DateTime AlarmTime
        {
            get { return _dteAlarmTime; }
            set
            {
                _dteAlarmTime = value;
            }
        }

        // indicate whether the alarm is set
        public bool AlarmSet
        {
            get
            {
                return _blnAlarmSet;
            }
            set
            {
                _blnAlarmSet = value;
            }
        }

        public ctlAlarmClock ()
        {
            InitializeComponent();
        }

        protected override void timer1_Tick ( object sender, EventArgs e )
        {
            base.timer1_Tick(sender, e);

            // Checks to see if the alarm is set
            if (AlarmSet == false)
            {
                return;
            }
            else 
            // If the date, hour and minute of the alarm time are the same as
            // the current ime, flash an alarm
            {
                if (AlarmTime.Date == DateTime.Now.Date &&
                    AlarmTime.Hour == DateTime.Now.Hour &&
                    AlarmTime.Minute == DateTime.Now.Minute)
                {
                    // Sets lblAlarmVisble to true, and changes the background color based on
                    // The value of blnColorTicker. The backgrond color of the lable
                    // will flash once per tick o the clock.

                    lblAlarm.Visible = true;
                    if (_blnColorTicker == false)
                    {
                        lblAlarm.BackColor = Color.Red;
                        _blnColorTicker = true;
                    }
                    else
                    {
                        lblAlarm.BackColor = Color.Blue;
                        _blnColorTicker = false;
                    }
                }
                else
                {
                    //Once the alarm has sounded for a minute, the label is made invisble again
                    lblAlarm.Visible = false;
                }
            }
        }
    }
}
