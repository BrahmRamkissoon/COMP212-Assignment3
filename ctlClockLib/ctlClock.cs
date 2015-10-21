using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlClockLib
{
    public partial class ctlClock: UserControl
    {
        public ctlClock()
        {
            InitializeComponent();
        }

        // make it protected and overridable with virtual keyword
        protected virtual void timer1_Tick ( object sender, EventArgs e )
        {
            // Causes the label to display the current time.
            lblDisplay.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
