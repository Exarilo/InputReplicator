using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void exaTimer1_Load(object sender, EventArgs e)
        {
            exaTimer1.StartTimer();
        }
    }
}
