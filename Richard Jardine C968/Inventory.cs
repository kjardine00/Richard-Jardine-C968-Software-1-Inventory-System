using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richard_Jardine_C968
{
    class Inventory
    {
        public static BindingList<Product> AllProducts = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static int partCount = 1;
        public static int productCount = 1;

        // Uncomment method LoadFakeData() to test functionality with a pre-loaded data set. MAKE SURE to also uncomment MainScreen.cs > Line 18.
        //public static void LoadFakeData() 
        //{
        //    Part partData1A = new InhousePart(1, "Part A1", 1.00m, 1, 1, 1, 1001);
        //    Part partData1B = new InhousePart(2, "Part A2", 2.00m, 2, 2, 2, 2002);
        //    Part partData2A = new InhousePart(3, "Part B1", 3.00m, 3, 3, 3, 3003);
        //    Part partData2B = new InhousePart(4, "Part B2", 4.00m, 4, 4, 4, 4004);
        //    Part partData3A = new OutsourcedPart(5, "Part 3A", 5.00m, 5, 5, 5, "New Company");
        //    Part partData3B = new OutsourcedPart(6, "Part 3B", 6.00m, 6, 6, 6, "New Company");
        //    Part partData4A = new OutsourcedPart(7, "Part 4A", 7.00m, 7, 7, 7, "Old Company");
        //    Part partData4B = new OutsourcedPart(8, "Part 4B", 8.00m, 8, 8, 8, "Old Company");

        //    AddPart(partData1A);
        //    AddPart(partData1B);
        //    AddPart(partData2A);
        //    AddPart(partData2B);
        //    AddPart(partData3A);
        //    AddPart(partData3B);
        //    AddPart(partData4A);
        //    AddPart(partData4B);

        //    BindingList<Part> associatedListofParts1;
        //    associatedListofParts1 = new BindingList<Part>();
        //    BindingList<Part> associatedListofParts2;
        //    associatedListofParts2 = new BindingList<Part>();
        //    BindingList<Part> associatedListofParts3;
        //    associatedListofParts3 = new BindingList<Part>();
        //    BindingList<Part> associatedListofParts4;
        //    associatedListofParts4 = new BindingList<Part>();

        //    associatedListofParts1.Add(partData1B);
        //    associatedListofParts2.Add(partData2A);
        //    associatedListofParts3.Add(partData1B);
        //    associatedListofParts4.Add(partData1B);

        //    Product prodData1 = new(1, "Product A", 1.00M, 1, 1, 1, associatedListofParts1);
        //    Product prodData2 = new(2, "Product B", 2.00M, 2, 2, 2, associatedListofParts2);
        //    Product prodData3 = new(3, "Product C", 3.00M, 3, 3, 3, associatedListofParts3);
        //    Product prodData4 = new(4, "Product D", 4.00M, 4, 4, 4, associatedListofParts4);

        //    AddProduct(prodData1);
        //    AddProduct(prodData2);
        //    AddProduct(prodData3);
        //    AddProduct(prodData4);
        //}

        public static void AddProduct(Product prodToBeAdded)
        {
            productCount++;
            AllProducts.Add(prodToBeAdded);
            
        }

        public static bool RemoveProduct(int prodToBeRemoved)
        {
            foreach (Product oldProduct in AllProducts)
            {
                if (oldProduct.ProductID == prodToBeRemoved)
                {
                    AllProducts.Remove(oldProduct);
                    return true;
                }
                else
                {
                    break;
                }
            }
            return false;
        }

        public static Product LookupProduct(int prodToBeFound)
        {
            foreach(Product productSearched in AllProducts)
            {
                if (prodToBeFound == productSearched.ProductID)
                {
                    return productSearched;
                }
                else
                {

                }
            }
            return null;
        }

        public static void UpdateProduct (int prodIDToBeUpdated, Product prodToBeUpdated)
        {
            foreach (Product oldProd in AllProducts)
            {
                if (oldProd.ProductID == prodIDToBeUpdated)
                {
                    oldProd.Name = prodToBeUpdated.Name;
                    oldProd.Price = prodToBeUpdated.Price;
                    oldProd.InStock = prodToBeUpdated.InStock;
                    oldProd.Min = prodToBeUpdated.Min;
                    oldProd.Max = prodToBeUpdated.Max;
                }
            }
        }

        public static void AddPart (Part newPart)
        {
            partCount++; 
            AllParts.Add(newPart);
        }

        public static bool deletePart (Part partToBeDeleted)
        {
            if (partToBeDeleted != null)
            {
                AllParts.Remove(partToBeDeleted);
                return true;
            }
            else
            {
                MessageBox.Show("The Part you selected could not be deleted.");
                return false;
            }
        }

        public static Part LookupPart(int partToBeFound)
        {
            foreach (Part partSearched in AllParts)
            {
                if (partToBeFound == partSearched.PartID)
                {
                    return partSearched;
                }
                else
                {
                    
                }
            }
            return null;
        }

        public static void UpdatePart(int partIDToBeUpdated, Part partToBeUpdated)
        {
            foreach (Part oldPart in AllParts)
            {
                if (oldPart.PartID == partIDToBeUpdated)
                {
                    oldPart.Name = partToBeUpdated.Name;
                    oldPart.Price = partToBeUpdated.Price;
                    oldPart.InStock = partToBeUpdated.InStock;
                    oldPart.Min = partToBeUpdated.Min;
                    oldPart.Max = partToBeUpdated.Max;

                    return;
                }
            }
        }
    }
}


