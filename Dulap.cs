using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_Laborator6_
{
    class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }
        public int GetCalculVolum()
        {
            int volum = lungime * latime * inaltime;
            return volum;
        }
        public void TiparesteVolum()
        {
            Console.WriteLine("Dulapul are volumul " + GetCalculVolum());
        }
    }
}
