using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{
     public class Mod11_2 : PureSystemCalculator
    {
        protected override string GetCharacterSet()
        {
            return "0123456789X";
           
        }

        protected override int GetModulus()
        {
            return 11;            
        }

        protected override int GetRadix()
        {
            return 2;
        }

        protected override bool IsDoubleCheckDigit()
        {
            return false;
        }
    }
}
