using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HWSEdit
{
	public partial class UpgradeTree : UserControl
	{
		protected UpgradeTreeNode catCore = new UpgradeTreeNode(Resources.Upgrades.cat_core_uname, Resources.Upgrades.cat_core_uname);
		protected UpgradeTreeNode catCombo = new UpgradeTreeNode(Resources.Upgrades.cat_combo_uname, Resources.Upgrades.cat_combo_uname);
		protected UpgradeTreeNode catActive = new UpgradeTreeNode(Resources.Upgrades.cat_active_uname, Resources.Upgrades.cat_active_uname);
		protected UpgradeTreeNode catPassive = new UpgradeTreeNode(Resources.Upgrades.cat_passive_uname, Resources.Upgrades.cat_passive_uname);

		public UpgradeTree()
		{
			InitializeComponent();

			// Core
			UpgradeTreeNode core_hp = new UpgradeTreeNode(
				Resources.Upgrades.core_hp_uname,
				Resources.Upgrades.core_hp_uname);
			core_hp.AddLevels(5);
			UpgradeTreeNode core_mana = new UpgradeTreeNode(
				Resources.Upgrades.core_mana_uname,
				Resources.Upgrades.core_mana_uname);
			core_mana.AddLevels(5);
			UpgradeTreeNode core_speed = new UpgradeTreeNode(
				Resources.Upgrades.core_speed_uname,
				Resources.Upgrades.core_speed_uname);
			core_speed.AddLevels(3);

			catCore.AddChildren(new UpgradeTreeNode[] { core_hp, core_mana, core_speed });

			// Combo
			UpgradeTreeNode combo = new UpgradeTreeNode(
				Resources.Upgrades.combo_uname, 
				Resources.Upgrades.combo_uname, 
				Resources.Upgrades.combo_udesc);
			combo.Tag = "";
			UpgradeTreeNode combo_nova = new UpgradeTreeNode(
				Resources.Upgrades.combo_nova_uname,
				Resources.Upgrades.combo_uname + " " + Resources.Upgrades.combo_nova_uname);
			combo_nova.Tag = "-nova";
			combo_nova.AddLevels(5);
			combo_nova.Requirements.Add(combo);
			UpgradeTreeNode combo_heal = new UpgradeTreeNode(
				Resources.Upgrades.combo_heal_uname, 
				Resources.Upgrades.combo_uname + " " + Resources.Upgrades.combo_heal_uname);
			combo_heal.Tag = "-heal";
			combo_heal.AddLevels(5);
			combo_heal.Requirements.Add(combo);
			UpgradeTreeNode combo_time = new UpgradeTreeNode(
				Resources.Upgrades.combo_time_uname, 
				Resources.Upgrades.combo_uname + " " + Resources.Upgrades.combo_time_uname);
			combo_time.Tag = "-time";
			combo_time.AddLevels(5);
			combo_time.Requirements.Add(combo);

			catCombo.Tag = "combo";
			catCombo.AddChildren(new UpgradeTreeNode[] { combo, combo_nova, combo_heal, combo_time });

			tree.Nodes.Add(catCore);
			tree.Nodes.Add(catCombo);
			tree.Nodes.Add(catActive);
			tree.Nodes.Add(catPassive);

			tree.AfterCheck += tree_AfterCheck;

			splitContainer.Panel2Collapsed = true;
		}

		protected void tree_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (e.Action != TreeViewAction.Unknown)
			{
				checkChildren(e.Node);
				if (e.Node.Parent != null)
				{
					checkParents(e.Node);
					(e.Node as UpgradeTreeNode).Parent.ValidateRequirements();
				}
			}
		}
		protected void checkChildren(TreeNode parent)
		{
			foreach (TreeNode child in parent.Nodes)
			{
				child.Checked = parent.Checked;
				checkChildren(child);
			}
		}
		protected void checkParents(TreeNode child)
		{
			if (child.Checked && child.Parent != null)
			{
				child.Parent.Checked = true;
				checkParents(child.Parent);
			}
		}

		private void upgradeTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			UpgradeTreeNode node = e.Node as UpgradeTreeNode;
			if (e.Node != null && node != null)
			{
				upgradeName.Text = node.UpgradeName;
				upgradeDescription.Text = node.UpgradeDescription;
				splitContainer.Panel2Collapsed = false;
			}
			else
			{
				splitContainer.Panel2Collapsed = true;
			}
		}

		private void tree_MouseUp(object sender, MouseEventArgs e)
		{
			if (tree.GetNodeAt(tree.PointToClient(e.Location)) == null)
			{
				tree.SelectedNode = null;
				splitContainer.Panel2Collapsed = true;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			splitContainer.SplitterDistance = 99999999;
		}
	}
}
