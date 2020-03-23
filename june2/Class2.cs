using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Sem2_2019
{
    class ElectricBike : Bike
    {
        private int _power;
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }
        public ElectricBike()
        {

        }
        public ElectricBike(int value)
        {

            _power = 200;
        }

        public ElectricBike(string brand, double price, int bp) : base(brand, price)
        {

            _power = bp;
        }

        public override double CalcDeposit()
        {
            return Price * 0.30;

        }
        public override string ToString()
        {
            return "Brand : " + Brand + " Price : " + Price + " Power : " + Power + "Frame # : " + FrameNumber + " Deposit " + CalcDeposit();
            //or
            //return base.ToString() + " Power : " + Power;
        }
    }

}