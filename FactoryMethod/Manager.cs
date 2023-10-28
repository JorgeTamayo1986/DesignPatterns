using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class Manager
    {
        public const int Familiar = 1;
        public const int Violencia = 2;
        public static Game GetGame(int classification)
        {
            switch (classification)
            {
                case Familiar:  return new MarioKart();
                case Violencia: return new MortalKombat();
                default: return null;

            }
        }
    }
}
