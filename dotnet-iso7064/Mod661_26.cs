using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{
    public class Mod661_26 : PureSystemCalculator
    {
        protected override string GetCharacterSet()
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        protected override int GetModulus()
        {
            return 661;
        }

        protected override int GetRadix()
        {
            return 26;
        }

        protected override bool IsDoubleCheckDigit()
        {
            return true;
        }
    }
}
