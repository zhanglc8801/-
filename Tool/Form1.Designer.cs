namespace Tool
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnJiexi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下载选中章节DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载选中章节分别保存EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在浏览器中打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载选中章节到TXTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.XH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址：";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(50, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(542, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // btnJiexi
            // 
            this.btnJiexi.Location = new System.Drawing.Point(598, 12);
            this.btnJiexi.Name = "btnJiexi";
            this.btnJiexi.Size = new System.Drawing.Size(75, 23);
            this.btnJiexi.TabIndex = 2;
            this.btnJiexi.Text = "解析";
            this.btnJiexi.UseVisualStyleBackColor = true;
            this.btnJiexi.Click += new System.EventHandler(this.btnJiexi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XH,
            this.Title,
            this.Link});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 377);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载选中章节DToolStripMenuItem,
            this.下载选中章节分别保存EToolStripMenuItem,
            this.在浏览器中打开OToolStripMenuItem,
            this.下载选中章节到TXTTToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(262, 92);
            // 
            // 下载选中章节DToolStripMenuItem
            // 
            this.下载选中章节DToolStripMenuItem.Name = "下载选中章节DToolStripMenuItem";
            this.下载选中章节DToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.下载选中章节DToolStripMenuItem.Text = "下载选中章节到Word(&D)";
            this.下载选中章节DToolStripMenuItem.Click += new System.EventHandler(this.下载选中章节DToolStripMenuItem_Click);
            // 
            // 下载选中章节分别保存EToolStripMenuItem
            // 
            this.下载选中章节分别保存EToolStripMenuItem.Name = "下载选中章节分别保存EToolStripMenuItem";
            this.下载选中章节分别保存EToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.下载选中章节分别保存EToolStripMenuItem.Text = "下载选中章节到Word_分别保存(&E)";
            this.下载选中章节分别保存EToolStripMenuItem.Click += new System.EventHandler(this.下载选中章节分别保存EToolStripMenuItem_Click);
            // 
            // 在浏览器中打开OToolStripMenuItem
            // 
            this.在浏览器中打开OToolStripMenuItem.Name = "在浏览器中打开OToolStripMenuItem";
            this.在浏览器中打开OToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.在浏览器中打开OToolStripMenuItem.Text = "在浏览器中打开(&O)";
            // 
            // 下载选中章节到TXTTToolStripMenuItem
            // 
            this.下载选中章节到TXTTToolStripMenuItem.Name = "下载选中章节到TXTTToolStripMenuItem";
            this.下载选中章节到TXTTToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.下载选中章节到TXTTToolStripMenuItem.Text = "下载选中章节到TXT(&T)";
            this.下载选中章节到TXTTToolStripMenuItem.Click += new System.EventHandler(this.下载选中章节到TXTTToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // XH
            // 
            this.XH.DataPropertyName = "index";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.XH.DefaultCellStyle = dataGridViewCellStyle2;
            this.XH.HeaderText = "序号";
            this.XH.Name = "XH";
            this.XH.ReadOnly = true;
            this.XH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.XH.Width = 50;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "章节标题";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 280;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            this.Link.HeaderText = "下载链接";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.Width = 325;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnJiexi);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnJiexi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下载选中章节DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载选中章节分别保存EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在浏览器中打开OToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 下载选中章节到TXTTToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn XH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
    }
}

