using System.ComponentModel;
namespace CafeSystem
{



    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            View.AutoGenerateColumns = true;
            View.DataSource = Order;

        }

        public class Class1
        {
            public string order { get; set; }
            public decimal price { get; set; }
            public Class1(string order, decimal price)
            {
                this.order = order;
                this.price = price;

            }
        }

        
        public BindingList<Class1> Order = new BindingList<Class1>();

        

        public void CalculateTotal()
        {
            decimal total = 0;
            foreach (Class1 item in Order)
            {
                total += item.price;
            }
            txtResult.Text = $"₱ {total:0.00}";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void btnBurger_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Burger", 85.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();



        }

        private void btnChickenSand_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Chicken Sandwich", 75.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();

        }

        private void btnFrenchFries_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("French Fries", 50.00m);
            Order.Add(order);
            Orders();
        }

        private void btnSpag_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Spaghetti", 95.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnSoftDrink(object sender, EventArgs e)
        {

            Class1 order = new Class1("Soft Drink", 45.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnSDrink_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("SoftDrink", 35.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Iced Tea", 40.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Bottled Water", 25.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {

            Class1 order = new Class1("Coffee", 45.00m);
            Order.Add(order);
            Orders();
            CalculateTotal();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {



            MessageBox.Show("=======================\nCodeffee\n======================= \nOrder Summary:\n\n" + string.Join("\n", Order.Select(o => $"{ o.order} - ₱ { o.price:0.00} ")) + $"\n\nTotal: ₱ { Order.Sum(o => o.price):0.00}\n\nThank you for your order!"


                ) ;

        }
        public void Orders()
        {
            View.Refresh();
        }

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void nudBurger_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            Order.Clear();
            View.Refresh();
            CalculateTotal();
        }
    }
}
