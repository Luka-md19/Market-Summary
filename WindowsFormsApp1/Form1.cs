using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private List<Market> _marketList;
        private List<MarketSummary> _summaryList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _marketList = new List<Market>();
            _summaryList = new List<MarketSummary>();
           
        }

        private void btnReadAllData_Click(object sender, EventArgs e)
        {
            _marketList = new List<Market>();
            string[] lines = File.ReadAllLines("quiz3market.txt");
            foreach (string line in lines.Skip(1))
            {
                string[] fields = line.Split('\t');
                if (fields.Length >= 3)
                {
                    Market market = new Market
                    {

                        ProductName = fields[0],
                        Unit = fields[1],
                        Price = decimal.Parse(fields[2].Replace("TL", "").Replace(",", "."))
                    };

                    _marketList.Add(market);




                    listBox1.Text = $"Total items read: {_marketList.Count}";
                }

            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            _summaryList = _marketList.GroupBy(m => new { m.ProductName, m.Unit })
           .Select(g => new MarketSummary
           {
               ProductName = g.Key.ProductName,
               Unit = g.Key.Unit,
               MinPrice = g.Min(m => m.Price),
               MaxPrice = g.Max(m => m.Price),
               AveragePrice = g.Average(m => m.Price)
           })
           .ToList();
            listBox1.DataSource = _summaryList;
            listBox1.DisplayMember = "ProductName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                MarketSummary selectedSummary = _summaryList[listBox1.SelectedIndex];
                MessageBox.Show($"Product Name: {selectedSummary.ProductName}\nUnit: {selectedSummary.Unit}\nMin Price: {selectedSummary.MinPrice:C2}\nMax Price: {selectedSummary.MaxPrice:C2}\nAverage Price: {selectedSummary.AveragePrice:C2}");
            }
        }
    }
}
