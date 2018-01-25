using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{

    public abstract class PureSystemCalculator
    {

        protected abstract int GetModulus();
        protected abstract int GetRadix();
        protected abstract String GetCharacterSet();
        protected abstract Boolean IsDoubleCheckDigit();



        /**
         * Compute check characters for the given input
         * @param input The input string that should be appended with a check digit.
         * @return The input string with the check digit appended.
         * @throws IllegalStateException Raised if an illegal character is encountered.
         */
        public String Compute(String input)
        {
            input = input.ToUpper();
            int m = GetModulus();
            int r = GetRadix();
            String chars = GetCharacterSet();
            Boolean doubleDigit = IsDoubleCheckDigit();

            // process the string 
            int p = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //Todo:Substring
                int val = chars.IndexOf(input[i]);
                if (val < 0) throw new Exception("Found illegal character " + input[i]);

                p = ((p + val) * r) % m;
            }

            // if we want a double digit output we perform one additional pass with val = 0
            if (doubleDigit) p = (p * r) % m;

            // now compute what checksum will be = 1 mod M
            int checksum = (m - p + 1) % m;

            if (doubleDigit)
            {
                int second = checksum % r;
                int first = (checksum - second) / r;
                return input + chars[first] + chars[second];
            }
            else
            {
                return input + chars[checksum];
            }
        }

}

}
