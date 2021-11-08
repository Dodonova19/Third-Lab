namespace Third
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultNumber = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.cmbFirstSystem = new System.Windows.Forms.ComboBox();
            this.cmbSecondSystem = new System.Windows.Forms.ComboBox();
            this.cmbResultSystem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultNumber
            // 
            this.resultNumber.Location = new System.Drawing.Point(12, 88);
            this.resultNumber.Name = "resultNumber";
            this.resultNumber.ReadOnly = true;
            this.resultNumber.Size = new System.Drawing.Size(261, 20);
            this.resultNumber.TabIndex = 3;
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(51, 62);
            this.secondNumber.MaxLength = 12;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(222, 20);
            this.secondNumber.TabIndex = 2;
            this.secondNumber.TextChanged += new System.EventHandler(this.OnSecondTextChanged);
            this.secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNumber_KeyPress);
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "<",
            ">",
            "=",
            "!="});
            this.cmbOperation.Location = new System.Drawing.Point(12, 49);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(31, 21);
            this.cmbOperation.TabIndex = 51;
            this.cmbOperation.Text = "+";
            this.cmbOperation.TextChanged += new System.EventHandler(this.OnOperationChanged);
            this.cmbOperation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperation_KeyPress);
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(49, 36);
            this.firstNumber.MaxLength = 12;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(224, 20);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.TextChanged += new System.EventHandler(this.OnFirstTextChanged);
            this.firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNumber_KeyPress);
            // 
            // cmbFirstSystem
            // 
            this.cmbFirstSystem.FormattingEnabled = true;
            this.cmbFirstSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbFirstSystem.Location = new System.Drawing.Point(279, 35);
            this.cmbFirstSystem.Name = "cmbFirstSystem";
            this.cmbFirstSystem.Size = new System.Drawing.Size(35, 21);
            this.cmbFirstSystem.TabIndex = 82;
            this.cmbFirstSystem.Text = "10";
            this.cmbFirstSystem.SelectedValueChanged += new System.EventHandler(this.OnFirstSystemChanged);
            this.cmbFirstSystem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperation_KeyPress);
            // 
            // cmbSecondSystem
            // 
            this.cmbSecondSystem.FormattingEnabled = true;
            this.cmbSecondSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbSecondSystem.Location = new System.Drawing.Point(279, 62);
            this.cmbSecondSystem.Name = "cmbSecondSystem";
            this.cmbSecondSystem.Size = new System.Drawing.Size(35, 21);
            this.cmbSecondSystem.TabIndex = 83;
            this.cmbSecondSystem.Text = "10";
            this.cmbSecondSystem.SelectedValueChanged += new System.EventHandler(this.OnSecondSystemChanged);
            this.cmbSecondSystem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperation_KeyPress);
            // 
            // cmbResultSystem
            // 
            this.cmbResultSystem.FormattingEnabled = true;
            this.cmbResultSystem.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbResultSystem.Location = new System.Drawing.Point(279, 89);
            this.cmbResultSystem.Name = "cmbResultSystem";
            this.cmbResultSystem.Size = new System.Drawing.Size(35, 21);
            this.cmbResultSystem.TabIndex = 84;
            this.cmbResultSystem.Text = "10";
            this.cmbResultSystem.SelectedValueChanged += new System.EventHandler(this.OnResultSystemChanged);
            this.cmbResultSystem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOperation_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Калькулятор систем счисления";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 116);
            this.Controls.Add(this.cmbResultSystem);
            this.Controls.Add(this.cmbSecondSystem);
            this.Controls.Add(this.cmbFirstSystem);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.resultNumber);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Системы счисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultNumber;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.ComboBox cmbFirstSystem;
        private System.Windows.Forms.ComboBox cmbSecondSystem;
        private System.Windows.Forms.ComboBox cmbResultSystem;
        private System.Windows.Forms.Label label1;
    }
}

