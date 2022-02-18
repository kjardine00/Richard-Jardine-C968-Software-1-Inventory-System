using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richard_Jardine_C968
{
    public class Product
    {
        public static BindingList<Part> AssociatedParts = new();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int pID, string pName, decimal pPrice, int pInStock, int pMin, int pMax, BindingList<Part> prodPartsList)
        {
            ProductID = pID;
            Name = pName;
            Price = pPrice;
            InStock = pInStock;
            Min = pMin;
            Max = pMax;
            AssociatedParts = prodPartsList;
        }

        public static BindingList<Part> GetProdList(Product product)
        {
            return Product.AssociatedParts;
        }

        public static void AddAssociatedPart(Part newAssociatedPart)
        {
            AssociatedParts.Add(newAssociatedPart);
        }

        public static bool RemoveAssociatedPart(int associatedPartIDToBeRemoved)
        {
            foreach (Part oldPart in AssociatedParts)
            {
                if (oldPart.PartID == associatedPartIDToBeRemoved)
                {
                    AssociatedParts.Remove(oldPart);
                    return true;
                }
                else
                {
                    break;
                }
            }
            return false;
        }

        public static Part LookupAssociatedPart(int associatedPartToBeFound)
        {
            foreach (Part partSearched in AssociatedParts)
            {
                if (associatedPartToBeFound == partSearched.PartID)
                {
                    return partSearched;
                }
                else
                {

                }
            }
            return null;
        }
    }
}
