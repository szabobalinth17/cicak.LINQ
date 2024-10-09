﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin
{
    enum Szine { Zold, Rozsaszin, Feher, Lila, Fekete }
    enum Neme { Fiu, Lany}
    class Cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }
        public Szine Szine  { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public Neme Neme { get; set; }
        public  int Suly { get; set; }
        public int Kor => DateTime.Now.Year - SzuletesiDatum.Year;
        public override string ToString()
        {
            return $"{ID,-5}{Neve,-15}{Szine,-10}{SzuletesiDatum.ToString("yyy.MM.dd"),-15}{Neme,-10}{Suly,-5}{Kor}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cica> cicak = new List<Cica>()
            {
                new Cica()
                {
                    ID=1,
                    Neme=Neme.Fiu,
                    Neve="Megatron",
                    Suly=10,
                    Szine=Szine.Fekete,
                    SzuletesiDatum=new DateTime(2018,08,13),
                },
                new Cica()
                {
                     ID=2,
                    Neme=Neme.Lany,
                    Neve="Lajos",
                    Suly=4,
                    Szine=Szine.Rozsaszin,
                    SzuletesiDatum=new DateTime(2022,12,20),

                },
                new Cica()
                {
                     ID=3,
                    Neme=Neme.Lany,
                    Neve="Tudja a gorcs",
                    Suly=20,
                    Szine=Szine.Lila,
                    SzuletesiDatum=new DateTime(2023,5,27),

                },
                 new Cica()
                {
                     ID=4,
                    Neme=Neme.Fiu,
                    Neve="Drogos geci",
                    Suly=20,
                    Szine=Szine.Feher,
                    SzuletesiDatum=new DateTime(2024,9
                    ,2),

                },
                  new Cica()
                {
                     ID=5,
                    Neme=Neme.Fiu,
                    Neve="Frontinos kocsog",
                    Suly=20,
                    Szine=Szine.Feher,
                    SzuletesiDatum=new DateTime(2024,9
                    ,2),

                },


            };
            //első cica
            Cica elsoCica = cicak.First();
            Console.WriteLine(elsoCica);

            Console.ReadKey();
            
            
        }
    }
}
