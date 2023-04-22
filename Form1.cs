using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class StadiumSeating : Form
    {
        const double CLASS_A = 15;
        const double CLASS_B = 12;
        const double CLASS_C = 9;

        private double totalA = 0;
        private double totalB = 0;
        private double totalC = 0;
        private double total = 0;

        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void btnCalculateRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                totalA = double.Parse(tboxClassA.Text) * CLASS_A;
                lblOutputClassA.Text = totalA.ToString("c2");

                totalB = double.Parse(tboxClassB.Text) * CLASS_B;
                lblOutputClassB.Text = totalB.ToString("c2");

                totalC = double.Parse(tboxClassC.Text) * CLASS_C;
                lblOutputClassC.Text = totalC.ToString("c2");

                total = totalA + totalB + totalC;
                lblTotal.Text = total.ToString("c2");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            lblOutputClassA.Text = "";
            
            lblOutputClassB.Text = "";
            
            lblOutputClassC.Text = "";
            
            lblTotal.Text = "";

            tboxClassA.Text = "";
            tboxClassB.Text = "";
            tboxClassC.Text = "";

            tboxClassA.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
