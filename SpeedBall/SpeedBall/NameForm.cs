using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedBall
{
    public partial class NameForm : Form
    {

        public String name { get; set; }
        public NameForm()
        {
            InitializeComponent();
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            lbName.Text = name;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
