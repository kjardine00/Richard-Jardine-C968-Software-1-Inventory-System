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
    public partial class MainScreen : Form
    {
        BindingSource partbindingsource = new BindingSource();
        BindingSource prodBindingSource = new BindingSource();

        public MainScreen()
        {
            InitializeComponent();

            //Uncomment method Inventory.LoadFakeData() to test functionality with a pre-loaded data set. MAKE SURE to also uncomment Inventory.cs > Lines 19 - 61.
            //Inventory.LoadFakeData(); 
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            prodBindingSource.DataSource = Inventory.AllProducts;
            ProductsDataGridView.DataSource = prodBindingSource;
            ProductsDataGridView.Columns[4].Visible = false;
            ProductsDataGridView.Columns[5].Visible = false;
            
            partbindingsource.DataSource = Inventory.AllParts;
            PartsDataGridView.DataSource = partbindingsource;
            PartsDataGridView.Columns[4].Visible = false;
            PartsDataGridView.Columns[5].Visible = false;
        }

        public void MainScreenPartsAddBtn_Click(object sender, EventArgs e)
        {
            new PartAddForm().ShowDialog();
        }

        private void MainScreenPartsModifyBtn_Click(object sender, EventArgs e)
        {
            if (PartsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Richard_Jardine_C968.InhousePart))
            {
                InhousePart inHousePart = (InhousePart)PartsDataGridView.CurrentRow.DataBoundItem;
                new PartModify(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)PartsDataGridView.CurrentRow.DataBoundItem;
                new PartModify(outsourcedPart).ShowDialog();
            }

            PartsDataGridView.DataSource = null;
            PartsDataGridView.DataSource = partbindingsource;
        }

        private void MainScreenPartsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Any())
            {
                DialogResult deletePartDialogResult = MessageBox.Show("Are you sure you would like to delete this Part?", "Delete Part", MessageBoxButtons.YesNo);

                if(deletePartDialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in PartsDataGridView.SelectedRows)
                    {
                        Part partToBeDeleted = row.DataBoundItem as Part;
                        Inventory.deletePart(partToBeDeleted);
                    }
                }
                else
                {
                    // do nothing
                }
            }
        }

        private void MainScreenPartsSearchBtn_Click(object sender, EventArgs e)
        {
            int searchedPart = int.Parse(MainScreenPartsTextSearch.Text);

            if (Inventory.LookupPart(searchedPart) != null)
            {
                PartsDataGridView.ClearSelection();
                int index = Inventory.AllParts.IndexOf(Inventory.LookupPart(searchedPart));
                PartsDataGridView.Rows[index].Selected = true;
                PartsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Green;
                MainScreenPartsTextSearch.BackColor = Color.White;
            }
            else
            {
                string errorMessage = "Could not find Part " + MainScreenPartsTextSearch.Text + ".";
                MessageBox.Show(errorMessage, "Not Found");
                MainScreenPartsTextSearch.BackColor = Color.Salmon;
            }
        }

        private void MainScreenProductsAddBtn_Click(object sender, EventArgs e)
        { 
            new ProductAdd().ShowDialog();
        }

        private void MainScreenProductsModifyBtn_Click(object sender, EventArgs e)
        {
            Product prodModify = (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            new ProductModify(prodModify).ShowDialog();

            ProductsDataGridView.DataSource = null;
            ProductsDataGridView.DataSource = prodBindingSource;
        }

        private void MainScreenProductsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Inventory.AllProducts.Any())
            {
                DialogResult deleteProductDialogResult = MessageBox.Show("Are you sure you would like to delete this Product?", "Delete Part", MessageBoxButtons.YesNo);

                if (deleteProductDialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in ProductsDataGridView.SelectedRows)
                    {
                        Product productToBeDeleted = row.DataBoundItem as Product;
                        var prodList = Product.GetProdList(productToBeDeleted);

                        if (prodList.Any())
                        {
                            MessageBox.Show("Error: The Product you seleceted has associated Parts and could not be deleted.", "Error: Could Not Be Deleted.");
                        }
                        else
                        {
                            Inventory.RemoveProduct(productToBeDeleted.ProductID);
                        }
                    }
                }
                else
                {
                    // do nothing
                }
            }
        }

        private void MainScreenProductsSearchBtn_Click(object sender, EventArgs e)
        {
            int searchedProduct = int.Parse(MainScreenProductsSearchText.Text);

            if (Inventory.LookupProduct(searchedProduct) != null)
            {
                ProductsDataGridView.ClearSelection();
                int index = Inventory.AllProducts.IndexOf(Inventory.LookupProduct(searchedProduct));
                ProductsDataGridView.Rows[index].Selected = true;
                ProductsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Green;
                MainScreenProductsSearchText.BackColor = Color.White;
            }
            else
            {
                string errorMessage = "Could not find Product " + MainScreenProductsSearchText.Text + ".";
                MessageBox.Show(errorMessage, "Not Found");
                MainScreenProductsSearchText.BackColor = Color.Salmon;
            }
        }

        private void MainScreenProductsSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainScreenExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
