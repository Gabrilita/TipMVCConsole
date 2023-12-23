using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipMVCConsole.Model;
using TipMVCConsole.View;

namespace TipMVCConsole.Controllers
{
    class TipController
    {
        Tip myTip = new Tip();
        Display myDisplay = new Display();

        public TipController()
        {
            //prehvurlqm ot Display ---> Tip
            myDisplay.Imput();
            myTip.Amount = myDisplay.Amount;
            myTip.Percent = myDisplay.Percent;
            //Calculate
            myDisplay.Tip= myTip.CalculateTip();
            myDisplay.Total= myTip.CalculateTotal();

            myDisplay.Output();

        }
    }
}
