using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhoneDevice
{
    class Display
    {
        private string displaySize;
        private string numOfColor;

        public string NumOfColor
        {
            get { return numOfColor; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid or empty numbers of Colors value");
                }
                numOfColor = value; 
            }
        }
        
        public string DisplaySize
        {
            get { return displaySize; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid or empty display size value");
                }
                displaySize = value; 
            }
        }
        public Display()
        { 
        }
        public Display(string numOfColors, string displaySize)
        {
            this.numOfColor = numOfColors;
            this.displaySize = displaySize;

        }
    }
}
