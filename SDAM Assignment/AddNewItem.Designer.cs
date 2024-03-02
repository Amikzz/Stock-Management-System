namespace SDAM_Assignment
{
    partial class AddNewItem
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
            this.stockCodeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.stockCodeInput = new System.Windows.Forms.TextBox();
            this.stockNameInput = new System.Windows.Forms.TextBox();
            this.enterQuanityInput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stockCodeLabel
            // 
            this.stockCodeLabel.AutoSize = true;
            this.stockCodeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCodeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.stockCodeLabel.Location = new System.Drawing.Point(32, 91);
            this.stockCodeLabel.Name = "stockCodeLabel";
            this.stockCodeLabel.Size = new System.Drawing.Size(153, 19);
            this.stockCodeLabel.TabIndex = 0;
            this.stockCodeLabel.Text = "Enter Stock Code: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(156, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Stock Name: ";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(32, 173);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(128, 19);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Enter Quantity: ";
            // 
            // stockCodeInput
            // 
            this.stockCodeInput.Location = new System.Drawing.Point(196, 88);
            this.stockCodeInput.Name = "stockCodeInput";
            this.stockCodeInput.Size = new System.Drawing.Size(300, 26);
            this.stockCodeInput.TabIndex = 3;
            // 
            // stockNameInput
            // 
            this.stockNameInput.Location = new System.Drawing.Point(196, 130);
            this.stockNameInput.Name = "stockNameInput";
            this.stockNameInput.Size = new System.Drawing.Size(300, 26);
            this.stockNameInput.TabIndex = 4;
            // 
            // enterQuanityInput
            // 
            this.enterQuanityInput.Location = new System.Drawing.Point(196, 170);
            this.enterQuanityInput.Name = "enterQuanityInput";
            this.enterQuanityInput.Size = new System.Drawing.Size(300, 26);
            this.enterQuanityInput.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(51, 249);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Azure;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(389, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 30);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.headingLabel.Location = new System.Drawing.Point(153, 22);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(228, 24);
            this.headingLabel.TabIndex = 8;
            this.headingLabel.Text = "Add a new Stock Item";
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(521, 310);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterQuanityInput);
            this.Controls.Add(this.stockNameInput);
            this.Controls.Add(this.stockCodeInput);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.stockCodeLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Stock Item";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockCodeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox stockCodeInput;
        private System.Windows.Forms.TextBox stockNameInput;
        private System.Windows.Forms.TextBox enterQuanityInput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label headingLabel;
    }
}