using System;

namespace Task4
{
	public class Fahrscheinautomat
	{
		/* Fields */
		/* Constructors */
		/* Methods - Zustand */
		public bool IstLeer()
		{
			return true;
		}
		/* Methods - Wartung */
		public int Vollmachen(Produkt[] produkte)
		{
			return 1;
		}
		public Produkt[] Leeren()
		{
			return new Produkt[] {};
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
	}
}

