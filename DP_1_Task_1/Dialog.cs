using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_1
{
    public abstract class Dialog
    {

        protected Button? btn { get; set; }

        protected Dialog(Button? btn)
        {
            this.btn = btn;
        }


        public void render()
        {
            btn!.render();
        }

        public abstract Button creatButton();

    }
}
