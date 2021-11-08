using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public enum NumSys { Binary, Octal, Decimal, Hexadecimal };
    public class NumberSystem
    {
        private string number;
        private NumSys numberSystem;

        public NumberSystem(string number, NumSys numberSystem)
        {
            this.number = number;
            this.numberSystem = numberSystem;
        }

        public string Number { get { return number; } }

        public static NumberSystem operator +(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) + long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }
        public static NumberSystem operator -(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) - long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }
        public static NumberSystem operator *(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) * long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }
        public static bool operator >(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) > long.Parse(secondNum.number);
        }
        public static bool operator <(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) < long.Parse(secondNum.number);
        }
        public static bool operator ==(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) == long.Parse(secondNum.number);
        }
        public static bool operator !=(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) != long.Parse(secondNum.number);
        }

        public NumberSystem To(NumSys numberSystem)
        {
            var newValue = this.ToDecimal();
            switch (numberSystem)
            {
                case NumSys.Binary:
                    newValue = newValue.ToBinary();
                    break;
                case NumSys.Decimal:
                    break;
                case NumSys.Octal:
                    newValue = newValue.ToOctal();
                    break;
                case NumSys.Hexadecimal:
                    newValue = newValue.ToHexadecimal();
                    break;
            }

            return newValue;
        }

        private NumberSystem ToBinary()
        {
            return new NumberSystem(Convert.ToString(Int64.Parse(number), 2), NumSys.Binary);
        }

        private NumberSystem ToOctal()
        {
            return new NumberSystem(Convert.ToString(Int64.Parse(number), 8), NumSys.Octal);
        }

        private NumberSystem ToDecimal()
        {
            NumberSystem result = null;
            switch (numberSystem) 
            {
                case NumSys.Binary:
                    result = new NumberSystem(Convert.ToInt64(number, 2).ToString(), NumSys.Decimal);
                    break;
                case NumSys.Decimal:
                    result = new NumberSystem(number, NumSys.Decimal);
                    break;
                case NumSys.Octal:
                    result = new NumberSystem(Convert.ToInt64(number, 8).ToString(), NumSys.Decimal);
                    break;
                case NumSys.Hexadecimal:
                    result = new NumberSystem(Convert.ToInt64(number, 16).ToString(), NumSys.Decimal);
                    break;
            }
            return result;
        }

        private NumberSystem ToHexadecimal()
        {
            return new NumberSystem(Convert.ToString(long.Parse(number), 16), NumSys.Binary);
        }
    }
}
