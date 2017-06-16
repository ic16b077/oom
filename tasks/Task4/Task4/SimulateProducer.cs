using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;

namespace Task4
{
    public static class SimulateProducer
    {
        public static void Run()
        {
            var source = new Subject<Zigarettenautomat>();
            Console.WriteLine("bla");
        }
    }
}
/*
Create a Subject<T> where T is one of your classes (e.g. Book) to simulate an external system pushing new T objects into your system.
Experiment with different Rx queries.
Also see http://rxwiki.wikidot.com/101samples.
*/