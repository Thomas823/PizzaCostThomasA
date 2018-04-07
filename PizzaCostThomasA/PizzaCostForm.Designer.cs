namespace PizzaCostThomasA
{
    partial class frmPizzaCost
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
            this.lblDiameterPrompt = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalPrompt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiameterPrompt
            // 
            this.lblDiameterPrompt.AutoSize = true;
            this.lblDiameterPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameterPrompt.Location = new System.Drawing.Point(22, 52);
            this.lblDiameterPrompt.Name = "lblDiameterPrompt";
            this.lblDiameterPrompt.Size = new System.Drawing.Size(361, 24);
            this.lblDiameterPrompt.TabIndex = 0;
            this.lblDiameterPrompt.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(413, 57);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(39, 128);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalPrompt
            // 
            this.lblTotalPrompt.AutoSize = true;
            this.lblTotalPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrompt.Location = new System.Drawing.Point(35, 216);
            this.lblTotalPrompt.Name = "lblTotalPrompt";
            this.lblTotalPrompt.Size = new System.Drawing.Size(229, 20);
            this.lblTotalPrompt.TabIndex = 3;
            this.lblTotalPrompt.Text = "The total cost (including tax) is: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(270, 216);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 4;
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 282);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalPrompt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblDiameterPrompt);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameterPrompt;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalPrompt;
        private System.Windows.Forms.Label lblTotal;
    }
}

