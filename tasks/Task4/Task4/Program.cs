using System;
using Newtonsoft.Json;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Inventarliste erzeugen */
			var inventarliste = new Inventar[] {
				new Zigarettenautomat(3153, new DateTime(2014, 5, 30), "Tschick-V-15", 412, true),
				new Zigarettenautomat (4965, new DateTime (2008, 10, 3), "Smoke Now Z-31", 301, true),
			};

			/* Inventarliste in JSON serialisieren */
			string output = JsonConvert.SerializeObject (inventarliste);

			/* JSON in Datei schreiben */
			string filename = @"/home/michael/FH Technikum/OOM/Mayerhofer/Inventar.json";
			if (!string.IsNullOrWhiteSpace (output)) {
				File.Exists (filename);
				File.WriteAllText(filename, output, Encoding.UTF8);
			}

			/* Datei lesen */
			string jsonstring = File.ReadAllText(filename);

			/* Inventarliste deserialisieren */
			var inventarlisteAusDatei = JsonConvert.DeserializeObject<List<Inventar>>(jsonstring);

			/* Auf Console schreiben */
			Console.WriteLine(JsonConvert.SerializeObject(inventarlisteAusDatei, Formatting.Indented));
		}
	}
}
