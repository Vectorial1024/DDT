using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDT
{
    public partial class DDTControl : Form
    {
        private bool useTerminate;
        private bool useDisintegrate;
        private bool useDisrupt;

        /// <summary>
        /// Indicates whether the Terminater Module is active.
        /// </summary>
        public bool TerminateModeOn
        {
            get
            {
                return useTerminate;
            }
            set
            {
                useTerminate = value;
            }
        }

        /// <summary>
        /// Indicates whether the Disintegrater Module is active.
        /// </summary>
        public bool DisintegrateModeActive
        {
            get
            {
                return useDisintegrate;
            }
            set
            {
                useDisintegrate = value;
            }
        }

        /// <summary>
        /// Indicates whether the Disrupter Module is active.
        /// </summary>
        public bool DisruptModeActive
        {
            get
            {
                return useDisrupt;
            }
            set
            {
                useDisrupt = value;
            }
        }
    }
}
