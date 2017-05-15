using System;

namespace Task2
{
	
	interface Fortbewegungsmittel
	{
		void SichFortbewegen(int treibstoff);

		string Beschreibung { get; }
	}

	class Flugzeug : Fortbewegungsmittel
	{
		private int sitzplaetze;
		private int fluegel;
		private string beschreibung;

		public Flugzeug(int newFluegel, int newSitzplaetze)
		{
			this.Sitzplaetze = newSitzplaetze;
			this.Fluegel = newFluegel;
		}

		public void SichFortbewegen(int treibstoff)
		{
			Console.WriteLine ("Das Flugzeug fliegt " + treibstoff * 1 + " Kilometer.");
		}

		public string Beschreibung
		{
			get
			{
				return beschreibung;
			}
			set
			{
				beschreibung = value;
			}
		}

		public int SitzplaetzeMinusTwo()
		{
			return sitzplaetze * 2;
		}

		public int Fluegel
		{
			get
			{
				return fluegel;
			}
			set
			{
				if (value < 2) throw new Exception("Mindestens zwei Flügel angeben.");
				fluegel = value;
			}
		}

		public int Sitzplaetze
		{
			get
			{
				return sitzplaetze;
			}
			set
			{
				if (value < 2) throw new Exception("Mindestens zwei Sitzplätze angeben.");
				sitzplaetze = value;
			}
		}
	}

	class Auto : Fortbewegungsmittel
	{
		private string beschreibung;

		public void SichFortbewegen(int treibstoff)
		{
			Console.WriteLine ("Das Auto fährt " + treibstoff * 100 + " Kilometer.");
		}

		public string Beschreibung
		{
			get
			{
				return beschreibung;
			}
			set
			{
				beschreibung = value;
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			var fortbewegungsmittel = new Fortbewegungsmittel[]
			{
				new Flugzeug(2, 134),
				new Flugzeug(4, 543),
				new Auto(),
				new Auto(),
			};

			foreach (var x in fortbewegungsmittel)
			{
				x.SichFortbewegen(2);
			}
		}
	}
}