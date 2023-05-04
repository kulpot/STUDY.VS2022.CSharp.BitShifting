using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShifting
{
    class Program
    {
        static void Main(string[] args)
        {
            int bits = 1063; //hex 0x427, bin 0100 0010 0111
            String input = "";
            int position = 0;
            int bitvalue = 0;
            do
            {
                Console.WriteLine("*********** Current Bits: " + bits + " - in binary form: " + Convert.ToString(bits, 2));
                Console.WriteLine("Bit position to extract: ");
                input = Console.ReadLine();
                if (!input.Equals(""))
                {
                    position = int.Parse(input);
                    int extractedBit = bits;
                    extractedBit = extractedBit & (1 << position); // extracted bit & 1000
                    extractedBit = extractedBit >> position;
                    Console.WriteLine("Bit at position: " + position + " is " + extractedBit);

                }

                Console.WriteLine("Bit value to write:");
                input = Console.ReadLine();
                if (!input.Equals(""))
                {
                    bitvalue = int.Parse(input);
                }
                Console.WriteLine("Position to write to:");
                input = Console.ReadLine();
                if (!input.Equals(""))
                {
                    position = int.Parse(input);
                }
                int reg = bits;
                reg = reg & ~(1 << position);
                bits = (reg | (bitvalue << position));

                Console.WriteLine("Updated Bits is: " + Convert.ToString(bits, 2));
            }
            while (true);
        }
    }
    //output
//*********** Current Bits: 1063 - in binary form: 10000100111
//Bit position to extract:
//5
//Bit at position: 5 is 1
//Bit value to write:
//0
//Position to write to:
//5
//Updated Bits is: 10000000111
//*********** Current Bits: 1031 - in binary form: 10000000111
//Bit position to extract:

//Bit value to write:
//0
//Position to write to:
//5
//Updated Bits is: 10000000111
//*********** Current Bits: 1031 - in binary form: 10000000111
//Bit position to extract:
//5
//Bit at position: 5 is 0
//Bit value to write:
//1
//Position to write to:
//5
//Updated Bits is: 10000100111
//*********** Current Bits: 1063 - in binary form: 10000100111
//Bit position to extract:
//5
//Bit at position: 5 is 1
//Bit value to write:
//1
//Position to write to:
//7
//Updated Bits is: 10010100111
//*********** Current Bits: 1191 - in binary form: 10010100111
//Bit position to extract:
//7
//Bit at position: 7 is 1
//Bit value to write:

}
