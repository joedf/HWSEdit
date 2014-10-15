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
		public static string RevisionDate = "14/10/2014";
		
		public SValue MAINBUFFER;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.dropdownDifficulty.SelectedIndex=1;
			buttonSaveAs.Enabled = false;
			tabGeneral.Enabled = false;
			tabModifiers.Enabled = false;
			tabPlayers.Enabled = false;
			tabhws2xml.Enabled = true;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show(AppTitle+"\nBy "+ AppAuthors+
							"\n\nReleased under the MIT License\n"+
							"Revision Date: "+RevisionDate,
							AppTitle,
							MessageBoxButtons.OK,
							MessageBoxIcon.Information);
		}
		
		void HelpTopicToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(AppURL);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult result = openHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				string fn = openHWSDialog.FileName;
				textBox1.Text = fn;
			}
		}
		
		void ButtonQuit(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button4Click(object sender, EventArgs e)
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
		
		void Button6Click(object sender, EventArgs e)
		{
			DialogResult result = openXMLDialog.ShowDialog();
			if (result == DialogResult.OK) {
				string fn = openXMLDialog.FileName;
				textBox2.Text = fn;
			}
		}
		
		void Button5Click(object sender, EventArgs e)
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
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult result = openHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				buttonSaveAs.Enabled = true;
				tabGeneral.Enabled = true;
				tabModifiers.Enabled = true;
				//tabPlayers.Enabled = true;
				
				string inFile = openHWSDialog.FileName;
				
				textBoxCurrentFile.Text = Path.GetFileName(inFile);
				
				//load file to mainbuffer
				BinaryReader BR = new BinaryReader(File.Open(inFile,FileMode.Open));
				MAINBUFFER = SValue.LoadStream(BR);
				
				//load values into form
				MAINBUFFERtoFormData();
				ValidifyModifiersCheckBoxes();
			}
		}
		
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
		
		void CheckboxModifiersChanged(object sender, EventArgs e)
		{
			ValidifyModifiersCheckBoxes();
		}
		
		void ButtonSaveAsClick(object sender, EventArgs e)
		{
			string inFileNoExt = Path.GetFileNameWithoutExtension(textBoxCurrentFile.Text);
			saveHWSDialog.FileName = inFileNoExt + ".hws";
			
			DialogResult result = saveHWSDialog.ShowDialog();
			if (result == DialogResult.OK) {
				
				string outFile = saveHWSDialog.FileName;
				
				//get data and update the MAINBUFFER
				ValidifyModifiersCheckBoxes();
				FormDatatoMAINBUFFER();
				
				BinaryWriter BW = new BinaryWriter(File.Open(outFile,FileMode.Create));
				SValue.SaveStream(MAINBUFFER,BW);
				BW.Close();
				
				MessageBox.Show("Successfully modified HWS file.\nSaved to:\n\""+outFile+"\"");
			}
		}
		
		void MAINBUFFERtoFormData() {
			//load values into form
			//+->general
			InputPlaytime.Value = MAINBUFFER.GetObject().Get("play-time").GetInteger();
			InputSpawnX.Value = (decimal)MAINBUFFER.GetObject().Get("spawn-pos").GetObject().Get("x").GetFloat();
			InputSpawnY.Value = (decimal)MAINBUFFER.GetObject().Get("spawn-pos").GetObject().Get("y").GetFloat();
			InputLevelID.Value = Int32.Parse(MAINBUFFER.GetObject().Get("level-id").GetString());
			dropdownDifficulty.SelectedIndex = MAINBUFFER.GetObject().Get("difficulty").GetInteger();
			checkboxNetworked.Checked = MAINBUFFER.GetObject().Get("networked").GetBoolean();
			//+->modifiers
			//  +->challenges
			checkBoxNoExtraLives.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("nolives").GetBoolean();
			checkBox1HP.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("1hp").GetBoolean();
			checkBoxSharedHPPool.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("sharehp").GetBoolean();
			checkBoxNoHPPickups.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("nohppup").GetBoolean();
			checkBoxNoManaRegen.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("nomanaregen").GetBoolean();
			checkBoxReverseHPRegen.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("revhpregen").GetBoolean();
			//  +->crutches
			checkBoxInfiniteLives.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("inflives").GetBoolean();
			checkBoxHPRegen.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("hpregen").GetBoolean();
			checkBoxDoubleDamage.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("doubledmg").GetBoolean();
			checkBoxDoubleLives.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("doublelife").GetBoolean();
			checkBox5XManaRegen.Checked = MAINBUFFER.GetObject().Get("modifiers").GetObject().Get("quickmana").GetBoolean();
		}
		
		void FormDatatoMAINBUFFER() {
			//load values into MAINBUFFER
			//+->general
			MAINBUFFER.GetObject().Set("play-time",new SValue((int)InputPlaytime.Value));
			SObject Obj_spawnpos = new SObject();
			Obj_spawnpos.Set("x",new SValue((float)InputSpawnX.Value));
			Obj_spawnpos.Set("y",new SValue((float)InputSpawnY.Value));
			MAINBUFFER.GetObject().Set("spawn-pos",new SValue(Obj_spawnpos));
			MAINBUFFER.GetObject().Set("level-id",new SValue(InputLevelID.Value.ToString()));
			MAINBUFFER.GetObject().Set("difficulty",new SValue((int)InputLevelID.Value));
			MAINBUFFER.GetObject().Set("networked",new SValue((bool)checkboxNetworked.Checked));
			//+->modifiers
			//  +->challenges
			SObject Obj_modifiers = new SObject();
			Obj_modifiers.Set("nolives",new SValue((bool)checkBoxNoExtraLives.Checked));
			Obj_modifiers.Set("1hp",new SValue((bool)checkBox1HP.Checked));
			Obj_modifiers.Set("sharehp",new SValue((bool)checkBoxSharedHPPool.Checked));
			Obj_modifiers.Set("nohppup",new SValue((bool)checkBoxNoHPPickups.Checked));
			Obj_modifiers.Set("nomanaregen",new SValue((bool)checkBoxNoManaRegen.Checked));
			Obj_modifiers.Set("revhpregen",new SValue((bool)checkBoxReverseHPRegen.Checked));
			//  +->crutches
			Obj_modifiers.Set("inflives",new SValue((bool)checkBoxInfiniteLives.Checked));
			Obj_modifiers.Set("hpregen",new SValue((bool)checkBoxHPRegen.Checked));
			Obj_modifiers.Set("doubledmg",new SValue((bool)checkBoxDoubleDamage.Checked));
			Obj_modifiers.Set("doublelife",new SValue((bool)checkBoxDoubleLives.Checked));
			Obj_modifiers.Set("quickmana",new SValue((bool)checkBox5XManaRegen.Checked));
			MAINBUFFER.GetObject().Set("modifiers",new SValue(Obj_modifiers));
		}
		
		void TabPageSelectorSelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabPageSelector.SelectedIndex == 3) {
				buttonSaveAs.Enabled = false;
			} else if (textBoxCurrentFile.Text.Length > 4) {
				buttonSaveAs.Enabled = true;
			}
		}
	}
}
