using MVC.View;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class TipController
    {
        private Tip tipController = new Tip();
        private Display display = new Display();
        public TipController()
        {
            display.Input();
            tipController.SumAmount = (float)display.Amount;
            tipController.Percent = (float)display.Percent;
            display.TipAmount = tipController.SumTip();
            display.Total = tipController.SumTotal();
            display.Output();
        }
    }
}
