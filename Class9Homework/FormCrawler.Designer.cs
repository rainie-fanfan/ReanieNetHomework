
namespace Homework9
{
    partial class FormCrawler
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labWebsite = new System.Windows.Forms.Label();
            this.textWebsite = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.labTextStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceUrl = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioCurrentNo = new System.Windows.Forms.RadioButton();
            this.radioCurrentYes = new System.Windows.Forms.RadioButton();
            this.labSetting = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUrl)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(124, 27);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "爬虫程序";
            // 
            // labWebsite
            // 
            this.labWebsite.AutoSize = true;
            this.labWebsite.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWebsite.Location = new System.Drawing.Point(12, 64);
            this.labWebsite.Name = "labWebsite";
            this.labWebsite.Size = new System.Drawing.Size(69, 19);
            this.labWebsite.TabIndex = 1;
            this.labWebsite.Text = "网站：";
            // 
            // textWebsite
            // 
            this.textWebsite.Font = new System.Drawing.Font("宋体", 12F);
            this.textWebsite.Location = new System.Drawing.Point(76, 61);
            this.textWebsite.Name = "textWebsite";
            this.textWebsite.Size = new System.Drawing.Size(531, 26);
            this.textWebsite.TabIndex = 2;
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.labStatus.Location = new System.Drawing.Point(73, 118);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(120, 16);
            this.labStatus.TabIndex = 3;
            this.labStatus.Text = "爬虫程序未开启";
            // 
            // labTextStatus
            // 
            this.labTextStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTextStatus.AutoSize = true;
            this.labTextStatus.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTextStatus.Location = new System.Drawing.Point(13, 114);
            this.labTextStatus.Name = "labTextStatus";
            this.labTextStatus.Size = new System.Drawing.Size(72, 20);
            this.labTextStatus.TabIndex = 4;
            this.labTextStatus.Text = "状态：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.textWebsite);
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Controls.Add(this.labStatus);
            this.panel1.Controls.Add(this.labTextStatus);
            this.panel1.Controls.Add(this.labWebsite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 157);
            this.panel1.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(642, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 115);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始爬虫";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSourceUrl;
            this.dataGridView.Location = new System.Drawing.Point(0, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(623, 293);
            this.dataGridView.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.Width = 250;
            // 
            // bindingSourceUrl
            // 
            this.bindingSourceUrl.DataSource = typeof(Homework9.Url);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioCurrentNo);
            this.panel2.Controls.Add(this.radioCurrentYes);
            this.panel2.Controls.Add(this.labSetting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(629, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 293);
            this.panel2.TabIndex = 7;
            // 
            // radioCurrentNo
            // 
            this.radioCurrentNo.AutoSize = true;
            this.radioCurrentNo.Font = new System.Drawing.Font("宋体", 11F);
            this.radioCurrentNo.Location = new System.Drawing.Point(95, 46);
            this.radioCurrentNo.Name = "radioCurrentNo";
            this.radioCurrentNo.Size = new System.Drawing.Size(40, 19);
            this.radioCurrentNo.TabIndex = 2;
            this.radioCurrentNo.Text = "否";
            this.radioCurrentNo.UseVisualStyleBackColor = true;
            // 
            // radioCurrentYes
            // 
            this.radioCurrentYes.AutoSize = true;
            this.radioCurrentYes.Checked = true;
            this.radioCurrentYes.Font = new System.Drawing.Font("宋体", 11F);
            this.radioCurrentYes.Location = new System.Drawing.Point(33, 46);
            this.radioCurrentYes.Name = "radioCurrentYes";
            this.radioCurrentYes.Size = new System.Drawing.Size(40, 19);
            this.radioCurrentYes.TabIndex = 1;
            this.radioCurrentYes.TabStop = true;
            this.radioCurrentYes.Text = "是";
            this.radioCurrentYes.UseVisualStyleBackColor = true;
            // 
            // labSetting
            // 
            this.labSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSetting.AutoSize = true;
            this.labSetting.Font = new System.Drawing.Font("宋体", 14F);
            this.labSetting.Location = new System.Drawing.Point(17, 12);
            this.labSetting.Name = "labSetting";
            this.labSetting.Size = new System.Drawing.Size(142, 19);
            this.labSetting.TabIndex = 0;
            this.labSetting.Text = "仅爬取当前页面";
            // 
            // FormCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrawler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUrl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labWebsite;
        private System.Windows.Forms.TextBox textWebsite;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label labTextStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSourceUrl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioCurrentNo;
        private System.Windows.Forms.RadioButton radioCurrentYes;
        private System.Windows.Forms.Label labSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}

