namespace WindowsFormsApp1
{
	partial class FormScrum
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScrum));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createStory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createAStoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createResponsible = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAResponsiblePersonToTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStory.SuspendLayout();
            this.createResponsible.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not Started";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createStory
            // 
            this.createStory.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.createStory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAStoryToolStripMenuItem});
            this.createStory.Name = "createStory";
            this.createStory.Size = new System.Drawing.Size(148, 26);
            // 
            // createAStoryToolStripMenuItem
            // 
            this.createAStoryToolStripMenuItem.Name = "createAStoryToolStripMenuItem";
            this.createAStoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.createAStoryToolStripMenuItem.Text = "Create a Story";
            this.createAStoryToolStripMenuItem.Click += new System.EventHandler(this.createAStoryToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.ContextMenuStrip = this.createStory;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(119, 22);
            this.panelMain.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(574, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "In Progress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(898, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createResponsible
            // 
            this.createResponsible.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.createResponsible.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAResponsiblePersonToTaskToolStripMenuItem});
            this.createResponsible.Name = "createResponsible";
            this.createResponsible.Size = new System.Drawing.Size(251, 26);
            // 
            // addAResponsiblePersonToTaskToolStripMenuItem
            // 
            this.addAResponsiblePersonToTaskToolStripMenuItem.Name = "addAResponsiblePersonToTaskToolStripMenuItem";
            this.addAResponsiblePersonToTaskToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.addAResponsiblePersonToTaskToolStripMenuItem.Text = "Add a responsible person to tasks";
            this.addAResponsiblePersonToTaskToolStripMenuItem.Click += new System.EventHandler(this.addAResponsiblePersonToTaskToolStripMenuItem_Click_1);
            // 
            // FormScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1252, 526);
            this.ContextMenuStrip = this.createStory;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScrum";
            this.Text = "Scrum Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createStory.ResumeLayout(false);
            this.createResponsible.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip createStory;
		private System.Windows.Forms.ToolStripMenuItem createAStoryToolStripMenuItem;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ContextMenuStrip createResponsible;
		private System.Windows.Forms.ToolStripMenuItem addAResponsiblePersonToTaskToolStripMenuItem;
	}
}

