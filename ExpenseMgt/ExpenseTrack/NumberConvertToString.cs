using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrack
{
    class NumberToWords
    {
        private static String[] units = { "শূন্য", "এক", "দুই", "তিন",
    "চার", "পাঁচ", "ছয়", "সাত", "আট", "নয়", "দশ", "এগারো",
    "বারো", "তেরো", "চৌদ্দো", "পনেরো", "ষোলো",
    "সতেরো", "আঠারো", "উনিশ" };
        private static String[] tens = { "", "", "বিশ", "ত্রিশ", "চল্লিশ",
    "পঞ্চাশ", "ষাট", "সত্তর", "আশি", "নব্বই" };

        public static String ConvertAmount(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return Convert(amount_int) + " মাত্র |";
                }
                else
                {
                    return Convert(amount_int) + " দশমিক " + Convert(amount_dec) + " মাত্র |";
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }

        public static String Convert(Int64 i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
            }
            if (i < 1000)
            {
                return units[i / 100] + " শত"
                        + ((i % 100 > 0) ? " " + Convert(i % 100) : "");
            }
            if (i < 100000)
            {
                return Convert(i / 1000) + " হাজার "
                        + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return Convert(i / 100000) + " লক্ষ "
                        + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return Convert(i / 10000000) + " কোটি    "
                        + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");
            }
            return Convert(i / 1000000000) + " আরব  "
                    + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");
        }
    }
}
