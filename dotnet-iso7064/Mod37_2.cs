using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{
    public class Mod37_2 : PureSystemCalculator
    {        
        protected override int GetModulus()
        {
            return 37;
        }

        protected override int GetRadix()
        {
            return 2;
        }

        protected override string GetCharacterSet()
        {
            return "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ*";
        }

        protected override bool IsDoubleCheckDigit()
        {
            return false;
        }
    }
}
