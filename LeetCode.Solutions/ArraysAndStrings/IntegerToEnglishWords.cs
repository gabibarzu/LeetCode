namespace LeetCode.Solutions.ArraysAndStrings
{
    /// <summary>
    /// Time: O(n)
    /// Space: O(1)
    /// </summary>
    public static class IntegerToEnglishWords
    {
        private static string One(int num)
        {
            return num switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => ""
            };
        }

        private static string TwoLessThan20(int num)
        {
            return num switch
            {
                10 => "Ten",
                11 => "Eleven",
                12 => "Twelve",
                13 => "Thirteen",
                14 => "Fourteen",
                15 => "Fifteen",
                16 => "Sixteen",
                17 => "Seventeen",
                18 => "Eighteen",
                19 => "Nineteen",
                _ => ""
            };
        }

        private static string Ten(int num)
        {
            return num switch
            {
                2 => "Twenty",
                3 => "Thirty",
                4 => "Forty",
                5 => "Fifty",
                6 => "Sixty",
                7 => "Seventy",
                8 => "Eighty",
                9 => "Ninety",
                _ => ""
            };
        }

        private static string Two(int num)
        {
            switch (num)
            {
                case 0:
                    return "";
                case < 10:
                    return One(num);
                case < 20:
                    return TwoLessThan20(num);
            }

            var tenner = num / 10;
            var rest = num - tenner * 10;
            if (rest != 0)
            {
                return Ten(tenner) + " " + One(rest);
            }

            return Ten(tenner);
        }

        private static string Three(int num)
        {
            var hundred = num / 100;
            var rest = num - hundred * 100;
            var res = "";
            if (hundred * rest != 0)
            {
                res = One(hundred) + " Hundred " + Two(rest);
            }
            else if (hundred == 0 && rest != 0)
            {
                res = Two(rest);
            }
            else if (hundred != 0 && rest == 0)
            {

                res = One(hundred) + " Hundred";
            }

            return res;
        }

        public static string NumberToWords(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }

            var billion = num / 1000000000;
            var million = (num - billion * 1000000000) / 1000000;
            var thousand = (num - billion * 1000000000 - million * 1000000) / 1000;
            var rest = num - billion * 1000000000 - million * 1000000 - thousand * 1000;

            var result = "";
            if (billion != 0)
            {
                result = Three(billion) + " Billion";
            }
            if (million != 0)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    result += " ";
                }
                result += Three(million) + " Million";
            }
            if (thousand != 0)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    result += " ";
                }
                result += Three(thousand) + " Thousand";
            }
            if (rest != 0)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    result += " ";
                }
                result += Three(rest);
            }

            return result;
        }
    }
}