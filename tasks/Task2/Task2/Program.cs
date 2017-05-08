using System;

namespace Task2
{

	class Flugzeug
	{
		private int m_sitzplaetze;
		private int m_fluegel;

		public Flugzeug(int newFluegel, int newSitzplaetze)
		{
			this.Sitzplaetze = newSitzplaetze;
			this.Fluegel = newFluegel;
		}

		public int SitzplaetzeMinusTwo()
		{
			return m_sitzplaetze * 2;
		}

		public int Fluegel
		{
			get
			{
				return m_fluegel;
			}
			set
			{
				if (value < 2) throw new Exception("Mindestens zwei Flügel angeben.");
				m_fluegel = value;
			}
		}

		public int Sitzplaetze
		{
			get
			{
				return m_sitzplaetze;
			}
			set
			{
				if (value < 2) throw new Exception("Mindestens zwei Sitzplätze angeben.");
				m_sitzplaetze = value;
			}
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Flugzeug a = new Flugzeug (2, 134);
			Console.WriteLine (a.SitzplaetzeMinusTwo());
		}
	}
}
