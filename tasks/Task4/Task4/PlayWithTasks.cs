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
    public static class PlayWithTasks
    {
        /* CPU-bound */
        Task<integer> resultValue = Task.Run(() => {
            Task.Delay(5000).Wait();
            return 1;
        });
        resultValue.ContinueWith(x => ConsoleWriteLine("HTTP response is quicker than me! Value=" + x.Result));
        
        /* IO-bound */
        string url = "www.google.com";
        Task<string> html = new WebClient().DownloadStringAsync(url);
        html.ContinueWith(x => Console.WriteLine("HTTP response received: " + x.Result));
        Console.WriteLine("Program won't wait for HTTP response and stays responsive!");
        
        
    }
}
