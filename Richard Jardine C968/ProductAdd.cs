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
    public partial class ProductAdd : Form
    {
        public BindingList<Part> newPartsAssociated = new BindingList<Part>();
        public ProductAdd()
        {
            InitializeComponent();
            ProductAddIDText.Text = (Inventory.productCount).ToString();
        }
        private void ProductAdd_Load(object sender, EventArgs e)
        {
            BindingSource candPartBindingSource = new BindingSource();
            candPartBindingSource.DataSource = Inventory.AllParts;
            ProductAddCandPartsGridView.DataSource = candPartBindingSource;

            BindingSource associatedPartBindingSource = new BindingSource();
            associatedPartBindingSource.DataSource = newPartsAssociated;
            ProductAddPartsAssocGridView.DataSource = associatedPartBindingSource;
        }

        private void ProductAddAddBtn_Click(object sender, EventArgs e)
        {
            Part newAssociatedPart = (Part)ProductAddCandPartsGridView.CurrentRow.DataBoundItem;
            newPartsAssociated.Add(newAssociatedPart);
        }

        private void ProductAddSaveBtn_Click(object sender, EventArgs e)
        {
            int prodID = int.Parse(ProductAddIDText.Text);
            string prodName = ProductAddNameText.Text;
            decimal prodPrice;
            int prodInventory;
            int prodMax;
            int prodMin;
            BindingList<Part> prodAssociatedParts = newPartsAssociated;

            try
            {
                prodPrice = int.Parse(ProductAddPriceText.Text);
                prodInventory = int.Parse(ProductAddInventoryText.Text);
                prodMax = int.Parse(ProductAddMaxText.Text);
                prodMin = int.Parse(ProductAddMinText.Text);
                ProductAddPriceText.BackColor = Color.White;
                ProductAddInventoryText.BackColor = Color.White;
                ProductAddMaxText.BackColor = Color.White;
                ProductAddMinText.BackColor = Color.White;
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must all be numeric values.");
                ProductAddPriceText.BackColor = Color.Salmon;
                ProductAddInventoryText.BackColor = Color.Salmon;
                ProductAddMaxText.BackColor = Color.Salmon;
                ProductAddMinText.BackColor = Color.Salmon;
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
            
            foreach (Part newPart in newPartsAssociated)
            {
                Product.AddAssociatedPart(newPart);
            }

            Product newProduct = new(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax, newPartsAssociated);
            Inventory.AddProduct(newProduct);

            this.Close();
        }

        private void ProductAddDeleteBtn_Click(object sender, EventArgs e)
        {
            if (newPartsAssociated.Any())
            {
                DialogResult removeAssociatedPartDialogResult = MessageBox.Show("Are you sure you would like to delete this Part?", "Delete Part", MessageBoxButtons.YesNo);

                if (removeAssociatedPartDialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in ProductAddPartsAssocGridView.SelectedRows)
                    {
                        Part selectedPartAssociated = row.DataBoundItem as Part;
                        newPartsAssociated.Remove(selectedPartAssociated);
                    }
                }
            }
        }

        private void ProductAddSearchBtn_Click(object sender, EventArgs e)
        {
            int searchedPart = int.Parse(ProductAddSearchText.Text);

            if (Product.LookupAssociatedPart(searchedPart) != null)
            {
                ProductAddPartsAssocGridView.ClearSelection();
                int index = Product.AssociatedParts.IndexOf(Product.LookupAssociatedPart(searchedPart));
                ProductAddPartsAssocGridView.Rows[index].Selected = true;
                ProductAddPartsAssocGridView.DefaultCellStyle.SelectionBackColor = Color.Green;
            }
            else
            {
                string errorMessage = "Could not find Part " + ProductAddSearchText.Text + ".";
                MessageBox.Show(errorMessage, "Not Found");
            }
        }

        private void ProductAddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
