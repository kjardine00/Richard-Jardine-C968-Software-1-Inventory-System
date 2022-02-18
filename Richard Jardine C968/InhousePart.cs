using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard_Jardine_C968
{
    public class InhousePart : Part
    {
        public int MachineID { get; set; }
        
        public InhousePart(int pID, string pName, decimal pPrice, int pInStock, int pMin, int pMax, int pMachineID)
        {
            PartID = pID;
            Name = pName;
            Price = pPrice;
            InStock = pInStock;
            Min = pMin;
            Max = pMax;
            MachineID = pMachineID;
        }
    }
}
