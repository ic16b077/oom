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
				new Fahrscheinautomat(1234, new DateTime(2010, 12, 5), "OEBB Fast and the Furious-Ticket", 123),
				new Fahrscheinautomat(7234, new DateTime(2003, 2, 15), "DB Slow Motion Fahrkarte", 456),
			};

			/* Inventarliste in JSON serialisieren */
			string output = JsonConvert.SerializeObject (inventarliste);

			/* JSON in Datei schreiben */
			string filename = @"M:\Inventar.json";
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

            /* T6.1 */
            SimulateProducer.Run();
		}
	}
}
