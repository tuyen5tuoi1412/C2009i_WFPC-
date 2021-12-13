namespace CalculationForm
{
    partial class Form1
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
            this.CalculationLable = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextboxY = new System.Windows.Forms.TextBox();
            this.comboBoxCalculation = new System.Windows.Forms.ComboBox();
            this.labelOperator = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculationLable
            // 
            this.CalculationLable.AutoSize = true;
            this.CalculationLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationLable.ForeColor = System.Drawing.Color.IndianRed;
            this.CalculationLable.Location = new System.Drawing.Point(249, 19);
            this.CalculationLable.Name = "CalculationLable";
            this.CalculationLable.Size = new System.Drawing.Size(237, 33);
            this.CalculationLable.TabIndex = 0;
            this.CalculationLable.Text = "Calculation Form";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Black;
            this.labelX.Location = new System.Drawing.Point(92, 71);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(34, 33);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.ForeColor = System.Drawing.Color.Black;
            this.labelY.Location = new System.Drawing.Point(92, 139);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(35, 33);
            this.labelY.TabIndex = 0;
            this.labelY.Text = "Y";
            // 
            // TextBoxX
            // 
            this.TextBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxX.Location = new System.Drawing.Point(179, 64);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(98, 40);
            this.TextBoxX.TabIndex = 1;
            // 
            // TextboxY
            // 
            this.TextboxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxY.Location = new System.Drawing.Point(179, 132);
            this.TextboxY.Name = "TextboxY";
            this.TextboxY.Size = new System.Drawing.Size(98, 40);
            this.TextboxY.TabIndex = 1;
            // 
            // comboBoxCalculation
            // 
            this.comboBoxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCalculation.FormattingEnabled = true;
            this.comboBoxCalculation.Location = new System.Drawing.Point(179, 203);
            this.comboBoxCalculation.Name = "comboBoxCalculation";
            this.comboBoxCalculation.Size = new System.Drawing.Size(180, 41);
            this.comboBoxCalculation.TabIndex = 2;
            // 
            // labelOperator
            // 
            this.labelOperator.AutoSize = true;
            this.labelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperator.ForeColor = System.Drawing.Color.IndianRed;
            this.labelOperator.Location = new System.Drawing.Point(12, 206);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(130, 33);
            this.labelOperator.TabIndex = 0;
            this.labelOperator.Text = "Operator";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.LightCoral;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateButton.Location = new System.Drawing.Point(179, 366);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 60);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(179, 265);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(108, 35);
            this.txtResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(29, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.comboBoxCalculation);
            this.Controls.Add(this.TextboxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOperator);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.CalculationLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculationLable;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextboxY;
        private System.Windows.Forms.ComboBox comboBoxCalculation;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

