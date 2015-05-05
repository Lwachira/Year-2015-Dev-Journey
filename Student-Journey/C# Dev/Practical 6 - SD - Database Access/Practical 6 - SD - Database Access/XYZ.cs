using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6___SD___Database_Access
{
    class XYZ
    {
        string prodNum;
        string prodDesc;
        double prodCost;
        string prodCat;

        public string ProdNum
        {
            get { return prodNum; }
            set { prodNum = value; }
        }

        public string ProdDesc
        {
            get
            {
                return prodDesc;
            }

            set { prodDesc = value; }
        }

        public double ProdCost
        {
            get { return prodCost; }
            set { prodCost = value; }
        }

        public string ProdCat
        {
            get { return prodCat; }
            set { prodCat = value; }
        }

        public XYZ(string ProdDesc)
        {

            prodDesc = ProdDesc;
        }

    

        public XYZ(string ProdNum, string ProdDesc, double ProdCost, string ProdCat)
        {
            prodNum = ProdNum;
            prodDesc = ProdDesc;
            prodCost = ProdCost;

            prodCat = ProdCat;
        }

        public override string ToString()
        {
            return "Product Number: " + prodNum + "Product Description: " + prodDesc + "Product Cost: " + ProdCost + "Product Category: " + ProdCat;
        }

    }


}
