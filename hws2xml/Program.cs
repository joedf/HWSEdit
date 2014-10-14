/*
 * Created with SharpDevelop.
 * User: Joe DF
 * Date: 2014-10-13
 */
using System;
using System.IO;

namespace hws2xml
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length < 2) {
				Console.WriteLine("hws2xml [infile] [outfile]");
				Console.WriteLine("if [infile] has .hws it will converted to .xml");
				Console.WriteLine("if [infile] has .xml it will converted to .hws");
			} else {
				string inFile = args[0];
				string outFile = args[1];
				
				if (File.Exists(inFile)) {
					string inType = Path.GetExtension(inFile).ToUpper();
					if (inType == ".XML") {
						TextReader TR = new StreamReader(inFile);
						SValue OBJ = SValue.FromXMLFile(TR);
						BinaryWriter BW = new BinaryWriter(File.Open(outFile,FileMode.Create));
						SValue.SaveStream(OBJ,BW);
						BW.Close();
						Console.WriteLine("Converted from XML to HWS.");
					} else { // .HWS
						BinaryReader BR = new BinaryReader(File.Open(inFile,FileMode.Open));
						SValue OBJ = SValue.LoadStream(BR);
						TextWriter TW = new StreamWriter(outFile);
						SValue.SaveXML(OBJ,TW);
						TW.Close();
						Console.WriteLine("Converted from HWS to XML.");
					}
				} else {
					Console.WriteLine("Error: Invalid input file.");
				}
				Console.WriteLine("Done.");
			}
		}
	}
}