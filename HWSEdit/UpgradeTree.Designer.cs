namespace HWSEdit
{
	partial class UpgradeTree
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.panel = new System.Windows.Forms.Panel();
			this.upgradeDescription = new System.Windows.Forms.Label();
			this.upgradeName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tree = new HWSEdit.UpgradeTreeView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.button2);
			this.splitContainer.Panel1.Controls.Add(this.button1);
			this.splitContainer.Panel1.Controls.Add(this.tree);
			this.splitContainer.Panel1MinSize = 50;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer.Panel2.Controls.Add(this.panel);
			this.splitContainer.Panel2MinSize = 1;
			this.splitContainer.Size = new System.Drawing.Size(444, 234);
			this.splitContainer.SplitterDistance = 137;
			this.splitContainer.TabIndex = 2;
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BackColor = System.Drawing.SystemColors.Control;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.button3);
			this.panel.Controls.Add(this.upgradeDescription);
			this.panel.Controls.Add(this.upgradeName);
			this.panel.Location = new System.Drawing.Point(-3, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(452, 144);
			this.panel.TabIndex = 0;
			// 
			// upgradeDescription
			// 
			this.upgradeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.upgradeDescription.Location = new System.Drawing.Point(11, 29);
			this.upgradeDescription.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
			this.upgradeDescription.Name = "upgradeDescription";
			this.upgradeDescription.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
			this.upgradeDescription.Size = new System.Drawing.Size(431, 60);
			this.upgradeDescription.TabIndex = 1;
			this.upgradeDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut efficitur, ante et ma" +
    "ttis consectetur, purus nisi accumsan lorem, id euismod.";
			// 
			// upgradeName
			// 
			this.upgradeName.AutoSize = true;
			this.upgradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.upgradeName.Location = new System.Drawing.Point(8, 8);
			this.upgradeName.Margin = new System.Windows.Forms.Padding(8);
			this.upgradeName.Name = "upgradeName";
			this.upgradeName.Size = new System.Drawing.Size(93, 13);
			this.upgradeName.TabIndex = 0;
			this.upgradeName.Text = "Upgrade name:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(288, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Expand All";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(369, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Collapse All";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(426, -1);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(21, 22);
			this.button3.TabIndex = 2;
			this.button3.Text = "▼";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tree
			// 
			this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tree.CheckBoxes = true;
			this.tree.Class = -1;
			this.tree.HideSelection = false;
			this.tree.Location = new System.Drawing.Point(0, 29);
			this.tree.Name = "tree";
			this.tree.Size = new System.Drawing.Size(444, 106);
			this.tree.TabIndex = 0;
			this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.upgradeTreeView1_AfterSelect);
			this.tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tree_MouseUp);
			// 
			// UpgradeTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "UpgradeTree";
			this.Size = new System.Drawing.Size(444, 234);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label upgradeName;
		private UpgradeTreeView tree;
		private System.Windows.Forms.Label upgradeDescription;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;

	}
}
