namespace SDAM_Assignment
{
    partial class AddStockQty
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.stockCodeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.stockCodeExistInput = new System.Windows.Forms.TextBox();
            this.quantityAddInput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(85, 20);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(349, 24);
            this.headingLabel.TabIndex = 9;
            this.headingLabel.Text = "Add quanity to existing stock item";
            // 
            // stockCodeLabel
            // 
            this.stockCodeLabel.AutoSize = true;
            this.stockCodeLabel.Location = new System.Drawing.Point(36, 95);
            this.stockCodeLabel.Name = "stockCodeLabel";
            this.stockCodeLabel.Size = new System.Drawing.Size(262, 19);
            this.stockCodeLabel.TabIndex = 10;
            this.stockCodeLabel.Text = "Enter stock code to add quantity:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(36, 148);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(154, 19);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Enter the quantity: ";
            // 
            // stockCodeExistInput
            // 
            this.stockCodeExistInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockCodeExistInput.Location = new System.Drawing.Point(303, 92);
            this.stockCodeExistInput.Name = "stockCodeExistInput";
            this.stockCodeExistInput.Size = new System.Drawing.Size(172, 26);
            this.stockCodeExistInput.TabIndex = 12;
            // 
            // quantityAddInput
            // 
            this.quantityAddInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityAddInput.Location = new System.Drawing.Point(229, 145);
            this.quantityAddInput.Name = "quantityAddInput";
            this.quantityAddInput.Size = new System.Drawing.Size(172, 26);
            this.quantityAddInput.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(52, 223);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 30);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(373, 223);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 30);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // AddStockQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(521, 310);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.quantityAddInput);
            this.Controls.Add(this.stockCodeExistInput);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.stockCodeLabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStockQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock Quantity";
            this.Load += new System.EventHandler(this.AddStockQty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label stockCodeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox stockCodeExistInput;
        private System.Windows.Forms.TextBox quantityAddInput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}