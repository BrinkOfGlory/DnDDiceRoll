using System;
using System.Collections.Generic;

namespace Utilities
{
      public class DiceBag {
        public enum Dice : uint {
            D2 = 2 ,
            D4 = 4 ,
            D6 = 6 ,
            D8 = 8 ,
            D10 = 10 ,
            D12 = 12 ,
            D20 = 20 ,
        };

        private Random _rng;

        public DiceBag() {
            _rng = new Random();
        }

        private int InternalRoll( uint dice ) {
            return 1 + _rng.Next( ( int )dice );
        }

        public int Roll( Dice d ) {
            return InternalRoll( ( uint )d );
        }

        public int RollWithModifier( Dice dice , uint modifier ) {
            return InternalRoll( ( uint )dice ) + ( int )modifier;
        }

        public List<int> RollQuantity( Dice d , uint times ) {
            List<int> rolls = new List<int>();
            for( int i = 0 ; i < times ; i++ ) {
                rolls.Add( InternalRoll( ( uint )d ) );
            }
            return rolls;
        }
    }
  class Program
  {
    static void Main()
    {
      DiceBag dice = new DiceBag();
      Console.Write("Dice >");
      diceToRoll = 
    }
  }
}