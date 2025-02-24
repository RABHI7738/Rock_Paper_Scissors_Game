using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace Rock_Paper_Scissors
{
    public partial class ResultForm : Form
    {

        private short _RoundsNum;
        private short _ComputerWinTimes;
        private short _PlayerWinTimes;
        private short _DrawTimes;
   

  

        public ResultForm(short ComputerWinTimes, short PlayerWinTimes, short DrawTimes, short RoundsNum)
        {
              this._RoundsNum = RoundsNum;
              this._ComputerWinTimes = ComputerWinTimes;
              this._PlayerWinTimes = PlayerWinTimes;
              this. _DrawTimes = DrawTimes;
         
        

            InitializeComponent();
        }
        private void GameWinner()
        {
            if (_ComputerWinTimes < _PlayerWinTimes)
            {
                lblWiner.Text = "You Winner :-)";
                lblWiner.ForeColor = Color.Chartreuse;
                try
                {

                  
                    SoundPlayer player = new SoundPlayer(Properties.Resources.mixkit_game_bonus_reached_2065);

                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
              

             else if (_ComputerWinTimes > _PlayerWinTimes){
                lblWiner.Text = "Computer Winner :-(";
                lblWiner.ForeColor = Color.Firebrick;

                try
                {

                    SoundPlayer player = new SoundPlayer(Properties.Resources.mixkit_funny_fail_low_tone_2876);

                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
              
            else
                lblWiner.Text = "Draw Game";
        }


        void DataResult()
        {
            lblRundsNum.Text = _RoundsNum.ToString();
            GameWinner();
            lblComputerWinTimes.Text = _ComputerWinTimes.ToString();    
            lblPlayerWinTimes.Text = _PlayerWinTimes.ToString();
            lblDrawTimes.Text = _DrawTimes.ToString();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
          
            DataResult();
        }


        private void lblWiner_Click(object sender, EventArgs e)
        {

        }

        private void lblComputerWinTimes_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerWinTimes_Click(object sender, EventArgs e)
        {

        }

        private void lblDrawTimes_Click(object sender, EventArgs e)
        {

        }

        private void ResultForm_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
