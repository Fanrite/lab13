using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Inputdata
{
    
    class Input
    {
        public static bool Indouble(ref double p, string buk)
        {
            string inp;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToDouble(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        public static bool Inint(ref int p, string buk)
        {
            string inp;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToInt32(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        public static bool In1in2(ref string p, string buk)
        {
            string inp;

        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            if (inp == "a" || inp == "A")
                p = "a";

            else if (inp == "b" || inp == "B")
                p = "b";

            else
            {
                if (MessageBox.Show("vi vveli ne pravelni danni, povtorit" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }

            return true;
        }

        //public static bool number(ref dynamic var, string terms)
        //{
        //vvod:
        //    string input;

        //    input = Interaction.InputBox(terms, "vvedenia", $"{var}");

        //    if (var.Type() == typeof(int))
        //    {
        //        try
        //        {
        //            var = Convert.ToInt32(input);
        //        }
        //        catch (System.FormatException)
        //        {
        //            if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //                goto vvod;
        //            else
        //                return false;
        //        }
        //        return true;
        //    }
        //    else if (var.Type() == typeof(double))
        //    {
        //        try
        //        {
        //            var = Convert.ToDouble(input);
        //        }
        //        catch (System.FormatException)
        //        {
        //            if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //                goto vvod;
        //            else
        //                return false;
        //        }
        //        return true;
        //    }

        }
    }
}
