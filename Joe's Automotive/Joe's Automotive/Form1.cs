using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class JoeAutomotive : Form
    {
        public JoeAutomotive()
        {
            InitializeComponent();
        }
        
        private double OilLubeCharges()
        {
            double oil = 0;
            double lube = 0;
            double total = 0;

            if (oilChangeCB.Checked)
            {
                oil = 26;
                total = oil + lube;
            }

            if (lubeJobCB.Checked)
            {
                //oil = 0;
                lube = 18;
                total = oil + lube;
            }

            return total;
        }

        private double FlushCharges()
        {
            double radiator = 0;
            double transmission = 0;
            double total = 0;

            if (radiatorCB.Checked)
            {
                radiator = 30;
                total = radiator  + transmission;
            }

            if (transmissionCB.Checked)
            {
                transmission = 80;
                total = radiator + transmission;
            }

            return total;
        }

        private double MiscCharges()
        {
            double inspection = 0;
            double muffler = 0;
            double tire = 0;
            double total = 0;

            if (inspectionCB.Checked)
            {
                inspection = 15;
                total = inspection + muffler + tire;
            }

            if (mufflerCB.Checked)
            {
                muffler = 100;
                total = total = inspection + muffler + tire;
            }

            if (tireCB.Checked)
            {
                tire = 20;
                total = inspection + muffler + tire;
            }

            return total;
        }

        private double OtherCharges()
        {
            double parts;
            double labor;
            const double rate = 20;
            //double totalP;
            double total = 0;

            if (double.TryParse(partsTxt.Text, out parts))
            {
                total = parts * rate;

                partsALbl.Text = total.ToString("c");
            }

            else
            {
                MessageBox.Show("Invalid input. Please enter valid number for parts.");
            }

            if (double.TryParse(laborTxt.Text, out labor))
            {
                total = labor * rate;
            }

            else
            {
                MessageBox.Show("Invalid input. Please enter valid number for parts.");
            }

            return total;
        }

        private double TaxCharges()
        {
           const double tax = 0.06;
           const double rate = 20;
           double totalP;
           double total = 0;
           double parts;

           parts = double.Parse(partsTxt.Text);
           totalP = rate * parts; 

           total = tax * totalP; 

           return total;
        }

        private void TotalCharges()
        {
            const double rate = 20;
            double totalOilLube;
            double totalFlush;
            double totalMisc;
            double totalServices = 0;
            double totalLabor;
            double totalTax;
            double grandTotal;
            double totalParts;
            double parts;

            parts = double.Parse(partsTxt.Text);
            totalParts = rate * parts;

            totalOilLube = OilLubeCharges();
            totalFlush = FlushCharges();
            totalMisc = MiscCharges();
            totalLabor = OtherCharges();
            totalTax = TaxCharges();

            totalServices += OilLubeCharges();
            totalServices += FlushCharges();
            totalServices += MiscCharges();
            totalServices += OtherCharges();

            grandTotal = totalTax + totalServices + totalParts;

            serviceALbl.Text = totalServices.ToString("c");
            taxALbl.Text = totalTax.ToString("c");
            totalALbl.Text = grandTotal.ToString("c");
        }

        private void ClearOilLube()
        {
            oilChangeCB.Checked = false;
            lubeJobCB.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorCB.Checked = false;
            transmissionCB.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCB.Checked = false;
            mufflerCB.Checked = false;
            tireCB.Checked = false;
        }

        private void ClearOther()
        {
            partsTxt.Text = "";
            laborTxt.Text = "";
        }

        private void ClearFees()
        {
            totalALbl.Text = "";
            serviceALbl.Text = "";
            partsALbl.Text = "";
            taxALbl.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            TotalCharges();
            OtherCharges();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearMisc();
            ClearFlushes();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JoeAutomotive_Load(object sender, EventArgs e)
        {
            partsTxt.Text = "0";
            laborTxt.Text = "0";
        }
    }
}
