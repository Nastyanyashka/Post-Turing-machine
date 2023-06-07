using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Post_Turing_machine
{
    internal class CoolLabel : Label
    {
        public CoolLabel() { }
        public void ChangeValue(Post_Machine machine)
        {
            string temptext = "";
            bool flag = false;
            int index = 0;
            bool value = false;
            for (int i = 0; i < this.Text.Length; i++)
            {
                if (this.Text[i] == ' ' && flag == false)
                {
                    index = int.Parse(temptext);
                    flag = true;
                    temptext = "";
                    if (index >= 0)
                    {
                        value = machine.RightTape[index];
                    }
                    else
                    {
                        value = machine.LeftTape[Math.Abs(index)];
                    }
                    continue;
                }
                if (this.Text[i] == ' ' && flag == true)
                {
                    continue;
                }
                if (this.Text[i] != ' ' && flag == true)
                {
                    if (value == false)
                    {
                        temptext = index.ToString() + "   " + "0";
                    }
                    else
                    {
                        temptext = index.ToString() + "   " + "1";
                    }
                    break;
                }
                temptext += this.Text[i];
            }
           this.Text = temptext;
        }
    }
}
