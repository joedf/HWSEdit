/*
 * Created by SharpDevelop.
 * User: Joachim
 * Date: 2014-10-14
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HWSEdit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toHWSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPageSelector = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxCurrentFile = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.InputPlaytime = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.InputLevelID = new System.Windows.Forms.TextBox();
			this.InputDifficulty = new System.Windows.Forms.ComboBox();
			this.checkboxNetworked = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.InputSpawnX = new System.Windows.Forms.NumericUpDown();
			this.InputSpawnY = new System.Windows.Forms.NumericUpDown();
			this.tabModifiers = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox5XManaRegen = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxDoubleLives = new System.Windows.Forms.CheckBox();
			this.checkBoxNoExtraLives = new System.Windows.Forms.CheckBox();
			this.checkBoxDoubleDamage = new System.Windows.Forms.CheckBox();
			this.checkBox1HP = new System.Windows.Forms.CheckBox();
			this.checkBoxHPRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxSharedHPPool = new System.Windows.Forms.CheckBox();
			this.checkBoxInfiniteLives = new System.Windows.Forms.CheckBox();
			this.checkBoxNoHPPickups = new System.Windows.Forms.CheckBox();
			this.checkBoxReverseHPRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxNoManaRegen = new System.Windows.Forms.CheckBox();
			this.tabPlayers = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.playerListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.playerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classImageList = new System.Windows.Forms.ImageList(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.InputPlayerLives = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.InputPlayerName = new System.Windows.Forms.TextBox();
			this.InputPlayerClass = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.InputPlayerDeaths = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.InputPlayerHealth = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.InputPlayerMana = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.InputPlayerPotion = new System.Windows.Forms.ComboBox();
			this.InputPlayerMoney = new System.Windows.Forms.NumericUpDown();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.upgradeTree1 = new HWSEdit.UpgradeTree();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.openDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.buttonSave = new System.Windows.Forms.ToolStripButton();
			this.buttonClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.openXMLConvertDialog = new System.Windows.Forms.OpenFileDialog();
			this.openHWSConvertDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveHWSConvertDialog = new System.Windows.Forms.SaveFileDialog();
			this.saveXMLConvertDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.tabPageSelector.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlaytime)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnY)).BeginInit();
			this.tabModifiers.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tabPlayers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.playerContextMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerLives)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerDeaths)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerHealth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerMana)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerMoney)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitCancelToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::HWSEdit.Properties.Resources.folder_horizontal_open;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.ButtonSaveAsClick);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Image = global::HWSEdit.Properties.Resources.cross_circle_frame;
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// exitCancelToolStripMenuItem
			// 
			this.exitCancelToolStripMenuItem.Name = "exitCancelToolStripMenuItem";
			resources.ApplyResources(this.exitCancelToolStripMenuItem, "exitCancelToolStripMenuItem");
			this.exitCancelToolStripMenuItem.Click += new System.EventHandler(this.ButtonQuit);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToXMLToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
			// 
			// convertToXMLToolStripMenuItem
			// 
			this.convertToXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toXMLToolStripMenuItem,
            this.toHWSToolStripMenuItem});
			this.convertToXMLToolStripMenuItem.Name = "convertToXMLToolStripMenuItem";
			resources.ApplyResources(this.convertToXMLToolStripMenuItem, "convertToXMLToolStripMenuItem");
			// 
			// toXMLToolStripMenuItem
			// 
			this.toXMLToolStripMenuItem.Name = "toXMLToolStripMenuItem";
			resources.ApplyResources(this.toXMLToolStripMenuItem, "toXMLToolStripMenuItem");
			this.toXMLToolStripMenuItem.Click += new System.EventHandler(this.toXMLToolStripMenuItem_Click);
			// 
			// toHWSToolStripMenuItem
			// 
			this.toHWSToolStripMenuItem.Name = "toHWSToolStripMenuItem";
			resources.ApplyResources(this.toHWSToolStripMenuItem, "toHWSToolStripMenuItem");
			this.toHWSToolStripMenuItem.Click += new System.EventHandler(this.toHWSToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// helpTopicToolStripMenuItem
			// 
			resources.ApplyResources(this.helpTopicToolStripMenuItem, "helpTopicToolStripMenuItem");
			this.helpTopicToolStripMenuItem.Name = "helpTopicToolStripMenuItem";
			this.helpTopicToolStripMenuItem.Click += new System.EventHandler(this.HelpTopicToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// tabPageSelector
			// 
			resources.ApplyResources(this.tabPageSelector, "tabPageSelector");
			this.tabPageSelector.Controls.Add(this.tabGeneral);
			this.tabPageSelector.Controls.Add(this.tabModifiers);
			this.tabPageSelector.Controls.Add(this.tabPlayers);
			this.tabPageSelector.Name = "tabPageSelector";
			this.tabPageSelector.SelectedIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.tabGeneral, "tabGeneral");
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.textBoxCurrentFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.InputPlaytime, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.InputLevelID, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.InputDifficulty, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.checkboxNetworked, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// textBoxCurrentFile
			// 
			resources.ApplyResources(this.textBoxCurrentFile, "textBoxCurrentFile");
			this.textBoxCurrentFile.Name = "textBoxCurrentFile";
			this.textBoxCurrentFile.ReadOnly = true;
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// InputPlaytime
			// 
			resources.ApplyResources(this.InputPlaytime, "InputPlaytime");
			this.InputPlaytime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlaytime.Name = "InputPlaytime";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// InputLevelID
			// 
			resources.ApplyResources(this.InputLevelID, "InputLevelID");
			this.InputLevelID.Name = "InputLevelID";
			// 
			// InputDifficulty
			// 
			resources.ApplyResources(this.InputDifficulty, "InputDifficulty");
			this.InputDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InputDifficulty.FormattingEnabled = true;
			this.InputDifficulty.Items.AddRange(new object[] {
            resources.GetString("InputDifficulty.Items"),
            resources.GetString("InputDifficulty.Items1"),
            resources.GetString("InputDifficulty.Items2")});
			this.InputDifficulty.Name = "InputDifficulty";
			// 
			// checkboxNetworked
			// 
			resources.ApplyResources(this.checkboxNetworked, "checkboxNetworked");
			this.checkboxNetworked.Name = "checkboxNetworked";
			this.checkboxNetworked.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.InputSpawnX, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.InputSpawnY, 3, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// InputSpawnX
			// 
			resources.ApplyResources(this.InputSpawnX, "InputSpawnX");
			this.InputSpawnX.DecimalPlaces = 1;
			this.InputSpawnX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.InputSpawnX.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
			this.InputSpawnX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.InputSpawnX.Name = "InputSpawnX";
			// 
			// InputSpawnY
			// 
			resources.ApplyResources(this.InputSpawnY, "InputSpawnY");
			this.InputSpawnY.DecimalPlaces = 1;
			this.InputSpawnY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.InputSpawnY.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
			this.InputSpawnY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.InputSpawnY.Name = "InputSpawnY";
			// 
			// tabModifiers
			// 
			this.tabModifiers.Controls.Add(this.tableLayoutPanel3);
			resources.ApplyResources(this.tabModifiers, "tabModifiers");
			this.tabModifiers.Name = "tabModifiers";
			this.tabModifiers.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.checkBox5XManaRegen, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxDoubleLives, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxNoExtraLives, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxDoubleDamage, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.checkBox1HP, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxHPRegen, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxSharedHPPool, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxInfiniteLives, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxNoHPPickups, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxReverseHPRegen, 0, 6);
			this.tableLayoutPanel3.Controls.Add(this.checkBoxNoManaRegen, 0, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Name = "label4";
			// 
			// checkBox5XManaRegen
			// 
			resources.ApplyResources(this.checkBox5XManaRegen, "checkBox5XManaRegen");
			this.checkBox5XManaRegen.Name = "checkBox5XManaRegen";
			this.checkBox5XManaRegen.UseVisualStyleBackColor = true;
			this.checkBox5XManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Name = "label3";
			// 
			// checkBoxDoubleLives
			// 
			resources.ApplyResources(this.checkBoxDoubleLives, "checkBoxDoubleLives");
			this.checkBoxDoubleLives.Name = "checkBoxDoubleLives";
			this.checkBoxDoubleLives.UseVisualStyleBackColor = true;
			this.checkBoxDoubleLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoExtraLives
			// 
			resources.ApplyResources(this.checkBoxNoExtraLives, "checkBoxNoExtraLives");
			this.checkBoxNoExtraLives.Name = "checkBoxNoExtraLives";
			this.checkBoxNoExtraLives.UseVisualStyleBackColor = true;
			this.checkBoxNoExtraLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxDoubleDamage
			// 
			resources.ApplyResources(this.checkBoxDoubleDamage, "checkBoxDoubleDamage");
			this.checkBoxDoubleDamage.Name = "checkBoxDoubleDamage";
			this.checkBoxDoubleDamage.UseVisualStyleBackColor = true;
			this.checkBoxDoubleDamage.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBox1HP
			// 
			resources.ApplyResources(this.checkBox1HP, "checkBox1HP");
			this.checkBox1HP.Name = "checkBox1HP";
			this.checkBox1HP.UseVisualStyleBackColor = true;
			this.checkBox1HP.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxHPRegen
			// 
			resources.ApplyResources(this.checkBoxHPRegen, "checkBoxHPRegen");
			this.checkBoxHPRegen.Name = "checkBoxHPRegen";
			this.checkBoxHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxSharedHPPool
			// 
			resources.ApplyResources(this.checkBoxSharedHPPool, "checkBoxSharedHPPool");
			this.checkBoxSharedHPPool.Name = "checkBoxSharedHPPool";
			this.checkBoxSharedHPPool.UseVisualStyleBackColor = true;
			this.checkBoxSharedHPPool.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxInfiniteLives
			// 
			resources.ApplyResources(this.checkBoxInfiniteLives, "checkBoxInfiniteLives");
			this.checkBoxInfiniteLives.Name = "checkBoxInfiniteLives";
			this.checkBoxInfiniteLives.UseVisualStyleBackColor = true;
			this.checkBoxInfiniteLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoHPPickups
			// 
			resources.ApplyResources(this.checkBoxNoHPPickups, "checkBoxNoHPPickups");
			this.checkBoxNoHPPickups.Name = "checkBoxNoHPPickups";
			this.checkBoxNoHPPickups.UseVisualStyleBackColor = true;
			this.checkBoxNoHPPickups.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxReverseHPRegen
			// 
			resources.ApplyResources(this.checkBoxReverseHPRegen, "checkBoxReverseHPRegen");
			this.checkBoxReverseHPRegen.Name = "checkBoxReverseHPRegen";
			this.checkBoxReverseHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxReverseHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoManaRegen
			// 
			resources.ApplyResources(this.checkBoxNoManaRegen, "checkBoxNoManaRegen");
			this.checkBoxNoManaRegen.Name = "checkBoxNoManaRegen";
			this.checkBoxNoManaRegen.UseVisualStyleBackColor = true;
			this.checkBoxNoManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// tabPlayers
			// 
			this.tabPlayers.Controls.Add(this.splitContainer1);
			resources.ApplyResources(this.tabPlayers, "tabPlayers");
			this.tabPlayers.Name = "tabPlayers";
			this.tabPlayers.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
			this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel2.Controls.Add(this.button3);
			this.splitContainer1.Panel2.Controls.Add(this.button2);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.playerListView);
			this.groupBox4.Controls.Add(this.button4);
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// button5
			// 
			resources.ApplyResources(this.button5, "button5");
			this.button5.Name = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// playerListView
			// 
			resources.ApplyResources(this.playerListView, "playerListView");
			this.playerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.playerListView.ContextMenuStrip = this.playerContextMenu;
			this.playerListView.FullRowSelect = true;
			this.playerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.playerListView.HideSelection = false;
			this.playerListView.LabelEdit = true;
			this.playerListView.LargeImageList = this.classImageList;
			this.playerListView.MultiSelect = false;
			this.playerListView.Name = "playerListView";
			this.playerListView.ShowGroups = false;
			this.playerListView.SmallImageList = this.classImageList;
			this.playerListView.UseCompatibleStateImageBehavior = false;
			this.playerListView.View = System.Windows.Forms.View.Details;
			this.playerListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.playerListView_AfterLabelEdit);
			this.playerListView.SelectedIndexChanged += new System.EventHandler(this.playerListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// playerContextMenu
			// 
			this.playerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.playerContextMenu.Name = "playerContextMenu";
			resources.ApplyResources(this.playerContextMenu, "playerContextMenu");
			this.playerContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.playerContextMenu_ItemClicked);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
			// 
			// classImageList
			// 
			this.classImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("classImageList.ImageStream")));
			this.classImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.classImageList.Images.SetKeyName(0, "");
			this.classImageList.Images.SetKeyName(1, "");
			this.classImageList.Images.SetKeyName(2, "");
			this.classImageList.Images.SetKeyName(3, "");
			this.classImageList.Images.SetKeyName(4, "");
			this.classImageList.Images.SetKeyName(5, "");
			// 
			// button4
			// 
			resources.ApplyResources(this.button4, "button4");
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel5);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel5
			// 
			resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerLives, 1, 2);
			this.tableLayoutPanel5.Controls.Add(this.label13, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerName, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerClass, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.label15, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.label16, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.label18, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerDeaths, 1, 3);
			this.tableLayoutPanel5.Controls.Add(this.label17, 0, 4);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerHealth, 1, 4);
			this.tableLayoutPanel5.Controls.Add(this.label2, 0, 5);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerMana, 1, 5);
			this.tableLayoutPanel5.Controls.Add(this.label14, 0, 7);
			this.tableLayoutPanel5.Controls.Add(this.label11, 0, 6);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerPotion, 1, 7);
			this.tableLayoutPanel5.Controls.Add(this.InputPlayerMoney, 1, 6);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			// 
			// InputPlayerLives
			// 
			resources.ApplyResources(this.InputPlayerLives, "InputPlayerLives");
			this.InputPlayerLives.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlayerLives.Name = "InputPlayerLives";
			this.InputPlayerLives.ValueChanged += new System.EventHandler(this.InputPlayerLives_ValueChanged);
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			// 
			// InputPlayerName
			// 
			resources.ApplyResources(this.InputPlayerName, "InputPlayerName");
			this.InputPlayerName.Name = "InputPlayerName";
			this.InputPlayerName.TextChanged += new System.EventHandler(this.InputPlayerName_TextChanged);
			// 
			// InputPlayerClass
			// 
			resources.ApplyResources(this.InputPlayerClass, "InputPlayerClass");
			this.InputPlayerClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InputPlayerClass.FormattingEnabled = true;
			this.InputPlayerClass.Name = "InputPlayerClass";
			this.InputPlayerClass.SelectedIndexChanged += new System.EventHandler(this.InputPlayerClass_SelectedIndexChanged);
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.Name = "label16";
			// 
			// label18
			// 
			resources.ApplyResources(this.label18, "label18");
			this.label18.Name = "label18";
			// 
			// InputPlayerDeaths
			// 
			resources.ApplyResources(this.InputPlayerDeaths, "InputPlayerDeaths");
			this.InputPlayerDeaths.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlayerDeaths.Name = "InputPlayerDeaths";
			this.InputPlayerDeaths.ValueChanged += new System.EventHandler(this.InputPlayerDeaths_ValueChanged);
			// 
			// label17
			// 
			resources.ApplyResources(this.label17, "label17");
			this.label17.Name = "label17";
			// 
			// InputPlayerHealth
			// 
			resources.ApplyResources(this.InputPlayerHealth, "InputPlayerHealth");
			this.InputPlayerHealth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlayerHealth.Name = "InputPlayerHealth";
			this.InputPlayerHealth.ValueChanged += new System.EventHandler(this.InputPlayerHealth_ValueChanged);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// InputPlayerMana
			// 
			resources.ApplyResources(this.InputPlayerMana, "InputPlayerMana");
			this.InputPlayerMana.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlayerMana.Name = "InputPlayerMana";
			this.InputPlayerMana.ValueChanged += new System.EventHandler(this.InputPlayerMana_ValueChanged);
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// InputPlayerPotion
			// 
			resources.ApplyResources(this.InputPlayerPotion, "InputPlayerPotion");
			this.InputPlayerPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InputPlayerPotion.FormattingEnabled = true;
			this.InputPlayerPotion.Items.AddRange(new object[] {
            resources.GetString("InputPlayerPotion.Items"),
            resources.GetString("InputPlayerPotion.Items1"),
            resources.GetString("InputPlayerPotion.Items2"),
            resources.GetString("InputPlayerPotion.Items3"),
            resources.GetString("InputPlayerPotion.Items4"),
            resources.GetString("InputPlayerPotion.Items5"),
            resources.GetString("InputPlayerPotion.Items6")});
			this.InputPlayerPotion.Name = "InputPlayerPotion";
			this.InputPlayerPotion.SelectedIndexChanged += new System.EventHandler(this.InputPlayerPotion_SelectedIndexChanged);
			// 
			// InputPlayerMoney
			// 
			resources.ApplyResources(this.InputPlayerMoney, "InputPlayerMoney");
			this.InputPlayerMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlayerMoney.Name = "InputPlayerMoney";
			this.InputPlayerMoney.ValueChanged += new System.EventHandler(this.InputPlayerMoney_ValueChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.upgradeTree1);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// upgradeTree1
			// 
			resources.ApplyResources(this.upgradeTree1, "upgradeTree1");
			this.upgradeTree1.Name = "upgradeTree1";
			// 
			// button3
			// 
			resources.ApplyResources(this.button3, "button3");
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// openDialog
			// 
			resources.ApplyResources(this.openDialog, "openDialog");
			// 
			// saveDialog
			// 
			this.saveDialog.DefaultExt = "*.hws;*.xml";
			resources.ApplyResources(this.saveDialog, "saveDialog");
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.buttonSave,
            this.buttonClose,
            this.toolStripButton4,
            this.toolStripButtonHelp,
            this.toolStripButtonAbout});
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Name = "toolStrip1";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = global::HWSEdit.Properties.Resources.folder_horizontal_open;
			resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.buttonSave, "buttonSave");
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonClose.Image = global::HWSEdit.Properties.Resources.cross_circle_frame;
			resources.ApplyResources(this.buttonClose, "buttonClose");
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Name = "toolStripButton4";
			resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
			// 
			// toolStripButtonHelp
			// 
			this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonHelp.Image = global::HWSEdit.Properties.Resources.question_frame;
			resources.ApplyResources(this.toolStripButtonHelp, "toolStripButtonHelp");
			this.toolStripButtonHelp.Name = "toolStripButtonHelp";
			this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = global::HWSEdit.Properties.Resources.information_balloon;
			resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.SizingGrip = false;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
			// 
			// openXMLConvertDialog
			// 
			this.openXMLConvertDialog.DefaultExt = "xml";
			resources.ApplyResources(this.openXMLConvertDialog, "openXMLConvertDialog");
			// 
			// openHWSConvertDialog
			// 
			resources.ApplyResources(this.openHWSConvertDialog, "openHWSConvertDialog");
			// 
			// saveHWSConvertDialog
			// 
			this.saveHWSConvertDialog.DefaultExt = "*.hws;*.xml";
			resources.ApplyResources(this.saveHWSConvertDialog, "saveHWSConvertDialog");
			// 
			// saveXMLConvertDialog
			// 
			this.saveXMLConvertDialog.DefaultExt = "*.xml";
			resources.ApplyResources(this.saveXMLConvertDialog, "saveXMLConvertDialog");
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabPageSelector);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPageSelector.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlaytime)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnY)).EndInit();
			this.tabModifiers.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tabPlayers.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.playerContextMenu.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerLives)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerDeaths)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerHealth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerMana)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputPlayerMoney)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxCurrentFile;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.OpenFileDialog openDialog;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown InputPlaytime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown InputSpawnX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxNoExtraLives;
		private System.Windows.Forms.CheckBox checkBox1HP;
		private System.Windows.Forms.CheckBox checkBoxSharedHPPool;
		private System.Windows.Forms.CheckBox checkBoxNoHPPickups;
		private System.Windows.Forms.CheckBox checkBoxNoManaRegen;
		private System.Windows.Forms.CheckBox checkBoxReverseHPRegen;
		private System.Windows.Forms.CheckBox checkBoxInfiniteLives;
		private System.Windows.Forms.CheckBox checkBoxHPRegen;
		private System.Windows.Forms.CheckBox checkBoxDoubleDamage;
		private System.Windows.Forms.CheckBox checkBoxDoubleLives;
		private System.Windows.Forms.CheckBox checkBox5XManaRegen;
		private System.Windows.Forms.ComboBox InputDifficulty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPlayers;
		private System.Windows.Forms.TabPage tabModifiers;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabControl tabPageSelector;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpTopicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitCancelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox InputLevelID;
		private System.Windows.Forms.ContextMenuStrip playerContextMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown InputSpawnY;
		private System.Windows.Forms.CheckBox checkboxNetworked;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton buttonSave;
		private System.Windows.Forms.ToolStripButton buttonClose;
		private System.Windows.Forms.ToolStripSeparator toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
		private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toHWSToolStripMenuItem;
		private System.Windows.Forms.ListView playerListView;
		private System.Windows.Forms.ImageList classImageList;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.NumericUpDown InputPlayerMana;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown InputPlayerHealth;
		private System.Windows.Forms.NumericUpDown InputPlayerLives;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox InputPlayerName;
		private System.Windows.Forms.ComboBox InputPlayerClass;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown InputPlayerMoney;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox InputPlayerPotion;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.NumericUpDown InputPlayerDeaths;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private UpgradeTree upgradeTree1;
		private System.Windows.Forms.OpenFileDialog openXMLConvertDialog;
		private System.Windows.Forms.OpenFileDialog openHWSConvertDialog;
		private System.Windows.Forms.SaveFileDialog saveHWSConvertDialog;
		private System.Windows.Forms.SaveFileDialog saveXMLConvertDialog;
	}
}
