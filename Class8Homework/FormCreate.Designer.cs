
namespace HomeWork8
{
    partial class FormCreate
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.labCreate = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDetail = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labNum = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.textProduct = new System.Windows.Forms.TextBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.labCreate);
            this.panel1.Controls.Add(this.labAddress);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 104);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 14F);
            this.btnOK.Location = new System.Drawing.Point(686, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 33);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "完成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labCreate
            // 
            this.labCreate.AutoSize = true;
            this.labCreate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCreate.Location = new System.Drawing.Point(25, 21);
            this.labCreate.Name = "labCreate";
            this.labCreate.Size = new System.Drawing.Size(93, 20);
            this.labCreate.TabIndex = 0;
            this.labCreate.Text = "创建订单";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("宋体", 14F);
            this.labAddress.Location = new System.Drawing.Point(25, 66);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(66, 19);
            this.labAddress.TabIndex = 0;
            this.labAddress.Text = "地址：";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("宋体", 14F);
            this.textAddress.Location = new System.Drawing.Point(119, 63);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(302, 29);
            this.textAddress.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("宋体", 14F);
            this.btnCreate.Location = new System.Drawing.Point(96, 332);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 33);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "添加订单明细";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView.DataSource = this.bindingSourceDetail;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView.Location = new System.Drawing.Point(0, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(516, 388);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn2.HeaderText = "Num";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // bindingSourceDetail
            // 
            this.bindingSourceDetail.DataSource = typeof(Order.OrderDetails);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.textNum);
            this.panel2.Controls.Add(this.textPrice);
            this.panel2.Controls.Add(this.labNum);
            this.panel2.Controls.Add(this.labPrice);
            this.panel2.Controls.Add(this.textProduct);
            this.panel2.Controls.Add(this.labProduct);
            this.panel2.Controls.Add(this.labDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(522, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 388);
            this.panel2.TabIndex = 1;
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("宋体", 14F);
            this.textNum.Location = new System.Drawing.Point(96, 253);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(189, 29);
            this.textNum.TabIndex = 12;
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.textPrice.Location = new System.Drawing.Point(96, 166);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(189, 29);
            this.textPrice.TabIndex = 11;
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("宋体", 14F);
            this.labNum.Location = new System.Drawing.Point(24, 256);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(66, 19);
            this.labNum.TabIndex = 10;
            this.labNum.Text = "数量：";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("宋体", 14F);
            this.labPrice.Location = new System.Drawing.Point(24, 169);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(66, 19);
            this.labPrice.TabIndex = 9;
            this.labPrice.Text = "单价：";
            // 
            // textProduct
            // 
            this.textProduct.Font = new System.Drawing.Font("宋体", 14F);
            this.textProduct.Location = new System.Drawing.Point(98, 80);
            this.textProduct.Name = "textProduct";
            this.textProduct.Size = new System.Drawing.Size(189, 29);
            this.textProduct.TabIndex = 9;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Font = new System.Drawing.Font("宋体", 14F);
            this.labProduct.Location = new System.Drawing.Point(26, 83);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(66, 19);
            this.labProduct.TabIndex = 9;
            this.labProduct.Text = "商品：";
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDetail.Location = new System.Drawing.Point(94, 15);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(135, 20);
            this.labDetail.TabIndex = 9;
            this.labDetail.Text = "创建订单明细";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labCreate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox textProduct;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}