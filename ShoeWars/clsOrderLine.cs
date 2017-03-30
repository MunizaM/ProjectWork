using System;

namespace ShoeWars
{
    public class clsOrderLine
    {
        public String OrderID { get; set; }
        public int OrderLineID { get; set; }
        public String ProductID { get; set; }

        public bool Valid(String someOrder)
        {
            //if the number of the Order is not blank 
            if (someOrder != "") 
            {
                //return true
                return true;
            }

                //otherwise return false
            else
            {
                //return false
                return false;
            }
        }
    }
}