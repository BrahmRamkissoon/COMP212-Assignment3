// Filename: ctlClock.cs
// Author: Brahm Ramkissoon
// Created Date  (dd/mm/yyyy): 21/10/2015
// Description:  Create a composite control:
/* Revisions    - created composite control of timer and lablel
**              - added timer event
**              - added a custom property 
**
*/
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
        // Private Variables
        private Color colBColor;

        // Public properties
        // Declares name and type of prop
        public Color ClockBackColor
        {
            // Retrieves the value of the private variable colBColor
            get
            {
                return colBColor;
            }

            // Stores the selected value in the private variable colBColor, and
            // Updates the background color of the label control lblDisplay.
            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }
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
