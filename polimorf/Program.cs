using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    //polimorfizam

    class Osoba {                           //bazna klasa
        public string ime { get; set; }
        public string prezime { get; set; }

        public override string ToString()
        {
           // return this.ime + " " + this.prezime;
            return base.ToString();
        }
    }

    class Ucenik : Osoba {
        public int razred { get; set; }
   
        public override string ToString() {
            return this.ime + " " + this.prezime + " " + this.razred;
            
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {


            Osoba o = new Osoba();
            o.ime = "Ivana";
            o.prezime = "Brlić Mažuranić";

            Ucenik u = new Ucenik();
            u.ime = "Antun Gustav";
            u.prezime = "Matoš";
            u.razred = 3;

            Console.WriteLine("Osoba: {0}", o.ToString());
            Console.WriteLine("Učenik: {0}", u.ToString());


          

            Console.ReadKey();

        }
    }
}
