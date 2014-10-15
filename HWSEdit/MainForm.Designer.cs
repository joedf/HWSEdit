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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPageSelector = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.textBoxCurrentFile = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.InputPlaytime = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.InputLevelID = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.InputSpawnY = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.InputSpawnX = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dropdownDifficulty = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkboxNetworked = new System.Windows.Forms.CheckBox();
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
			this.label2 = new System.Windows.Forms.Label();
			this.tabhws2xml = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSaveAs = new System.Windows.Forms.Button();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.openHWSDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveXMLDialog = new System.Windows.Forms.SaveFileDialog();
			this.openXMLDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveHWSDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.tabPageSelector.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlaytime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputLevelID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnX)).BeginInit();
			this.tabModifiers.SuspendLayout();
			this.tabPlayers.SuspendLayout();
			this.tabhws2xml.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(275, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openToolStripMenuItem,
									this.saveAsToolStripMenuItem,
									this.exitCancelToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.ButtonSaveAsClick);
			// 
			// exitCancelToolStripMenuItem
			// 
			this.exitCancelToolStripMenuItem.Name = "exitCancelToolStripMenuItem";
			this.exitCancelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.exitCancelToolStripMenuItem.Text = "Exit/Cancel";
			this.exitCancelToolStripMenuItem.Click += new System.EventHandler(this.ButtonQuit);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpTopicToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// helpTopicToolStripMenuItem
			// 
			this.helpTopicToolStripMenuItem.Name = "helpTopicToolStripMenuItem";
			this.helpTopicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.helpTopicToolStripMenuItem.Text = "Help Topic";
			this.helpTopicToolStripMenuItem.Click += new System.EventHandler(this.HelpTopicToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.aboutToolStripMenuItem.Text = "About";
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
			this.tabPageSelector.Location = new System.Drawing.Point(4, 27);
			this.tabPageSelector.Name = "tabPageSelector";
			this.tabPageSelector.SelectedIndex = 0;
			this.tabPageSelector.Size = new System.Drawing.Size(269, 196);
			this.tabPageSelector.TabIndex = 1;
			this.tabPageSelector.SelectedIndexChanged += new System.EventHandler(this.TabPageSelectorSelectedIndexChanged);
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.textBoxCurrentFile);
			this.tabGeneral.Controls.Add(this.label10);
			this.tabGeneral.Controls.Add(this.InputPlaytime);
			this.tabGeneral.Controls.Add(this.label9);
			this.tabGeneral.Controls.Add(this.InputLevelID);
			this.tabGeneral.Controls.Add(this.label8);
			this.tabGeneral.Controls.Add(this.InputSpawnY);
			this.tabGeneral.Controls.Add(this.label7);
			this.tabGeneral.Controls.Add(this.InputSpawnX);
			this.tabGeneral.Controls.Add(this.label6);
			this.tabGeneral.Controls.Add(this.label5);
			this.tabGeneral.Controls.Add(this.dropdownDifficulty);
			this.tabGeneral.Controls.Add(this.label1);
			this.tabGeneral.Controls.Add(this.checkboxNetworked);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(261, 170);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// textBoxCurrentFile
			// 
			this.textBoxCurrentFile.Location = new System.Drawing.Point(75, 143);
			this.textBoxCurrentFile.Name = "textBoxCurrentFile";
			this.textBoxCurrentFile.ReadOnly = true;
			this.textBoxCurrentFile.Size = new System.Drawing.Size(176, 20);
			this.textBoxCurrentFile.TabIndex = 13;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(4, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 23);
			this.label10.TabIndex = 12;
			this.label10.Text = "Current file :";
			// 
			// InputPlaytime
			// 
			this.InputPlaytime.Location = new System.Drawing.Point(64, 108);
			this.InputPlaytime.Maximum = new decimal(new int[] {
									2147483647,
									0,
									0,
									0});
			this.InputPlaytime.Name = "InputPlaytime";
			this.InputPlaytime.Size = new System.Drawing.Size(103, 20);
			this.InputPlaytime.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(3, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "Play time :";
			// 
			// InputLevelID
			// 
			this.InputLevelID.Location = new System.Drawing.Point(64, 84);
			this.InputLevelID.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.InputLevelID.Name = "InputLevelID";
			this.InputLevelID.Size = new System.Drawing.Size(103, 20);
			this.InputLevelID.TabIndex = 9;
			this.InputLevelID.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(3, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Level ID :";
			// 
			// InputSpawnY
			// 
			this.InputSpawnY.DecimalPlaces = 1;
			this.InputSpawnY.Increment = new decimal(new int[] {
									1,
									0,
									0,
									65536});
			this.InputSpawnY.Location = new System.Drawing.Point(197, 58);
			this.InputSpawnY.Maximum = new decimal(new int[] {
									500,
									0,
									0,
									0});
			this.InputSpawnY.Minimum = new decimal(new int[] {
									500,
									0,
									0,
									-2147483648});
			this.InputSpawnY.Name = "InputSpawnY";
			this.InputSpawnY.Size = new System.Drawing.Size(54, 20);
			this.InputSpawnY.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(173, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Y";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// InputSpawnX
			// 
			this.InputSpawnX.DecimalPlaces = 1;
			this.InputSpawnX.Increment = new decimal(new int[] {
									1,
									0,
									0,
									65536});
			this.InputSpawnX.Location = new System.Drawing.Point(113, 58);
			this.InputSpawnX.Maximum = new decimal(new int[] {
									500,
									0,
									0,
									0});
			this.InputSpawnX.Minimum = new decimal(new int[] {
									500,
									0,
									0,
									-2147483648});
			this.InputSpawnX.Name = "InputSpawnX";
			this.InputSpawnX.Size = new System.Drawing.Size(54, 20);
			this.InputSpawnX.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(89, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "X";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Spawn position :";
			// 
			// dropdownDifficulty
			// 
			this.dropdownDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropdownDifficulty.FormattingEnabled = true;
			this.dropdownDifficulty.Items.AddRange(new object[] {
									"Easy",
									"Medium",
									"Hard"});
			this.dropdownDifficulty.Location = new System.Drawing.Point(59, 30);
			this.dropdownDifficulty.Name = "dropdownDifficulty";
			this.dropdownDifficulty.Size = new System.Drawing.Size(83, 21);
			this.dropdownDifficulty.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Difficulty :";
			// 
			// checkboxNetworked
			// 
			this.checkboxNetworked.Location = new System.Drawing.Point(6, 6);
			this.checkboxNetworked.Name = "checkboxNetworked";
			this.checkboxNetworked.Size = new System.Drawing.Size(206, 24);
			this.checkboxNetworked.TabIndex = 0;
			this.checkboxNetworked.Text = "Networked (Multiplayer game)";
			this.checkboxNetworked.UseVisualStyleBackColor = true;
			// 
			// tabModifiers
			// 
			this.tabModifiers.Controls.Add(this.label4);
			this.tabModifiers.Controls.Add(this.label3);
			this.tabModifiers.Controls.Add(this.checkBox5XManaRegen);
			this.tabModifiers.Controls.Add(this.checkBoxDoubleLives);
			this.tabModifiers.Controls.Add(this.checkBoxDoubleDamage);
			this.tabModifiers.Controls.Add(this.checkBoxHPRegen);
			this.tabModifiers.Controls.Add(this.checkBoxInfiniteLives);
			this.tabModifiers.Controls.Add(this.checkBoxReverseHPRegen);
			this.tabModifiers.Controls.Add(this.checkBoxNoManaRegen);
			this.tabModifiers.Controls.Add(this.checkBoxNoHPPickups);
			this.tabModifiers.Controls.Add(this.checkBoxSharedHPPool);
			this.tabModifiers.Controls.Add(this.checkBox1HP);
			this.tabModifiers.Controls.Add(this.checkBoxNoExtraLives);
			this.tabModifiers.Location = new System.Drawing.Point(4, 22);
			this.tabModifiers.Name = "tabModifiers";
			this.tabModifiers.Padding = new System.Windows.Forms.Padding(3);
			this.tabModifiers.Size = new System.Drawing.Size(261, 170);
			this.tabModifiers.TabIndex = 1;
			this.tabModifiers.Text = "Modifiers";
			this.tabModifiers.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(6, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Challenges";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(131, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Crutches";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// checkBox5XManaRegen
			// 
			this.checkBox5XManaRegen.Location = new System.Drawing.Point(131, 106);
			this.checkBox5XManaRegen.Name = "checkBox5XManaRegen";
			this.checkBox5XManaRegen.Size = new System.Drawing.Size(104, 24);
			this.checkBox5XManaRegen.TabIndex = 10;
			this.checkBox5XManaRegen.Text = "5x Mana regen";
			this.checkBox5XManaRegen.UseVisualStyleBackColor = true;
			this.checkBox5XManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxDoubleLives
			// 
			this.checkBoxDoubleLives.Location = new System.Drawing.Point(131, 85);
			this.checkBoxDoubleLives.Name = "checkBoxDoubleLives";
			this.checkBoxDoubleLives.Size = new System.Drawing.Size(104, 24);
			this.checkBoxDoubleLives.TabIndex = 9;
			this.checkBoxDoubleLives.Text = "Double lives";
			this.checkBoxDoubleLives.UseVisualStyleBackColor = true;
			this.checkBoxDoubleLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxDoubleDamage
			// 
			this.checkBoxDoubleDamage.Location = new System.Drawing.Point(131, 65);
			this.checkBoxDoubleDamage.Name = "checkBoxDoubleDamage";
			this.checkBoxDoubleDamage.Size = new System.Drawing.Size(104, 24);
			this.checkBoxDoubleDamage.TabIndex = 8;
			this.checkBoxDoubleDamage.Text = "Double damage";
			this.checkBoxDoubleDamage.UseVisualStyleBackColor = true;
			this.checkBoxDoubleDamage.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxHPRegen
			// 
			this.checkBoxHPRegen.Location = new System.Drawing.Point(131, 44);
			this.checkBoxHPRegen.Name = "checkBoxHPRegen";
			this.checkBoxHPRegen.Size = new System.Drawing.Size(104, 24);
			this.checkBoxHPRegen.TabIndex = 7;
			this.checkBoxHPRegen.Text = "HP regen";
			this.checkBoxHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxInfiniteLives
			// 
			this.checkBoxInfiniteLives.Location = new System.Drawing.Point(131, 23);
			this.checkBoxInfiniteLives.Name = "checkBoxInfiniteLives";
			this.checkBoxInfiniteLives.Size = new System.Drawing.Size(104, 24);
			this.checkBoxInfiniteLives.TabIndex = 6;
			this.checkBoxInfiniteLives.Text = "Infinite Lives";
			this.checkBoxInfiniteLives.UseVisualStyleBackColor = true;
			this.checkBoxInfiniteLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxReverseHPRegen
			// 
			this.checkBoxReverseHPRegen.Location = new System.Drawing.Point(6, 126);
			this.checkBoxReverseHPRegen.Name = "checkBoxReverseHPRegen";
			this.checkBoxReverseHPRegen.Size = new System.Drawing.Size(120, 24);
			this.checkBoxReverseHPRegen.TabIndex = 5;
			this.checkBoxReverseHPRegen.Text = "Reverse HP regen";
			this.checkBoxReverseHPRegen.UseVisualStyleBackColor = true;
			this.checkBoxReverseHPRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoManaRegen
			// 
			this.checkBoxNoManaRegen.Location = new System.Drawing.Point(6, 105);
			this.checkBoxNoManaRegen.Name = "checkBoxNoManaRegen";
			this.checkBoxNoManaRegen.Size = new System.Drawing.Size(114, 24);
			this.checkBoxNoManaRegen.TabIndex = 4;
			this.checkBoxNoManaRegen.Text = "No Mana regen";
			this.checkBoxNoManaRegen.UseVisualStyleBackColor = true;
			this.checkBoxNoManaRegen.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoHPPickups
			// 
			this.checkBoxNoHPPickups.Location = new System.Drawing.Point(6, 84);
			this.checkBoxNoHPPickups.Name = "checkBoxNoHPPickups";
			this.checkBoxNoHPPickups.Size = new System.Drawing.Size(104, 24);
			this.checkBoxNoHPPickups.TabIndex = 3;
			this.checkBoxNoHPPickups.Text = "No HP pickups";
			this.checkBoxNoHPPickups.UseVisualStyleBackColor = true;
			this.checkBoxNoHPPickups.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxSharedHPPool
			// 
			this.checkBoxSharedHPPool.Location = new System.Drawing.Point(6, 64);
			this.checkBoxSharedHPPool.Name = "checkBoxSharedHPPool";
			this.checkBoxSharedHPPool.Size = new System.Drawing.Size(104, 24);
			this.checkBoxSharedHPPool.TabIndex = 2;
			this.checkBoxSharedHPPool.Text = "Shared HP pool";
			this.checkBoxSharedHPPool.UseVisualStyleBackColor = true;
			this.checkBoxSharedHPPool.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBox1HP
			// 
			this.checkBox1HP.Location = new System.Drawing.Point(6, 43);
			this.checkBox1HP.Name = "checkBox1HP";
			this.checkBox1HP.Size = new System.Drawing.Size(104, 24);
			this.checkBox1HP.TabIndex = 1;
			this.checkBox1HP.Text = "1 HP";
			this.checkBox1HP.UseVisualStyleBackColor = true;
			this.checkBox1HP.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// checkBoxNoExtraLives
			// 
			this.checkBoxNoExtraLives.Location = new System.Drawing.Point(6, 23);
			this.checkBoxNoExtraLives.Name = "checkBoxNoExtraLives";
			this.checkBoxNoExtraLives.Size = new System.Drawing.Size(104, 24);
			this.checkBoxNoExtraLives.TabIndex = 0;
			this.checkBoxNoExtraLives.Text = "No extra lives";
			this.checkBoxNoExtraLives.UseVisualStyleBackColor = true;
			this.checkBoxNoExtraLives.CheckedChanged += new System.EventHandler(this.CheckboxModifiersChanged);
			// 
			// tabPlayers
			// 
			this.tabPlayers.Controls.Add(this.label2);
			this.tabPlayers.Location = new System.Drawing.Point(4, 22);
			this.tabPlayers.Name = "tabPlayers";
			this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPlayers.Size = new System.Drawing.Size(261, 170);
			this.tabPlayers.TabIndex = 2;
			this.tabPlayers.Text = "Players";
			this.tabPlayers.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(252, 164);
			this.label2.TabIndex = 0;
			this.label2.Text = "Not yet implemented";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabhws2xml
			// 
			this.tabhws2xml.Controls.Add(this.groupBox2);
			this.tabhws2xml.Controls.Add(this.groupBox1);
			this.tabhws2xml.Location = new System.Drawing.Point(4, 22);
			this.tabhws2xml.Name = "tabhws2xml";
			this.tabhws2xml.Padding = new System.Windows.Forms.Padding(3);
			this.tabhws2xml.Size = new System.Drawing.Size(261, 170);
			this.tabhws2xml.TabIndex = 3;
			this.tabhws2xml.Text = "hws2xml";
			this.tabhws2xml.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Location = new System.Drawing.Point(6, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(248, 76);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Convert to HWS";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 45);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(236, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Save As HWS";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(167, 17);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "Browse...";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
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
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 76);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Convert to XML";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 45);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(236, 23);
			this.button4.TabIndex = 2;
			this.button4.Text = "Save As XML";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(167, 17);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Browse...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(155, 20);
			this.textBox1.TabIndex = 0;
			// 
			// buttonSaveAs
			// 
			this.buttonSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveAs.Location = new System.Drawing.Point(117, 225);
			this.buttonSaveAs.Name = "buttonSaveAs";
			this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveAs.TabIndex = 2;
			this.buttonSaveAs.Text = "Save As...";
			this.buttonSaveAs.UseVisualStyleBackColor = true;
			this.buttonSaveAs.Click += new System.EventHandler(this.ButtonSaveAsClick);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonQuit.Location = new System.Drawing.Point(198, 225);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 23);
			this.buttonQuit.TabIndex = 3;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit);
			// 
			// openHWSDialog
			// 
			this.openHWSDialog.Filter = "Hammerwatch Save file|*.hws";
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
			this.saveHWSDialog.DefaultExt = "*.hws";
			this.saveHWSDialog.Filter = "Hammerwatch Save file|*.hws";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(275, 251);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonSaveAs);
			this.Controls.Add(this.tabPageSelector);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(291, 289);
			this.Name = "MainForm";
			this.Text = "HWSEdit";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPageSelector.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InputPlaytime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputLevelID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputSpawnX)).EndInit();
			this.tabModifiers.ResumeLayout(false);
			this.tabPlayers.ResumeLayout(false);
			this.tabhws2xml.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxCurrentFile;
		private System.Windows.Forms.SaveFileDialog saveHWSDialog;
		private System.Windows.Forms.OpenFileDialog openXMLDialog;
		private System.Windows.Forms.SaveFileDialog saveXMLDialog;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.OpenFileDialog openHWSDialog;
		private System.Windows.Forms.TabPage tabhws2xml;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown InputLevelID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown InputPlaytime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown InputSpawnX;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown InputSpawnY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
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
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Button buttonSaveAs;
		private System.Windows.Forms.ComboBox dropdownDifficulty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkboxNetworked;
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
	}
}
