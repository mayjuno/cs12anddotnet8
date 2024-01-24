using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;
public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        Console.WriteLine("DvdPlayer is pausing.");
    }
    public void Play()
    {
        Console.WriteLine("DvdPlayer is playing.");
    }
}
