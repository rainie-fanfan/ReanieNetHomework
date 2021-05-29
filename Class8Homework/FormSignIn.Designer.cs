
namespace HomeWork8
{
    partial class FormSignIn
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
            this.labSystem = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCusName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labSystem
            // 
            this.labSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSystem.AutoSize = true;
            this.labSystem.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSystem.Location = new System.Drawing.Point(175, 25);
            this.labSystem.Name = "labSystem";
            this.labSystem.Size = new System.Drawing.Size(180, 27);
            this.labSystem.TabIndex = 0;
            this.labSystem.Text = "订单管理系统";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 14F);
            this.labName.Location = new System.Drawing.Point(151, 62);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(66, 19);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 70);
            this.panel1.TabIndex = 2;
            // 
            // textCusName
            // 
            this.textCusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCusName.Font = new System.Drawing.Font("宋体", 14F);
            this.textCusName.Location = new System.Drawing.Point(244, 59);
            this.textCusName.Name = "textCusName";
            this.textCusName.Size = new System.Drawing.Size(150, 29);
            this.textCusName.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labName);
            this.panel2.Controls.Add(this.textCusName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 248);
            this.panel2.TabIndex = 4;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSignIn.Location = new System.Drawing.Point(197, 32);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 42);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "登录";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSignIn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 100);
            this.panel3.TabIndex = 5;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSignIn";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignIn_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labSystem;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textCusName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel panel3;
    }
}