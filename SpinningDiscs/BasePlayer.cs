using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BasePlayer
    {

        public string Laser { get; set; }
        public double Storage { get; set; }

        public BasePlayer(string laser, double storage)
        {
            Laser = laser;
            Storage = storage;
        }

        public void Read()
        {
            Console.WriteLine($"The disc is being read at {Laser} speed and has {Storage} GB of storage");
        }


    }
}
