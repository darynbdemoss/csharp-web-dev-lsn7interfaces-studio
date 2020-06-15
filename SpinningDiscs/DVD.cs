using System;
namespace SpinningDiscs
{
    // TODO: Implement your custom interface.
    public class DVD : BasePlayer, IOpticalDisc
    {
        public string Video { get; set; }
        

        public DVD(string laser, double storage, string video) : base(laser, storage)
        {
            Video = video;
        }

       

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public void PlayMovie()
        {
            Console.WriteLine($"You are now watching {Video}");
        }

        public void SpinDisc()
        {
            Console.WriteLine("500 RPMs");

        }
    }
}
