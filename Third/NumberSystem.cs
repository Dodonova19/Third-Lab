using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    //Перечисление возможных систем счисления
    public enum NumSys { Binary, Octal, Decimal, Hexadecimal };
    public class NumberSystem
    {
        private string number;
        private NumSys numberSystem;

        //Конструктор
        public NumberSystem(string number, NumSys numberSystem)
        {
            this.number = number;
            this.numberSystem = numberSystem;
        }

        //Свойство для получения числа
        public string Number { get { return number; } }

        //Оператор сложения
        public static NumberSystem operator +(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) + long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }

        //Оператор вычитания
        public static NumberSystem operator -(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) - long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }

        //Оператор умножения
        public static NumberSystem operator *(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return new NumberSystem((long.Parse(firstNum.number) * long.Parse(secondNum.number)).ToString(), NumSys.Decimal);
        }

        //Оператор сравнения первого и второго числа (больше ли первое)
        public static bool operator >(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) > long.Parse(secondNum.number);
        }

        //Оператор сравнения первого и второго числа (больше ли второе)
        public static bool operator <(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) < long.Parse(secondNum.number);
        }

        //Оператор сравнения первого и второго числа (равны ли)
        public static bool operator ==(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) == long.Parse(secondNum.number);
        }

        //Оператор сравнения первого и второго числа (не равны ли)
        public static bool operator !=(NumberSystem first, NumberSystem second)
        {
            var firstNum = first.To(NumSys.Decimal);
            var secondNum = second.To(NumSys.Decimal);

            return long.Parse(firstNum.number) != long.Parse(secondNum.number);
        }

        //Перевод в указанную систему счисления
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

        //Перевод в двоичную систему счисления
        private NumberSystem ToBinary()
        {
            return new NumberSystem(Convert.ToString(Int64.Parse(number), 2), NumSys.Binary);
        }

        //Перевод в восьмеричную систему счисления
        private NumberSystem ToOctal()
        {
            return new NumberSystem(Convert.ToString(Int64.Parse(number), 8), NumSys.Octal);
        }

        //Перевод в десятичную систему счисления
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

        //Перевод в шестнадцатеричную систему счисления
        private NumberSystem ToHexadecimal()
        {
            return new NumberSystem(Convert.ToString(long.Parse(number), 16), NumSys.Binary);
        }
    }
}
