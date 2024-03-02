namespace SDAM_Assignment
{
    partial class RemoveStockItem
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
            this.stockCodeRemInput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeQuantityLabel = new System.Windows.Forms.Label();
            this.removeQuantityInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(134, 21);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(246, 24);
            this.headingLabel.TabIndex = 9;
            this.headingLabel.Text = "Remove Stock Quantity";
            // 
            // stockCodeLabel
            // 
            this.stockCodeLabel.AutoSize = true;
            this.stockCodeLabel.Location = new System.Drawing.Point(29, 100);
            this.stockCodeLabel.Name = "stockCodeLabel";
            this.stockCodeLabel.Size = new System.Drawing.Size(228, 19);
            this.stockCodeLabel.TabIndex = 11;
            this.stockCodeLabel.Text = "Enter stock code to remove: ";
            // 
            // stockCodeRemInput
            // 
            this.stockCodeRemInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockCodeRemInput.Location = new System.Drawing.Point(266, 97);
            this.stockCodeRemInput.Name = "stockCodeRemInput";
            this.stockCodeRemInput.Size = new System.Drawing.Size(183, 26);
            this.stockCodeRemInput.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(52, 229);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 30);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Azure;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeButton.Location = new System.Drawing.Point(366, 229);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(83, 30);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeQuantityLabel
            // 
            this.removeQuantityLabel.AutoSize = true;
            this.removeQuantityLabel.Location = new System.Drawing.Point(29, 158);
            this.removeQuantityLabel.Name = "removeQuantityLabel";
            this.removeQuantityLabel.Size = new System.Drawing.Size(206, 19);
            this.removeQuantityLabel.TabIndex = 17;
            this.removeQuantityLabel.Text = "Enter quantity to remove: ";
            // 
            // removeQuantityInput
            // 
            this.removeQuantityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeQuantityInput.Location = new System.Drawing.Point(266, 153);
            this.removeQuantityInput.Name = "removeQuantityInput";
            this.removeQuantityInput.Size = new System.Drawing.Size(183, 26);
            this.removeQuantityInput.TabIndex = 18;
            // 
            // RemoveStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(521, 310);
            this.Controls.Add(this.removeQuantityInput);
            this.Controls.Add(this.removeQuantityLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stockCodeRemInput);
            this.Controls.Add(this.stockCodeLabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveStockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Stock Quantity";
            this.Load += new System.EventHandler(this.RemoveStockQty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label stockCodeLabel;
        private System.Windows.Forms.TextBox stockCodeRemInput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label removeQuantityLabel;
        private System.Windows.Forms.TextBox removeQuantityInput;
    }
}