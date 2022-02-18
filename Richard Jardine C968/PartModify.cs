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
    public partial class PartModify : Form
    {
        public PartModify(InhousePart partToBeUpdated)  
        {
            InitializeComponent();

            PartModifyInHouseRadio.Select();
            PartModifyMachineID.Text = "Machine ID";

            PartModifyIDText.Text = partToBeUpdated.PartID.ToString();
            PartModifyNameText.Text = partToBeUpdated.Name;
            PartModifyPriceCostText.Text = partToBeUpdated.Price.ToString();
            PartModifyInventoryText.Text = partToBeUpdated.InStock.ToString();
            PartModifyMinText.Text = partToBeUpdated.Min.ToString();
            PartModifyMaxText.Text = partToBeUpdated.Max.ToString();
            PartModifyMachineIDText.Text = partToBeUpdated.MachineID.ToString();
        }

        public PartModify(OutsourcedPart partToBeUpdated)  
        {
            InitializeComponent();

            PartModifyInHouseRadio.Select();
            PartModifyMachineID.Text = "Machine ID";

            PartModifyIDText.Text = partToBeUpdated.PartID.ToString();
            PartModifyNameText.Text = partToBeUpdated.Name;
            PartModifyPriceCostText.Text = partToBeUpdated.Price.ToString();
            PartModifyInventoryText.Text = partToBeUpdated.InStock.ToString();
            PartModifyMinText.Text = partToBeUpdated.Min.ToString();
            PartModifyMaxText.Text = partToBeUpdated.Max.ToString();
            PartModifyMachineIDText.Text = partToBeUpdated.MachineID.ToString();
        }
    
        private void PartModifyInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartModifyMachineID.Text = "Machine ID";
        }

        private void PartModifyOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartModifyMachineID.Text = "Company ID";
        }

        private void PartModifySaveBtn_Click(object sender, EventArgs e)
        {
            int pID = int.Parse(PartModifyIDText.Text);
            string pName = PartModifyNameText.Text;
            decimal pPrice;
            int pInventory;
            int pMin;
            int pMax;
            int pMachineID;

            try
            {
                pPrice = decimal.Parse(PartModifyPriceCostText.Text);
                pInventory = int.Parse(PartModifyInventoryText.Text);
                pMin = int.Parse(PartModifyMinText.Text);
                pMax = int.Parse(PartModifyMaxText.Text);
                PartModifyPriceCostText.BackColor = Color.White;
                PartModifyInventoryText.BackColor = Color.White;
                PartModifyMinText.BackColor = Color.White;
                PartModifyMaxText.BackColor = Color.White;
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must all be numeric values.");
                PartModifyPriceCostText.BackColor = Color.Salmon;
                PartModifyInventoryText.BackColor = Color.Salmon;
                PartModifyMinText.BackColor = Color.Salmon;
                PartModifyMaxText.BackColor = Color.Salmon;
                return;
            }

            if (pInventory < pMin && pMax > pInventory)
            {
                MessageBox.Show("The specified Inventory amount does not fit within the Minimum and Maximum");
                return;
            }

            if (pMin > pMax)
            {
                MessageBox.Show("The Minimum cannot be exceed the Maximum.");
                return;
            }

            if (PartModifyInHouseRadio.Checked == true)
            {
                try
                {
                    pMachineID = int.Parse(PartModifyMachineIDText.Text); 
                    PartModifyMachineIDText.BackColor = Color.White;
                }
                catch
                {
                    MessageBox.Show("Error: Machine ID text field must a be numeric values.");
                    PartModifyMachineIDText.BackColor = Color.Salmon;
                    return;
                }
                InhousePart inhouse = new(pID, pName, pPrice, pInventory, pMin, pMax, pMachineID);

                Inventory.UpdatePart(pID, inhouse);
            }
            else
            {
                string pCompName = PartModifyMachineIDText.Text;

                OutsourcedPart outsourced = new(pID, pName, pPrice, pInventory, pMin, pMax, pCompName);

                Inventory.UpdatePart(pID, outsourced);
            }

            this.Close();
        }

        private void PartModifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
