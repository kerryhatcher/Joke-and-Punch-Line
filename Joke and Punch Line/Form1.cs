using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_and_Punch_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            labelText.Text = "How do you make holy water?";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelText.Text = "You boil the hell out of it. ";
        }
    }
}
