using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
namespace BlackJack1
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Image image;
        private Dock game = new Dock();
        private Player player = new Player();
        private Dealer dealer = new Dealer();
        private Stack<Card> cards;
        private Card top;
        private Graphics graphics;
        private int PlayerDrawer;
        private int DealerDrawer;
        private bool StartDrawingPlayer;
        private bool StartDrawingDealer;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DisplayImage(Card x)
        {
            string fileplace = "C:\\Users\\天才黃柏霖\\Desktop\\BlackJack1\\BlackJack1\\bin\\JPEG\\" + x.GetFileName + ".jpg";
            image = Image.FromFile(fileplace);
            graphics = CreateGraphics();
            graphics.DrawImage(image, 5 + 100 * PlayerDrawer, 220, 85, 150);
            ++PlayerDrawer;
        }
        private void DisplayImage2(Card x)
        {
            string fileplace = "C:\\Users\\天才黃柏霖\\Desktop\\BlackJack1\\BlackJack1\\bin\\JPEG\\" + x.GetFileName + ".jpg";
            image = Image.FromFile(fileplace);
            graphics = CreateGraphics();
            graphics.DrawImage(image, 5 + 100 * DealerDrawer, 5, 85, 150);
            ++DealerDrawer;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (StartDrawingPlayer)
            {
                DisplayImage(top);
            }
            else if (StartDrawingDealer)
            {

                DisplayImage2(top);
            }

        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(1097, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "抽牌";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1097, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1097, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "莊家總分:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "玩家總分:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
    class Dock
    {
        private Random random = new Random();
        private List<int> UsedCard = new List<int>();
        private Stack<Card> NewCard = new Stack<Card>();

        public Dock()
        {
            bool same = false;
            int counter = 0;
            while (counter < 52)
            {
                same = false;
                int k = random.Next(52) + 1;
                int suit = k % 4;
                int number = k % 13 + 1;
                foreach (int n in UsedCard)
                {
                    if (k == n)
                    {
                        same = true;
                        break;
                    }

                }
                if (same == false)
                {
                    NewCard.Push(new Card(suit, number));
                    UsedCard.Add(k);
                    ++counter;
                }

            }

        }
        public Stack<Card> Cards()
        {
            return NewCard;
        }
    }
    class Card
    {
        private string shape;
        private int number;
        private string filename;
        private string[] Suit = { "S", "H", "D", "C" };
        public Card(int x, int y)
        {
            shape = Suit[x];
            number = y;
            filename = number.ToString() + shape;
        }
        public int PlusNumber(List<Card> x)
        {
            int Total = 0;
            foreach (Card Acard in x)
            {
                if (Acard != null)
                {
                    int BeyondTen = (Acard.number >= 10) ? 10 : Acard.number;
                    Total += BeyondTen;
                }
                else
                {
                    break;
                }
            }

            return Total;
        }
        public int PlusNumber2(List<Card> x)
        {
            int Total = 0;
            foreach (Card Acard in x)
            {
                if (Acard != null)
                {
                    int BeyondTen = (Acard.number >= 10) ? 10 : Acard.number;
                    if (BeyondTen == 1)
                    {
                        BeyondTen = 11;
                    }
                    Total += BeyondTen;
                }
            }

            return Total;

        }
        public string GetFileName
        {
            get
            {
                return filename;
            }
        }
    }
    class Player
    {
        private List<Card> Hand = new List<Card>();
        protected int NCard = 0;
        protected int HandTotal;
        protected int HandTotal2;

        virtual public bool GetCardOK()
        {
            return true;
        }

        public void SaveCard(Card x)
        {
            Hand.Add(x);
            ++NCard;
            HandTotal = x.PlusNumber(Hand);
            HandTotal2 = x.PlusNumber2(Hand);

        }

        public bool Status()
        {
            bool IsOutOfRange = false;
            if (HandTotal > 21 & HandTotal2 > 21)
            {
                IsOutOfRange = true;
            }
            return IsOutOfRange;

        }
        public string GetNumber
        {
            get
            {

                if (HandTotal != HandTotal2 & HandTotal2 == 21)
                {
                    return HandTotal2.ToString();
                }
                else if (HandTotal != HandTotal2 & HandTotal2 < 21)
                {
                    return HandTotal.ToString() + "或" + HandTotal2.ToString();
                }
                else
                {
                    return HandTotal.ToString();
                }
            }
        }
        public int GetNcard
        {
            get
            {
                return NCard;
            }
        }
        public int FinalScore()
        {
            if (HandTotal != HandTotal2 & HandTotal2 > 21)
            {
                return HandTotal;
            }
            else if (HandTotal != HandTotal2)
            {
                return HandTotal2;
            }
            else
            {
                return HandTotal;
            }
        }
    }
    
    class Dealer : Player
    {
        override public bool GetCardOK()
        {

            if (HandTotal != HandTotal2 & HandTotal2 <= 21)
            {
                return (HandTotal2 < 17);
            }
            else
            {
                return (HandTotal < 17);
            }
        }
    }
}


