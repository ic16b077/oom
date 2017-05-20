using System;

namespace Task4
{
	public class Inventar
	{
		/* Fields */
		private int inventarnummer;
		private DateTime ankaufdatum;
		private string modell;
		/* Constructors */
		public Inventar (int inventarnummer, DateTime ankaufdatum, string modell)
		{
			Inventarnummer = inventarnummer;
			Ankaufdatum = ankaufdatum;
			Modell = modell;
		}

		public int Inventarnummer
		{
			get
			{
				return inventarnummer;
			}
			set
			{
				if (value < 1) throw new ArgumentException("Negative Werte und 0 als Inventarnummer nicht erlaubt.");
				inventarnummer = value;
			}
		}
		public DateTime Ankaufdatum
		{
			get
			{
				return ankaufdatum;
			}
			set
			{
				ankaufdatum = value;
			}
		}
		public string Modell
		{
			get
			{
				return modell;
			}
			set
			{
				if ( string.IsNullOrWhiteSpace(value) ) throw new ArgumentException("Modell muss angegeben werden.");
				modell = value;
			}
		}
	}
}

