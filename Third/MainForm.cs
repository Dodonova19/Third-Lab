using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third
{
    public partial class MainForm : Form
    {
        //Объекты, содержащие числа с формы
        private NumberSystem first = null;
        private NumberSystem second = null;
        private NumberSystem result = null;

        public MainForm()
        {
            InitializeComponent();
        }
       
        //Выполнение выбранного действия
        private void Calculate()
        {
            if(firstNumber.Text == "" || secondNumber.Text == "")
            {
                return;
            }
            try
            {
                switch (cmbOperation.Text)
                {
                    case "+":
                        result = first + second;
                        cmbResultSystem.Enabled = true;
                        break;
                    case "-":
                        result = first - second;
                        cmbResultSystem.Enabled = true;
                        break;
                    case "*":
                        result = first * second;
                        cmbResultSystem.Enabled = true;
                        break;
                    case ">":
                        resultNumber.Text = first > second ? "Верно" : "Неверно";
                        cmbResultSystem.Enabled = false;
                        return;
                    case "<":
                        resultNumber.Text = first < second ? "Верно" : "Неверно";
                        cmbResultSystem.Enabled = false;
                        return;
                    case "=":
                        resultNumber.Text = first == second ? "Верно" : "Неверно";
                        cmbResultSystem.Enabled = false;
                        return;
                    case "!=":
                        resultNumber.Text = first != second ? "Верно" : "Неверно";
                        cmbResultSystem.Enabled = false;
                        return;
                }

                switch (cmbResultSystem.Text)
                {
                    case "2":
                        result = result.To(NumSys.Binary);
                        break;
                    case "8":
                        result = result.To(NumSys.Octal);
                        break;
                    case "10":
                        result = result.To(NumSys.Decimal);
                        break;
                    case "16":
                        result = result.To(NumSys.Hexadecimal);
                        break;
                    default:
                        result = result.To(NumSys.Decimal);
                        break;
                }

                resultNumber.Text = result.Number;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Ошибка", MessageBoxButtons.OK);
            }
        }

        //Перерасчёт при смене действия
        private void OnOperationChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        //Перерасчёт при изменении первого числа
        private void OnFirstTextChanged(object sender, EventArgs e)
        {
            if (firstNumber.Text == "") {
                first = null;
                resultNumber.Text = "";
                return; 
            }
            NumSys system;
            switch (cmbFirstSystem.Text)
            {
                case "2":
                    system = NumSys.Binary;
                    break;
                case "8":
                    system = NumSys.Octal;
                    break;
                case "10":
                    system = NumSys.Decimal;
                    break;
                case "16":
                    system = NumSys.Hexadecimal;
                    break;
                default:
                    system = NumSys.Decimal;
                    break;
            }

            first = new NumberSystem(firstNumber.Text, system);
            Calculate();
        }

        //Перерасчёт при изменении второго числа
        private void OnSecondTextChanged(object sender, EventArgs e)
        {
            if (secondNumber.Text == "")
            {
                second = null;
                resultNumber.Text = "";
                return;
            }
            NumSys system;
            switch (cmbSecondSystem.Text)
            {
                case "2":
                    system = NumSys.Binary;
                    break;
                case "8":
                    system = NumSys.Octal;
                    break;
                case "10":
                    system = NumSys.Decimal;
                    break;
                case "16":
                    system = NumSys.Hexadecimal;
                    break;
                default:
                    system = NumSys.Decimal;
                    break;
            }

            second = new NumberSystem(secondNumber.Text, system);
            Calculate();
        }

        //Перерасчёт при изменении сс первого числа
        private void OnFirstSystemChanged(object sender, EventArgs e)
        {
            if (first is null) return;
            switch (cmbFirstSystem.Text)
            {
                case "2":
                    first = first.To(NumSys.Binary);
                    firstNumber.MaxLength = 30;
                    break;
                case "8":
                    first = first.To(NumSys.Octal);
                    firstNumber.MaxLength = 14;
                    break;
                case "10":
                    first = first.To(NumSys.Decimal);
                    firstNumber.MaxLength = 12;
                    break;
                case "16":
                    first = first.To(NumSys.Hexadecimal);
                    firstNumber.MaxLength = 9;
                    break;
                default:
                    first = first.To(NumSys.Decimal);
                    firstNumber.MaxLength = 12;
                    break;
            }
            firstNumber.Text = first.Number;
        }

        //Перерасчёт при изменении сс второго числа
        private void OnSecondSystemChanged(object sender, EventArgs e)
        {
            if (second is null) return;
            switch (cmbSecondSystem.Text)
            {
                case "2":
                    second = second.To(NumSys.Binary);
                    secondNumber.MaxLength = 30;
                    break;
                case "8":
                    second = second.To(NumSys.Octal);
                    secondNumber.MaxLength = 14;
                    break;
                case "10":
                    second = second.To(NumSys.Decimal);
                    secondNumber.MaxLength = 12;
                    break;
                case "16":
                    second = second.To(NumSys.Hexadecimal);
                    secondNumber.MaxLength = 9;
                    break;
                default:
                    second = second.To(NumSys.Decimal);
                    secondNumber.MaxLength = 12;
                    break;
            }
            secondNumber.Text = second.Number;
        }

        //Перерасчёт при изменении сс результата
        private void OnResultSystemChanged(object sender, EventArgs e)
        {
            if (result is null) return;
            switch (cmbResultSystem.Text)
            {
                case "2":
                    result = result.To(NumSys.Binary);
                    break;
                case "8":
                    result = result.To(NumSys.Octal);
                    break;
                case "10":
                    result = result.To(NumSys.Decimal);
                    break;
                case "16":
                    result = result.To(NumSys.Hexadecimal);
                    break;
                default:
                    result = result.To(NumSys.Decimal);
                    break;
            }
            resultNumber.Text = result.Number;
        }

        //Переход на следующее поле при нажатии на кнопку при выделенном comboBox'e
        private void cmbOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("{TAB}");
            e.Handled = true;
        }

        //Проверка ввода и переход на следующее поле при нажатии на enter
        private void firstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

            switch (cmbFirstSystem.Text)
            {
                case "2":
                    if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "8":
                    if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' ||
                        e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "10":
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "16":
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' ||
                        e.KeyChar == 'd' || e.KeyChar == 'e' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        //Проверка ввода и переход на следующее поле при нажатии на enter
        private void secondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

            switch (cmbSecondSystem.Text)
            {
                case "2":
                    if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "8":
                    if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' ||
                        e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "10":
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "16":
                    if (char.IsDigit(e.KeyChar) || e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' ||
                        e.KeyChar == 'd' || e.KeyChar == 'e' || e.KeyChar == (char)Keys.Back)
                    {
                        return;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
    }
}
