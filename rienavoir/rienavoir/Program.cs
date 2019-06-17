using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rienavoir
{
    class Program
    {
        static void Main(string[] args)
        {
            int noteRe = 587;
            int noteSol= 783;
            int noteDo = 523;
            int noteMi = 659;
            int noteFa = 698;
            int noteLa = 880;
            int noire = 400;
            

            Console.Beep(noteRe, noire);
            Console.Beep(noteSol, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteMi, noire);
            Console.Beep(noteMi, noire);
            Console.Beep(noteFa, noire);
            Console.Beep(noteMi, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteSol, noire);
            Console.Beep(noteSol, noire);
            Console.Beep(noteLa, noire);
            Console.Beep(noteSol, noire);
            Console.Beep(noteFa, noire);
            Console.Beep(noteMi, noire);

        }
    }
}

