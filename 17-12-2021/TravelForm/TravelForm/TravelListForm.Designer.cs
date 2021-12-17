namespace TravelForm
{
    partial class TravelListForm
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
            this.listViewTravels = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewTravels
            // 
            this.listViewTravels.FullRowSelect = true;
            this.listViewTravels.GridLines = true;
            this.listViewTravels.HideSelection = false;
            this.listViewTravels.Location = new System.Drawing.Point(0, 1);
            this.listViewTravels.Margin = new System.Windows.Forms.Padding(6);
            this.listViewTravels.Name = "listViewTravels";
            this.listViewTravels.Size = new System.Drawing.Size(606, 230);
            this.listViewTravels.TabIndex = 0;
            this.listViewTravels.UseCompatibleStateImageBehavior = false;
            this.listViewTravels.View = System.Windows.Forms.View.Details;
            // 
            // TravelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 232);
            this.Controls.Add(this.listViewTravels);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TravelListForm";
            this.Text = "TravelListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTravels;
    }
}