using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.Entity;

namespace OrderWindowApp
{
    public partial class Form_add_item : Form
    {
        public List<OrderDetails> itemList = new List<OrderDetails>();
        public OrderService orderService = new OrderService();
        List<Goods> goodsList = new List<Goods>();

        public int Apple { get; set; } = 1;
        public int Banana { get; set; } = 1;
        public int Blueberry { get; set; } = 1;
        public int Cherry { get; set; } = 1;
        public int Grape { get; set; } = 1;
        public int Kiwi { get; set; } = 1;
        public int Litchi { get; set; } = 1;
        public int Mango { get; set; } = 1;
        public int Mangosteen { get; set; } = 1;
        public int Orange { get; set; } = 1;
        public int Peach { get; set; } = 1;
        public int Pear { get; set; } = 1;
        public int Pineapple { get; set; } = 1;
        public int Pitaya { get; set; } = 1;
        public int Strawberry { get; set; } = 1;
        public int Watermelon { get; set; } = 1;

        public Form_add_item()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Form_add_order_Load(object sender, EventArgs e)
        {
            textBox_apple.DataBindings.Add("Text", this, "Apple");
            textBox_banana.DataBindings.Add("Text", this, "Banana");
            textBox_blueberry.DataBindings.Add("Text", this, "Blueberry");
            textBox_cherry.DataBindings.Add("Text", this, "Cherry");
            textBox_grape.DataBindings.Add("Text", this, "Grape");
            textBox_kiwi.DataBindings.Add("Text", this, "Kiwi");
            textBox_litchi.DataBindings.Add("Text", this, "Litchi");
            textBox_mango.DataBindings.Add("Text", this, "Mango");
            textBox_mangosteen.DataBindings.Add("Text", this, "Mangosteen");
            textBox_orange.DataBindings.Add("Text", this, "Orange");
            textBox_peach.DataBindings.Add("Text", this, "Peach");
            textBox_pear.DataBindings.Add("Text", this, "Pear");
            textBox_pineapple.DataBindings.Add("Text", this, "Pineapple");
            textBox_pitaya.DataBindings.Add("Text", this, "Pitaya");
            textBox_strawberry.DataBindings.Add("Text", this, "Strawberry");
            textBox_watermelon.DataBindings.Add("Text", this, "Watermelon");
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name.Split('_')[1];
            string propertyName = name.Substring(0, 1).ToUpper() + name.Substring(1);
            using (var db = new OrderContext())
            {
                Goods selectedGoods = orderService.queryGoods(name);
                int count = (int)this.GetType().GetProperty(propertyName).GetValue(this);
                itemList.Add(new OrderDetails(count,selectedGoods));
            }
            
            MessageBox.Show("已加入购物车");
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0][0-9]*$";
            if (Regex.Match(((TextBox)sender).Text, pattern).Success)
            {
                ((TextBox)sender).Text = "1";
            }
        }
    }
}
