namespace TravelForm
{
    partial class TravelsOptionsForm
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioButtonAllPackages = new System.Windows.Forms.RadioButton();
            this.radioButtonByContinent = new System.Windows.Forms.RadioButton();
            this.radioButtonByTravelType = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxViewInformationOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.checkBoxPictures = new System.Windows.Forms.CheckBox();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.comboBoxTravelType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.groupBoxRadio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxViewInformationOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelHeader.Location = new System.Drawing.Point(214, 23);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(306, 31);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Around Travel the World";
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.radioButtonAllPackages);
            this.groupBoxRadio.Controls.Add(this.radioButtonByContinent);
            this.groupBoxRadio.Controls.Add(this.radioButtonByTravelType);
            this.groupBoxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadio.Location = new System.Drawing.Point(83, 91);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(563, 107);
            this.groupBoxRadio.TabIndex = 1;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "Search Option";
            // 
            // radioButtonAllPackages
            // 
            this.radioButtonAllPackages.AutoSize = true;
            this.radioButtonAllPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAllPackages.Location = new System.Drawing.Point(408, 46);
            this.radioButtonAllPackages.Name = "radioButtonAllPackages";
            this.radioButtonAllPackages.Size = new System.Drawing.Size(118, 24);
            this.radioButtonAllPackages.TabIndex = 1;
            this.radioButtonAllPackages.TabStop = true;
            this.radioButtonAllPackages.Text = "All Packages";
            this.radioButtonAllPackages.UseVisualStyleBackColor = true;
            // 
            // radioButtonByContinent
            // 
            this.radioButtonByContinent.AutoSize = true;
            this.radioButtonByContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonByContinent.Location = new System.Drawing.Point(213, 46);
            this.radioButtonByContinent.Name = "radioButtonByContinent";
            this.radioButtonByContinent.Size = new System.Drawing.Size(118, 24);
            this.radioButtonByContinent.TabIndex = 1;
            this.radioButtonByContinent.TabStop = true;
            this.radioButtonByContinent.Text = "By Continent";
            this.radioButtonByContinent.UseVisualStyleBackColor = true;
            // 
            // radioButtonByTravelType
            // 
            this.radioButtonByTravelType.AutoSize = true;
            this.radioButtonByTravelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonByTravelType.Location = new System.Drawing.Point(34, 46);
            this.radioButtonByTravelType.Name = "radioButtonByTravelType";
            this.radioButtonByTravelType.Size = new System.Drawing.Size(129, 24);
            this.radioButtonByTravelType.TabIndex = 0;
            this.radioButtonByTravelType.TabStop = true;
            this.radioButtonByTravelType.Text = "By Travel Type";
            this.radioButtonByTravelType.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxViewInformationOptions);
            this.panel1.Controls.Add(this.comboBoxContinent);
            this.panel1.Controls.Add(this.comboBoxTravelType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(83, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 319);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxViewInformationOptions
            // 
            this.groupBoxViewInformationOptions.Controls.Add(this.checkBoxText);
            this.groupBoxViewInformationOptions.Controls.Add(this.checkBoxPictures);
            this.groupBoxViewInformationOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxViewInformationOptions.Location = new System.Drawing.Point(34, 189);
            this.groupBoxViewInformationOptions.Name = "groupBoxViewInformationOptions";
            this.groupBoxViewInformationOptions.Size = new System.Drawing.Size(479, 100);
            this.groupBoxViewInformationOptions.TabIndex = 3;
            this.groupBoxViewInformationOptions.TabStop = false;
            this.groupBoxViewInformationOptions.Text = "View Information Options";
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxText.Location = new System.Drawing.Point(284, 49);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(58, 24);
            this.checkBoxText.TabIndex = 0;
            this.checkBoxText.Text = "Text";
            this.checkBoxText.UseVisualStyleBackColor = true;
            // 
            // checkBoxPictures
            // 
            this.checkBoxPictures.AutoSize = true;
            this.checkBoxPictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPictures.Location = new System.Drawing.Point(51, 49);
            this.checkBoxPictures.Name = "checkBoxPictures";
            this.checkBoxPictures.Size = new System.Drawing.Size(85, 24);
            this.checkBoxPictures.TabIndex = 0;
            this.checkBoxPictures.Text = "Pictures";
            this.checkBoxPictures.UseVisualStyleBackColor = true;
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(284, 120);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(140, 28);
            this.comboBoxContinent.TabIndex = 2;
            // 
            // comboBoxTravelType
            // 
            this.comboBoxTravelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTravelType.FormattingEnabled = true;
            this.comboBoxTravelType.Location = new System.Drawing.Point(284, 59);
            this.comboBoxTravelType.Name = "comboBoxTravelType";
            this.comboBoxTravelType.Size = new System.Drawing.Size(140, 28);
            this.comboBoxTravelType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Continent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel Type";
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(284, 574);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(155, 40);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // TravelsOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.LabelHeader);
            this.Name = "TravelsOptionsForm";
            this.Text = "Form1";
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxViewInformationOptions.ResumeLayout(false);
            this.groupBoxViewInformationOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonAllPackages;
        private System.Windows.Forms.RadioButton radioButtonByContinent;
        private System.Windows.Forms.RadioButton radioButtonByTravelType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxViewInformationOptions;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.CheckBox checkBoxPictures;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.ComboBox comboBoxTravelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonView;
    }
}

