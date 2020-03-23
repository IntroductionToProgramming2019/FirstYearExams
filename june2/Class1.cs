using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Sem2_2019
{
    class Bike
    {
        private string _brand;
        private double _price;
        private int _frameNumber;

        static public int frameNumber;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int FrameNumber
        {
            get
            {
                return _frameNumber;
            }
            set
            {
                _frameNumber = value;
            }

        }

        public Bike()
        {
            frameNumber++;
            FrameNumber = frameNumber;
        }

        public Bike(string b, double p)
        {
            Brand = b;
            Price = p;
            frameNumber++;
            FrameNumber = frameNumber;

        }
        public override string ToString()
        {
            return "Brand: " + Brand + "  Price:" + Price + " Frame # : " + FrameNumber;
        }


        public virtual double CalcDeposit()
        {
            return Price * 0.30;
        }
    }
}