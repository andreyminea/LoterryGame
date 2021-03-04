using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace Lottery
{
    public class DatabaseAPI
    {
        private readonly string filename = "savedDb.xml";
        private readonly string tableName = "Entries";
        DataSet dataSet;
        DataTable table;
        public DatabaseAPI()
        {
            dataSet = new DataSet();
            CheckXMLFile();
            dataSet.ReadXml(filename);
           
            if(dataSet.Tables.Contains(tableName))
            {
                Debug.WriteLine("exists");
                table = dataSet.Tables[0];
            }
            else
            {
                Debug.WriteLine("create new");
                CreateTableHeader();
                dataSet.Tables.Add(table);
            }
        }
        private void CheckXMLFile()
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            Debug.WriteLine(fs.Length);
            if(fs.Length == 0)
            {
                fs.Close();
                SaveDatabase();
            }
            fs.Close();
        }
        private void CreateTableHeader()
        {
            table = new DataTable(tableName);
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Numbers", typeof(string));
            table.Columns.Add("Sum", typeof(string));
            table.Columns.Add("Date of purchase", typeof(string));
        }

        public void AddEntry(EntryPerson person)
        {
            table.Rows.Add(person.Name, person.GetNumbers(), person.Sum, person.Date.ToString());
        }

        public DataTable GetTable()
        {
            return table;
        }

        public void SaveDatabase()
        {
            Debug.WriteLine("save");
            dataSet.WriteXml(filename);
        }
    }
}
