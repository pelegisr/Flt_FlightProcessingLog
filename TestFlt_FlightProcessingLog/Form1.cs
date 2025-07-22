using System;
using System.Windows.Forms;

namespace TestFlt_FlightProcessingLog
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peleg.Flt_FlightProcessingLog.Manager manager = new Peleg.Flt_FlightProcessingLog.Manager();

            var cs = uPanel.Connection.SqlConnectionString;
            var task = "n/a";
            manager.Run(ref cs, ref task);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
            Close();
        }
    }
}
