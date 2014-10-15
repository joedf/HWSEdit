using System.Collections;
using System.Collections.Generic;
// using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using OpenTK;

// Code from Myrad / hammerwatch
// See http://hammerwatch.com/forum/index.php?topic=2197.msg5313#msg5313

namespace hwsFormat
{
	public enum SValueType
	{
		Array,
		Object,
		Boolean,
		Double,
		Float,
		Integer,
		String,
		IntegerArray,
		Vector2,
		Null
	}
 
	public class SValue
	{
		public SValueType Type;
		private object value;

		public SValue()
		{
			Type = SValueType.Null;
			value = null;
		}

		public SValue(SValue[] v)
		{
			Type = SValueType.Array;
			value = v;
		}

		public SValue(SObject v)
		{
			Type = SValueType.Object;
			value = v;
		}

		public SValue(bool v)
		{
			Type = SValueType.Boolean;
			value = v;
		}

		public SValue(double v)
		{
			Type = SValueType.Double;
			value = v;
		}

		public SValue(float v)
		{
			Type = SValueType.Float;
			value = v;
		}

		public SValue(int v)
		{
			Type = SValueType.Integer;
			value = v;
		}

		public SValue(string v)
		{
			Type = SValueType.String;
			value = v;
		}

		public SValue(int[] v)
		{
			Type = SValueType.IntegerArray;
			value = v;
		}

		public SValue(Vector2 v)
		{
			Type = SValueType.Vector2;
			value = v;
		}

		public SValue(float x, float y)
		{
			Type = SValueType.Vector2;
			value = new Vector2(x, y);
		}

		public SValue(object v, SValueType type)
		{
			Type = type;
			value = v;
		}

		public SValue[] GetArray() { return (SValue[])value; }
		public SObject GetObject() { return (SObject)value; }
		public bool GetBoolean() { return (bool)value; }
		public double GetDouble() { return (double)value; }
		public float GetFloat() { return (float)value; }
		public int GetInteger() { return (int)value; }
		public string GetString() { return (string)value; }
		public int[] GetIntegerArray() { return (int[])value; }
		public Vector2 GetVector2() { return (Vector2)value; }

		public object GetRawValue() { return value; }

		public static implicit operator SValue(SValue[] val) { return new SValue(val); }
		public static implicit operator SValue(SObject val) { return new SValue(val); }
		public static implicit operator SValue(bool val) { return new SValue(val); }
		public static implicit operator SValue(double val) { return new SValue(val); }
		public static implicit operator SValue(float val) { return new SValue(val); }
		public static implicit operator SValue(int val) { return new SValue(val); }
		public static implicit operator SValue(string val) { return new SValue(val); }
		public static implicit operator SValue(int[] val) { return new SValue(val); }
		public static implicit operator SValue(Vector2 val) { return new SValue(val); }

		public static SValue FromArray(SValue[] val) { return new SValue(val, SValueType.Array); }
		public static SValue FromObject(SObject val) { return new SValue(val, SValueType.Object); }
		public static SValue FromBoolean(bool val) { return new SValue(val, SValueType.Boolean); }
		public static SValue FromDouble(double val) { return new SValue(val, SValueType.Double); }
		public static SValue FromFloat(float val) { return new SValue(val, SValueType.Float); }
		public static SValue FromInteger(int val) { return new SValue(val, SValueType.Integer); }
		public static SValue FromString(string val) { return new SValue(val, SValueType.String); }
		public static SValue FromIntegerArray(int[] val) { return new SValue(val, SValueType.IntegerArray); }
		public static SValue FromVector2(Vector2 val) { return new SValue(val, SValueType.Vector2); }

		public bool IsNull()
		{
			return Type == SValueType.Null;
		}

		public static SValue FromXMLFile(TextReader xml)
		{
			var doc = XDocument.Load(xml);
			return ParseXMLNode(doc.Root);
		}

		public static SValue FromXMLString(string xml)
		{
			var doc = XDocument.Parse(xml);
			return ParseXMLNode(doc.Root);
		}

		public static SValue FromXMLDocument(XElement xml)
		{
			return ParseXMLNode(xml);
		}

		private static SValue ParseXMLNode(XElement node)
		{
			switch (node.Name.LocalName)
			{
				case "array":
					var arr = new List<SValue>();
					foreach (var child in node.Elements())
						arr.Add(ParseXMLNode(child));

					return FromArray(arr.ToArray());

				case "dictionary":
					var dict = new SObject();
					foreach (var child in node.Elements())
					{
						var name = child.Attribute("name").Value;
						if (child.Name == "entry")
							dict.Set(name, ParseXMLNode(child.Elements().First()));
						else
							dict.Set(name, ParseXMLNode(child));
					}
					return FromObject(dict);

				case "bool":
					return FromBoolean(bool.Parse(node.Value));
				case "double":
					return FromDouble(double.Parse(node.Value, CultureInfo.InvariantCulture));
				case "float":
					return FromFloat(float.Parse(node.Value, CultureInfo.InvariantCulture));
				case "int":
					return FromInteger(int.Parse(node.Value, CultureInfo.InvariantCulture));
				case "string":
					return FromString(node.Value);
				case "vec2":
					{
						var sarr = node.Value.Split(' ');
						return FromVector2(new Vector2(float.Parse(sarr[0], CultureInfo.InvariantCulture), float.Parse(sarr[1], CultureInfo.InvariantCulture)));
					}

				case "int-arr":
					{
						var sarr = node.Value.Split(' ');
						var iarr = new int[sarr.Length];

						for (var j = 0; j < sarr.Length; j++)
							iarr[j] = int.Parse(sarr[j], CultureInfo.InvariantCulture);

						return FromIntegerArray(iarr);
					}
			}

			return new SValue(null, SValueType.Null);
		}

		public static void SaveXML(SValue val, TextWriter tw, string indent = "", string name = null, bool compact = false)
		{
			if (!compact)
				tw.Write(indent);

			switch (val.Type)
			{
				case SValueType.Array:
					{
						var arr = val.GetArray();
						var childCompact = compact;
						if (arr.Length < 10 && !childCompact)
						{
							childCompact = true;
							foreach (var arrEntry in arr)
								if (arrEntry.Type == SValueType.Object || arrEntry.Type == SValueType.IntegerArray || arrEntry.Type == SValueType.Array)
								{
									childCompact = false;
									break;
								}
						}

						tw.Write(name == null ? "<array>" : "<array name=\"" + name + "\">");

						if (!childCompact)
							tw.WriteLine();

						
						foreach (var arrEntry in arr)
							SaveXML(arrEntry, tw, indent + "\t", null, childCompact);

						if (!childCompact)
							tw.Write(indent);

						tw.Write("</array>");
					}
					break;

				case SValueType.Object:
					{
						tw.WriteLine(name == null ? "<dictionary>" : "<dictionary name=\"" + name + "\">");

						var dict = val.GetObject();
						foreach (var dictEntry in dict)
							SaveXML(dictEntry.Value, tw, indent + "\t", dictEntry.Key, compact);

						if (!compact)
							tw.Write(indent);

						tw.Write("</dictionary>");
					}
					break;

				case SValueType.Boolean:
					tw.Write(name == null ? "<bool>" : "<bool name=\"" + name + "\">");
					tw.Write(val.GetBoolean() + "</bool>");
					break;
				case SValueType.Double:
					tw.Write(name == null ? "<double>" : "<double name=\"" + name + "\">");
					tw.Write(val.GetDouble().ToString(CultureInfo.InvariantCulture) + "</double>");
					break;
				case SValueType.Float:
					tw.Write(name == null ? "<float>" : "<float name=\"" + name + "\">");
					tw.Write(val.GetFloat().ToString(CultureInfo.InvariantCulture) + "</float>");
					break;
				case SValueType.Integer:
					tw.Write(name == null ? "<int>" : "<int name=\"" + name + "\">");
					tw.Write(val.GetInteger() + "</int>");
					break;
				case SValueType.String:
					tw.Write(name == null ? "<string>" : "<string name=\"" + name + "\">");
					tw.Write(val.GetString() + "</string>");
					break;

				case SValueType.Vector2:
					tw.Write(name == null ? "<vec2>" : "<vec2 name=\"" + name + "\">");
					var v2 = val.GetVector2();
					tw.Write(v2.X.ToString(CultureInfo.InvariantCulture));
					tw.Write(" ");
					tw.Write(v2.Y.ToString(CultureInfo.InvariantCulture));
					tw.Write("</vec2>");
					break;

				case SValueType.IntegerArray:
					tw.Write(name == null ? "<int-arr>" : "<int-arr name=\"" + name + "\">");

					var v = val.GetIntegerArray();
					for (var i = 0; i < v.Length; i++)
					{
						tw.Write(v[i]);
						if (i != v.Length - 1)
							tw.Write(' ');
					}
					tw.Write("</int-arr>");
					break;

				case SValueType.Null:
					tw.Write(name == null ? "<null/>" : "<null name=\"" + name + "\"/>");
					break;
			}

			if (!compact)
				tw.WriteLine();
		}

		public static SValue FindDictionaryEntry(BinaryReader sr, string name)
		{
			var type = sr.ReadByte();
			switch (type)
			{
				case 1:
					{
						var len = sr.ReadInt32();
						for (var j = 0; j < len; j++)
						{
							var ret = FindDictionaryEntry(sr, name);
							if (ret != null)
								return ret;
						}

						return null;
					}
				case 2:
					{
						var len = sr.ReadInt32();
						for (var j = 0; j < len; j++)
						{
							var nm = sr.ReadString();
							if (nm == name)
								return LoadStream(sr);

							var ret = FindDictionaryEntry(sr, name);
							if (ret != null)
								return ret;
						}

						return null;
					}

				case 3:
					sr.BaseStream.Seek(1, SeekOrigin.Current);
					return null;
				case 4:
					sr.BaseStream.Seek(8, SeekOrigin.Current);
					return null;
				case 5:
					sr.BaseStream.Seek(4, SeekOrigin.Current);
					return null;
				case 6:
					sr.BaseStream.Seek(4, SeekOrigin.Current);
					return null;
				case 7:
					sr.ReadString();
					return null;

				case 8:
					{
						var len = sr.ReadInt32();
						sr.BaseStream.Seek(4 * len, SeekOrigin.Current);
						return null;
					}

				case 9:
					sr.BaseStream.Seek(4 * 2, SeekOrigin.Current);
					return null;
			}

			return null;
		}

		public static SValue LoadStream(BinaryReader sr)
		{
			var type = sr.ReadByte();
			switch (type)
			{
				case 1:
					{
						var len = sr.ReadInt32();

						var arr = new SValue[len];
						for (var j = 0; j < arr.Length; j++)
							arr[j] = LoadStream(sr);

						return FromArray(arr.ToArray());
					}
				case 2:
					{
						var len = sr.ReadInt32();

						var dict = new SObject();
						for (var j = 0; j < len; j++)
						{
							var name = sr.ReadString();
							dict.Set(name, LoadStream(sr));
						}
						return FromObject(dict);
					}

				case 3:
					return FromBoolean(sr.ReadBoolean());
				case 4:
					return FromDouble(sr.ReadDouble());
				case 5:
					return FromFloat(sr.ReadSingle());
				case 6:
					return FromInteger(sr.ReadInt32());
				case 7:
					return FromString(sr.ReadString());

				case 8:
					{
						var len = sr.ReadInt32();
						
						var iarr = new int[len];
						for (var j = 0; j < iarr.Length; j++)
							iarr[j] = sr.ReadInt32();

						return FromIntegerArray(iarr);
					}

				case 9:
					return FromVector2(new Vector2(sr.ReadSingle(), sr.ReadSingle()));
			}

			return new SValue(null, SValueType.Null);
		}

		public static void SaveStream(SValue val, BinaryWriter sw)
		{
			switch (val.Type)
			{
				case SValueType.Array:
					{
						sw.Write((byte)1);

						var arr = val.GetArray();
						sw.Write(arr.Length);

						foreach (var arrEntry in arr)
							SaveStream(arrEntry, sw);
					}
					break;

				case SValueType.Object:
					{
						sw.Write((byte)2);

						var dict = val.GetObject();
						sw.Write(dict.Size);

						foreach (var dictEntry in dict)
						{
							sw.Write(dictEntry.Key);
							SaveStream(dictEntry.Value, sw);
						}
					}
					break;

				case SValueType.Boolean:
					sw.Write((byte)3);
					sw.Write(val.GetBoolean());
					break;
				case SValueType.Double:
					sw.Write((byte)4);
					sw.Write(val.GetDouble());
					break;
				case SValueType.Float:
					sw.Write((byte)5);
					sw.Write(val.GetFloat());
					break;
				case SValueType.Integer:
					sw.Write((byte)6);
					sw.Write(val.GetInteger());
					break;
				case SValueType.String:
					sw.Write((byte)7);
					sw.Write(val.GetString() ?? "");
					break;

				case SValueType.IntegerArray:
					sw.Write((byte)8);

					var iArr = val.GetIntegerArray();
					sw.Write(iArr.Length);

					for (var i = 0; i < iArr.Length; i++)
						sw.Write(iArr[i]);

					break;

				case SValueType.Vector2:
					sw.Write((byte)9);
					var v2 = val.GetVector2();
					sw.Write(v2.X);
					sw.Write(v2.Y);
					break;

				case SValueType.Null:
					sw.Write((byte)0);
					break;
			}
		}
	}

	public class SObject : IEnumerable<KeyValuePair<string, SValue>>
	{
		Dictionary<string, SValue> values;

		public SObject()
		{
			values = new Dictionary<string, SValue>();
		}

		public SValue this[string index]
		{
			get
			{
				SValue val;
				if (values.TryGetValue(index, out val))
					return val;

				return new SValue();
			}
			set
			{
				values[index] = value;
			}
		}

		public SValue Get(string index)
		{
			SValue val;
			if (values.TryGetValue(index, out val))
				return val;

			return new SValue(null, SValueType.Null);
		}

		public void Set(string index, SValue value)
		{
			values[index] = value;
		}

		public int Size { get { return values.Count; } }

		public IEnumerator<KeyValuePair<string, SValue>> GetEnumerator()
		{
			return values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
