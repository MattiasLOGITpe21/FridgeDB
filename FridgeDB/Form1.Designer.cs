namespace FridgeDB
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
            this.FoodType = new System.Windows.Forms.Label();
            this.listFood = new System.Windows.Forms.ListBox();
            this.FoodInTheFridge = new System.Windows.Forms.Label();
            this.listFoodInTheFridge = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FoodType
            // 
            this.FoodType.AutoSize = true;
            this.FoodType.Location = new System.Drawing.Point(24, 41);
            this.FoodType.Name = "FoodType";
            this.FoodType.Size = new System.Drawing.Size(58, 13);
            this.FoodType.TabIndex = 0;
            this.FoodType.Text = "Food Type";
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.Location = new System.Drawing.Point(27, 97);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(120, 95);
            this.listFood.TabIndex = 1;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            // 
            // FoodInTheFridge
            // 
            this.FoodInTheFridge.AutoSize = true;
            this.FoodInTheFridge.Location = new System.Drawing.Point(262, 41);
            this.FoodInTheFridge.Name = "FoodInTheFridge";
            this.FoodInTheFridge.Size = new System.Drawing.Size(97, 13);
            this.FoodInTheFridge.TabIndex = 2;
            this.FoodInTheFridge.Text = "Food In The Fridge";
            // 
            // listFoodInTheFridge
            // 
            this.listFoodInTheFridge.FormattingEnabled = true;
            this.listFoodInTheFridge.Location = new System.Drawing.Point(265, 97);
            this.listFoodInTheFridge.Name = "listFoodInTheFridge";
            this.listFoodInTheFridge.Size = new System.Drawing.Size(120, 95);
            this.listFoodInTheFridge.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodInTheFridge);
            this.Controls.Add(this.FoodInTheFridge);
            this.Controls.Add(this.listFood);
            this.Controls.Add(this.FoodType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoodType;
        private System.Windows.Forms.ListBox listFood;
        private System.Windows.Forms.Label FoodInTheFridge;
        private System.Windows.Forms.ListBox listFoodInTheFridge;
    }
}

