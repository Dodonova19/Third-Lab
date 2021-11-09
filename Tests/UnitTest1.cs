using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Third;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTest() //Проверка суммы
        {
            var first = new NumberSystem("101011", NumSys.Binary);
            var second = new NumberSystem("1227", NumSys.Octal);

            Assert.AreEqual((first + second).To(NumSys.Decimal).Number, "706");
        }

        [TestMethod]
        public void MinusTest() //Проверка разности
        {
            var first = new NumberSystem("1242", NumSys.Octal);
            var second = new NumberSystem("1011", NumSys.Binary);

            Assert.AreEqual((first - second).To(NumSys.Decimal).Number, "663");
        }

        [TestMethod]
        public void MultiplyTest() //Проверка умножения
        {
            var first = new NumberSystem("a", NumSys.Hexadecimal);
            var second = new NumberSystem("10101", NumSys.Binary);

            Assert.AreEqual((first * second).To(NumSys.Decimal).Number, "210");
        }

        [TestMethod]
        public void LessTest() //Проверка действия "меньше"
        {
            var first = new NumberSystem("a", NumSys.Hexadecimal);
            var second = new NumberSystem("25", NumSys.Octal);

            Assert.AreEqual(first < second, true);
        }

        [TestMethod]
        public void MoreTest() //Проверка действия "больше"
        {
            var first = new NumberSystem("a", NumSys.Hexadecimal);
            var second = new NumberSystem("25", NumSys.Octal);

            Assert.AreEqual(first > second, false);
        }

        [TestMethod]
        public void EqualTest() //Проверка действия "равно"
        {
            var first = new NumberSystem("a", NumSys.Hexadecimal);
            var second = new NumberSystem("25", NumSys.Octal);

            Assert.AreEqual(first == second, false);
        }

        [TestMethod]
        public void UnequalTest() //Проверка действия "не равно"
        {
            var first = new NumberSystem("a", NumSys.Hexadecimal);
            var second = new NumberSystem("25", NumSys.Octal);

            Assert.AreEqual(first != second, true);
        }

        [TestMethod]
        public void From10To2() //Проверка перевода из 10-й в 2-ю сс
        {
            var num = new NumberSystem("621", NumSys.Decimal);

            Assert.AreEqual(num.To(NumSys.Binary).Number, "1001101101");
        }

        [TestMethod]
        public void From2To8() //Проверка перевода из 2-й в 8-ю сс
        {
            var num = new NumberSystem("1001101101", NumSys.Binary);

            Assert.AreEqual(num.To(NumSys.Octal).Number, "1155");
        }

        [TestMethod]
        public void From8To16() //Проверка перевода из 8-й в 16-ю сс
        {
            var num = new NumberSystem("1155", NumSys.Octal);

            Assert.AreEqual(num.To(NumSys.Hexadecimal).Number, "26d");
        }

        [TestMethod]
        public void From16To10() //Проверка перевода из 16-й в 10-ю сс
        {
            var num = new NumberSystem("26d", NumSys.Hexadecimal);

            Assert.AreEqual(num.To(NumSys.Decimal).Number, "621");
        }
    }
}
