using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_1
{
    public class WindowDialog : Dialog
    {
        public WindowDialog(Button? btn) : base(btn)
        {
        }

        public override Button creatButton()
        {
            return new Windows();
        }
    }
}
