using System;
using System.Collections.Generic;

namespace Task4
{
	public class Zigarettenautomat : Inventar, Automat
	{
		/* Fields */
		private List<Produkt> produkte = new List<Produkt> {};//Produkt[] produkte = {};
		private int fassungsvermoegen;
		private bool altersabfrage;

		/* Constructors */
		public Zigarettenautomat (int inventarnummer, DateTime ankaufdatum, string modell, int fassungsvermoegen, bool altersabfrage) 
			: base (inventarnummer, ankaufdatum, modell)
		{
			Fassungsvermoegen = fassungsvermoegen;
			Altersabfrage = altersabfrage;
		}

		/* Methods - Zustand */
		public bool IstLeer()
		{
			if (produkte.Count == 0) return true;
			return false;
		}
		/* Methods - Wartung */
		public int Vollmachen(List<Produkt> nachschub)
		{
			int benoetigt = fassungsvermoegen - produkte.Count;
			int nachgefuellt = 0;

			for (int i = benoetigt; i >= 1; i--) {
				if (nachschub.Count >= nachgefuellt + 1) {
					produkte.Add (nachschub [nachgefuellt]);
					nachgefuellt++;
				}
			}
			return benoetigt - nachgefuellt;
		}
		public List<Produkt> Leeren()
		{
			List<Produkt> produktliste = produkte;
			produkte = new List<Produkt> {};
			return produktliste;
		}
		/* Methods - Betrieb */
		public bool Bestellung(int Produktnummer, int Anzahl)
		{
			return true;
		}
		public bool Bezahlung(double Betrag)
		{
			return true;
		}
		public Produkt[] Produktausgabe()
		{
			return new Produkt[] {};
		}

		/* Getters and Setters */
		public bool Altersabfrage {
			get {
				return altersabfrage;
			}
			private set
			{
				if (value != true) throw new Exception("Zigarettenautomaten ohne Altersabfrage nicht erlaubt!");
				altersabfrage = value;
			}
		}
		public int Fassungsvermoegen {
			get {
				return fassungsvermoegen;
			}
			private set
			{
				fassungsvermoegen = value;
			}
		}
	}
}

