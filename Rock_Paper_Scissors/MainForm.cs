using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rock_Paper_Scissors.Properties;
using System.Media;

using Rock_Paper_Scissors;


namespace Rock_Paper_Scissors
{
    public partial class MainForm : Form
    {

        enum enGameChoice { Rock = 1, Paper = 2, Scissors = 3 };
        enum enWinner { Player1 = 1, Computer = 2, Draw = 3 };



     

        public MainForm()
        {
       

            InitializeComponent();
        
        }


       



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private int _RoundsNumber;
        private int _RoundsCounter;


       private enGameChoice _PlayerChoice;
       private enGameChoice _ComputerChoice;
       private enWinner _Winner;


        private short _ComputerWinTimes;
        private short _PlayerWinTimes;
        private short _DrawTimes;
        private enWinner _GameWinner;

        private bool IsStartGame = false;
        private bool IsAlreadyStart = false;

   private async void _PanelsBackColor(enWinner _Winner)
        {
            switch (_Winner)
            {
                case enWinner.Player1:
                    panel1.BackColor = Color.Chartreuse;
                    panel2.BackColor = Color.Chartreuse;
                    panel3.BackColor = Color.Chartreuse;
                    panel4.BackColor = Color.Chartreuse;
                    panel5.BackColor = Color.Chartreuse;
                    panel6.BackColor = Color.Chartreuse;

                    label6.ForeColor = Color.Chartreuse;

                    await Task.Delay(1500);

                    panel1.BackColor = Color.Black;
                    panel2.BackColor = Color.Black;
                    panel3.BackColor = Color.Black;
                    panel4.BackColor = Color.Black;
                    panel5.BackColor = Color.Black;
                    panel6.BackColor = Color.Black;

                    label6.ForeColor = Color.Black;
                    break;

                case enWinner.Computer:
                    panel1.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel3.BackColor = Color.Red;
                    panel4.BackColor = Color.Red;
                    panel5.BackColor = Color.Red;
                    panel6.BackColor = Color.Red;

                    label6.ForeColor = Color.Red;

                    await Task.Delay(1500);

                    panel1.BackColor = Color.Black;
                    panel2.BackColor = Color.Black;
                    panel3.BackColor = Color.Black;
                    panel4.BackColor = Color.Black;
                    panel5.BackColor = Color.Black;
                    panel6.BackColor = Color.Black;

                    label6.ForeColor = Color.Black;
                    break;

                default:

                    panel1.BackColor = Color.Yellow;
                    panel2.BackColor = Color.Yellow;
                    panel3.BackColor = Color.Yellow;
                    panel4.BackColor = Color.Yellow;
                    panel5.BackColor = Color.Yellow;
                    panel6.BackColor = Color.Yellow;

                    label6.ForeColor = Color.Yellow;

                    await Task.Delay(1500);

                    panel1.BackColor = Color.Black;
                    panel2.BackColor = Color.Black;
                    panel3.BackColor = Color.Black;
                    panel4.BackColor = Color.Black;
                    panel5.BackColor = Color.Black;
                    panel6.BackColor = Color.Black;

                    label6.ForeColor = Color.Black;
                    break;
            }
        }



        public void EndGame()
        {
            switch (_Winner)
            {
                case enWinner.Player1:

                    _PanelsBackColor(enWinner.Player1);

                    label6.Text = "  You Winner :-)";
                    _PlayerWinTimes++;
                    lblPlayerWinTimes.Text = _PlayerWinTimes.ToString();

                    try
                    {
                        SoundPlayer player = new SoundPlayer(Properties.Resources.GoodResult);

                        player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex.Message);
                    }
                    break;

                case enWinner.Computer:

                    _PanelsBackColor(enWinner.Computer);

                    label6.Text = "Computer Winner :-(";
                    _ComputerWinTimes++;
                    lblComputerWinTimes.Text= _ComputerWinTimes.ToString();

                    try
                    {

                        SoundPlayer player = new SoundPlayer(Properties.Resources.mixkit_wrong_answer_fail_notification_946);

                        player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error " + ex.Message);
                    }
                    break;

                default:

                    _PanelsBackColor(enWinner.Draw);

                    label6.Text = "  Draw Round !";
                   label6.ForeColor = Color.Yellow;
                    _DrawTimes++;
                    break;
            }

            if (_RoundsCounter == _RoundsNumber)
            {
                lblRoundsCounter.Text = "Round " + _RoundsNumber.ToString() ;
              
                IsStartGame = false;
                IsAlreadyStart = true;

                if (_ComputerWinTimes > _PlayerWinTimes)
                    _GameWinner = enWinner.Computer;

                else if(_ComputerWinTimes < _PlayerWinTimes)
                    _GameWinner = enWinner.Player1;

                else
                    _GameWinner = enWinner.Draw;

           

                return;
            }

            _RoundsCounter++;
            lblRoundsCounter.Text = "Round " + _RoundsCounter.ToString() ;
                    
        }
       
        private void CheckWinner(enGameChoice PlayerChoice, enGameChoice ComputerChoice)
        {
           
            if (PlayerChoice == enGameChoice.Rock && ComputerChoice == enGameChoice.Rock)
            {
                _Winner = enWinner.Draw;
                ptrbxYourChoice.Image = Resources.Rock;
                ptrbxComputerChoice.Image = Resources.Rock;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Paper && ComputerChoice == enGameChoice.Paper)
            {
                _Winner = enWinner.Draw;
                ptrbxYourChoice.Image = Resources.Paper;
                ptrbxComputerChoice.Image = Resources.Paper;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Scissors && ComputerChoice == enGameChoice.Scissors)
            {
                _Winner = enWinner.Draw;
                ptrbxYourChoice.Image = Resources.Scissors;
                ptrbxComputerChoice.Image = Resources.Scissors;

                EndGame();
            }




            if (PlayerChoice == enGameChoice.Rock && ComputerChoice == enGameChoice.Scissors)
            {
                _Winner = enWinner.Player1;
                ptrbxYourChoice.Image = Resources.Rock;
                ptrbxComputerChoice.Image = Resources.Scissors;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Paper && ComputerChoice == enGameChoice.Rock)
            {
                _Winner = enWinner.Player1;
                ptrbxYourChoice.Image = Resources.Paper;
                ptrbxComputerChoice.Image = Resources.Rock;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Scissors && ComputerChoice == enGameChoice.Paper)
            {
                _Winner = enWinner.Player1;
                ptrbxYourChoice.Image = Resources.Scissors;
                ptrbxComputerChoice.Image = Resources.Paper;

                EndGame();
            }



            if (PlayerChoice == enGameChoice.Scissors && ComputerChoice == enGameChoice.Rock)
            {
                _Winner = enWinner.Computer;
                ptrbxYourChoice.Image = Resources.Scissors;
                ptrbxComputerChoice.Image = Resources.Rock;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Rock && ComputerChoice == enGameChoice.Paper)
            {
                _Winner = enWinner.Computer;
                ptrbxYourChoice.Image = Resources.Rock;
                ptrbxComputerChoice.Image = Resources.Paper;

                EndGame();
            }
            if (PlayerChoice == enGameChoice.Paper && ComputerChoice == enGameChoice.Scissors)
            {
                _Winner = enWinner.Computer ;
                ptrbxYourChoice.Image = Resources.Paper;
                ptrbxComputerChoice.Image = Resources.Scissors;

                EndGame();
            }







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void StartGame()
        {
           
            IsStartGame = true;


            RoundsNumber Rounds = new RoundsNumber();


            if (Rounds.ShowDialog() == DialogResult.OK)
            {

                _RoundsNumber = Rounds.SelectedRoundsNumber;

                lblRoundsNumber.Text = _RoundsNumber.ToString() + " Rounds";
                lblRoundsCounter.Text = "Rounds 0";
                IsAlreadyStart = true;
            }
           

         
        }



      
        private void lblRoundsNumber_Click_1(object sender, EventArgs e)
        {

        }
        private void RestartGame()
        {
            _ComputerWinTimes = 0;
            _PlayerWinTimes = 0;
            _DrawTimes = 0;
            _RoundsCounter = 0;
            lblRoundsCounter.Text = "";
            lblComputerWinTimes.Text = "0";
            lblPlayerWinTimes.Text = "0";
            lblRoundsNumber.Text = "Round 0";
        }

    

  
        private void ptrbxChoice(object sender, EventArgs e)
        {
          


            if (IsStartGame)
                {

               if(_RoundsCounter == _RoundsNumber)
                {
                    if (IsAlreadyStart)
                    {
                        MessageBox.Show("Click Restart Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Click Start Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                       

                }


                Random RandomNumber = new Random();
                int ComputerChoice = RandomNumber.Next(1, 3);

                PictureBox Choice = (PictureBox)sender;

                    byte PlayerChoice = Convert.ToByte(Choice.Tag);
              
                    CheckWinner((enGameChoice)PlayerChoice, (enGameChoice)ComputerChoice);

            }
            else
            {
                if (IsAlreadyStart)
                {
                    MessageBox.Show("Click Restart Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Click Start Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

          
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (IsStartGame)
            {
                if(_RoundsCounter < _RoundsNumber)
                {
                    MessageBox.Show("Complete The Rounds !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ResultForm resultForm = new ResultForm(_ComputerWinTimes, _PlayerWinTimes, _DrawTimes, (short)_RoundsNumber);

                    resultForm.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Click Start Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
     
        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnRestartGame_Click_1(object sender, EventArgs e)
        {


        

            if (IsAlreadyStart)
            {
                RestartGame();
                IsAlreadyStart = false;

                StartGame();
                return;
            }
            MessageBox.Show("Click Start Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void btnStartGame_Click(object sender, EventArgs e)
        {


            if (IsAlreadyStart)
            {
                MessageBox.Show("Click Restart Game to play", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StartGame();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
   
}
