using System;
using System.Collections.Generic;

namespace Emulator
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string[] program = ReadProgram();

            
            Dictionary<string, ushort> registers = InitializeRegisters();
            Dictionary<string, bool> flags = InitializeFlags();

            
            ExecuteProgram(program, registers, flags);

            
            PrintRegisters(registers);
            PrintFlags(flags);
        }

        static string[] ReadProgram()
        {
           
            Console.WriteLine("Enter the first line of the 8086 assembly program: ");
            string line1 = Console.ReadLine();
            Console.WriteLine("Enter the second line of the 8086 assembly program: ");
            string line2 = Console.ReadLine();
            string[] program = new string[] { line1, line2 };
            return program;
        }

        static Dictionary<string, ushort> InitializeRegisters()
        {
            
            Dictionary<string, ushort> registers = new Dictionary<string, ushort>();
            registers["ax"] = 0;
            registers["bx"] = 0;
            registers["cx"] = 0;
            registers["dx"] = 0;
            registers["si"] = 0;
            registers["di"] = 0;
            registers["bp"] = 0;
            registers["sp"] = 0;
            return registers;
        }

        static Dictionary<string, bool> InitializeFlags()
        {
            
            Dictionary<string, bool> flags = new Dictionary<string, bool>();
            flags["cf"] = false;
            flags["pf"] = false;
            flags["af"] = false;
            flags["zf"] = false;
            flags["sf"] = false;
            flags["tf"] = false;
            flags["if"] = false;
            flags["df"] = false;
            flags["of"] = false;
            return flags;
        }

        static void ExecuteProgram(string[] program, Dictionary<string, ushort> registers, Dictionary<string, bool> flags)
        {
            
            
        }

        static void PrintRegisters(Dictionary<string, ushort> registers)
        {
            Console.WriteLine("Registers:");
            foreach (KeyValuePair<string, ushort> pair in registers)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static void PrintFlags(Dictionary<string, bool> flags)
        {
            Console.WriteLine("Flags:");
            foreach (KeyValuePair<string, bool> pair in flags)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}