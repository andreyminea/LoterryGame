using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery
{
    public partial class PlayForm : Form
    {
        DatabaseAPI database;
        public PlayForm(DatabaseAPI database)
        {
            InitializeComponent();
            this.database = database;
        }

        private List<int> CalculateNumbers()
        {
            List<int> numbersList = new List<int>();
            Random random = new Random();
            int number;

            while (numbersList.Count<3)
            {
                number = random.Next(1, Globals.MAX_RANGE);
                bool unique = true;

                foreach(var nr in numbersList)
                {
                    if (number == nr)
                        unique = false;
                }
                if (unique)
                    numbersList.Add(number);
            }
            return numbersList;
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            List<int> luckyNumbers = CalculateNumbers();
            DiplayWinningNumbers(luckyNumbers);
            FindWinners(luckyNumbers);
            CalculateWinnings();
        }
        private void CalculateWinnings()
        {
            var rows = database.GetTable().Rows;
            float amount = 0;

            foreach (DataRow row in rows)
            {
                amount += float.Parse(row.Field<string>("Sum"));
            }
            moneyText.Text = amount.ToString() + " $";
        }
        private void FindWinners(List<int> luckyNumbers)
        {
            string winners = "";
            var rows = database.GetTable().Rows;

            foreach(DataRow row in rows)
            {
                List<int> userNumbers = ToList(row.Field<string>("Numbers"));
                var distinct = userNumbers.Except(luckyNumbers).ToList();
                if(distinct.Count == 0)
                {
                    winners += row.Field<string>("Name") + " ";
                }
            }
            if(winners.Length==0)
            {
                winners = " None ";
            }

            winnerText.Text = winners;
        }
        private List<int> ToList(string v)
        {
            string[] brokeString = v.Split(' ');
            List<int> list = new List<int>();

            foreach(string val in brokeString)
            {
                list.Add(Int32.Parse(val));
                Debug.WriteLine(Int32.Parse(val));
            }
            return list;
        }

        private void DiplayWinningNumbers(List<int> luckyNumbers)
        {
            string luckyNumbersString = "";

            for (int i = 0; i < luckyNumbers.Count; i++)
            {
                luckyNumbersString += luckyNumbers[i];
                if (i != luckyNumbers.Count - 1)
                {
                    luckyNumbersString += "  ";
                }
            }
            numbersBox.Text = luckyNumbersString;
        }
    }
}
