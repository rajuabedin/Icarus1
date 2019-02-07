using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icarus
{
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();

            List<string> date = new List<string>();
            List<int> saleNumber = new List<int>();
            string fileList = getCsvData("https://raw.githubusercontent.com/rajuAbedin/testadata/master/example.csv");
            string[] tempString;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            fileList = fileList.Replace(System.Environment.NewLine, ",");

            tempString = fileList.Split(delimiterChars);

            

            int arrayNumber = 0;

            foreach (var value in tempString)
            {
                if (arrayNumber == 0)
                {
                    date.Add(value);
                    arrayNumber = 1;
                }
                else
                {
                    saleNumber.Add(Int32.Parse(value));
                    arrayNumber = 0;
                }
            }
            Random random = new Random();
            for (int i = saleNumber.Count - 30; i < saleNumber.Count - 10; i++)
            {
                
                chart1.Series["Sales"].Points.AddXY(date[i], saleNumber[i]);
            }
            for (int i = saleNumber.Count - 30; i < saleNumber.Count; i++)
            {
                chart1.Series["Prediction"].Points.AddXY(date[i], saleNumber[i] - random.Next(-5, 5));
            }




        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string getCsvData(string url)
        {
            string csv;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());

            csv = streamReader.ReadToEnd();
            streamReader.Close();
            return csv;
        }
    }
}
