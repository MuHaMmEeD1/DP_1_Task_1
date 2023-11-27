using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_1
{
    public class WebDialog : Dialog
    {
        public WebDialog(Button? btn) : base(btn)
        {
        }

        public override Button creatButton()
        {
            return new Web();
        }
    }
}
