using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundMakers = new List<ISound>();
            soundMakers.Add(new Firework());
            soundMakers.Add(new Parrot());
            soundMakers.Add(new Radio());
            soundMakers.Add(new Firework());
            soundMakers.Add(new Parrot());
            soundMakers.Add(new Firework());
            soundMakers.Add(new Radio());
            soundMakers.Add(new Parrot());
            soundMakers.Add(new Radio());

            foreach (var soundMaker in soundMakers)
            {
                soundMaker.PlaySound();
            }
        }
    }
}