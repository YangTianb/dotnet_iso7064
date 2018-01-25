using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{
    public class Mod97_10 : PureSystemCalculator
    {
        protected override string GetCharacterSet()
        {
            return "0123456789";
        }

        protected override int GetModulus()
        {
            return 97;
        }

        protected override int GetRadix()
        {
            return 10;
        }

        protected override bool IsDoubleCheckDigit()
        {
            return true;
        }
    }
}
