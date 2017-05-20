using System;
using NUnit.Framework;
using System.Collections.Generic;
using static System.Console;

namespace Task4
{
	[TestFixture]
	public class ZigarettenautomatTests
	{
		[Test]
		public void CanCreateZigarettenautomat()
		{
			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", 412, true);

			Assert.IsTrue( zigarettenautomat.Inventarnummer == 3153 );
			Assert.IsTrue( zigarettenautomat.Ankaufdatum == new DateTime (2014, 5, 30) );
			Assert.IsTrue( zigarettenautomat.Modell == "Tschick-V-15" );
			Assert.IsTrue( zigarettenautomat.Fassungsvermoegen == 412 );
			Assert.IsTrue( zigarettenautomat.Altersabfrage == true );
		}

		[Test]
		public void CannotCreateZigarettenautomatWithNegativeOrZeroInventarnummer()
		{
			Assert.Catch(() =>
				{
					var zigarettenautomat = new Zigarettenautomat (-3153, new DateTime (2014, 5, 30), "Tschick-V-15", 412, true);
				});
			Assert.Catch(() =>
				{
					var zigarettenautomat = new Zigarettenautomat (0, new DateTime (2014, 5, 30), "Tschick-V-15", 412, true);
				});
		}

		[Test]
		public void CannotCreateZigarettenautomatWithNullOrEmptyModell()
		{
			Assert.Catch(() =>
				{
					var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "", 412, true);
				});
			Assert.Catch(() =>
				{
					var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), null, 412, true);
				});
		}

		[Test]
		public void ZigarettenautomatIstLeer ()
		{
			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", 412, true);
			Assert.IsTrue (zigarettenautomat.IstLeer() == true);
		}

		[Test]
		public void ZigarettenautomatNachfuellen ()
		{
			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", 412, true);
			zigarettenautomat.Vollmachen (new List<Produkt> { 
				new Produkt(), 
				new Produkt(), 
			} );
			Assert.IsTrue (zigarettenautomat.IstLeer() == false);
		}

		[Test]
		public void ZigarettenautomatNachfuellenReturnValue ()
		{
			int fassungsvermoegen = 3;
			int nachfuellmenge = 2;

			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", fassungsvermoegen, true);

			List<Produkt> produkte = new List<Produkt> {};
			for (int i = nachfuellmenge; i >= 1; i--) {
				produkte.Add ( new Produkt() );
			}
			int nochBenoetigteMenge = zigarettenautomat.Vollmachen (produkte);
			Assert.IsTrue ( nochBenoetigteMenge == fassungsvermoegen - nachfuellmenge );
		}

		[Test]
		public void ZigarettenautomatLeeren ()
		{
			int fassungsvermoegen = 3;
			int nachfuellmenge = 2;

			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", fassungsvermoegen, true);

			List<Produkt> produkte = new List<Produkt> {};
			for (int i = nachfuellmenge; i >= 1; i--) {
				produkte.Add ( new Produkt() );
			}
			zigarettenautomat.Vollmachen (produkte);

			zigarettenautomat.Leeren ();

			Assert.IsTrue ( zigarettenautomat.IstLeer() == true );
		}

		[Test]
		public void ZigarettenautomatLeerenReturnValue ()
		{
			int fassungsvermoegen = 3;
			int nachfuellmenge = 2;

			var zigarettenautomat = new Zigarettenautomat (3153, new DateTime (2014, 5, 30), "Tschick-V-15", fassungsvermoegen, true);

			List<Produkt> produkte = new List<Produkt> {};
			for (int i = nachfuellmenge; i >= 1; i--) {
				produkte.Add ( new Produkt() );
			}
			zigarettenautomat.Vollmachen (produkte);

			List<Produkt> entnommeneProdukte = zigarettenautomat.Leeren ();

			Assert.IsTrue ( entnommeneProdukte.Count == 2 );
		}
	}
}