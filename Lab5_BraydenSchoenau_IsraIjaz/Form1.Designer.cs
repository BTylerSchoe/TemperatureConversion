namespace Lab5_BraydenSchoenau_IsraIjaz
{
    partial class frmTemperatureConversion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblConvertTo = new System.Windows.Forms.Label();
            this.lblConvertedValueDisplay = new System.Windows.Forms.Label();
            this.lblConvertedValue = new System.Windows.Forms.Label();
            this.txtTemperatureValue = new System.Windows.Forms.TextBox();
            this.rbtCelsius = new System.Windows.Forms.RadioButton();
            this.rbtFahrenheit = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TemperatureTips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.Location = new System.Drawing.Point(54, 57);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(97, 23);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "&Temperature:";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConvertTo
            // 
            this.lblConvertTo.Location = new System.Drawing.Point(69, 124);
            this.lblConvertTo.Name = "lblConvertTo";
            this.lblConvertTo.Size = new System.Drawing.Size(82, 17);
            this.lblConvertTo.TabIndex = 1;
            this.lblConvertTo.Text = "Convert to:";
            this.lblConvertTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConvertedValueDisplay
            // 
            this.lblConvertedValueDisplay.Location = new System.Drawing.Point(5, 284);
            this.lblConvertedValueDisplay.Name = "lblConvertedValueDisplay";
            this.lblConvertedValueDisplay.Size = new System.Drawing.Size(146, 17);
            this.lblConvertedValueDisplay.TabIndex = 2;
            this.lblConvertedValueDisplay.Text = "Converted Value:";
            this.lblConvertedValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConvertedValue
            // 
            this.lblConvertedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConvertedValue.Location = new System.Drawing.Point(234, 284);
            this.lblConvertedValue.Name = "lblConvertedValue";
            this.lblConvertedValue.Size = new System.Drawing.Size(396, 27);
            this.lblConvertedValue.TabIndex = 6;
            // 
            // txtTemperatureValue
            // 
            this.txtTemperatureValue.Location = new System.Drawing.Point(237, 58);
            this.txtTemperatureValue.Name = "txtTemperatureValue";
            this.txtTemperatureValue.Size = new System.Drawing.Size(393, 22);
            this.txtTemperatureValue.TabIndex = 3;
            this.TemperatureTips.SetToolTip(this.txtTemperatureValue, "Enter The Temperature");
            this.txtTemperatureValue.TextChanged += new System.EventHandler(this.txtTemperatureValue_TextChanged);
            // 
            // rbtCelsius
            // 
            this.rbtCelsius.AutoSize = true;
            this.rbtCelsius.Checked = true;
            this.rbtCelsius.Location = new System.Drawing.Point(237, 124);
            this.rbtCelsius.Name = "rbtCelsius";
            this.rbtCelsius.Size = new System.Drawing.Size(74, 21);
            this.rbtCelsius.TabIndex = 4;
            this.rbtCelsius.TabStop = true;
            this.rbtCelsius.Text = "C&elsius";
            this.TemperatureTips.SetToolTip(this.rbtCelsius, "Convert To Celsius");
            this.rbtCelsius.UseVisualStyleBackColor = true;
            this.rbtCelsius.CheckedChanged += new System.EventHandler(this.rbCelcius_CheckedChanged);
            // 
            // rbtFahrenheit
            // 
            this.rbtFahrenheit.AutoSize = true;
            this.rbtFahrenheit.Location = new System.Drawing.Point(237, 213);
            this.rbtFahrenheit.Name = "rbtFahrenheit";
            this.rbtFahrenheit.Size = new System.Drawing.Size(97, 21);
            this.rbtFahrenheit.TabIndex = 5;
            this.rbtFahrenheit.Text = "&Fahrenheit";
            this.TemperatureTips.SetToolTip(this.rbtFahrenheit, "Convert To Fahrenheit");
            this.rbtFahrenheit.UseVisualStyleBackColor = true;
            this.rbtFahrenheit.CheckedChanged += new System.EventHandler(this.rbrFahrenheit_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(125, 359);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(97, 39);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "&Convert";
            this.TemperatureTips.SetToolTip(this.btnConvert, "Convert The Temperature(Alt-C)");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(328, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.TemperatureTips.SetToolTip(this.btnReset, "Reset The Program(Alt-R)");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(533, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 39);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.TemperatureTips.SetToolTip(this.btnExit, "Exit The Program(Alt-X)");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTemperatureConversion
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(776, 452);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbtFahrenheit);
            this.Controls.Add(this.rbtCelsius);
            this.Controls.Add(this.txtTemperatureValue);
            this.Controls.Add(this.lblConvertedValue);
            this.Controls.Add(this.lblConvertedValueDisplay);
            this.Controls.Add(this.lblConvertTo);
            this.Controls.Add(this.lblTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTemperatureConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.frmTemperatureConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblConvertTo;
        private System.Windows.Forms.Label lblConvertedValueDisplay;
        private System.Windows.Forms.Label lblConvertedValue;
        private System.Windows.Forms.TextBox txtTemperatureValue;
        private System.Windows.Forms.RadioButton rbtCelsius;
        private System.Windows.Forms.RadioButton rbtFahrenheit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip TemperatureTips;
    }
}

