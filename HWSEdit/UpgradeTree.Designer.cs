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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeTree));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonCollapseAll = new System.Windows.Forms.Button();
			this.buttonExpandAll = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.upgradeDescription = new System.Windows.Forms.Label();
			this.upgradeName = new System.Windows.Forms.Label();
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
			resources.ApplyResources(this.splitContainer, "splitContainer");
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.buttonCollapseAll);
			this.splitContainer.Panel1.Controls.Add(this.buttonExpandAll);
			this.splitContainer.Panel1.Controls.Add(this.tree);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer.Panel2.Controls.Add(this.panel);
			// 
			// buttonCollapseAll
			// 
			resources.ApplyResources(this.buttonCollapseAll, "buttonCollapseAll");
			this.buttonCollapseAll.Name = "buttonCollapseAll";
			this.buttonCollapseAll.UseVisualStyleBackColor = true;
			this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
			// 
			// buttonExpandAll
			// 
			resources.ApplyResources(this.buttonExpandAll, "buttonExpandAll");
			this.buttonExpandAll.Name = "buttonExpandAll";
			this.buttonExpandAll.UseVisualStyleBackColor = true;
			this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
			// 
			// panel
			// 
			resources.ApplyResources(this.panel, "panel");
			this.panel.BackColor = System.Drawing.SystemColors.Control;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.button3);
			this.panel.Controls.Add(this.upgradeDescription);
			this.panel.Controls.Add(this.upgradeName);
			this.panel.Name = "panel";
			// 
			// button3
			// 
			resources.ApplyResources(this.button3, "button3");
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// upgradeDescription
			// 
			resources.ApplyResources(this.upgradeDescription, "upgradeDescription");
			this.upgradeDescription.Name = "upgradeDescription";
			// 
			// upgradeName
			// 
			resources.ApplyResources(this.upgradeName, "upgradeName");
			this.upgradeName.Name = "upgradeName";
			// 
			// tree
			// 
			resources.ApplyResources(this.tree, "tree");
			this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tree.CheckBoxes = true;
			this.tree.Class = -1;
			this.tree.HideSelection = false;
			this.tree.Name = "tree";
			this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.upgradeTreeView1_AfterSelect);
			this.tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tree_MouseUp);
			// 
			// UpgradeTree
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "UpgradeTree";
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
		private System.Windows.Forms.Button buttonExpandAll;
		private System.Windows.Forms.Button buttonCollapseAll;
		private System.Windows.Forms.Button button3;

	}
}
