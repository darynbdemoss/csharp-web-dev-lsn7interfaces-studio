using System;
namespace SpinningDiscs
{
    // TODO: Implement your custom interface.
    public class CD : BasePlayer, IOpticalDisc
    {
        public string Audio { get; set; }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public CD(string laser, double storage, string audio) : base(laser, storage)
        {
            Audio = audio;
        }

        public void PlaySong()
        {
            Console.WriteLine($"You are now listening to {Audio}");
        }

        public void SpinDisc()
        {
            Console.WriteLine("500 RPMs");

        }

    }
}

