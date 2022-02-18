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
    public partial class ProductModify : Form
    {
        public ProductModify(Product productToModify)
        {
            InitializeComponent();

            BindingSource candPartBindingSource = new BindingSource();
            candPartBindingSource.DataSource = Inventory.AllParts;
            ProductModifyCandPartsGridView.DataSource = candPartBindingSource;

            BindingSource associatedPartBindingSource = new BindingSource();
            associatedPartBindingSource.DataSource = Product.AssociatedParts;
            ProductModifyPartsAssocGridView.DataSource = associatedPartBindingSource;

            ProductModifyIDText.Text = productToModify.ProductID.ToString();
            ProductModifyNameText.Text = productToModify.Name;
            ProductModifyPriceText.Text = productToModify.Price.ToString();
            ProductModifyInventoryText.Text = productToModify.InStock.ToString();
            ProductModifyMinText.Text = productToModify.Min.ToString();
            ProductModifyMaxText.Text = productToModify.Max.ToString();
        }

        private void ProductModifyAddBtn_Click(object sender, EventArgs e)
        {
            Part newAssociatedPart = (Part)ProductModifyCandPartsGridView.CurrentRow.DataBoundItem;
            Product.AssociatedParts.Add(newAssociatedPart);
        }

        private void ProductModifySaveBtn_Click(object sender, EventArgs e)
        {
            int prodID = int.Parse(ProductModifyIDText.Text);
            string prodName = ProductModifyNameText.Text;
            decimal prodPrice;
            int prodInventory;
            int prodMin;
            int prodMax;

            try
            {
                prodPrice = decimal.Parse(ProductModifyPriceText.Text);
                prodInventory = int.Parse(ProductModifyInventoryText.Text);
                prodMin = int.Parse(ProductModifyMinText.Text);
                prodMax = int.Parse(ProductModifyMaxText.Text);
                ProductModifyPriceText.BackColor = Color.White;
                ProductModifyInventoryText.BackColor = Color.White;
                ProductModifyMinText.BackColor = Color.White;
                ProductModifyMaxText.BackColor = Color.White;
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must all be numeric values.");
                ProductModifyPriceText.BackColor = Color.Salmon;
                ProductModifyInventoryText.BackColor = Color.Salmon;
                ProductModifyMinText.BackColor = Color.Salmon;
                ProductModifyMaxText.BackColor = Color.Salmon;
                return;
            }

            if (prodInventory < prodMin && prodMax > prodInventory)
            {
                MessageBox.Show("The specified Inventory amount does not fit within the Minimum and Maximum");
                return;
            }

            if (prodMax < prodMin)
            {
                MessageBox.Show("The Minimum cannot be exceed the Maximum.");
                return;
            }

            Product updatedProduct = new(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax, Product.AssociatedParts);
            Inventory.UpdateProduct(prodID, updatedProduct);

            this.Close();
        }

        private void ProductModifyDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Product.AssociatedParts.Any())
            {
                DialogResult removeAssociatedPartDialogResult = MessageBox.Show("Are you sure you would like to delete this Part?", "Delete Part", MessageBoxButtons.YesNo);

                if (removeAssociatedPartDialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in ProductModifyPartsAssocGridView.SelectedRows)
                    {
                        Part selectedPartAssociated = row.DataBoundItem as Part;
                        Product.RemoveAssociatedPart(selectedPartAssociated.PartID);
                    }
                }
            }
        }

        private void ProductModifySearchBtn_Click(object sender, EventArgs e)
        {
            int searchedPart = int.Parse(ProductModifySearchText.Text);

            if (Product.LookupAssociatedPart(searchedPart) != null)
            {
                ProductModifyPartsAssocGridView.ClearSelection();
                int index = Product.AssociatedParts.IndexOf(Product.LookupAssociatedPart(searchedPart));
                ProductModifyPartsAssocGridView.Rows[index].Selected = true;
                ProductModifyPartsAssocGridView.DefaultCellStyle.SelectionBackColor = Color.Green;
            }
            else
            {
                string errorMessage = "Could not find Part " + ProductModifySearchText.Text + ".";
                MessageBox.Show(errorMessage, "Not Found");
            }
        }
        private void ProductModifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
