using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4

{
    class Program
    {
        static void Main(string[] args)
        {
            new Oracle().Run();
           
        }
    }

    class Oracle
    {
        String username = "";

        public void Run()
        {
            Console.WriteLine("I will tell you of the future!");
            Console.WriteLine("Tell me your name!");
            username = Console.ReadLine();
            Console.WriteLine("{0} ... You have quite unusual name huh. ", username);
            Console.WriteLine("Nonetheless, I will see what the Universe has given me.");

            Console.WriteLine("Well, {0}, Your Numerology number is {1}", username, this.RunTheNumerologyCalculation(username));
        }
        public int RunTheNumerologyCalculation(String name)
        {   
            int temp;
            int aggregated = 0;
            foreach (var letter in name)
            {
                temp = this.ReturnCyclicNumberPosition(Convert.ToString(letter).ToUpper());
                aggregated += temp;
            }
            Console.WriteLine("aggregated value is {0} ", aggregated);
            

            string StringValueOfNumber = Convert.ToString(aggregated);
           
            return AddUpEachNumberInAggregated(StringValueOfNumber);
        }

        public int ReturnLetterPositionInAlphabet(string Letter)
        {
            Dictionary<string, int> Gematria = new Dictionary<string, int>()
            {
            {"A",1},
            {"B",2},
            {"C",3},
            {"D",4},
            {"E",5},
            {"F",6},
            {"G",7},
            {"H",8},
            {"I",9},
            {"J",1},
            {"K",2},
            {"L",3},
            {"M",4},
            {"N",5},
            {"O",6},
            {"P",7},
            {"Q",8},
            {"R",9},
            {"S",1},
            {"T",2},
            {"U",3},
            {"V",4},
            {"W",5},
            {"X",6},
            {"Y",7},
            {"Z",8},
           };
            return Gematria[Letter];
        }

        public int ReturnCyclicNumberPosition(string InputLetter)
        {
            switch (InputLetter)
            {
                case "A":
                    return 1;
                case "J":
                    return 1;
                case "S":
                    return 1;

                case "B":
                    return 2;
                case "K":
                    return 2;
                case "T":
                    return 2;

                case "C":
                    return 3;
                case "L":
                    return 3;
                case "U":
                    return 3;

                case "D":
                    return 4;
                case "M":
                    return 4;
                case "V":
                    return 4;

                case "E":
                    return 5;
                case "N":
                    return 5;
                case "W":
                    return 5;

                case "F":
                    return 6;
                case "O":
                    return 6;
                case "X":
                    return 6;

                case "G":
                    return 7;
                case "P":
                    return 7;
                case "Y":
                    return 7;

                case "H":
                    return 8;
                case "Q":
                    return 8;
                case "Z":
                    return 8;

                case "I":
                    return 9;

                case "9":
                    return 9;

                default: return 0;
            }
        }

        private int AddUpEachNumberInAggregated(string StringValueOfNumber)
        {
            int temp, total = 0;
            
            foreach (char a in StringValueOfNumber)
            {
                temp = Convert.ToInt32(Convert.ToString(a));
                total += temp;
            }
            return total;
        }

    }

    public class PlayGround
    {
        int temp;
        public void Run()
        {
            string a = "1";
            temp = Convert.ToInt32(a);
            Console.WriteLine(temp);
            
        }
    }
}