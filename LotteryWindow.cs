using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lottery
{
    public partial class LotteryWindow : Form
    {
        DatabaseAPI database;
        Form dataForm;
        Form playForm;

        public LotteryWindow(DatabaseAPI database)
        {
            InitializeComponent();
            this.database = database;
            dataForm = new HistoryView(database);
            dataForm.Show();
        }

        private void randomGenBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int n1 = NonEqualRandomNum();
            number1.Value = n1;
            int n2 = NonEqualRandomNum(n1);
            number2.Value = n2;
            number3.Value = NonEqualRandomNum(n1, n2);
        }

        private int NonEqualRandomNum(params int[] values)
        {
            Random random = new Random();
            int number = 0;
            bool generate = true;
            
            while(generate)
            {
                number = random.Next(1, Globals.MAX_RANGE);
                if (values.Length == 0)
                    generate = false;
                else
                {
                    generate = false;
                    foreach(var val in values)
                    {
                        if (val == number)
                            generate = true;
                    }
                }
            }
            return number;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(ValidateInputs() && ValidateName())
            {
                Debug.WriteLine(nameInput.Text);
                Debug.WriteLine(number1.Value.ToString() + " " +
                                number2.Value.ToString() + " " +
                                number3.Value.ToString());
                Debug.WriteLine(new Date(date.SelectionStart));
                SaveToDatabase();
            }
        }

        private void SaveToDatabase()
        {
            EntryPerson newEntry = new EntryPerson();
            newEntry.Name = nameInput.Text;
            newEntry.Numbers = new List<int>()
            {   Convert.ToInt32(number1.Value),
                Convert.ToInt32(number2.Value),
                Convert.ToInt32(number3.Value)
            };
            newEntry.Sum = "5";
            newEntry.Date = date.SelectionStart.Date;
            database.AddEntry(newEntry);
        }

        private bool ValidateInputs()
        {
            if (number1.Value >= 1 && number1.Value <= Globals.MAX_RANGE)
                if (number2.Value >= 1 && number2.Value <= Globals.MAX_RANGE)
                    if (number3.Value >= 1 && number3.Value <= Globals.MAX_RANGE)
                        if(number1.Value != number2.Value 
                            && number1.Value != number3.Value 
                            && number2.Value != number3.Value)
                        return true;
            return false;
        }

        private bool ValidateName()
        {
            if (nameInput.Text.Length > 0)
                return true;
            return false;
        }

        private void LotteryWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataForm.Close();
        }

        private void LotteryWindow_Resize(object sender, EventArgs e)
        {
            dataForm.WindowState = WindowState;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            playForm = new PlayForm(database);
            playForm.ShowDialog();
        }
    }
}
