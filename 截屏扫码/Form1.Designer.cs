namespace 截屏扫码
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
            this.blurMask = new System.Windows.Forms.Label();
            this.frontMask = new System.Windows.Forms.Label();
            this.txtHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blurMask
            // 
            this.blurMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blurMask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blurMask.Location = new System.Drawing.Point(0, 0);
            this.blurMask.Name = "blurMask";
            this.blurMask.Size = new System.Drawing.Size(770, 486);
            this.blurMask.TabIndex = 0;
            this.blurMask.Text = "       ";
            this.blurMask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.blurMask_MouseMove);
            // 
            // frontMask
            // 
            this.frontMask.BackColor = System.Drawing.Color.Transparent;
            this.frontMask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frontMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frontMask.ForeColor = System.Drawing.Color.Aqua;
            this.frontMask.Location = new System.Drawing.Point(290, 206);
            this.frontMask.Name = "frontMask";
            this.frontMask.Size = new System.Drawing.Size(192, 192);
            this.frontMask.TabIndex = 1;
            this.frontMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.frontMask.Click += new System.EventHandler(this.frontMask_Click);
            this.frontMask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.blurMask_MouseMove);
            // 
            // txtHint
            // 
            this.txtHint.AutoSize = true;
            this.txtHint.ForeColor = System.Drawing.Color.Aqua;
            this.txtHint.Location = new System.Drawing.Point(288, 398);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(155, 24);
            this.txtHint.TabIndex = 2;
            this.txtHint.Text = "按下鼠标左键决定，ESC取消\r\n使用滚轮调整取景器大小";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 486);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.frontMask);
            this.Controls.Add(this.blurMask);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blurMask;
        private System.Windows.Forms.Label frontMask;
        private System.Windows.Forms.Label txtHint;
    }
}

