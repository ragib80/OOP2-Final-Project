namespace Restaurant_Management_System.Views
{
    partial class FoodCart
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
            this.BurgerQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBurgerPrice = new System.Windows.Forms.TextBox();
            this.tbPizzaPrice = new System.Windows.Forms.TextBox();
            this.tbSandwichPrice = new System.Windows.Forms.TextBox();
            this.tbCokePrice = new System.Windows.Forms.TextBox();
            this.tbCoffeePrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PizzaQuantity = new System.Windows.Forms.NumericUpDown();
            this.SandwichQuantity = new System.Windows.Forms.NumericUpDown();
            this.CokeQuantity = new System.Windows.Forms.NumericUpDown();
            this.CoffeeQuantity = new System.Windows.Forms.NumericUpDown();
            this.gridOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CokeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // BurgerQuantity
            // 
            this.BurgerQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerQuantity.Location = new System.Drawing.Point(286, 124);
            this.BurgerQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.BurgerQuantity.Name = "BurgerQuantity";
            this.BurgerQuantity.Size = new System.Drawing.Size(90, 27);
            this.BurgerQuantity.TabIndex = 0;
            this.BurgerQuantity.ValueChanged += new System.EventHandler(this.BurgerQuantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foodcart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "FoodMenu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Burger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pizza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sandwich";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Coke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Coffee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price";
            // 
            // tbBurgerPrice
            // 
            this.tbBurgerPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBurgerPrice.Location = new System.Drawing.Point(175, 124);
            this.tbBurgerPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbBurgerPrice.Name = "tbBurgerPrice";
            this.tbBurgerPrice.Size = new System.Drawing.Size(56, 27);
            this.tbBurgerPrice.TabIndex = 9;
            this.tbBurgerPrice.Text = "20";
            this.tbBurgerPrice.TextChanged += new System.EventHandler(this.tbBurgerPrice_TextChanged);
            // 
            // tbPizzaPrice
            // 
            this.tbPizzaPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPizzaPrice.Location = new System.Drawing.Point(175, 164);
            this.tbPizzaPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPizzaPrice.Name = "tbPizzaPrice";
            this.tbPizzaPrice.Size = new System.Drawing.Size(56, 27);
            this.tbPizzaPrice.TabIndex = 10;
            this.tbPizzaPrice.TextChanged += new System.EventHandler(this.tbPizzaPrice_TextChanged);
            // 
            // tbSandwichPrice
            // 
            this.tbSandwichPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSandwichPrice.Location = new System.Drawing.Point(175, 204);
            this.tbSandwichPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbSandwichPrice.Name = "tbSandwichPrice";
            this.tbSandwichPrice.Size = new System.Drawing.Size(56, 27);
            this.tbSandwichPrice.TabIndex = 11;
            this.tbSandwichPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbCokePrice
            // 
            this.tbCokePrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCokePrice.Location = new System.Drawing.Point(175, 240);
            this.tbCokePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbCokePrice.Name = "tbCokePrice";
            this.tbCokePrice.Size = new System.Drawing.Size(56, 27);
            this.tbCokePrice.TabIndex = 12;
            // 
            // tbCoffeePrice
            // 
            this.tbCoffeePrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoffeePrice.Location = new System.Drawing.Point(175, 280);
            this.tbCoffeePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbCoffeePrice.Name = "tbCoffeePrice";
            this.tbCoffeePrice.Size = new System.Drawing.Size(56, 27);
            this.tbCoffeePrice.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantity";
            // 
            // PizzaQuantity
            // 
            this.PizzaQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaQuantity.Location = new System.Drawing.Point(286, 164);
            this.PizzaQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.PizzaQuantity.Name = "PizzaQuantity";
            this.PizzaQuantity.Size = new System.Drawing.Size(90, 27);
            this.PizzaQuantity.TabIndex = 15;
            // 
            // SandwichQuantity
            // 
            this.SandwichQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichQuantity.Location = new System.Drawing.Point(286, 204);
            this.SandwichQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.SandwichQuantity.Name = "SandwichQuantity";
            this.SandwichQuantity.Size = new System.Drawing.Size(90, 27);
            this.SandwichQuantity.TabIndex = 16;
            // 
            // CokeQuantity
            // 
            this.CokeQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CokeQuantity.Location = new System.Drawing.Point(286, 240);
            this.CokeQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.CokeQuantity.Name = "CokeQuantity";
            this.CokeQuantity.Size = new System.Drawing.Size(90, 27);
            this.CokeQuantity.TabIndex = 17;
            // 
            // CoffeeQuantity
            // 
            this.CoffeeQuantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeQuantity.Location = new System.Drawing.Point(286, 280);
            this.CoffeeQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.CoffeeQuantity.Name = "CoffeeQuantity";
            this.CoffeeQuantity.Size = new System.Drawing.Size(90, 27);
            this.CoffeeQuantity.TabIndex = 18;
            // 
            // gridOrderDetails
            // 
            this.gridOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetails.Location = new System.Drawing.Point(492, 85);
            this.gridOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gridOrderDetails.Name = "gridOrderDetails";
            this.gridOrderDetails.RowHeadersWidth = 51;
            this.gridOrderDetails.RowTemplate.Height = 24;
            this.gridOrderDetails.Size = new System.Drawing.Size(346, 221);
            this.gridOrderDetails.TabIndex = 19;
            this.gridOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrderDetails_CellContentClick);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(208, 336);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(167, 33);
            this.btnConfirmOrder.TabIndex = 20;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(208, 383);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(167, 33);
            this.btnDeleteOrder.TabIndex = 21;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(696, 335);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(90, 27);
            this.tbTotalPrice.TabIndex = 22;
            this.tbTotalPrice.TextChanged += new System.EventHandler(this.tbTotalPrice_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Price";
            // 
            // FoodCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Management_System.Properties.Resources.screenshot_2_1;
            this.ClientSize = new System.Drawing.Size(889, 443);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.gridOrderDetails);
            this.Controls.Add(this.CoffeeQuantity);
            this.Controls.Add(this.CokeQuantity);
            this.Controls.Add(this.SandwichQuantity);
            this.Controls.Add(this.PizzaQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCoffeePrice);
            this.Controls.Add(this.tbCokePrice);
            this.Controls.Add(this.tbSandwichPrice);
            this.Controls.Add(this.tbPizzaPrice);
            this.Controls.Add(this.tbBurgerPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BurgerQuantity);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FoodCart";
            this.Text = "FoodCart";
            ((System.ComponentModel.ISupportInitialize)(this.BurgerQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CokeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BurgerQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBurgerPrice;
        private System.Windows.Forms.TextBox tbPizzaPrice;
        private System.Windows.Forms.TextBox tbSandwichPrice;
        private System.Windows.Forms.TextBox tbCokePrice;
        private System.Windows.Forms.TextBox tbCoffeePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PizzaQuantity;
        private System.Windows.Forms.NumericUpDown SandwichQuantity;
        private System.Windows.Forms.NumericUpDown CokeQuantity;
        private System.Windows.Forms.NumericUpDown CoffeeQuantity;
        private System.Windows.Forms.DataGridView gridOrderDetails;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label10;
    }
}