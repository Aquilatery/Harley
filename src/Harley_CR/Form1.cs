using System;
using System.Windows.Forms;
using Harley.Transition.Form;
using Harley.Enum.Transition;

namespace Harley_CR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animate.Window(Handle, Speed.FiveHundred, Direction.Center);
        }
    }
}