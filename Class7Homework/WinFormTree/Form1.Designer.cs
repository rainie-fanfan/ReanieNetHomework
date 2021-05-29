
namespace WinFormTree
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
            this.btn_Draw = new System.Windows.Forms.Button();
            this.lab_N = new System.Windows.Forms.Label();
            this.text_N = new System.Windows.Forms.TextBox();
            this.lab_length = new System.Windows.Forms.Label();
            this.lab_per_right = new System.Windows.Forms.Label();
            this.lab_per_left = new System.Windows.Forms.Label();
            this.lab_th_right = new System.Windows.Forms.Label();
            this.lab_th_left = new System.Windows.Forms.Label();
            this.text_length = new System.Windows.Forms.TextBox();
            this.track_per_right = new System.Windows.Forms.TrackBar();
            this.track_per_left = new System.Windows.Forms.TrackBar();
            this.track_th_right = new System.Windows.Forms.TrackBar();
            this.track_th_left = new System.Windows.Forms.TrackBar();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.group_color = new System.Windows.Forms.GroupBox();
            this.label_Color_Text = new System.Windows.Forms.Label();
            this.label_Col = new System.Windows.Forms.Label();
            this.lab_Color = new System.Windows.Forms.Label();
            this.btn_Color = new System.Windows.Forms.Button();
            this.group_th = new System.Windows.Forms.GroupBox();
            this.group_per = new System.Windows.Forms.GroupBox();
            this.group_standard = new System.Windows.Forms.GroupBox();
            this.panel_Canvas = new System.Windows.Forms.Panel();
            this.lab_Y = new System.Windows.Forms.Label();
            this.lab_X = new System.Windows.Forms.Label();
            this.lab_position = new System.Windows.Forms.Label();
            this.lab_Click = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.track_per_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_per_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_th_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_th_left)).BeginInit();
            this.panel_setting.SuspendLayout();
            this.group_color.SuspendLayout();
            this.group_th.SuspendLayout();
            this.group_per.SuspendLayout();
            this.group_standard.SuspendLayout();
            this.panel_Canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Draw
            // 
            this.btn_Draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Draw.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Draw.Location = new System.Drawing.Point(147, 508);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(128, 34);
            this.btn_Draw.TabIndex = 0;
            this.btn_Draw.Text = "应用参数";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // lab_N
            // 
            this.lab_N.AutoSize = true;
            this.lab_N.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_N.Location = new System.Drawing.Point(15, 28);
            this.lab_N.Name = "lab_N";
            this.lab_N.Size = new System.Drawing.Size(88, 16);
            this.lab_N.TabIndex = 1;
            this.lab_N.Text = "递归深度：";
            // 
            // text_N
            // 
            this.text_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_N.Location = new System.Drawing.Point(143, 25);
            this.text_N.Name = "text_N";
            this.text_N.Size = new System.Drawing.Size(100, 26);
            this.text_N.TabIndex = 2;
            // 
            // lab_length
            // 
            this.lab_length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_length.AutoSize = true;
            this.lab_length.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_length.Location = new System.Drawing.Point(15, 64);
            this.lab_length.Name = "lab_length";
            this.lab_length.Size = new System.Drawing.Size(88, 16);
            this.lab_length.TabIndex = 3;
            this.lab_length.Text = "主干长度：";
            // 
            // lab_per_right
            // 
            this.lab_per_right.AutoSize = true;
            this.lab_per_right.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_per_right.Location = new System.Drawing.Point(9, 35);
            this.lab_per_right.Name = "lab_per_right";
            this.lab_per_right.Size = new System.Drawing.Size(120, 16);
            this.lab_per_right.TabIndex = 4;
            this.lab_per_right.Text = "右分支长度比：";
            // 
            // lab_per_left
            // 
            this.lab_per_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_per_left.AutoSize = true;
            this.lab_per_left.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_per_left.Location = new System.Drawing.Point(9, 73);
            this.lab_per_left.Name = "lab_per_left";
            this.lab_per_left.Size = new System.Drawing.Size(120, 16);
            this.lab_per_left.TabIndex = 5;
            this.lab_per_left.Text = "左分支长度比：";
            // 
            // lab_th_right
            // 
            this.lab_th_right.AutoSize = true;
            this.lab_th_right.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_th_right.Location = new System.Drawing.Point(6, 35);
            this.lab_th_right.Name = "lab_th_right";
            this.lab_th_right.Size = new System.Drawing.Size(104, 16);
            this.lab_th_right.TabIndex = 6;
            this.lab_th_right.Text = "右分支角度：";
            // 
            // lab_th_left
            // 
            this.lab_th_left.AutoSize = true;
            this.lab_th_left.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_th_left.Location = new System.Drawing.Point(6, 73);
            this.lab_th_left.Name = "lab_th_left";
            this.lab_th_left.Size = new System.Drawing.Size(104, 16);
            this.lab_th_left.TabIndex = 7;
            this.lab_th_left.Text = "左分支角度：";
            // 
            // text_length
            // 
            this.text_length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.text_length.Location = new System.Drawing.Point(143, 61);
            this.text_length.Name = "text_length";
            this.text_length.Size = new System.Drawing.Size(100, 26);
            this.text_length.TabIndex = 8;
            // 
            // track_per_right
            // 
            this.track_per_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.track_per_right.Location = new System.Drawing.Point(126, 25);
            this.track_per_right.Name = "track_per_right";
            this.track_per_right.Size = new System.Drawing.Size(121, 45);
            this.track_per_right.TabIndex = 9;
            // 
            // track_per_left
            // 
            this.track_per_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.track_per_left.Location = new System.Drawing.Point(126, 63);
            this.track_per_left.Name = "track_per_left";
            this.track_per_left.Size = new System.Drawing.Size(121, 45);
            this.track_per_left.TabIndex = 10;
            // 
            // track_th_right
            // 
            this.track_th_right.Location = new System.Drawing.Point(127, 25);
            this.track_th_right.Maximum = 90;
            this.track_th_right.Name = "track_th_right";
            this.track_th_right.Size = new System.Drawing.Size(121, 45);
            this.track_th_right.TabIndex = 11;
            // 
            // track_th_left
            // 
            this.track_th_left.Location = new System.Drawing.Point(127, 63);
            this.track_th_left.Maximum = 90;
            this.track_th_left.Name = "track_th_left";
            this.track_th_left.Size = new System.Drawing.Size(121, 45);
            this.track_th_left.TabIndex = 12;
            // 
            // panel_setting
            // 
            this.panel_setting.Controls.Add(this.btn_Reset);
            this.panel_setting.Controls.Add(this.group_color);
            this.panel_setting.Controls.Add(this.group_th);
            this.panel_setting.Controls.Add(this.group_per);
            this.panel_setting.Controls.Add(this.group_standard);
            this.panel_setting.Controls.Add(this.btn_Draw);
            this.panel_setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_setting.Location = new System.Drawing.Point(0, 0);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(284, 554);
            this.panel_setting.TabIndex = 13;
            // 
            // group_color
            // 
            this.group_color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.group_color.Controls.Add(this.label_Color_Text);
            this.group_color.Controls.Add(this.label_Col);
            this.group_color.Controls.Add(this.lab_Color);
            this.group_color.Controls.Add(this.btn_Color);
            this.group_color.Font = new System.Drawing.Font("宋体", 12F);
            this.group_color.Location = new System.Drawing.Point(12, 360);
            this.group_color.Name = "group_color";
            this.group_color.Size = new System.Drawing.Size(262, 127);
            this.group_color.TabIndex = 17;
            this.group_color.TabStop = false;
            this.group_color.Text = "画笔颜色";
            // 
            // label_Color_Text
            // 
            this.label_Color_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Color_Text.AutoSize = true;
            this.label_Color_Text.Location = new System.Drawing.Point(170, 36);
            this.label_Color_Text.MinimumSize = new System.Drawing.Size(80, 20);
            this.label_Color_Text.Name = "label_Color_Text";
            this.label_Color_Text.Size = new System.Drawing.Size(80, 20);
            this.label_Color_Text.TabIndex = 19;
            // 
            // label_Col
            // 
            this.label_Col.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Col.AutoSize = true;
            this.label_Col.Location = new System.Drawing.Point(122, 36);
            this.label_Col.Name = "label_Col";
            this.label_Col.Size = new System.Drawing.Size(56, 16);
            this.label_Col.TabIndex = 18;
            this.label_Col.Text = "颜色：";
            // 
            // lab_Color
            // 
            this.lab_Color.AutoSize = true;
            this.lab_Color.BackColor = System.Drawing.Color.White;
            this.lab_Color.Location = new System.Drawing.Point(23, 30);
            this.lab_Color.MaximumSize = new System.Drawing.Size(80, 80);
            this.lab_Color.MinimumSize = new System.Drawing.Size(80, 80);
            this.lab_Color.Name = "lab_Color";
            this.lab_Color.Size = new System.Drawing.Size(80, 80);
            this.lab_Color.TabIndex = 17;
            // 
            // btn_Color
            // 
            this.btn_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Color.Location = new System.Drawing.Point(125, 86);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(107, 26);
            this.btn_Color.TabIndex = 16;
            this.btn_Color.Text = "选择颜色";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // group_th
            // 
            this.group_th.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.group_th.Controls.Add(this.track_th_left);
            this.group_th.Controls.Add(this.track_th_right);
            this.group_th.Controls.Add(this.lab_th_left);
            this.group_th.Controls.Add(this.lab_th_right);
            this.group_th.Font = new System.Drawing.Font("宋体", 12F);
            this.group_th.Location = new System.Drawing.Point(12, 240);
            this.group_th.Name = "group_th";
            this.group_th.Size = new System.Drawing.Size(262, 114);
            this.group_th.TabIndex = 15;
            this.group_th.TabStop = false;
            this.group_th.Text = "分支角度";
            // 
            // group_per
            // 
            this.group_per.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.group_per.Controls.Add(this.track_per_left);
            this.group_per.Controls.Add(this.track_per_right);
            this.group_per.Controls.Add(this.lab_per_left);
            this.group_per.Controls.Add(this.lab_per_right);
            this.group_per.Font = new System.Drawing.Font("宋体", 12F);
            this.group_per.Location = new System.Drawing.Point(12, 120);
            this.group_per.Name = "group_per";
            this.group_per.Size = new System.Drawing.Size(262, 114);
            this.group_per.TabIndex = 14;
            this.group_per.TabStop = false;
            this.group_per.Text = "长度比";
            // 
            // group_standard
            // 
            this.group_standard.Controls.Add(this.text_N);
            this.group_standard.Controls.Add(this.lab_N);
            this.group_standard.Controls.Add(this.text_length);
            this.group_standard.Controls.Add(this.lab_length);
            this.group_standard.Font = new System.Drawing.Font("宋体", 12F);
            this.group_standard.Location = new System.Drawing.Point(12, 12);
            this.group_standard.Name = "group_standard";
            this.group_standard.Size = new System.Drawing.Size(262, 102);
            this.group_standard.TabIndex = 14;
            this.group_standard.TabStop = false;
            this.group_standard.Text = "基本参数";
            // 
            // panel_Canvas
            // 
            this.panel_Canvas.Controls.Add(this.lab_Y);
            this.panel_Canvas.Controls.Add(this.lab_X);
            this.panel_Canvas.Controls.Add(this.lab_position);
            this.panel_Canvas.Controls.Add(this.lab_Click);
            this.panel_Canvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Canvas.Location = new System.Drawing.Point(290, 0);
            this.panel_Canvas.Name = "panel_Canvas";
            this.panel_Canvas.Size = new System.Drawing.Size(613, 554);
            this.panel_Canvas.TabIndex = 14;
            this.panel_Canvas.Click += new System.EventHandler(this.panel_Canvas_Click);
            // 
            // lab_Y
            // 
            this.lab_Y.AutoSize = true;
            this.lab_Y.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_Y.Location = new System.Drawing.Point(304, 16);
            this.lab_Y.Name = "lab_Y";
            this.lab_Y.Size = new System.Drawing.Size(24, 16);
            this.lab_Y.TabIndex = 3;
            this.lab_Y.Text = "Y:";
            // 
            // lab_X
            // 
            this.lab_X.AutoSize = true;
            this.lab_X.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_X.Location = new System.Drawing.Point(224, 16);
            this.lab_X.Name = "lab_X";
            this.lab_X.Size = new System.Drawing.Size(24, 16);
            this.lab_X.TabIndex = 2;
            this.lab_X.Text = "X:";
            // 
            // lab_position
            // 
            this.lab_position.AutoSize = true;
            this.lab_position.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_position.Location = new System.Drawing.Point(143, 16);
            this.lab_position.Name = "lab_position";
            this.lab_position.Size = new System.Drawing.Size(56, 16);
            this.lab_position.TabIndex = 1;
            this.lab_position.Text = "位置：";
            // 
            // lab_Click
            // 
            this.lab_Click.AutoSize = true;
            this.lab_Click.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Click.Location = new System.Drawing.Point(15, 13);
            this.lab_Click.Name = "lab_Click";
            this.lab_Click.Size = new System.Drawing.Size(104, 19);
            this.lab_Click.TabIndex = 0;
            this.lab_Click.Text = "点击生成树";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(12, 508);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(128, 34);
            this.btn_Reset.TabIndex = 18;
            this.btn_Reset.Text = "清屏";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 554);
            this.Controls.Add(this.panel_Canvas);
            this.Controls.Add(this.panel_setting);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.track_per_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_per_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_th_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_th_left)).EndInit();
            this.panel_setting.ResumeLayout(false);
            this.group_color.ResumeLayout(false);
            this.group_color.PerformLayout();
            this.group_th.ResumeLayout(false);
            this.group_th.PerformLayout();
            this.group_per.ResumeLayout(false);
            this.group_per.PerformLayout();
            this.group_standard.ResumeLayout(false);
            this.group_standard.PerformLayout();
            this.panel_Canvas.ResumeLayout(false);
            this.panel_Canvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Label lab_N;
        private System.Windows.Forms.TextBox text_N;
        private System.Windows.Forms.Label lab_length;
        private System.Windows.Forms.Label lab_per_right;
        private System.Windows.Forms.Label lab_per_left;
        private System.Windows.Forms.Label lab_th_right;
        private System.Windows.Forms.Label lab_th_left;
        private System.Windows.Forms.TextBox text_length;
        private System.Windows.Forms.TrackBar track_per_right;
        private System.Windows.Forms.TrackBar track_per_left;
        private System.Windows.Forms.TrackBar track_th_right;
        private System.Windows.Forms.TrackBar track_th_left;
        private System.Windows.Forms.Panel panel_setting;
        private System.Windows.Forms.GroupBox group_standard;
        private System.Windows.Forms.GroupBox group_per;
        private System.Windows.Forms.GroupBox group_th;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.GroupBox group_color;
        private System.Windows.Forms.Label label_Color_Text;
        private System.Windows.Forms.Label label_Col;
        private System.Windows.Forms.Label lab_Color;
        private System.Windows.Forms.Panel panel_Canvas;
        private System.Windows.Forms.Label lab_Y;
        private System.Windows.Forms.Label lab_X;
        private System.Windows.Forms.Label lab_position;
        private System.Windows.Forms.Label lab_Click;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_Reset;
    }
}

