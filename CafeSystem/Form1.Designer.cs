namespace CafeSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBurger = new Button();
            btnChickenSand = new Button();
            btnSpag = new Button();
            btnFrenchFries = new Button();
            lblFood = new Label();
            btnTea = new Button();
            btnCoffee = new Button();
            btnWater = new Button();
            lblDrink = new Label();
            lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            View = new DataGridView();
            btnSDrink = new Button();
            btnOrder = new Button();
            btnClear = new Button();
            txtResult = new TextBox();
            lblOrders = new Label();
            ((System.ComponentModel.ISupportInitialize)View).BeginInit();
            SuspendLayout();
            // 
            // btnBurger
            // 
            btnBurger.Location = new Point(41, 235);
            btnBurger.Margin = new Padding(4, 5, 4, 5);
            btnBurger.Name = "btnBurger";
            btnBurger.Size = new Size(127, 140);
            btnBurger.TabIndex = 0;
            btnBurger.Text = "Burger";
            btnBurger.UseVisualStyleBackColor = true;
            btnBurger.Click += btnBurger_Click;
            // 
            // btnChickenSand
            // 
            btnChickenSand.Location = new Point(203, 235);
            btnChickenSand.Margin = new Padding(4, 5, 4, 5);
            btnChickenSand.Name = "btnChickenSand";
            btnChickenSand.Size = new Size(127, 140);
            btnChickenSand.TabIndex = 0;
            btnChickenSand.Text = "Chicken Sandwich";
            btnChickenSand.UseVisualStyleBackColor = true;
            btnChickenSand.Click += btnChickenSand_Click;
            // 
            // btnSpag
            // 
            btnSpag.Location = new Point(527, 235);
            btnSpag.Margin = new Padding(4, 5, 4, 5);
            btnSpag.Name = "btnSpag";
            btnSpag.Size = new Size(127, 140);
            btnSpag.TabIndex = 0;
            btnSpag.Text = "Spaghetti";
            btnSpag.UseVisualStyleBackColor = true;
            btnSpag.Click += btnSpag_Click;
            // 
            // btnFrenchFries
            // 
            btnFrenchFries.Location = new Point(366, 235);
            btnFrenchFries.Margin = new Padding(4, 5, 4, 5);
            btnFrenchFries.Name = "btnFrenchFries";
            btnFrenchFries.Size = new Size(127, 140);
            btnFrenchFries.TabIndex = 0;
            btnFrenchFries.Text = "French Fries";
            btnFrenchFries.UseVisualStyleBackColor = true;
            btnFrenchFries.Click += btnFrenchFries_Click;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFood.Location = new Point(41, 88);
            lblFood.Margin = new Padding(4, 0, 4, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(166, 55);
            lblFood.TabIndex = 1;
            lblFood.Text = "FOOD";
            lblFood.Click += label1_Click;
            // 
            // btnTea
            // 
            btnTea.Location = new Point(203, 660);
            btnTea.Margin = new Padding(4, 5, 4, 5);
            btnTea.Name = "btnTea";
            btnTea.Size = new Size(127, 140);
            btnTea.TabIndex = 0;
            btnTea.Text = "Iced Tea";
            btnTea.UseVisualStyleBackColor = true;
            btnTea.Click += btnTea_Click;
            // 
            // btnCoffee
            // 
            btnCoffee.Location = new Point(527, 660);
            btnCoffee.Margin = new Padding(4, 5, 4, 5);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(127, 140);
            btnCoffee.TabIndex = 0;
            btnCoffee.Text = "Coffee";
            btnCoffee.UseVisualStyleBackColor = true;
            btnCoffee.Click += btnCoffee_Click;
            // 
            // btnWater
            // 
            btnWater.Location = new Point(366, 660);
            btnWater.Margin = new Padding(4, 5, 4, 5);
            btnWater.Name = "btnWater";
            btnWater.Size = new Size(127, 140);
            btnWater.TabIndex = 0;
            btnWater.Text = "Bottled Water";
            btnWater.UseVisualStyleBackColor = true;
            btnWater.Click += btnWater_Click;
            // 
            // lblDrink
            // 
            lblDrink.AutoSize = true;
            lblDrink.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrink.Location = new Point(41, 512);
            lblDrink.Margin = new Padding(4, 0, 4, 0);
            lblDrink.Name = "lblDrink";
            lblDrink.Size = new Size(181, 47);
            lblDrink.TabIndex = 1;
            lblDrink.Text = "DRINKS";
            lblDrink.Click += label1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(77, 395);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(43, 25);
            lbl.TabIndex = 3;
            lbl.Text = "₱85";
            lbl.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 395);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 3;
            label3.Text = "₱75";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 395);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 3;
            label4.Text = "₱95";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 395);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 3;
            label5.Text = "₱50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 828);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 3;
            label6.Text = "₱35";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 828);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 25);
            label7.TabIndex = 3;
            label7.Text = "₱40";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 828);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 25);
            label8.TabIndex = 3;
            label8.Text = "₱45";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(574, 828);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 25);
            label9.TabIndex = 3;
            label9.Text = "₱25";
            // 
            // View
            // 
            View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View.Location = new Point(830, 125);
            View.Margin = new Padding(4, 5, 4, 5);
            View.Name = "View";
            View.RowHeadersWidth = 62;
            View.Size = new Size(343, 540);
            View.TabIndex = 4;
            View.CellContentClick += View_CellContentClick;
            // 
            // btnSDrink
            // 
            btnSDrink.Location = new Point(41, 660);
            btnSDrink.Margin = new Padding(4, 5, 4, 5);
            btnSDrink.Name = "btnSDrink";
            btnSDrink.Size = new Size(127, 140);
            btnSDrink.TabIndex = 0;
            btnSDrink.Text = "Soft Drink";
            btnSDrink.UseVisualStyleBackColor = true;
            btnSDrink.Click += btnSDrink_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(192, 255, 192);
            btnOrder.Location = new Point(1031, 828);
            btnOrder.Margin = new Padding(4, 5, 4, 5);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(141, 57);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Location = new Point(830, 828);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 57);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(830, 675);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(341, 141);
            txtResult.TabIndex = 6;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrders.Location = new Point(877, 45);
            lblOrders.Margin = new Padding(4, 0, 4, 0);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(236, 55);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "ORDERS";
            lblOrders.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 1050);
            Controls.Add(txtResult);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(View);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(lblDrink);
            Controls.Add(lblOrders);
            Controls.Add(lblFood);
            Controls.Add(btnWater);
            Controls.Add(btnCoffee);
            Controls.Add(btnFrenchFries);
            Controls.Add(btnSDrink);
            Controls.Add(btnTea);
            Controls.Add(btnSpag);
            Controls.Add(btnChickenSand);
            Controls.Add(btnBurger);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBurger;
        private Button btnChickenSand;
        private Button btnSpag;
        private Button btnFrenchFries;
        private Label lblFood;
        
        private Button btnTea;
        private Button btnCoffee;
        private Button btnWater;
        private Label lblDrink;
        private Label lbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView View;
        private Button btnSDrink;
        private Button btnOrder;
        private Button btnClear;
        private TextBox txtResult;
        private Label lblOrders;
    }
}
