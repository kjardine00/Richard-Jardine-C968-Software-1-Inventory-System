using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richard_Jardine_C968
{
    public partial class PartAddForm : Form
    {
        public PartAddForm()
        {
            InitializeComponent();
            PartAddInHouseRadio.Select();
            PartAddIDText.Text = (Inventory.partCount).ToString();
        }

        private void PartAddInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            InhouseOutsourcedLabel.Text = "Machine ID";
        }

        private void PartAddOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            InhouseOutsourcedLabel.Text = "Company Name";
        }

        
        private void PartAddSaveBtn_Click(object sender, EventArgs e)
        {


            int pID = int.Parse(PartAddIDText.Text);
            string pName = PartAddNameText.Text;
            decimal pPrice;
            int pInventory;
            int pMin;
            int pMax;
            int pMachineID;

            try
            {
                pPrice = decimal.Parse(PartAddPriceCostText.Text);
                pInventory = int.Parse(PartAddInventoryText.Text);
                pMin = int.Parse(PartAddMinText.Text);
                pMax = int.Parse(PartAddMaxText.Text);
                PartAddPriceCostText.BackColor = Color.White;
                PartAddInventoryText.BackColor = Color.White;
                PartAddMinText.BackColor = Color.White;
                PartAddMaxText.BackColor = Color.White;
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must all be numeric values.");
                PartAddPriceCostText.BackColor = Color.Salmon;
                PartAddInventoryText.BackColor = Color.Salmon;
                PartAddMinText.BackColor = Color.Salmon;
                PartAddMaxText.BackColor = Color.Salmon;
                return;
            }

            if (pInventory < pMin && pMax > pInventory)
            {
                MessageBox.Show("The specified Inventory amount does not fit within the Minimum and Maximum");
                return;
            }

            if (pMax < pMin)
            {
                MessageBox.Show("The Minimum cannot be exceed the Maximum.");
                return;
            }

            if (PartAddInHouseRadio.Checked == true)
            {
                try
                {
                    pMachineID = int.Parse(PartAddMachineIDText.Text);
                    PartAddMachineIDText.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Error: Machine ID text field must a be numeric values.");
                    PartAddMachineIDText.BackColor = Color.Salmon;
                    return;
                }

                InhousePart inhouse = new(pID, pName, pPrice, pInventory, pMin, pMax, pMachineID);
                Inventory.AddPart(inhouse);
            }
            else
            {
                string pCompName = PartAddMachineIDText.Text;

                OutsourcedPart outsourced = new(pID, pName, pPrice, pInventory, pMin, pMax, pCompName);

                Inventory.AddPart(outsourced);
            }
            this.Close();
        }
        
            private void PartAddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}