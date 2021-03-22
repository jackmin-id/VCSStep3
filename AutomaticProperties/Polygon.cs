using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomaticProperties
{
    class Polygon
    {
        int numSides;
        public int NumSides
        {   get
            {
                return numSides;
            }

            set
            {
                numSides = value;
            }
     }
        public double SideLength { get; set; }

        public Polygon()
        {
            this.NumSides = 4;
            this.SideLength = 10.0;
        }
    }

    public class Dummy
    {
        public const string OfficialName = "The Very Big Corporation";

        public string CompanyName { get; } = OfficialName;

        private string _regCode;

        public string RegCode { get; set; }
            /*
        {
            get { return _regCode; }
            set { _regCode = value; }
        }*/

        public string DisplayName
        {
           // get { return CompanyName + ": " + _regCode; }
            get { return CompanyName + ": " + RegCode; }
            set { }
        }
    }
}
