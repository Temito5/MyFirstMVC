using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class TipController
    {
            Display myDisp = new Display();
            Tip myTip = new Tip();
        public TipController()
        {
            myDisp.Input(); 
            myTip.Amount= myDisp.Amount;
            myTip.Percent= myDisp.Percent;
            myDisp.TipSum = myTip.CalculateTip();
            myDisp.TotalSum = myTip.CalculateTotal();
            myDisp.Output();

        }
    }
}
