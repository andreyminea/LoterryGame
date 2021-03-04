using System;
using System.Windows.Forms;

namespace Lottery
{
    public partial class HistoryView : Form
    {
        private DatabaseAPI database;
        public HistoryView()
        {
            InitializeComponent();
        }

        public HistoryView(DatabaseAPI database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void HistoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            database.SaveDatabase();
        }

        private void HistoryView_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = database.GetTable();
            dataGrid.AutoResizeColumns();
        }
    }
}
