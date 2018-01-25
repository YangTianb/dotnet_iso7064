using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet.iso7064
{
    public class Mod1271_36 : PureSystemCalculator
    {
        protected override string GetCharacterSet()
        {
            return "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        protected override int GetModulus()
        {
            return 1271;
        }

        protected override int GetRadix()
        {
            return 36;
        }

        protected override bool IsDoubleCheckDigit()
        {
            return true;
        }
    }
}
