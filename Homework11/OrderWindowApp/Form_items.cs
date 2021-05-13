using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace OrderWindowApp
{
    public partial class Form_items : Form
    {
        public List<OrderDetails> itemList = new List<OrderDetails>();
        public OrderService orderService = new OrderService();
        public int id;

        public string Customer { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }


        public Form_items(string buttonString, double amount)
        {
            InitializeComponent();
            button_createOrder.Text = buttonString;
            Amount = amount;

            this.StartPosition = FormStartPosition.Manual;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_items_Load(object sender, EventArgs e)
        {
            textBox_customer.DataBindings.Add("Text", this, "Customer");
            textBox_address.DataBindings.Add("Text", this, "Address");
            label_tips.DataBindings.Add("Text", this, "Amount");
            Display();
        }
 

        //显示订单明细
        private void Display()
        {
            int n = itemList.Count;
            for (int index = 0; index < n; index++)
            {
                string name = itemList[index].Goods.Name;
                double price = itemList[index].Goods.Price;
                int count = itemList[index].Count;
                double amount = itemList[index].Amount;

                CheckBox checkBox = new CheckBox();
                checkBox.Anchor = AnchorStyles.None;
                checkBox.Text = "";
                if(button_createOrder.Text == "修改订单")
                {
                    checkBox.Checked = true;
                }
                checkBox.CheckStateChanged += checkBox_stateChanged;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                ResourceManager resourceManager = Properties.Resources.ResourceManager;
                Bitmap image = (Bitmap)resourceManager.GetObject(name);
                pictureBox.Image = image;

                Label label = new Label();
                float fontSize = 10.5f;
                FontFamily fontFamily = new FontFamily("Times New Roman");
                label.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = $"{name}\n\nPrice:${price}\n\nCount:{count}\n\nAmount:{amount}";

                tableLayoutPanel_items.Controls.Add(checkBox, 3 * index % 12, index / 4);
                tableLayoutPanel_items.Controls.Add(pictureBox, 3 * index % 12 + 1, index / 4);
                tableLayoutPanel_items.Controls.Add(label, 3 * index % 12 + 2, index / 4);
            }
        }

        private void button_createOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Customer = new Customer(Customer);
            order.Address = Address;

            if(Customer == null || Address == null)
            {
                MessageBox.Show("创建失败！\n请补全收货信息");
                return;
            }

            int n = itemList.Count;

            for(int index = 0; index < n; index++)
            {
                CheckBox checkBox = (CheckBox)tableLayoutPanel_items.GetControlFromPosition(3 * index % 12, index / 4);
                if(checkBox.Checked == true)
                {
                    OrderDetails item = new OrderDetails(itemList[index].Count, itemList[index].Goods.GoodsId);
                    order.ItemList.Add(item);
                    itemList[index] = null;
                }
            }

            if(button_createOrder.Text == "创建订单")
            {
                if (Amount == 0)
                {
                    MessageBox.Show("创建订单失败！\n请添加商品");
                }
                else
                {
                    orderService.Add(order);
                    itemList.RemoveAll(item => item == null);
                    tableLayoutPanel_items.Controls.Clear();
                    Display();
                    label_tips.Text = "0";
                }
            }
          
            if(button_createOrder.Text == "修改订单")
            {
                if(Amount == 0)
                {
                    //商品全部删除，修改订单==删除订单
                    orderService.Delete(id);
                }
                else
                {
                    //修改订单不改变id，而创建order时id为newId，需要改回原来id
                    order.OrderId = id;
                    orderService.Modify(id, order);
                }
                MessageBox.Show("修改订单成功！");
            }
            (this.MdiParent as Form_orderList).orderbindingSource.DataSource = orderService.QueryAll();
            if(button_createOrder.Text == "修改订单")
            {
                this.Dispose();
            }
        }

        private void checkBox_stateChanged(object sender, EventArgs e)
        {
            label_tips.DataBindings.Clear();
            int n = itemList.Count;
            Amount = 0;

            for (int index = 0; index < n; index++)
            {
                CheckBox checkBox = (CheckBox)tableLayoutPanel_items.GetControlFromPosition(3 * index % 12, index / 4);
                if (checkBox.Checked == true)
                {
                    this.Amount += itemList[index].Amount;
                }
            }
            label_tips.DataBindings.Add("Text", this, "Amount");
        }


    }
}
