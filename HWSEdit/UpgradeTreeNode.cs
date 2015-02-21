using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HWSEdit
{
	public class UpgradeTreeNode : TreeNode
	{
		public new bool Checked
		{
			get { return base.Checked; }
			set
			{
				base.Checked = value;
				ValidateRequirements();
			}
		}
		public new UpgradeTreeNode Parent
		{
			get { return _Parent; }
		}
		private UpgradeTreeNode _Parent;
		public readonly string UpgradeName;
		public readonly string UpgradeDescription;
		public readonly List<UpgradeTreeNode> Children = new List<UpgradeTreeNode>();
		public readonly List<UpgradeTreeNode> Requirements = new List<UpgradeTreeNode>();

		public UpgradeTreeNode(string Text, string UpgradeName, string UpgradeDescription)
			: this(Text, UpgradeName)
		{
			this.UpgradeDescription = UpgradeDescription;
		}
		public UpgradeTreeNode(string Text, string UpgradeName)
			: base(UpgradeName)
		{
			this.UpgradeName = UpgradeName;
			this.Text = Text;
		}

		public void Clear()
		{
			Nodes.Clear();
			Children.Clear();
		}

		public void AddChild(UpgradeTreeNode Child)
		{
			Child._Parent = this;
			Children.Add(Child);
			Nodes.Add(Child);
		}
		public void AddChildren(IEnumerable<UpgradeTreeNode> Children)
		{
			foreach (UpgradeTreeNode child in Children)
				AddChild(child);
		}

		public void ValidateRequirements()
		{
			if (this.Checked)
			{
				foreach (UpgradeTreeNode req in Requirements)
				{
					req.Checked = true;
				}
			}
			foreach (UpgradeTreeNode child in Children)
			{
				child.ValidateRequirements();
			}
		}

		public void AddLevels(uint levels, string Description = "")
		{
			if (levels == 0) return;
			if (levels > 5) throw new IndexOutOfRangeException("The maximum number of levels for an upgrade is 5.");

			UpgradeTreeNode[] nodes = new UpgradeTreeNode[levels];
			if (levels >= 1)
			{
				UpgradeTreeNode lvl = new UpgradeTreeNode(Resources.Upgrades.lvl1, UpgradeName + " " + Resources.Upgrades.lvl1, Description);
				lvl.Tag = "-1";
				nodes[0] = lvl;

			}
			if (levels >= 2)
			{
				UpgradeTreeNode lvl = new UpgradeTreeNode(Resources.Upgrades.lvl2, UpgradeName + " " + Resources.Upgrades.lvl2, Description);
				lvl.Tag = "-2";
				nodes[1] = lvl;
				nodes[1].Requirements.Add(nodes[0]);
			}
			if (levels >= 3)
			{
				UpgradeTreeNode lvl = new UpgradeTreeNode(Resources.Upgrades.lvl3, UpgradeName + " " + Resources.Upgrades.lvl3, Description);
				lvl.Tag = "-3";
				nodes[2] = lvl;
				nodes[2].Requirements.Add(nodes[1]);
			}
			if (levels >= 4)
			{
				UpgradeTreeNode lvl = new UpgradeTreeNode(Resources.Upgrades.lvl4, UpgradeName + " " + Resources.Upgrades.lvl4, Description);
				lvl.Tag = "-4";
				nodes[3] = lvl;
				nodes[3].Requirements.Add(nodes[2]);
			}
			if (levels == 5)
			{
				UpgradeTreeNode lvl = new UpgradeTreeNode(Resources.Upgrades.lvl5, UpgradeName + " " + Resources.Upgrades.lvl5, Description);
				lvl.Tag = "-5";
				nodes[4] = lvl;
				nodes[4].Requirements.Add(nodes[3]);
			}
			AddChildren(nodes);
		}

		void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node == this)
			{
				this.Checked = !this.Checked;
			}
		}
	}
}
