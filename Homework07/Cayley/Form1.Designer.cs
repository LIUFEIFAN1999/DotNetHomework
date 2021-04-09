
namespace Cayley
{
    partial class Form1
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
            this.labeln = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelleng = new System.Windows.Forms.Label();
            this.textBoxPer2 = new System.Windows.Forms.TextBox();
            this.textBoxPer1 = new System.Windows.Forms.TextBox();
            this.labelth2 = new System.Windows.Forms.Label();
            this.labelper1 = new System.Windows.Forms.Label();
            this.labelper2 = new System.Windows.Forms.Label();
            this.textBoxLeng = new System.Windows.Forms.TextBox();
            this.textBoxTh2 = new System.Windows.Forms.TextBox();
            this.labelcolor = new System.Windows.Forms.Label();
            this.labelth1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxTh1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeln
            // 
            this.labeln.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(49, 37);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(80, 18);
            this.labeln.TabIndex = 10;
            this.labeln.Text = "递归深度";
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxN.Location = new System.Drawing.Point(39, 124);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 28);
            this.textBoxN.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 744);
            this.panel1.TabIndex = 20;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelleng
            // 
            this.labelleng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelleng.AutoSize = true;
            this.labelleng.Location = new System.Drawing.Point(227, 37);
            this.labelleng.Name = "labelleng";
            this.labelleng.Size = new System.Drawing.Size(80, 18);
            this.labelleng.TabIndex = 11;
            this.labelleng.Text = "主干长度";
            // 
            // textBoxPer2
            // 
            this.textBoxPer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPer2.Location = new System.Drawing.Point(39, 308);
            this.textBoxPer2.Name = "textBoxPer2";
            this.textBoxPer2.Size = new System.Drawing.Size(100, 28);
            this.textBoxPer2.TabIndex = 7;
            // 
            // textBoxPer1
            // 
            this.textBoxPer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPer1.Location = new System.Drawing.Point(217, 308);
            this.textBoxPer1.Name = "textBoxPer1";
            this.textBoxPer1.Size = new System.Drawing.Size(100, 28);
            this.textBoxPer1.TabIndex = 4;
            // 
            // labelth2
            // 
            this.labelth2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelth2.AutoSize = true;
            this.labelth2.Location = new System.Drawing.Point(4, 405);
            this.labelth2.Name = "labelth2";
            this.labelth2.Size = new System.Drawing.Size(170, 18);
            this.labelth2.TabIndex = 14;
            this.labelth2.Text = "左分支角度(PI/180)";
            // 
            // labelper1
            // 
            this.labelper1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelper1.AutoSize = true;
            this.labelper1.Location = new System.Drawing.Point(209, 221);
            this.labelper1.Name = "labelper1";
            this.labelper1.Size = new System.Drawing.Size(116, 18);
            this.labelper1.TabIndex = 9;
            this.labelper1.Text = "右分支长度比";
            // 
            // labelper2
            // 
            this.labelper2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelper2.AutoSize = true;
            this.labelper2.Location = new System.Drawing.Point(31, 221);
            this.labelper2.Name = "labelper2";
            this.labelper2.Size = new System.Drawing.Size(116, 18);
            this.labelper2.TabIndex = 12;
            this.labelper2.Text = "左分支长度比";
            // 
            // textBoxLeng
            // 
            this.textBoxLeng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLeng.Location = new System.Drawing.Point(217, 124);
            this.textBoxLeng.Name = "textBoxLeng";
            this.textBoxLeng.Size = new System.Drawing.Size(100, 28);
            this.textBoxLeng.TabIndex = 5;
            // 
            // textBoxTh2
            // 
            this.textBoxTh2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTh2.Location = new System.Drawing.Point(39, 492);
            this.textBoxTh2.Name = "textBoxTh2";
            this.textBoxTh2.Size = new System.Drawing.Size(100, 28);
            this.textBoxTh2.TabIndex = 6;
            // 
            // labelcolor
            // 
            this.labelcolor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcolor.AutoSize = true;
            this.labelcolor.Location = new System.Drawing.Point(49, 589);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(80, 18);
            this.labelcolor.TabIndex = 15;
            this.labelcolor.Text = "画笔颜色";
            // 
            // labelth1
            // 
            this.labelth1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelth1.AutoSize = true;
            this.labelth1.Location = new System.Drawing.Point(182, 405);
            this.labelth1.Name = "labelth1";
            this.labelth1.Size = new System.Drawing.Size(170, 18);
            this.labelth1.TabIndex = 13;
            this.labelth1.Text = "右分支角度(PI/180)";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Pink",
            "Orange",
            "Yellow",
            "Purple"});
            this.comboBox1.Location = new System.Drawing.Point(39, 679);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // textBoxTh1
            // 
            this.textBoxTh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTh1.Location = new System.Drawing.Point(217, 492);
            this.textBoxTh1.Name = "textBoxTh1";
            this.textBoxTh1.Size = new System.Drawing.Size(100, 28);
            this.textBoxTh1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(227, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Location = new System.Drawing.Point(517, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 744);
            this.panel2.TabIndex = 21;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button1, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.textBoxPer1, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBoxTh2, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.textBoxLeng, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelth2, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBoxPer2, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.labeln, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelper1, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBoxN, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelper2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelleng, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelcolor, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.labelth1, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBoxTh1, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 0, 7);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(357, 740);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTh1;
        private System.Windows.Forms.Label labelth1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelleng;
        private System.Windows.Forms.TextBox textBoxLeng;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.Label labelper2;
        private System.Windows.Forms.TextBox textBoxTh2;
        private System.Windows.Forms.TextBox textBoxPer2;
        private System.Windows.Forms.Label labelth2;
        private System.Windows.Forms.Label labelper1;
        private System.Windows.Forms.TextBox textBoxPer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

