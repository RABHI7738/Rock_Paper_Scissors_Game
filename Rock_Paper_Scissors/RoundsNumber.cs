using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rock_Paper_Scissors;
namespace Rock_Paper_Scissors
{
    public partial class RoundsNumber : Form
    {
        public int SelectedRoundsNumber {  get; private set; }
        public RoundsNumber()
        {
            InitializeComponent();
        }



     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            label2.Text = numericUpDown1.Value.ToString() + " Rounds";
        }

        private void button1_Click_1(object sender, EventArgs e) 
        {
            SelectedRoundsNumber = (int)numericUpDown1.Value;

            this.DialogResult = DialogResult.OK;

            this.Close();


        }
    }
}
