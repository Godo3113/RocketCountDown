using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountDownReference;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int value, count;
            var countStart = Int32.TryParse(txtStart.Text, out value) ? value : 0;
            count = countStart;

            try
            {
                CountDownReference.CountDownServiceClient client = new CountDownReference.CountDownServiceClient();

                while (count > 0)
                {
                    count = client.Count(countStart);
                    lblCount.Text = count.ToString();
                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (CountDownException)
            {
            }
        } 
    }

    public class CountDownException : Exception
    {
        public CountDownException()
        {

        }
        public CountDownException(String msg) : base(String.Format("Invalid start number: {0}", msg))
        {

        }

    }
}
