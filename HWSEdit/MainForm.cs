/*
Copyright (c) 2014 Joe DF (joedf@ahkscript.org)

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify, merge,
publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or
substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
DEALINGS IN THE SOFTWARE.
*/

/*
 * Created by SharpDevelop.
 * User: Joachim
 * Date: 2014-10-14
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using OpenTK;
using hwsFormat;
using System.IO;

namespace HWSEdit
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string AppName = "HWSEdit";
		public static string AppTitle = AppName + " - Hammerwatch Save Editor";
		public static string AppURL = "http://hammerwatch.com/forum/index.php?topic=2197.0";
		public static string AppAuthors = "Joe DF";
		public static string RevisionDate = "15/10/2014";

		public SValue MAINBUFFER;

		private string currentFile = "";
		private List<SObject> players;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.InputDifficulty.SelectedIndex=1;
			buttonSave.Enabled = false;
			buttonClose.Enabled = false;
			saveToolStripMenuItem.Enabled = false;
			saveAsToolStripMenuItem.Enabled = false;
			closeToolStripMenuItem.Enabled = false;
			tabGeneral.Enabled = false;
			tabModifiers.Enabled = false;
			tabPlayers.Enabled = false;
			tabhws2xml.Enabled = true;
			InputPlayerClass.Enabled = false;
			InputPlayerName.Enabled = false;
			playerListView.Columns[0].Width = -2;
		}


		#region Event callbacks
		private void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show(AppTitle+"\nBy "+ AppAuthors+ "\n" +
			                "A grand thanks to Myran (for the core of this application)\n"+
			                "Fugue Icons - (C) 2012 Yusuke Kamiyamane"+
							"\n\nReleased under the MIT License\n"+
							"Revision Date: "+RevisionDate,
							AppTitle,
							MessageBoxButtons.OK,
							MessageBoxIcon.Information);
		}
		private void HelpTopicToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(AppURL);
		}
		private void saveXMLBrowseButtonClick(object sender, EventArgs e)
		{
			DialogResult result = openHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				string fn = openHWSDialog.FileName;
				textBox1.Text = fn;
			}
		}
		private void ButtonQuit(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void saveXMLButtonClick(object sender, EventArgs e)
		{
			string inFile = textBox1.Text;
			saveXMLDialog.FileName = Path.GetFileNameWithoutExtension(inFile) + ".xml";
			
			DialogResult result = saveXMLDialog.ShowDialog();
			if (result == DialogResult.OK) {
				
				string outFile = saveXMLDialog.FileName;
				
				BinaryReader BR = new BinaryReader(File.Open(inFile,FileMode.Open));
				SValue OBJ = SValue.LoadStream(BR);
				TextWriter TW = new StreamWriter(outFile);
				SValue.SaveXML(OBJ,TW);
				TW.Close();
				
				MessageBox.Show("Converted from HWS to XML.\nSaved to:\n\""+outFile+"\"");
			}
		}
		private void saveHWSBrowseButtonClick(object sender, EventArgs e)
		{
			DialogResult result = openXMLDialog.ShowDialog();
			if (result == DialogResult.OK) {
				string fn = openXMLDialog.FileName;
				textBox2.Text = fn;
			}
		}
		private void saveHWSButtonClick(object sender, EventArgs e)
		{
			string inFile = textBox2.Text;
			saveHWSDialog.FileName = Path.GetFileNameWithoutExtension(inFile) + ".hws";
			
			DialogResult result = saveHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				
				string outFile = saveHWSDialog.FileName;
				
				TextReader TR = new StreamReader(inFile);
				SValue OBJ = SValue.FromXMLFile(TR);
				BinaryWriter BW = new BinaryWriter(File.Open(outFile,FileMode.Create));
				SValue.SaveStream(OBJ,BW);
				BW.Close();
				
				MessageBox.Show("Converted from XML to HWS.\nSaved to:\n\""+outFile+"\"");
			}
		}
		private void playerListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (playerListView.SelectedItems.Count > 0 && playerListView.SelectedIndices.Count == 1)
			{
				SObject player = players[playerListView.SelectedIndices[0]];
				InputPlayerName.Text = player.Get("name").GetString();
				InputPlayerName.Enabled = true;
				InputPlayerClass.SelectedIndex = player.Get("class").GetInteger();
				InputPlayerClass.Enabled = true;
				InputPlayerLives.Value = player.Get("lives").GetInteger();
				InputPlayerLives.Enabled = true;
				InputPlayerHealth.Value = player.Get("health").GetInteger();
				InputPlayerHealth.Enabled = true;
				InputPlayerMana.Value = player.Get("mana").GetInteger();
				InputPlayerMana.Enabled = true;
				InputPlayerMoney.Value = player.Get("money").GetInteger();
				InputPlayerMoney.Enabled = true;
				InputPlayerPotion.SelectedIndex = player.Get("potion").GetInteger();
				InputPlayerPotion.Enabled = true;
			}
			else
			{
				InputPlayerName.Text = "";
				InputPlayerName.Enabled = false;
				InputPlayerClass.SelectedIndex = -1;
				InputPlayerClass.Enabled = false;
				InputPlayerLives.Value = 0;
				InputPlayerLives.Enabled = false;
				InputPlayerHealth.Value = 0;
				InputPlayerHealth.Enabled = false;
				InputPlayerMana.Value = 0;
				InputPlayerMana.Enabled = false;
				InputPlayerMoney.Value = 0;
				InputPlayerMoney.Enabled = false;
				InputPlayerPotion.SelectedIndex = -1;
				InputPlayerPotion.Enabled = false;
			}
		}
		private void playerListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			InputPlayerName.Text = e.Label;
		}
		private void InputPlayerName_TextChanged(object sender, EventArgs e)
		{
			if (playerListView.SelectedItems.Count > 0) playerListView.SelectedItems[0].Text = InputPlayerName.Text;
		}
		private void playerContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == renameToolStripMenuItem)
			{
				if (playerListView.SelectedItems.Count > 0) playerListView.SelectedItems[0].BeginEdit();
			}
		}
		private void InputPlayerClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (playerListView.SelectedItems.Count > 0) playerListView.SelectedItems[0].ImageIndex = InputPlayerClass.SelectedIndex;
		}
		private void OpenToolStripMenuItemClick(object sender, EventArgs e) { Open(); }
		private void openToolStripButton_Click(object sender, EventArgs e) { Open(); }
		private void buttonSave_Click(object sender, EventArgs e) { Save(currentFile); }
		private void saveToolStripMenuItem_Click(object sender, EventArgs e) { Save(currentFile); }
		private void ButtonSaveAsClick(object sender, EventArgs e) { SaveAs(); }
		#endregion

		#region Data management
		void ValidifyModifiersCheckBoxes() {
			//checkBoxNoExtraLives vs checkBoxInfiniteLives vs checkBoxDoubleLives
			if (checkBoxInfiniteLives.Checked) {
				checkBoxNoExtraLives.Checked = false;
				checkBoxNoExtraLives.Enabled = false;
				checkBoxDoubleLives.Checked = false;
				checkBoxDoubleLives.Enabled = false;
			} else if (checkBoxNoExtraLives.Checked) {
				checkBoxInfiniteLives.Checked = false;
				checkBoxInfiniteLives.Enabled = false;
				checkBoxDoubleLives.Checked = false;
				checkBoxDoubleLives.Enabled = false;
			} else if (checkBoxDoubleLives.Checked) {
				checkBoxInfiniteLives.Checked = false;
				checkBoxInfiniteLives.Enabled = false;
				checkBoxNoExtraLives.Checked = false;
				checkBoxNoExtraLives.Enabled = false;
			} else {
				checkBoxInfiniteLives.Checked = false;
				checkBoxInfiniteLives.Enabled = true;
				checkBoxNoExtraLives.Checked = false;
				checkBoxNoExtraLives.Enabled = true;
				checkBoxDoubleLives.Checked = false;
				checkBoxDoubleLives.Enabled = true;
			}
			
			//checkBoxNoManaRegen vs checkBox5XManaRegen
			if (checkBoxNoManaRegen.Checked) {
				checkBox5XManaRegen.Checked = false;
				checkBox5XManaRegen.Enabled = false;
			} else if (checkBox5XManaRegen.Checked) {
				checkBoxNoManaRegen.Checked = false;
				checkBoxNoManaRegen.Enabled = false;
			} else {
				checkBoxNoManaRegen.Checked = false;
				checkBoxNoManaRegen.Enabled = true;
				checkBox5XManaRegen.Checked = false;
				checkBox5XManaRegen.Enabled = true;
			}
			
			//checkBox1HP vs checkBoxNoHPPickups vs checkBoxReverseHPRegen vs checkBoxHPRegen
			if (checkBox1HP.Checked) {
				checkBoxNoHPPickups.Checked = false;
				checkBoxNoHPPickups.Enabled = false;
				checkBoxReverseHPRegen.Checked = false;
				checkBoxReverseHPRegen.Enabled = false;
				checkBoxHPRegen.Checked = false;
				checkBoxHPRegen.Enabled = false;
			} else if (checkBoxHPRegen.Checked) {
				checkBox1HP.Checked = false;
				checkBox1HP.Enabled = false;
				checkBoxReverseHPRegen.Checked = false;
				checkBoxReverseHPRegen.Enabled = false;
			} else if (checkBoxReverseHPRegen.Checked) {
				checkBox1HP.Checked = false;
				checkBox1HP.Enabled = false;
				checkBoxHPRegen.Checked = false;
				checkBoxHPRegen.Enabled = false;
			} else if (checkBoxNoHPPickups.Checked) {
				checkBox1HP.Checked = false;
				checkBox1HP.Enabled = false;
			} else {
				checkBox1HP.Checked = false;
				checkBox1HP.Enabled = true;
				checkBoxNoHPPickups.Checked = false;
				checkBoxNoHPPickups.Enabled = true;
				checkBoxReverseHPRegen.Checked = false;
				checkBoxReverseHPRegen.Enabled = true;
				checkBoxHPRegen.Checked = false;
				checkBoxHPRegen.Enabled = true;
			}
		}

		private void CheckboxModifiersChanged(object sender, EventArgs e)
		{
			ValidifyModifiersCheckBoxes();
		}
		
		bool MAINBUFFERtoFormData() {
			//load values into form
			try
			{
				//+->general
				SObject root = MAINBUFFER.GetObject();
				InputPlaytime.Value = root.Get("play-time").GetInteger();
				InputSpawnX.Value = (decimal) root.Get("spawn-pos").GetObject().Get("x").GetFloat();
				InputSpawnY.Value = (decimal) root.Get("spawn-pos").GetObject().Get("y").GetFloat();
				InputLevelID.Text = root.Get("level-id").GetString();
				InputDifficulty.SelectedIndex = root.Get("difficulty").GetInteger();
				checkboxNetworked.Checked = root.Get("networked").GetBoolean();
				//+->modifiers
				SObject modifiers = root.Get("modifiers").GetObject();
				//  +->challenges
				checkBoxNoExtraLives.Checked = modifiers.Get("nolives").GetBoolean();
				checkBox1HP.Checked = modifiers.Get("1hp").GetBoolean();
				checkBoxSharedHPPool.Checked = modifiers.Get("sharehp").GetBoolean();
				checkBoxNoHPPickups.Checked = modifiers.Get("nohppup").GetBoolean();
				checkBoxNoManaRegen.Checked = modifiers.Get("nomanaregen").GetBoolean();
				checkBoxReverseHPRegen.Checked = modifiers.Get("revhpregen").GetBoolean();
				//  +->crutches
				checkBoxInfiniteLives.Checked = modifiers.Get("inflives").GetBoolean();
				checkBoxHPRegen.Checked = modifiers.Get("hpregen").GetBoolean();
				checkBoxDoubleDamage.Checked = modifiers.Get("doubledmg").GetBoolean();
				checkBoxDoubleLives.Checked = modifiers.Get("doublelife").GetBoolean();
				checkBox5XManaRegen.Checked = modifiers.Get("quickmana").GetBoolean();
				//+->players
				players = new List<SObject>();
				foreach (SValue player in root.Get("players").GetArray())
				{
					if (player.GetObject() != null)
					{
						players.Add(player.GetObject());
						playerListView.Items.Add(player.GetObject().Get("name").GetString(), player.GetObject().Get("class").GetInteger());
					}
				}
				return true;
			}
			catch(Exception e)
			{
				MessageBox.Show("Invalid save data. The data is either corrupted or did not adhere to a recognized format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				toolStripStatusLabel.Text = "Error encountered while loading.";
				toolStripStatusLabel.ToolTipText = "Invalid save data. The file is either corrupted or not a valid save.";
				return false;
			}
		}
		
		bool FormDatatoMAINBUFFER() {
			//load values into MAINBUFFER
			try
			{
				//+->general
				MAINBUFFER.GetObject().Set("play-time", new SValue((int) InputPlaytime.Value));
				SObject Obj_spawnpos = new SObject();
				Obj_spawnpos.Set("x", new SValue((float) InputSpawnX.Value));
				Obj_spawnpos.Set("y", new SValue((float) InputSpawnY.Value));
				MAINBUFFER.GetObject().Set("spawn-pos", new SValue(Obj_spawnpos));
				MAINBUFFER.GetObject().Set("level-id", new SValue(InputLevelID.Text));
				MAINBUFFER.GetObject().Set("difficulty", new SValue((int) InputDifficulty.SelectedIndex));
				MAINBUFFER.GetObject().Set("networked", new SValue((bool) checkboxNetworked.Checked));
				//+->modifiers
				//  +->challenges
				SObject Obj_modifiers = new SObject();
				Obj_modifiers.Set("nolives", new SValue((bool) checkBoxNoExtraLives.Checked));
				Obj_modifiers.Set("1hp", new SValue((bool) checkBox1HP.Checked));
				Obj_modifiers.Set("sharehp", new SValue((bool) checkBoxSharedHPPool.Checked));
				Obj_modifiers.Set("nohppup", new SValue((bool) checkBoxNoHPPickups.Checked));
				Obj_modifiers.Set("nomanaregen", new SValue((bool) checkBoxNoManaRegen.Checked));
				Obj_modifiers.Set("revhpregen", new SValue((bool) checkBoxReverseHPRegen.Checked));
				//  +->crutches
				Obj_modifiers.Set("inflives", new SValue((bool) checkBoxInfiniteLives.Checked));
				Obj_modifiers.Set("hpregen", new SValue((bool) checkBoxHPRegen.Checked));
				Obj_modifiers.Set("doubledmg", new SValue((bool) checkBoxDoubleDamage.Checked));
				Obj_modifiers.Set("doublelife", new SValue((bool) checkBoxDoubleLives.Checked));
				Obj_modifiers.Set("quickmana", new SValue((bool) checkBox5XManaRegen.Checked));
				MAINBUFFER.GetObject().Set("modifiers", new SValue(Obj_modifiers));
				//+->players
			}
			catch (Exception e)
			{
				MessageBox.Show("An error occurred while trying to prepare the data for saving:\n" + e.Message + "\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				toolStripStatusLabel.Text = "Error encountered while saving.";
				toolStripStatusLabel.ToolTipText = "An error occurred while trying to prepare the data for saving.";
				return false;
			}
			return true;
		}
		#endregion

		#region Actions
		public void Open()
		{
			openHWSDialog.InitialDirectory = GetDefaultFileDialogPath();
			DialogResult result = openHWSDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				currentFile = openHWSDialog.FileName;
				textBoxCurrentFile.Text = Path.GetFileName(currentFile);

				//load file to mainbuffer
				string ext = Path.GetExtension(currentFile);
				if (ext == ".xml")
				{
					using (StreamReader SR = new StreamReader(File.Open(currentFile, FileMode.Open)))
					{
						MAINBUFFER = SValue.FromXMLFile(SR);
					}
				}
				else if (ext == ".hws")
				{
					using (BinaryReader BR = new BinaryReader(File.Open(currentFile, FileMode.Open)))
					{
						MAINBUFFER = SValue.LoadStream(BR);
					}
				}

				//load values into form
				if (MAINBUFFERtoFormData())
				{
					buttonSave.Enabled = true;
					buttonClose.Enabled = true;
					saveToolStripMenuItem.Enabled = true;
					saveAsToolStripMenuItem.Enabled = true;
					closeToolStripMenuItem.Enabled = true;
					tabGeneral.Enabled = true;
					tabModifiers.Enabled = true;
					tabPlayers.Enabled = true;
					tabPageSelector.SelectedIndex = 0;

					ValidifyModifiersCheckBoxes();

					toolStripStatusLabel.Text = "Successfully loaded data.";
					toolStripStatusLabel.ToolTipText = "Successfully loaded data from: \"" + currentFile + "\"";
				}
			}
		}
		public void SaveAs()
		{
			saveHWSDialog.FileName = Path.GetFileName(currentFile);
				
			DialogResult result = saveHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				Save(saveHWSDialog.FileName);
			}
		}
		public void Save(string file)
		{
			//get data and update the MAINBUFFER
			ValidifyModifiersCheckBoxes();
			if (FormDatatoMAINBUFFER())
			{
				string ext = Path.GetExtension(file);
				if (ext == ".xml")
				{
					using (TextWriter TW = new StreamWriter(File.Open(file, FileMode.Create)))
					{
						SValue.SaveXML(MAINBUFFER, TW);
					}
				}
				else if (ext == ".hws")
				{
					using (BinaryWriter BW = new BinaryWriter(File.Open(file, FileMode.Create)))
					{
						SValue.SaveStream(MAINBUFFER, BW);
					}
				}
				else
				{
					MessageBox.Show("Invalid save file type. You must save with either an XML or HWS extension so we know how to save the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					toolStripStatusLabel.Text = "Error encountered while saving.";
					toolStripStatusLabel.ToolTipText = "Invalid save file type. You must save with either an XML or HWS extension so we know how to save the file.";
					return;
				}

				toolStripStatusLabel.Text = "Successfully saved data.";
				toolStripStatusLabel.ToolTipText = "Successfully saved data to: \"" + file + "\"";
			}
		}
		#endregion

		#region Util
		public string GetDefaultFileDialogPath()
		{
			string pathAttempt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "/Steam/steamapps/common/Hammerwatch/saves");
			if (Directory.Exists(pathAttempt)) return pathAttempt;
			pathAttempt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "/Steam/steamapps/common/Hammerwatch/saves");
			if (Directory.Exists(pathAttempt)) return pathAttempt;

			return "";
		}
		#endregion
	}
}
