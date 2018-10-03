﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    //Avaa-metodi pohjautuen muihin huoneisiin -ES

    public class Jobs
    {
        //Avaa-metodi pohjautuen muihin huoneisiin -ES Lisätty lamppu rajapinnan toteutus
        string vastaus;

        private bool lamppuPäällä = false;

        public bool LamppuPäällä
        {
            get
            {
                return lamppuPäällä;
            }
        }



        public void Avaa()
        {
            Console.WriteLine("Astut sisään Pixarin perustajan mukaan nimettyyn Jobs-huoneeseen.\nPimeässä näet flappitaulun, jossa on kirjoitusta, mutta et saa kirjoituksesta selvää pimeässä. Voit halutessasi palata takaisin käytävään (A).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            Love lamppu = new Love();

            switch (vastaus)
            {
                case "A":
                    Console.WriteLine("Siirryt takaisin käytävään.");
                    Kaytava kaytava = new Kaytava();
                    kaytava.Avaa();
                    break;
                case "LAMPPU PÄÄLLE":
                    lamppu.Päällä();
                    Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... Voit halutessasi palata takaisin käytävään (A)");
                    lamppu.PoisPäältä();
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    Avaa();
                    break;
                case "AVAA LAMPPU":
                    lamppu.Päällä();
                    Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... Voit halutessasi palata takaisin käytävään (A)");
                    lamppu.PoisPäältä();
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    Avaa();
                    break;

                case "LAITA LAMPPU PÄÄLLE":
                    lamppu.Päällä();
                    Console.WriteLine("Nyt näe, että fläppitaululle on piirretty  huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... Voit halutessasi palata takaisin käytävään (A)");
                    lamppu.PoisPäältä();
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    Avaa();
                    break;

                case "KYTKE LAMPPU PÄÄLLE":
                    lamppu.Päällä();
                    Console.WriteLine("Nyt huomaat, että joku tylsistynyt konsultti on piirtänyt siihen rivoja kuvija. Silmiisi sattuu... Voit halutessasi palata takaisin käytävään (A)");
                    lamppu.PoisPäältä();
                    vastaus = Console.ReadLine();
                    vastaus = vastaus.ToUpper();
                    Avaa();
                    break;

                default:
                    Console.WriteLine("En ymmärrä sinua :(");
                    Avaa();
                    break;
            }

        }


    

    public void ValoisaHuone()
    {

    }

    public void PoisPäältä()
    {
        lamppuPäällä = false;
        Console.WriteLine("Taskulamppu sammui");
    }

    public void Päällä()
    {
        lamppuPäällä = true;
        Console.WriteLine("Taskulamppu on päällä");
    }

}
}