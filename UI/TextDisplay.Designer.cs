﻿namespace Astrid.Common.UI {
    public partial  class TextDisplay {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.rtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxt
            // 
            this.rtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt.Location = new System.Drawing.Point(0, 0);
            this.rtxt.Multiline = true;
            this.rtxt.Name = "rtxt";
            this.rtxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rtxt.Size = new System.Drawing.Size(150, 150);
            this.rtxt.TabIndex = 0;
            // 
            // TextDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxt);
            this.Name = "TextDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rtxt;
    }
}
