
namespace OrderWindowApp
{
    partial class Form_orderList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_repository = new System.Windows.Forms.Button();
            this.button_items = new System.Windows.Forms.Button();
            this.button_orderList = new System.Windows.Forms.Button();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.orderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.button_query = new System.Windows.Forms.Button();
            this.comboBox_query = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.selectbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_repository, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_items, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_orderList, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_repository
            // 
            this.button_repository.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_repository.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_repository.FlatAppearance.BorderSize = 0;
            this.button_repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_repository.ForeColor = System.Drawing.Color.White;
            this.button_repository.Location = new System.Drawing.Point(0, 0);
            this.button_repository.Margin = new System.Windows.Forms.Padding(0);
            this.button_repository.Name = "button_repository";
            this.button_repository.Size = new System.Drawing.Size(323, 67);
            this.button_repository.TabIndex = 0;
            this.button_repository.Text = "仓库";
            this.button_repository.UseVisualStyleBackColor = false;
            this.button_repository.Click += new System.EventHandler(this.button_repository_Click);
            // 
            // button_items
            // 
            this.button_items.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_items.FlatAppearance.BorderSize = 0;
            this.button_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_items.ForeColor = System.Drawing.Color.White;
            this.button_items.Location = new System.Drawing.Point(323, 0);
            this.button_items.Margin = new System.Windows.Forms.Padding(0);
            this.button_items.Name = "button_items";
            this.button_items.Size = new System.Drawing.Size(323, 67);
            this.button_items.TabIndex = 1;
            this.button_items.Text = "购物车";
            this.button_items.UseVisualStyleBackColor = false;
            this.button_items.Click += new System.EventHandler(this.button_items_Click);
            // 
            // button_orderList
            // 
            this.button_orderList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_orderList.FlatAppearance.BorderSize = 0;
            this.button_orderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_orderList.ForeColor = System.Drawing.Color.White;
            this.button_orderList.Location = new System.Drawing.Point(646, 0);
            this.button_orderList.Margin = new System.Windows.Forms.Padding(0);
            this.button_orderList.Name = "button_orderList";
            this.button_orderList.Size = new System.Drawing.Size(324, 67);
            this.button_orderList.TabIndex = 2;
            this.button_orderList.Text = "订单列表";
            this.button_orderList.UseVisualStyleBackColor = false;
            this.button_orderList.Click += new System.EventHandler(this.button_orderList_Click);
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.AutoGenerateColumns = false;
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.customerDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridView_order.DataSource = this.orderbindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_order.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_order.GridColor = System.Drawing.Color.White;
            this.dataGridView_order.Location = new System.Drawing.Point(0, 326);
            this.dataGridView_order.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.ReadOnly = true;
            this.dataGridView_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_order.RowHeadersVisible = false;
            this.dataGridView_order.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_order.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_order.RowTemplate.Height = 30;
            this.dataGridView_order.Size = new System.Drawing.Size(970, 270);
            this.dataGridView_order.TabIndex = 2;
            this.dataGridView_order.TabStop = false;
            this.dataGridView_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_order_CellContentClick);
            this.dataGridView_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_order_CellDoubleClick);
            // 
            // orderbindingSource
            // 
            this.orderbindingSource.AllowNew = true;
            this.orderbindingSource.DataSource = typeof(OrderManagement.Order);
            // 
            // textBox_query
            // 
            this.textBox_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_query.Location = new System.Drawing.Point(484, 8);
            this.textBox_query.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(194, 21);
            this.textBox_query.TabIndex = 0;
            // 
            // button_query
            // 
            this.button_query.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_query.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_query.FlatAppearance.BorderSize = 0;
            this.button_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_query.ForeColor = System.Drawing.Color.White;
            this.button_query.Location = new System.Drawing.Point(680, 7);
            this.button_query.Margin = new System.Windows.Forms.Padding(2);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(73, 23);
            this.button_query.TabIndex = 1;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = false;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // comboBox_query
            // 
            this.comboBox_query.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_query.FormattingEnabled = true;
            this.comboBox_query.Location = new System.Drawing.Point(397, 8);
            this.comboBox_query.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_query.Name = "comboBox_query";
            this.comboBox_query.Size = new System.Drawing.Size(87, 20);
            this.comboBox_query.TabIndex = 2;
            this.comboBox_query.SelectedValueChanged += new System.EventHandler(this.comboBox_query_SelectedValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox_query, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_query, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_query, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_add, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_import, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_export, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(970, 37);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(860, 7);
            this.button_add.Margin = new System.Windows.Forms.Padding(0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(73, 23);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_import
            // 
            this.button_import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_import.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_import.FlatAppearance.BorderSize = 0;
            this.button_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_import.ForeColor = System.Drawing.Color.White;
            this.button_import.Location = new System.Drawing.Point(36, 7);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(73, 23);
            this.button_import.TabIndex = 4;
            this.button_import.Text = "导入";
            this.button_import.UseVisualStyleBackColor = false;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_export
            // 
            this.button_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_export.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_export.FlatAppearance.BorderSize = 0;
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.ForeColor = System.Drawing.Color.White;
            this.button_export.Location = new System.Drawing.Point(181, 7);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(73, 23);
            this.button_export.TabIndex = 5;
            this.button_export.Text = "导出";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Id";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // Form_orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 596);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView_order);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_orderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_repository;
        private System.Windows.Forms.Button button_items;
        private System.Windows.Forms.Button button_orderList;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.ComboBox comboBox_query;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.BindingSource selectbindingSource;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_export;
        internal System.Windows.Forms.BindingSource orderbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}

