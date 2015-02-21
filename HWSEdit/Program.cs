/*
 * Created by SharpDevelop.
 * User: Joachim
 * Date: 2014-10-14
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace HWSEdit
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		public static string AppName = "HWSEdit";
		public static string AppTitle = AppName + " - Hammerwatch Save Editor";
		public static string AppURL = "http://hammerwatch.com/forum/index.php?topic=2197.0";
		public static string AppAuthors = "Joe DF & Drew Burden";
		public static string RevisionDate = "20/2/2015";

		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form MainInstance = new MainForm();
			MainInstance.Text = Program.AppTitle;
			Application.Run(MainInstance);
		}
		
	}
}
