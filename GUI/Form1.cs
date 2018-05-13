using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        State initialState;
        int sumOfCoins = 0;
        List<State> savedStates;
        StringBuilder sb;
        public Form1()
        {
            InitializeComponent();
            initialState = new StateTable().GetInitialState();
            sb = new StringBuilder();
            savedStates = new List<State>();
            herbataButton.Enabled = false;
            kawaButton.Enabled = false;
        }

        private void coin_Click(object sender, EventArgs e)
        {
            savedStates.Add(initialState);
            StateLabel.Text = "Jestes w stanie: " + initialState.Name;
            int value = Convert.ToInt32((sender as Button).Text.Split(' ')[0]);

            sumOfCoins += value;
            sb.Append(" -> ").Append(initialState.Name);
            StatesLabel.Text = sb.ToString();
            initialState = initialState.NextState(value);
            if (initialState.Proudct?.Equals("Herbata")??false)
            {
                herbataButton.Enabled = true;
            }
            if (initialState.Proudct?.Equals("Kawa")??false)
            {
                kawaButton.Enabled = true;
            }
        }

        private void herbataButton_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32((sender as Button).Text.Split(' ')[1]) == 5 ? 1 : 2;
            finishApp();
        }
        public void finishApp()
        {
            sb.Append(" -> ").Append(initialState.Name);
            StatesLabel.Text = sb.ToString();
            SumLabel.Text = "Sum: " + sumOfCoins.ToString();
            productLabel.Text = "Wydano: " + initialState.Proudct;
            restLabel.Text = "Reszty: " + initialState.Rest;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            kawaButton.Enabled = false;
            herbataButton.Enabled = false;
        }
    }
}
