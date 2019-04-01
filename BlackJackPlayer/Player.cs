using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace BlackJackPlayer
{
    public class Player
    {
        public Player(int money, TextBlock lblBet, TextBlock lblMoney, Button btnDeal, TextBlock lblTotal, ListView playerCards)
        {
            this.bet = 0;
            this.money = money;
            this.lblBet = lblBet;
            this.lblMoney = lblMoney;
            this.btnDeal = btnDeal;
            this.total = 0;
            this.cards = new List<String>();
            this.lblTotal = lblTotal;
            this.playerCards = playerCards;
            this.one = 0;
            this.isBomb = false;
            this.isBlackJack = false;
        }
        public Player(TextBlock lblTotal, ListView playerCards)
        {
            this.total = 0;
            this.cards = new List<String>();
            this.lblTotal = lblTotal;
            this.playerCards = playerCards;
            this.one = 0;
            this.isBomb = false;
            this.isBlackJack = false;
        }
        public int bet { get; set; }
        public int money { get; set; }
        public int total { get; set; }
        public List<String> cards { get; set; }
        public TextBlock lblBet { get; set; }
        public TextBlock lblMoney { get; set; }
        public TextBlock lblTotal { get; set; }
        public Button btnDeal { get; set; }
        public ListView playerCards { get; set; }
        public int one { get; set; }
        public bool isBomb { get; set; }
        public bool isBlackJack { get; set; }
        public void reset()
        {
            this.bet = 0;
            this.cards = new List<String>();
            this.total = 0;
            this.one = 0;
            this.isBomb = false;
            this.isBlackJack = false;
            this.lblTotal.Text = "";
            this.playerCards.Items.Clear();
        }
        public bool addBet(int bet)
        {
            if (this.bet + bet < 0 || this.money - bet < 0)
                return false;
            this.bet += bet;
            this.money -= bet;
            lblBet.Text = this.bet.ToString();
            lblMoney.Text = this.money.ToString();
            return true;
        }
    }
}
