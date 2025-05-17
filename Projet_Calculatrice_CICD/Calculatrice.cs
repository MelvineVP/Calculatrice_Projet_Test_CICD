
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_test_Ci_CD
{
    public class Calculatrice
    {
        public int Calculate(string text)
        {
            int number_one = 0;
            int number_two = 0;

            int result = 0;

            string number_one_string = "";
            string number_two_string = "";

            bool is_number_one = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '+')
                {
                    if (is_number_one)
                        number_one_string += text[i];
                    if (!is_number_one)
                        number_two_string += text[i];
                }
                else
                    is_number_one = false;
            }

            number_one = Convert.ToInt32(number_one_string);
            number_two = Convert.ToInt32(number_two_string);

            result = number_one + number_two;

            return result;
        }
    }
}
