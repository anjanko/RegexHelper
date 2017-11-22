using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
namespace Regex_v1
{
    static class RegexConverter
    {

        internal static string Exp5_Email()
        {
            return @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}\b";
        }

        internal static string Exp4_Date(int format, int searchOption)
        {
            string result = string.Empty;
            if(format==0&&searchOption==0)
            {
                result= @"^(19|20)\d\d([- /.])(0[1-9]|1[012])\2(0[1-9]|[12][0-9]|3[01])$";
            }
            if(format==0&&searchOption==1)
            {
                result= @"\b(19|20)\d\d([- /.])(0[1-9]|1[012])\2(0[1-9]|[12][0-9]|3[01])\b";
            }
            if (format == 1 && searchOption == 1)
            {
                result = @"\b(0[1-9]|[12][0-9]|3[01])([- /.])(0[1-9]|1[012])\2(19|20)\d\d\b";
            }
            if (format == 1 && searchOption == 0)
            {
                result = @"^(0[1-9]|[12][0-9]|3[01])([- /.])(0[1-9]|1[012])\2(19|20)\d\d$";
            }
            return result;
        }

        internal static string Exp3_NotAllowed(List<string> listaWyrazow)
        {
            string result = string.Empty;
            return result;
        }

        internal static string Exp2_Words(List<string> ex2_List)
        {
            string result = string.Empty;
            return result;
        }

        internal static string Exp1_Pattern(List<string> ex1_TokensList)
        {
            string result = string.Empty;
            return result;
        }
    }
}
