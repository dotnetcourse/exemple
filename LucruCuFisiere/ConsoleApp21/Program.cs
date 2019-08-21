using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{
			//FileStream myFile = File.Open("c:\\temp1\\testfisier.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

			//StreamWriter myWriter = new StreamWriter(myFile);
			//myWriter.Write("Maria are doua mer.");
			//myWriter.WriteLine("Vlad are trei pere.");
			//myWriter.Flush();

			//string textDinFisier = File.ReadAllText("c:\\temp1\\testfisier.txt");
			//Console.WriteLine(textDinFisier);

			//FileStream myFile = File.Open("c:\\temp1\\testfisier.txt", FileMode.Open, FileAccess.ReadWrite);
			//StreamReader myReader = new StreamReader(myFile);

			////while (!myReader.EndOfStream)
			////{
			////	string linie = myReader.ReadLine();

			////	Console.WriteLine(linie);
			////}

			//string totTextul = myReader.ReadToEnd();

			//myReader.Close();
			//myFile.Close();

			//foreach (string folder in Directory.EnumerateDirectories("c:\\users\\"))
			//	{
			//	Console.WriteLine(folder);
			//}

			//string basePath = "c:\\temp1";
			//string userPath = "rpascal";
			//string file = "somefile.txt";

			//string finalPath = Path.Combine(Path.Combine(basePath, userPath), file);

			//Carte carte = new Carte
			//{
			//	Abstract = "detalii despre carte",
			//	DataPublicarii = DateTime.Now,
			//	Id = 1,
			//	NumeAutor = "Jack London",
			//	NumeleCartii = "White Fang"
			//};



			//string serializedObject = JsonConvert.SerializeObject(carte);
			//File.WriteAllText("c:\\temp1\\carte.json", serializedObject);
			//Console.WriteLine(serializedObject);

			//string serializedObject = File.ReadAllText("c:\\temp1\\carte.json");
			//Carte carte = JsonConvert.DeserializeObject<Carte>(serializedObject);

			XmlSerializer serializer = new XmlSerializer(typeof(Carte));

			FileStream myFile = File.Open("c:\\temp1\\xmlfile.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			//serializer.Serialize(myFile, carte);
			//myFile.Flush();
			//myFile.Close();

			Carte carte = (Carte)serializer.Deserialize(myFile);
			myFile.Close();

			Console.ReadKey();

		}
	}
}
