using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public static class DataValidation
    {
        public static bool CheckTextBox(TextBox tb)
        {
            if (tb.Text != string.Empty)
            {
                return true;
            }
            return false;
        }
        public static bool CheckTextBox(TextBox tb, int max)
        {
            if (tb.Text != string.Empty && tb.Text.Length <= max)
            {
                return true;
            }
            return false;
        }

        public static bool CheckFutureDate(DateTimePicker dtp)
        {
            if(dtp.Value > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
