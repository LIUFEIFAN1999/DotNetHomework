using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
using System.Runtime.InteropServices;


namespace OrderWindowApp
{
    

    
    public partial class Form_orderList : Form
    {
        public List<OrderDetails> itemList = new List<OrderDetails>();

        private Customer customer1;
        private Customer customer2;
        private Goods pc;
        private Goods guitar;
        private Goods shirt;
        private Goods bag;
        private OrderDetails item0;
        private OrderDetails item1;
        private OrderDetails item2;
        private OrderDetails item3;
        private Order order0;
        private Order order1;
        private Order order2;
        private Order order3;
        private OrderService orderService;
        public List<string> selectList = new List<string> { "All", "Id", "Customer", "Product", "Amount" };


        public string QueryString { get; set; }
        public Form_orderList()
        {
            InitializeComponent();
                
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            dataGridView_order.Update();
            if(comboBox_query.SelectedIndex == 0)
            {
                textBox_query.Text = "";
                orderbindingSource.DataSource = orderService.QueryAll();
            }
            if (comboBox_query.SelectedIndex == 1)
            {
                orderbindingSource.DataSource = orderService.QueryById(int.Parse(QueryString));
            }
            if (comboBox_query.SelectedIndex == 2)
            {
                orderbindingSource.DataSource = orderService.QueryByCustomer(QueryString);
            }
            if (comboBox_query.SelectedIndex == 3)
            {
                orderbindingSource.DataSource = orderService.QueryByName(QueryString);
            }
            if (comboBox_query.SelectedIndex == 4)
            {
                string pattern = @"^[0-9]*[.]*[0-9]*$";
                if (QueryString != null && Regex.Match(QueryString, pattern).Success)
                {
                    orderbindingSource.DataSource = orderService.QueryByAmount(Convert.ToDouble(QueryString));
                }
                else
                {
                    textBox_query.Text = "";
                    orderbindingSource.DataSource = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_query.DataBindings.Add("Text", this, "QueryString");
            comboBox_query.DataSource = selectList;

            customer1 = new Customer(1, "LiuFeifan", "18812345678");
            customer2 = new Customer(2, "Liuxia", "18202939333");

            /*pc = new Goods("computer", "Lenovo 16G 512G i5", 4325.99, 1000);
            pc.GoodsId = 1;
            guitar = new Goods("guitar", "Mesopotamia S200 41", 2680, 2000);
            shirt = new Goods("T-Shirt", "Li-Ning 2021", 129.98, 50);
            bag = new Goods("handbag", "Dior Latest", 10000, 500);*/

            item0 = new OrderDetails(1, 1);
            /*item1 = new OrderDetails(guitar, 2);
            item2 = new OrderDetails(shirt, 3);
            item3 = new OrderDetails(bag, 1);*/

            //item0.Goods = null;
            order0 = new Order(20, customer1, "Wuhan", item0);
            order0.ItemList.Add(item0);
            order1 = new Order(21, customer2, "wuhan", item0);
            /*order1 = new Order(2, customer2, "Nanchang", item2);
            order2 = new Order(3, customer1, "Shanghai", item1);
            order3 = new Order(4, customer2, "Beijing", item3);*/

            orderService = new OrderService();
            /*orderService.Add(order0);
            orderService.Add(order1);*/
            /* orderService.Add(order2);
             orderService.Add(order3);*/
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Close_MdiChildren();
            Form_items itemsForm = new Form_items("创建订单", 0);
            itemsForm.MdiParent = this;
            itemsForm.itemList = this.itemList;
            itemsForm.orderService = this.orderService;
            itemsForm.Show();
        }

        private void button_repository_Click(object sender, EventArgs e)
        {
            Close_MdiChildren();
            Form_add_item productForm = new Form_add_item();
            productForm.MdiParent = this;
            productForm.itemList = this.itemList;
            productForm.Show();
        }

        private void button_items_Click(object sender, EventArgs e)
        {
            Close_MdiChildren();
            Form_items itemsForm = new Form_items("创建订单", 0);
            itemsForm.MdiParent = this;
            itemsForm.itemList = this.itemList;
            itemsForm.orderService = this.orderService;
            itemsForm.Show();
        }

        private void comboBox_query_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_query.Text = "";
        }

        //刷新订单列表
        private void button_orderList_Click(object sender, EventArgs e)
        {
            List<Order> orderList = orderService.QueryAll();

            Console.WriteLine(orderList[0].Customer);
            orderbindingSource.DataSource = orderService.QueryAll();
        }

        //导入订单
        private void button_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "|*.xml";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    orderService.Import(openFile.FileName);
                    MessageBox.Show("导入成功！");

                    comboBox_query.SelectedIndex = 0;
                    orderbindingSource.DataSource = orderService.OrderList;
                }
            }
        }

        //导出订单
        private void button_export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "|*.xml";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    orderService.Export(saveFile.FileName);
                    MessageBox.Show("导出成功！");
                }
            }
        }


        //删除订单
        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                orderService.Delete(int.Parse(dataGridView_order.Rows[e.RowIndex].Cells[0].Value.ToString()));
                orderbindingSource.DataSource = orderService.QueryAll();
            }
        }

        //查看或修改订单
        private void dataGridView_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close_MdiChildren();
            Order order = orderService.QueryById(int.Parse(dataGridView_order.Rows[e.RowIndex].Cells[0].Value.ToString()));
            Form_items orderForm = new Form_items("修改订单", order.Amount);
            orderForm.MdiParent = this;
            orderForm.orderService = this.orderService;
            orderForm.itemList = order.ItemList;
            orderForm.Customer = order.Customer.Name;
            orderForm.Address = order.Address;
            orderForm.id = order.OrderId;
            orderForm.Show();
        }

        //关闭子窗口
        private void Close_MdiChildren()
        {
            foreach(Form form in this.MdiChildren)
            {
                form.Dispose();
            }
        }
    }
}
