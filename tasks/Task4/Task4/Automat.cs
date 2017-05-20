using System;
using System.Collections.Generic;

namespace Task4
{
	public interface Automat
	{
		/* Zustand */
		bool IstLeer();
		/* Wartung */
		int Vollmachen(List<Produkt> produkte);
		List<Produkt> Leeren();
		/* Betrieb */
		bool Bestellung(int Produktnummer, int Anzahl);
		bool Bezahlung(double Betrag);
		Produkt[] Produktausgabe();
	}
}