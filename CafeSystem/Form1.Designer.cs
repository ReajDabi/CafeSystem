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
            textBox1 = new TextBox();
            nudBurger = new NumericUpDown();
            nudCS = new NumericUpDown();
            nudFF = new NumericUpDown();
            nudSD = new NumericUpDown();
            nudSpag = new NumericUpDown();
            nudIT = new NumericUpDown();
            nudC = new NumericUpDown();
            nudBW = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBW).BeginInit();
            SuspendLayout();
            // 
            // btnBurger
            // 
            btnBurger.Location = new Point(29, 141);
            btnBurger.Name = "btnBurger";
            btnBurger.Size = new Size(89, 84);
            btnBurger.TabIndex = 0;
            btnBurger.Text = "Burger";
            btnBurger.UseVisualStyleBackColor = true;
            btnBurger.Click += btnBurger_Click;
            // 
            // btnChickenSand
            // 
            btnChickenSand.Location = new Point(142, 141);
            btnChickenSand.Name = "btnChickenSand";
            btnChickenSand.Size = new Size(89, 84);
            btnChickenSand.TabIndex = 0;
            btnChickenSand.Text = "Chicken Sandwich";
            btnChickenSand.UseVisualStyleBackColor = true;
            btnChickenSand.Click += btnChickenSand_Click;
            // 
            // btnSpag
            // 
            btnSpag.Location = new Point(369, 141);
            btnSpag.Name = "btnSpag";
            btnSpag.Size = new Size(89, 84);
            btnSpag.TabIndex = 0;
            btnSpag.Text = "Spaghetti";
            btnSpag.UseVisualStyleBackColor = true;
            btnSpag.Click += btnSpag_Click;
            // 
            // btnFrenchFries
            // 
            btnFrenchFries.Location = new Point(256, 141);
            btnFrenchFries.Name = "btnFrenchFries";
            btnFrenchFries.Size = new Size(89, 84);
            btnFrenchFries.TabIndex = 0;
            btnFrenchFries.Text = "French Fries";
            btnFrenchFries.UseVisualStyleBackColor = true;
            btnFrenchFries.Click += btnFrenchFries_Click;
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFood.Location = new Point(29, 53);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(100, 38);
            lblFood.TabIndex = 1;
            lblFood.Text = "FOOD";
            lblFood.Click += label1_Click;
            // 
            // btnTea
            // 
            btnTea.Location = new Point(142, 396);
            btnTea.Name = "btnTea";
            btnTea.Size = new Size(89, 84);
            btnTea.TabIndex = 0;
            btnTea.Text = "Iced Tea";
            btnTea.UseVisualStyleBackColor = true;
            btnTea.Click += btnTea_Click;
            // 
            // btnCoffee
            // 
            btnCoffee.Location = new Point(369, 396);
            btnCoffee.Name = "btnCoffee";
            btnCoffee.Size = new Size(89, 84);
            btnCoffee.TabIndex = 0;
            btnCoffee.Text = "Coffee";
            btnCoffee.UseVisualStyleBackColor = true;
            btnCoffee.Click += btnCoffee_Click;
            // 
            // btnWater
            // 
            btnWater.Location = new Point(256, 396);
            btnWater.Name = "btnWater";
            btnWater.Size = new Size(89, 84);
            btnWater.TabIndex = 0;
            btnWater.Text = "Bottled Water";
            btnWater.UseVisualStyleBackColor = true;
            btnWater.Click += btnWater_Click;
            // 
            // lblDrink
            // 
            lblDrink.AutoSize = true;
            lblDrink.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrink.Location = new Point(29, 307);
            lblDrink.Name = "lblDrink";
            lblDrink.Size = new Size(121, 32);
            lblDrink.TabIndex = 1;
            lblDrink.Text = "DRINKS";
            lblDrink.Click += label1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(54, 237);
            lbl.Name = "lbl";
            lbl.Size = new Size(26, 15);
            lbl.TabIndex = 3;
            lbl.Text = "₱85";
            lbl.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 237);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 3;
            label3.Text = "₱75";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 237);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 3;
            label4.Text = "₱95";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 237);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 3;
            label5.Text = "₱50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 497);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 3;
            label6.Text = "₱35";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 497);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 3;
            label7.Text = "₱40";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 497);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 3;
            label8.Text = "₱45";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 497);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 3;
            label9.Text = "₱25";
            // 
            // View
            // 
            View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            View.Location = new Point(581, 75);
            View.Name = "View";
            View.Size = new Size(240, 324);
            View.TabIndex = 4;
            View.CellContentClick += View_CellContentClick;
            // 
            // btnSDrink
            // 
            btnSDrink.Location = new Point(29, 396);
            btnSDrink.Name = "btnSDrink";
            btnSDrink.Size = new Size(89, 84);
            btnSDrink.TabIndex = 0;
            btnSDrink.Text = "Soft Drink";
            btnSDrink.UseVisualStyleBackColor = true;
            btnSDrink.Click += btnSDrink_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(722, 497);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(99, 34);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(581, 497);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(581, 405);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 86);
            textBox1.TabIndex = 6;
            // 
            // nudBurger
            // 
            nudBurger.Location = new Point(29, 268);
            nudBurger.Name = "nudBurger";
            nudBurger.Size = new Size(57, 23);
            nudBurger.TabIndex = 7;
            nudBurger.ValueChanged += nudBurger_ValueChanged;
            // 
            // nudCS
            // 
            nudCS.Location = new Point(142, 268);
            nudCS.Name = "nudCS";
            nudCS.Size = new Size(57, 23);
            nudCS.TabIndex = 7;
            // 
            // nudFF
            // 
            nudFF.Location = new Point(259, 268);
            nudFF.Name = "nudFF";
            nudFF.Size = new Size(57, 23);
            nudFF.TabIndex = 7;
            // 
            // nudSD
            // 
            nudSD.Location = new Point(29, 530);
            nudSD.Name = "nudSD";
            nudSD.Size = new Size(57, 23);
            nudSD.TabIndex = 7;
            // 
            // nudSpag
            // 
            nudSpag.Location = new Point(371, 268);
            nudSpag.Name = "nudSpag";
            nudSpag.Size = new Size(57, 23);
            nudSpag.TabIndex = 7;
            // 
            // nudIT
            // 
            nudIT.Location = new Point(142, 530);
            nudIT.Name = "nudIT";
            nudIT.Size = new Size(57, 23);
            nudIT.TabIndex = 7;
            // 
            // nudC
            // 
            nudC.Location = new Point(369, 530);
            nudC.Name = "nudC";
            nudC.Size = new Size(57, 23);
            nudC.TabIndex = 7;
            // 
            // nudBW
            // 
            nudBW.Location = new Point(256, 530);
            nudBW.Name = "nudBW";
            nudBW.Size = new Size(57, 23);
            nudBW.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 670);
            Controls.Add(nudBW);
            Controls.Add(nudC);
            Controls.Add(nudIT);
            Controls.Add(nudSpag);
            Controls.Add(nudSD);
            Controls.Add(nudFF);
            Controls.Add(nudCS);
            Controls.Add(nudBurger);
            Controls.Add(textBox1);
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
            Controls.Add(lblFood);
            Controls.Add(btnWater);
            Controls.Add(btnCoffee);
            Controls.Add(btnFrenchFries);
            Controls.Add(btnSDrink);
            Controls.Add(btnTea);
            Controls.Add(btnSpag);
            Controls.Add(btnChickenSand);
            Controls.Add(btnBurger);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)View).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFF).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpag).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBW).EndInit();
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
        private TextBox textBox1;
        private NumericUpDown nudBurger;
        private NumericUpDown nudCS;
        private NumericUpDown nudFF;
        private NumericUpDown nudSD;
        private NumericUpDown nudSpag;
        private NumericUpDown nudIT;
        private NumericUpDown nudC;
        private NumericUpDown nudBW;
    }
}
