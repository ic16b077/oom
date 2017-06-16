using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Drawing;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Console;

namespace Task4
{
    public static class SimulateProducer
    {
        public static void Run(Inventar []inventarliste)
        {
            var producer = new Subject<Inventar>();

            producer
                .Where(x => x.Inventarnummer > 2000)
                .Subscribe(x => Console.WriteLine($"Inventarnummer {x.Inventarnummer}, Modell: {x.Modell}"));

            producer
                .Where(x => x.Inventarnummer > 2000)
                .Select(x => x.Ankaufdatum)
                .Subscribe(x => Console.WriteLine($"Ankaufdatum: {x}\n"));

            producer
                .Skip(2)
                .Take(1)
                .Subscribe(x => Console.WriteLine($"Übersprungenes Inventar: {x}\n"));

            foreach (var inventar in inventarliste)
            {
                Console.WriteLine("Warte auf Daten..");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                producer.OnNext(inventar); // push value i to subscribers
            }
        }
    }
}
/*
Create a Subject<T> where T is one of your classes (e.g. Book) to simulate an external system pushing new T objects into your system.
Experiment with different Rx queries.
Also see http://rxwiki.wikidot.com/101samples.
*/