using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutOfClassAssignment4
{
    class ttt_Button : Button
    {
        public static int Btn_Size = 100;

        public ttt_Button()
        {
            this.Width = this.Height = Btn_Size;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Text = "*";
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Consolas", 25);
        }
    }
}
