namespace SDAM_Assignment
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.addNewStockButton = new System.Windows.Forms.Button();
            this.addQtyButton = new System.Windows.Forms.Button();
            this.removeStockButton = new System.Windows.Forms.Button();
            this.viewTransactionButton = new System.Windows.Forms.Button();
            this.stockLevelButton = new System.Windows.Forms.Button();
            this.optionMenuLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewStockButton
            // 
            this.addNewStockButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addNewStockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addNewStockButton.FlatAppearance.BorderSize = 0;
            this.addNewStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewStockButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStockButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewStockButton.Location = new System.Drawing.Point(456, 84);
            this.addNewStockButton.Name = "addNewStockButton";
            this.addNewStockButton.Size = new System.Drawing.Size(185, 48);
            this.addNewStockButton.TabIndex = 0;
            this.addNewStockButton.Text = "Add New Stock Item";
            this.addNewStockButton.UseVisualStyleBackColor = false;
            this.addNewStockButton.Click += new System.EventHandler(this.addNewStockButton_Click);
            // 
            // addQtyButton
            // 
            this.addQtyButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQtyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQtyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addQtyButton.Location = new System.Drawing.Point(456, 142);
            this.addQtyButton.Name = "addQtyButton";
            this.addQtyButton.Size = new System.Drawing.Size(185, 48);
            this.addQtyButton.TabIndex = 1;
            this.addQtyButton.Text = "Add Stock Quantity";
            this.addQtyButton.UseVisualStyleBackColor = false;
            this.addQtyButton.Click += new System.EventHandler(this.addQtyButton_Click);
            // 
            // removeStockButton
            // 
            this.removeStockButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeStockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStockButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStockButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeStockButton.Location = new System.Drawing.Point(456, 201);
            this.removeStockButton.Name = "removeStockButton";
            this.removeStockButton.Size = new System.Drawing.Size(185, 48);
            this.removeStockButton.TabIndex = 2;
            this.removeStockButton.Text = "Remove Stock Quantity";
            this.removeStockButton.UseVisualStyleBackColor = false;
            this.removeStockButton.Click += new System.EventHandler(this.removeStockButton_Click);
            // 
            // viewTransactionButton
            // 
            this.viewTransactionButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTransactionButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransactionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.viewTransactionButton.Location = new System.Drawing.Point(456, 259);
            this.viewTransactionButton.Name = "viewTransactionButton";
            this.viewTransactionButton.Size = new System.Drawing.Size(185, 48);
            this.viewTransactionButton.TabIndex = 3;
            this.viewTransactionButton.Text = "View Transaction Log";
            this.viewTransactionButton.UseVisualStyleBackColor = false;
            this.viewTransactionButton.Click += new System.EventHandler(this.viewTransactionButton_Click);
            // 
            // stockLevelButton
            // 
            this.stockLevelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.stockLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockLevelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLevelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stockLevelButton.Location = new System.Drawing.Point(456, 317);
            this.stockLevelButton.Name = "stockLevelButton";
            this.stockLevelButton.Size = new System.Drawing.Size(185, 48);
            this.stockLevelButton.TabIndex = 4;
            this.stockLevelButton.Text = "View Stock Levels";
            this.stockLevelButton.UseVisualStyleBackColor = false;
            this.stockLevelButton.Click += new System.EventHandler(this.stockLevelButton_Click);
            // 
            // optionMenuLabel
            // 
            this.optionMenuLabel.AutoSize = true;
            this.optionMenuLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionMenuLabel.Location = new System.Drawing.Point(462, 43);
            this.optionMenuLabel.Name = "optionMenuLabel";
            this.optionMenuLabel.Size = new System.Drawing.Size(173, 24);
            this.optionMenuLabel.TabIndex = 5;
            this.optionMenuLabel.Text = "Select an option";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(483, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 457);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(141, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(111, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(247, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amikzz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(247, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Developed by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(149, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SDAM_Assignment.Properties.Resources._7656428_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(109, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionMenuLabel);
            this.Controls.Add(this.stockLevelButton);
            this.Controls.Add(this.viewTransactionButton);
            this.Controls.Add(this.removeStockButton);
            this.Controls.Add(this.addQtyButton);
            this.Controls.Add(this.addNewStockButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Stock Management System";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewStockButton;
        private System.Windows.Forms.Button addQtyButton;
        private System.Windows.Forms.Button removeStockButton;
        private System.Windows.Forms.Button viewTransactionButton;
        private System.Windows.Forms.Button stockLevelButton;
        private System.Windows.Forms.Label optionMenuLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}