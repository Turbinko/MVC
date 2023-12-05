using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Tip
    {
        private float sumAmount;
        private float percent;

        public float Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    percent = value / 100.0f;
                }
                else
                {
                    percent = value;
                }
            }
        }
        public float SumAmount
        {
            get { return sumAmount; }
            set { sumAmount = value; }
        }
        public Tip(float _sumAmount, float _percent)
        {
            SumAmount = _sumAmount;
            Percent = _percent;
        }
        public Tip():this(0,0)
        {

        }
        public double SumTip()
        {
            return SumAmount * Percent;
        }
        public double SumTotal()
        {
            return SumTip() + SumAmount;
        }
    }
}
