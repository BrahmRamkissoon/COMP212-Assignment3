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
    }
}
