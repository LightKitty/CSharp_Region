namespace CSharp_Region
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawRectangle = new System.Windows.Forms.Button();
            this.RegionComplement = new System.Windows.Forms.Button();
            this.RegionExclude = new System.Windows.Forms.Button();
            this.RegionIntersect = new System.Windows.Forms.Button();
            this.RegionMakeInfinite = new System.Windows.Forms.Button();
            this.RegionUnion = new System.Windows.Forms.Button();
            this.RegionXor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RegionData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrawRectangle
            // 
            this.DrawRectangle.Location = new System.Drawing.Point(642, 77);
            this.DrawRectangle.Name = "DrawRectangle";
            this.DrawRectangle.Size = new System.Drawing.Size(123, 36);
            this.DrawRectangle.TabIndex = 0;
            this.DrawRectangle.Text = "Draw Rectangle";
            this.toolTip1.SetToolTip(this.DrawRectangle, "绘制两个矩形");
            this.DrawRectangle.UseVisualStyleBackColor = true;
            this.DrawRectangle.Click += new System.EventHandler(this.DrawRectangle_Click);
            // 
            // RegionComplement
            // 
            this.RegionComplement.Location = new System.Drawing.Point(642, 124);
            this.RegionComplement.Name = "RegionComplement";
            this.RegionComplement.Size = new System.Drawing.Size(123, 36);
            this.RegionComplement.TabIndex = 1;
            this.RegionComplement.Text = "Region Complement";
            this.toolTip1.SetToolTip(this.RegionComplement, "获取目标矩形与此Region不相交的部分");
            this.RegionComplement.UseVisualStyleBackColor = true;
            this.RegionComplement.Click += new System.EventHandler(this.RegionComplement_Click);
            // 
            // RegionExclude
            // 
            this.RegionExclude.Location = new System.Drawing.Point(642, 171);
            this.RegionExclude.Name = "RegionExclude";
            this.RegionExclude.Size = new System.Drawing.Size(123, 36);
            this.RegionExclude.TabIndex = 2;
            this.RegionExclude.Text = "Region Exclude";
            this.toolTip1.SetToolTip(this.RegionExclude, "获取此Region与目标矩形不相交的部分");
            this.RegionExclude.UseVisualStyleBackColor = true;
            this.RegionExclude.Click += new System.EventHandler(this.RegionExclude_Click);
            // 
            // RegionIntersect
            // 
            this.RegionIntersect.Location = new System.Drawing.Point(642, 218);
            this.RegionIntersect.Name = "RegionIntersect";
            this.RegionIntersect.Size = new System.Drawing.Size(123, 36);
            this.RegionIntersect.TabIndex = 3;
            this.RegionIntersect.Text = "Region Intersect";
            this.toolTip1.SetToolTip(this.RegionIntersect, "获取两个矩形的交集");
            this.RegionIntersect.UseVisualStyleBackColor = true;
            this.RegionIntersect.Click += new System.EventHandler(this.RegionIntersect_Click);
            // 
            // RegionMakeInfinite
            // 
            this.RegionMakeInfinite.Location = new System.Drawing.Point(642, 359);
            this.RegionMakeInfinite.Name = "RegionMakeInfinite";
            this.RegionMakeInfinite.Size = new System.Drawing.Size(123, 36);
            this.RegionMakeInfinite.TabIndex = 4;
            this.RegionMakeInfinite.Text = "Region MakeInfinite";
            this.toolTip1.SetToolTip(this.RegionMakeInfinite, "将此 System.Drawing.Region 对象初始化为无限内部");
            this.RegionMakeInfinite.UseVisualStyleBackColor = true;
            this.RegionMakeInfinite.Click += new System.EventHandler(this.RegionMakeInfinite_Click);
            // 
            // RegionUnion
            // 
            this.RegionUnion.Location = new System.Drawing.Point(642, 265);
            this.RegionUnion.Name = "RegionUnion";
            this.RegionUnion.Size = new System.Drawing.Size(123, 36);
            this.RegionUnion.TabIndex = 5;
            this.RegionUnion.Text = "Region Union";
            this.toolTip1.SetToolTip(this.RegionUnion, "获取两个矩形的并集");
            this.RegionUnion.UseVisualStyleBackColor = true;
            this.RegionUnion.Click += new System.EventHandler(this.RegionUnion_Click);
            // 
            // RegionXor
            // 
            this.RegionXor.Location = new System.Drawing.Point(642, 312);
            this.RegionXor.Name = "RegionXor";
            this.RegionXor.Size = new System.Drawing.Size(123, 36);
            this.RegionXor.TabIndex = 6;
            this.RegionXor.Text = "Region Xor";
            this.toolTip1.SetToolTip(this.RegionXor, "获取两个矩形的并集中不相交的部分");
            this.RegionXor.UseVisualStyleBackColor = true;
            this.RegionXor.Click += new System.EventHandler(this.RegionXor_Click);
            // 
            // RegionData
            // 
            this.RegionData.Location = new System.Drawing.Point(642, 406);
            this.RegionData.Name = "RegionData";
            this.RegionData.Size = new System.Drawing.Size(123, 36);
            this.RegionData.TabIndex = 8;
            this.RegionData.Text = "DisplayRegionData";
            this.toolTip1.SetToolTip(this.RegionData, "显示RegionData信息");
            this.RegionData.UseVisualStyleBackColor = true;
            this.RegionData.Click += new System.EventHandler(this.RegionData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "本实例使用两个矩形A和B来演示\r\nSystem.Drawing.Region类的各方法的功能。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 469);
            this.Controls.Add(this.RegionData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegionXor);
            this.Controls.Add(this.RegionUnion);
            this.Controls.Add(this.RegionMakeInfinite);
            this.Controls.Add(this.RegionIntersect);
            this.Controls.Add(this.RegionExclude);
            this.Controls.Add(this.RegionComplement);
            this.Controls.Add(this.DrawRectangle);
            this.Name = "Form1";
            this.Text = "CSharp_Region";
            this.toolTip1.SetToolTip(this, "获取目标矩形与此Region不相交的部分");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawRectangle;
        private System.Windows.Forms.Button RegionComplement;
        private System.Windows.Forms.Button RegionExclude;
        private System.Windows.Forms.Button RegionIntersect;
        private System.Windows.Forms.Button RegionMakeInfinite;
        private System.Windows.Forms.Button RegionUnion;
        private System.Windows.Forms.Button RegionXor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegionData;
    }
}

