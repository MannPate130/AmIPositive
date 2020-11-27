using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class amIpositive : Form
    {
        public amIpositive()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
          
            int integer = Convert.ToInt32(integerTextbox.Text);
            

            if (integer >= 0)
            {
                negativeOrpositiveLabel.Text = $"{integer} is a positive number";
            }
            else
            {
                negativeOrpositiveLabel.Text = $"{integer} is not a positive number";
            }


            int divide = Convert.ToInt32(integerTextbox.Text);
            

            if (divide % 7 == 0) 
            {
                divisibleLabel.Text = $"{divide} is divisible by 7";
            }
            else
            {
                divisibleLabel.Text = $"{divide} is not divisible by 7";
            }
        }
    }
}


