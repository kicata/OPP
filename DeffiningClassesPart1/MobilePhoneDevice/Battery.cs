using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhoneDevice
{
    public enum BatteryType
    {
        
        LiION,
        NiMH,
        NiCd,
        PernikPower
    
    }
    class Battery
    {
        private string battModel;
        private double hoursIdle;
        private double hoursTalk;

        public double HoursTalk
        {
            get { return hoursTalk; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("The value must be > 0  ");
                } 
                hoursTalk = value; }
        }
        

        public double HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The value must be > 0  ");
                } 
                hoursIdle = value; 
            }
        }
        

        public string BattModel
        {
            get { return battModel; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Battery Model");
                }
                battModel = value; 
            }
        }

        public Battery()
        { 
        }
        public Battery(string battModel,double hoursIdle, double hoursTalk)
        {
            this.battModel = battModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        
    }
}
