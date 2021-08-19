using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cards = game.Cards();
            button1.Enabled = false;
            for (int i = 0; i < 2; i++)
            {
                top = cards.Pop();
                player.SaveCard(top);
                StartDrawingPlayer = true;
                DisplayImage(top);
                StartDrawingPlayer = false;
                top = cards.Pop();
                dealer.SaveCard(top);
                StartDrawingDealer = true;
                DisplayImage2(top);
                StartDrawingDealer = false;

            }
            label4.Text = player.GetNumber;
            label2.Text = dealer.GetNumber;
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            top = cards.Pop();
            player.SaveCard(top);
            StartDrawingPlayer = true;
            DisplayImage(top);
            StartDrawingPlayer = false;
            label4.Text = player.GetNumber;
            bool IsOutOfRange = player.Status();
            if (IsOutOfRange)
            {
                MessageBox.Show("你的點數為" + player.GetNumber + "點,下次再努力");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
            }
            else if (player.GetNcard >= 5)
            {
                MessageBox.Show("已達到手牌數量的上限,請按停止");
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            bool DealerRule = dealer.GetCardOK();
            bool IsOutOfRange = false;
            while (DealerRule)
            {
                top = cards.Pop();
                dealer.SaveCard(top);
                StartDrawingDealer = true;
                DisplayImage2(top);
                StartDrawingDealer = false;
                label2.Text = dealer.GetNumber;
                IsOutOfRange = dealer.Status();
                if (IsOutOfRange)
                {
                    MessageBox.Show("電腦自爆,你贏得了勝利");
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = true;
                }
                DealerRule = dealer.GetCardOK();

            }
            if (!IsOutOfRange)
            {
                int playerfinalscore = player.FinalScore();
                int dealerfinalscore = dealer.FinalScore();
                if (playerfinalscore == dealerfinalscore)
                {
                    MessageBox.Show("此次比賽雙方平手,皆為" + playerfinalscore.ToString() + "分");
                }
                else if (playerfinalscore > dealerfinalscore)
                {
                    MessageBox.Show("你真棒!你贏了!");
                }
                else
                {
                    MessageBox.Show("雖敗猶榮,下次再努力!");
                }
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.Restart();
        }
    }
}
