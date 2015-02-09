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
			this.dropdownDifficulty = new System.Windows.Forms.ComboBox();
			this.checkboxNetworked = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.InputSpawnX = new System.Windows.Forms.NumericUpDown();
			this.InputSpawnY = new System.Windows.Forms.NumericUpDown();
			this.tabModifiers = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox5XManaRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxDoubleLives = new System.Windows.Forms.CheckBox();
			this.checkBoxDoubleDamage = new System.Windows.Forms.CheckBox();
			this.checkBoxHPRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxInfiniteLives = new System.Windows.Forms.CheckBox();
			this.checkBoxReverseHPRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxNoManaRegen = new System.Windows.Forms.CheckBox();
			this.checkBoxNoHPPickups = new System.Windows.Forms.CheckBox();
			this.checkBoxSharedHPPool = new System.Windows.Forms.CheckBox();
			this.checkBox1HP = new System.Windows.Forms.CheckBox();
			this.checkBoxNoExtraLives = new System.Windows.Forms.CheckBox();
			this.tabPlayers = new System.Windows.Forms.TabPage();
			this.playerListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.playerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classImageList = new System.Windows.Forms.ImageList(this.components);
			this.label11 = new System.Windows.Forms.Label();
			this.InputPlayerClass = new System.Windows.Forms.ComboBox();
			this.InputPlayerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabhws2xml = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveHWSButton = new System.Windows.Forms.Button();
			this.saveHWSBrowseButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.saveXMLButton = new System.Windows.Forms.Button();
			this.saveXMLBrowseButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openHWSDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveXMLDialog = new System.Windows.Forms.SaveFileDialog();
			this.openXMLDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveHWSDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.buttonSave = new System.Windows.Forms.ToolStripButton();
			this.buttonClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1.SuspendLayout();
			this.tabPageSelector.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlaytime)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnY)).BeginInit();
			this.tabModifiers.SuspendLayout();
			this.tabPlayers.SuspendLayout();
			this.playerContextMenu.SuspendLayout();
			this.tabhws2xml.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(414, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
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
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::HWSEdit.Properties.Resources.folder_horizontal_open;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.ButtonSaveAsClick);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Image = global::HWSEdit.Properties.Resources.cross_circle_frame;
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.closeToolStripMenuItem.Text = "Clos&e";
			// 
			// exitCancelToolStripMenuItem
			// 
			this.exitCancelToolStripMenuItem.Name = "exitCancelToolStripMenuItem";
			this.exitCancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitCancelToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.exitCancelToolStripMenuItem.Text = "E&xit";
			this.exitCancelToolStripMenuItem.Click += new System.EventHandler(this.ButtonQuit);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToXMLToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// convertToXMLToolStripMenuItem
			// 
			this.convertToXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toXMLToolStripMenuItem,
            this.toHWSToolStripMenuItem});
			this.convertToXMLToolStripMenuItem.Name = "convertToXMLToolStripMenuItem";
			this.convertToXMLToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.convertToXMLToolStripMenuItem.Text = "Convert";
			// 
			// toXMLToolStripMenuItem
			// 
			this.toXMLToolStripMenuItem.Name = "toXMLToolStripMenuItem";
			this.toXMLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.toXMLToolStripMenuItem.Text = "To XML...";
			// 
			// toHWSToolStripMenuItem
			// 
			this.toHWSToolStripMenuItem.Name = "toHWSToolStripMenuItem";
			this.toHWSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.toHWSToolStripMenuItem.Text = "To HWS...";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// helpTopicToolStripMenuItem
			// 
			this.helpTopicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpTopicToolStripMenuItem.Image")));
			this.helpTopicToolStripMenuItem.Name = "helpTopicToolStripMenuItem";
			this.helpTopicToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpTopicToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.helpTopicToolStripMenuItem.Text = "&Help";
			this.helpTopicToolStripMenuItem.Click += new System.EventHandler(this.HelpTopicToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// tabPageSelector
			// 
			this.tabPageSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPageSelector.Controls.Add(this.tabGeneral);
			this.tabPageSelector.Controls.Add(this.tabModifiers);
			this.tabPageSelector.Controls.Add(this.tabPlayers);
			this.tabPageSelector.Controls.Add(this.tabhws2xml);
			this.tabPageSelector.Location = new System.Drawing.Point(9, 52);
			this.tabPageSelector.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.tabPageSelector.Name = "tabPageSelector";
			this.tabPageSelector.SelectedIndex = 0;
			this.tabPageSelector.Size = new System.Drawing.Size(396, 191);
			this.tabPageSelector.TabIndex = 1;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.tableLayoutPanel1);
			this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(388, 165);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.textBoxCurrentFile, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.InputPlaytime, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.InputLevelID, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.dropdownDifficulty, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.checkboxNetworked, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 159);
			this.tableLayoutPanel1.TabIndex = 16;
			// 
			// textBoxCurrentFile
			// 
			this.textBoxCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCurrentFile.Location = new System.Drawing.Point(123, 3);
			this.textBoxCurrentFile.Name = "textBoxCurrentFile";
			this.textBoxCurrentFile.ReadOnly = true;
			this.textBoxCurrentFile.Size = new System.Drawing.Size(256, 20);
			this.textBoxCurrentFile.TabIndex = 13;
			this.textBoxCurrentFile.WordWrap = false;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(114, 26);
			this.label10.TabIndex = 12;
			this.label10.Text = "Current file:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(3, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Difficulty:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InputPlaytime
			// 
			this.InputPlaytime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputPlaytime.Location = new System.Drawing.Point(123, 29);
			this.InputPlaytime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.InputPlaytime.Name = "InputPlaytime";
			this.InputPlaytime.Size = new System.Drawing.Size(256, 20);
			this.InputPlaytime.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(3, 26);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 26);
			this.label9.TabIndex = 10;
			this.label9.Text = "Play time:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(3, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 26);
			this.label8.TabIndex = 8;
			this.label8.Text = "Level ID:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(3, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 26);
			this.label5.TabIndex = 3;
			this.label5.Text = "Spawn position:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InputLevelID
			// 
			this.InputLevelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputLevelID.Location = new System.Drawing.Point(123, 55);
			this.InputLevelID.Name = "InputLevelID";
			this.InputLevelID.Size = new System.Drawing.Size(256, 20);
			this.InputLevelID.TabIndex = 14;
			// 
			// dropdownDifficulty
			// 
			this.dropdownDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dropdownDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropdownDifficulty.FormattingEnabled = true;
			this.dropdownDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
			this.dropdownDifficulty.Location = new System.Drawing.Point(123, 107);
			this.dropdownDifficulty.Name = "dropdownDifficulty";
			this.dropdownDifficulty.Size = new System.Drawing.Size(256, 21);
			this.dropdownDifficulty.TabIndex = 2;
			// 
			// checkboxNetworked
			// 
			this.checkboxNetworked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkboxNetworked.AutoSize = true;
			this.checkboxNetworked.Location = new System.Drawing.Point(123, 137);
			this.checkboxNetworked.Name = "checkboxNetworked";
			this.checkboxNetworked.Size = new System.Drawing.Size(256, 14);
			this.checkboxNetworked.TabIndex = 16;
			this.checkboxNetworked.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 130);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 29);
			this.label12.TabIndex = 17;
			this.label12.Text = "Networked multiplayer:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.InputSpawnX, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.InputSpawnY, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(120, 78);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 26);
			this.tableLayoutPanel2.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(131, 0);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 26);
			this.label7.TabIndex = 7;
			this.label7.Text = "Y";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 26);
			this.label6.TabIndex = 4;
			this.label6.Text = "X";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InputSpawnX
			// 
			this.InputSpawnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputSpawnX.DecimalPlaces = 1;
			this.InputSpawnX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.InputSpawnX.Location = new System.Drawing.Point(18, 3);
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
			this.InputSpawnX.MinimumSize = new System.Drawing.Size(1, 0);
			this.InputSpawnX.Name = "InputSpawnX";
			this.InputSpawnX.Size = new System.Drawing.Size(110, 20);
			this.InputSpawnX.TabIndex = 5;
			// 
			// InputSpawnY
			// 
			this.InputSpawnY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputSpawnY.DecimalPlaces = 1;
			this.InputSpawnY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.InputSpawnY.Location = new System.Drawing.Point(149, 3);
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
			this.InputSpawnY.MinimumSize = new System.Drawing.Size(1, 0);
			this.InputSpawnY.Name = "InputSpawnY";
			this.InputSpawnY.Size = new System.Drawing.Size(110, 20);
			this.InputSpawnY.TabIndex = 6;
			// 
			// tabModifiers
			// 
			this.tabModifiers.Controls.Add(this.tableLayoutPanel3);
			this.tabModifiers.Location = new System.Drawing.Point(4, 22);
			this.tabModifiers.Name = "tabModifiers";
			this.tabModifiers.Padding = new System.Windows.Forms.Padding(3);
			this.tabModifiers.Size = new System.Drawing.Size(388, 165);
			this.tabModifiers.TabIndex = 1;
			this.tabModifiers.Text = "Modifiers";
			this.tabModifiers.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(3, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(185, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Challenges";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(194, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Crutches";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox5XManaRegen
			// 
			this.checkBox5XManaRegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox5XManaRegen.Location = new System.Drawing.Point(194, 113);
			this.checkBox5XManaRegen.Name = "checkBox5XManaRegen";
			this.checkBox5XManaRegen.Size = new System.Drawing.Size(185, 16);
			this.checkBox5XManaRegen.TabIndex = 10;
			this.checkBox5XManaRegen.Text = "5x Mana regen";
			this.checkBox5XManaRegen.UseVisualStyleBackColor = true;
			this.checkBox5XManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxDoubleLives
			// 
			this.checkBoxDoubleLives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxDoubleLives.Location = new System.Drawing.Point(194, 91);
			this.checkBoxDoubleLives.Name = "checkBoxDoubleLives";
			this.checkBoxDoubleLives.Size = new System.Drawing.Size(185, 16);
			this.checkBoxDoubleLives.TabIndex = 9;
			this.checkBoxDoubleLives.Text = "Double lives";
			this.checkBoxDoubleLives.UseVisualStyleBackColor = true;
			this.checkBoxDoubleLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxDoubleDamage
			// 
			this.checkBoxDoubleDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxDoubleDamage.Location = new System.Drawing.Point(194, 69);
			this.checkBoxDoubleDamage.Name = "checkBoxDoubleDamage";
			this.checkBoxDoubleDamage.Size = new System.Drawing.Size(185, 16);
			this.checkBoxDoubleDamage.TabIndex = 8;
			this.checkBoxDoubleDamage.Text = "Double damage";
			this.checkBoxDoubleDamage.UseVisualStyleBackColor = true;
			this.checkBoxDoubleDamage.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxHPRegen
			// 
			this.checkBoxHPRegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxHPRegen.Location = new System.Drawing.Point(194, 47);
			this.checkBoxHPRegen.Name = "checkBoxHPRegen";
			this.checkBoxHPRegen.Size = new System.Drawing.Size(185, 16);
			this.checkBoxHPRegen.TabIndex = 7;
			this.checkBoxHPRegen.Text = "HP regen";
			this.checkBoxHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxInfiniteLives
			// 
			this.checkBoxInfiniteLives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxInfiniteLives.Location = new System.Drawing.Point(194, 25);
			this.checkBoxInfiniteLives.Name = "checkBoxInfiniteLives";
			this.checkBoxInfiniteLives.Size = new System.Drawing.Size(185, 16);
			this.checkBoxInfiniteLives.TabIndex = 6;
			this.checkBoxInfiniteLives.Text = "Infinite Lives";
			this.checkBoxInfiniteLives.UseVisualStyleBackColor = true;
			this.checkBoxInfiniteLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxReverseHPRegen
			// 
			this.checkBoxReverseHPRegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxReverseHPRegen.Location = new System.Drawing.Point(3, 135);
			this.checkBoxReverseHPRegen.Name = "checkBoxReverseHPRegen";
			this.checkBoxReverseHPRegen.Size = new System.Drawing.Size(185, 21);
			this.checkBoxReverseHPRegen.TabIndex = 5;
			this.checkBoxReverseHPRegen.Text = "Reverse HP regen";
			this.checkBoxReverseHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxReverseHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoManaRegen
			// 
			this.checkBoxNoManaRegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxNoManaRegen.Location = new System.Drawing.Point(3, 113);
			this.checkBoxNoManaRegen.Name = "checkBoxNoManaRegen";
			this.checkBoxNoManaRegen.Size = new System.Drawing.Size(185, 16);
			this.checkBoxNoManaRegen.TabIndex = 4;
			this.checkBoxNoManaRegen.Text = "No Mana regen";
			this.checkBoxNoManaRegen.UseVisualStyleBackColor = true;
			this.checkBoxNoManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoHPPickups
			// 
			this.checkBoxNoHPPickups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxNoHPPickups.Location = new System.Drawing.Point(3, 91);
			this.checkBoxNoHPPickups.Name = "checkBoxNoHPPickups";
			this.checkBoxNoHPPickups.Size = new System.Drawing.Size(185, 16);
			this.checkBoxNoHPPickups.TabIndex = 3;
			this.checkBoxNoHPPickups.Text = "No HP pickups";
			this.checkBoxNoHPPickups.UseVisualStyleBackColor = true;
			this.checkBoxNoHPPickups.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxSharedHPPool
			// 
			this.checkBoxSharedHPPool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSharedHPPool.Location = new System.Drawing.Point(3, 69);
			this.checkBoxSharedHPPool.Name = "checkBoxSharedHPPool";
			this.checkBoxSharedHPPool.Size = new System.Drawing.Size(185, 16);
			this.checkBoxSharedHPPool.TabIndex = 2;
			this.checkBoxSharedHPPool.Text = "Shared HP pool";
			this.checkBoxSharedHPPool.UseVisualStyleBackColor = true;
			this.checkBoxSharedHPPool.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBox1HP
			// 
			this.checkBox1HP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1HP.Location = new System.Drawing.Point(3, 47);
			this.checkBox1HP.Name = "checkBox1HP";
			this.checkBox1HP.Size = new System.Drawing.Size(185, 16);
			this.checkBox1HP.TabIndex = 1;
			this.checkBox1HP.Text = "1 HP";
			this.checkBox1HP.UseVisualStyleBackColor = true;
			this.checkBox1HP.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoExtraLives
			// 
			this.checkBoxNoExtraLives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxNoExtraLives.Location = new System.Drawing.Point(3, 25);
			this.checkBoxNoExtraLives.Name = "checkBoxNoExtraLives";
			this.checkBoxNoExtraLives.Size = new System.Drawing.Size(185, 16);
			this.checkBoxNoExtraLives.TabIndex = 0;
			this.checkBoxNoExtraLives.Text = "No extra lives";
			this.checkBoxNoExtraLives.UseVisualStyleBackColor = true;
			this.checkBoxNoExtraLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// tabPlayers
			// 
			this.tabPlayers.Controls.Add(this.playerListView);
			this.tabPlayers.Controls.Add(this.label11);
			this.tabPlayers.Controls.Add(this.InputPlayerClass);
			this.tabPlayers.Controls.Add(this.InputPlayerName);
			this.tabPlayers.Controls.Add(this.label2);
			this.tabPlayers.Location = new System.Drawing.Point(4, 22);
			this.tabPlayers.Name = "tabPlayers";
			this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPlayers.Size = new System.Drawing.Size(388, 171);
			this.tabPlayers.TabIndex = 2;
			this.tabPlayers.Text = "Players";
			this.tabPlayers.UseVisualStyleBackColor = true;
			// 
			// playerListView
			// 
			this.playerListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.playerListView.ContextMenuStrip = this.playerContextMenu;
			this.playerListView.Dock = System.Windows.Forms.DockStyle.Left;
			this.playerListView.FullRowSelect = true;
			this.playerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.playerListView.HideSelection = false;
			this.playerListView.LabelEdit = true;
			this.playerListView.LabelWrap = false;
			this.playerListView.LargeImageList = this.classImageList;
			this.playerListView.Location = new System.Drawing.Point(3, 3);
			this.playerListView.MultiSelect = false;
			this.playerListView.Name = "playerListView";
			this.playerListView.ShowGroups = false;
			this.playerListView.Size = new System.Drawing.Size(174, 165);
			this.playerListView.SmallImageList = this.classImageList;
			this.playerListView.TabIndex = 19;
			this.playerListView.UseCompatibleStateImageBehavior = false;
			this.playerListView.View = System.Windows.Forms.View.Details;
			this.playerListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.playerListView_AfterLabelEdit);
			this.playerListView.SelectedIndexChanged += new System.EventHandler(this.playerListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 121;
			// 
			// playerContextMenu
			// 
			this.playerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.playerContextMenu.Name = "playerContextMenu";
			this.playerContextMenu.Size = new System.Drawing.Size(118, 48);
			this.playerContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.playerContextMenu_ItemClicked);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "&Rename";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			// 
			// classImageList
			// 
			this.classImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("classImageList.ImageStream")));
			this.classImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.classImageList.Images.SetKeyName(0, "knight.png");
			this.classImageList.Images.SetKeyName(1, "priest.png");
			this.classImageList.Images.SetKeyName(2, "ranger.png");
			this.classImageList.Images.SetKeyName(3, "warlock.png");
			this.classImageList.Images.SetKeyName(4, "thief.png");
			this.classImageList.Images.SetKeyName(5, "wizard.png");
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(230, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 17);
			this.label11.TabIndex = 18;
			this.label11.Text = "Class:";
			// 
			// InputPlayerClass
			// 
			this.InputPlayerClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InputPlayerClass.FormattingEnabled = true;
			this.InputPlayerClass.Items.AddRange(new object[] {
            "Paladin",
            "Priest",
            "Ranger",
            "Warlock",
            "Thief",
            "Wizard"});
			this.InputPlayerClass.Location = new System.Drawing.Point(280, 32);
			this.InputPlayerClass.Name = "InputPlayerClass";
			this.InputPlayerClass.Size = new System.Drawing.Size(102, 21);
			this.InputPlayerClass.TabIndex = 17;
			this.InputPlayerClass.SelectedIndexChanged += new System.EventHandler(this.InputPlayerClass_SelectedIndexChanged);
			// 
			// InputPlayerName
			// 
			this.InputPlayerName.Location = new System.Drawing.Point(280, 6);
			this.InputPlayerName.Name = "InputPlayerName";
			this.InputPlayerName.Size = new System.Drawing.Size(102, 20);
			this.InputPlayerName.TabIndex = 16;
			this.InputPlayerName.TextChanged += new System.EventHandler(this.InputPlayerName_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(230, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Name:";
			// 
			// tabhws2xml
			// 
			this.tabhws2xml.Controls.Add(this.groupBox2);
			this.tabhws2xml.Controls.Add(this.groupBox1);
			this.tabhws2xml.Location = new System.Drawing.Point(4, 22);
			this.tabhws2xml.Name = "tabhws2xml";
			this.tabhws2xml.Padding = new System.Windows.Forms.Padding(3);
			this.tabhws2xml.Size = new System.Drawing.Size(388, 184);
			this.tabhws2xml.TabIndex = 3;
			this.tabhws2xml.Text = "hws2xml";
			this.tabhws2xml.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.saveHWSButton);
			this.groupBox2.Controls.Add(this.saveHWSBrowseButton);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Location = new System.Drawing.Point(6, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(248, 76);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Convert to HWS";
			// 
			// saveHWSButton
			// 
			this.saveHWSButton.Location = new System.Drawing.Point(6, 45);
			this.saveHWSButton.Name = "saveHWSButton";
			this.saveHWSButton.Size = new System.Drawing.Size(236, 23);
			this.saveHWSButton.TabIndex = 2;
			this.saveHWSButton.Text = "Save As HWS";
			this.saveHWSButton.UseVisualStyleBackColor = true;
			this.saveHWSButton.Click += new System.EventHandler(this.saveHWSButtonClick);
			// 
			// saveHWSBrowseButton
			// 
			this.saveHWSBrowseButton.Location = new System.Drawing.Point(167, 17);
			this.saveHWSBrowseButton.Name = "saveHWSBrowseButton";
			this.saveHWSBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.saveHWSBrowseButton.TabIndex = 1;
			this.saveHWSBrowseButton.Text = "Browse...";
			this.saveHWSBrowseButton.UseVisualStyleBackColor = true;
			this.saveHWSBrowseButton.Click += new System.EventHandler(this.saveHWSBrowseButtonClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 19);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(155, 20);
			this.textBox2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.saveXMLButton);
			this.groupBox1.Controls.Add(this.saveXMLBrowseButton);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 76);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Convert to XML";
			// 
			// saveXMLButton
			// 
			this.saveXMLButton.Location = new System.Drawing.Point(6, 45);
			this.saveXMLButton.Name = "saveXMLButton";
			this.saveXMLButton.Size = new System.Drawing.Size(236, 23);
			this.saveXMLButton.TabIndex = 2;
			this.saveXMLButton.Text = "Save As XML";
			this.saveXMLButton.UseVisualStyleBackColor = true;
			this.saveXMLButton.Click += new System.EventHandler(this.saveXMLButtonClick);
			// 
			// saveXMLBrowseButton
			// 
			this.saveXMLBrowseButton.Location = new System.Drawing.Point(167, 17);
			this.saveXMLBrowseButton.Name = "saveXMLBrowseButton";
			this.saveXMLBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.saveXMLBrowseButton.TabIndex = 1;
			this.saveXMLBrowseButton.Text = "Browse...";
			this.saveXMLBrowseButton.UseVisualStyleBackColor = true;
			this.saveXMLBrowseButton.Click += new System.EventHandler(this.saveXMLBrowseButtonClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(155, 20);
			this.textBox1.TabIndex = 0;
			// 
			// openHWSDialog
			// 
			this.openHWSDialog.Filter = "Hammerwatch Save file (*.hws)|*.hws|XML File (*.xml)|*.xml";
			// 
			// saveXMLDialog
			// 
			this.saveXMLDialog.DefaultExt = "*.xml";
			this.saveXMLDialog.Filter = "XML file|*.xml";
			// 
			// openXMLDialog
			// 
			this.openXMLDialog.Filter = "XML file|*.xml";
			// 
			// saveHWSDialog
			// 
			this.saveHWSDialog.DefaultExt = "*.hws;*.xml";
			this.saveHWSDialog.Filter = "Hammerwatch Save file (*.hws)|*.hws|XML File (*.xml)|*.xml";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.buttonSave,
            this.buttonClose,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(414, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = global::HWSEdit.Properties.Resources.folder_horizontal_open;
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "Open";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(23, 22);
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonClose.Image = global::HWSEdit.Properties.Resources.cross_circle_frame;
			this.buttonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(23, 22);
			this.buttonClose.Text = "Close";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = global::HWSEdit.Properties.Resources.question_frame;
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "Help";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = global::HWSEdit.Properties.Resources.information_balloon;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "About";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 249);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(414, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(26, 17);
			this.toolStripStatusLabel.Text = "Idle";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 7;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 159);
			this.tableLayoutPanel3.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(414, 271);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabPageSelector);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(365, 310);
			this.Name = "MainForm";
			this.Text = "HWSEdit - Hammerwatch Save Editor";
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
			this.tabPlayers.ResumeLayout(false);
			this.tabPlayers.PerformLayout();
			this.playerContextMenu.ResumeLayout(false);
			this.tabhws2xml.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxCurrentFile;
		private System.Windows.Forms.SaveFileDialog saveHWSDialog;
		private System.Windows.Forms.OpenFileDialog openXMLDialog;
		private System.Windows.Forms.SaveFileDialog saveXMLDialog;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button saveXMLBrowseButton;
		private System.Windows.Forms.Button saveXMLButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button saveHWSBrowseButton;
		private System.Windows.Forms.Button saveHWSButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.OpenFileDialog openHWSDialog;
		private System.Windows.Forms.TabPage tabhws2xml;
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
		private System.Windows.Forms.ComboBox dropdownDifficulty;
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
		private System.Windows.Forms.TextBox InputPlayerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip playerContextMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox InputPlayerClass;
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
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
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
	}
}
