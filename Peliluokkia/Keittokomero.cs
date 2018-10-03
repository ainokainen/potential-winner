﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Keittokomero

    {
        public void Avaa()
        {
            Console.WriteLine("Hapuilet pimeässä tiskipöydän luo.\n");
            Jatka();
        }

        public void Jatka()
        {
            string vastaus;
            Console.WriteLine("Pöydältä erottuu esine, jonka tunnistat ensiapulaukuksi (A).\n" +
                "Kädelläsi tavoitat myös vesihanan (B). Voit myös siirtyä ruokailutilaan (C) tai voit palata takaisin keittiön (D) puolelle.\n" +
                "WC-tilan (E) ovi näyttäisi olevan hieman raollaan. \n");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            switch (vastaus)
            {
                case "A":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tämä on kaikin puolin hyvin standardinmukainen ensiapulaukku.\n" +
                        "Haluatko tehdä jotain laukulle?\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "B":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Helkkarin kiva, juoksevaa vettä ei tule.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Siirryt ruokailutilaan.\n");
                    Console.ResetColor();
                    Ruokailutila ruokailutila = new Ruokailutila();
                    ruokailutila.Avaa();
                    break;
                case "D":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kävelet keittiöön.\n");
                    Console.ResetColor();
                    Keittio keittio = new Keittio();
                    keittio.Avaa();
                    break;
                case "E":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Astut WC-tilaan.\n");
                    Console.ResetColor();
                    WC vessa = new WC();
                    vessa.Avaa();
                    break;
                case "KASSI":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Inventaario inventaario = new Inventaario();
                    Console.WriteLine(inventaario);
                    Console.ResetColor();
                    Jatka();
                    break;
                case "AVAA ENSIAPULAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "TUTKI ENSIAPULAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "AVAA ENSIAPU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                case "AVAA LAUKKU":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tunnustelet ensiapulaukun sisältöä. Tunnistat hämärässä burana-paketin ja huomaat myös jonkun kookkaamman esineen.\n");
                    Console.ResetColor();
                    Ensiapulaukku();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Epäkelpo valinta.\n");
                    Console.ResetColor();
                    Jatka();
                    break;
            }
        }

        public void Ensiapulaukku()
        {
            string komento = "";
            string esine = "taskulamppu";

            if (Inventaario.esineet.Contains("vesipullo"))
            {
                Console.WriteLine("Burana-paketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin tai jättää ensiapulaukun sikseen (C).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();

                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saan päänsäryn pois.");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Onneksi tuli kerättyä vesipullo talteen. Viimein saat päänsäryn pois.");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nice, taskulamppu. Tästä voisi olla vielä hyötyä!\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lasket ensiapulaukun takaisin pöydälle.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario3 = new Inventaario();
                        inventaario3.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Ensiapulaukku();
                        Console.ResetColor();
                        break;
                }

            }
            else
            {

                Console.WriteLine("Buranapaketissa (A) on onneksi vielä tabuja jäljellä. Voit myös tarkastella tuntematonta esinettä (B) tarkemmin tai jättää ensiapulaukun sikseen (C).\n");
                komento = Console.ReadLine();
                komento = komento.ToUpper();
                switch (komento)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nyt on burana, mutta jostain pitäisi saada vielä vettä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "OTA VESIPULLO":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "JUO VETTÄ":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hanasta ei tule mitään. Vettä pitäisi löytää jostain.");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nice, löysin taskulampun. Tästä voisi olla vielä hyötyä.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lasket ensiapulaukun takaisin pöydälle.\n");
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LISÄÄ TASKULAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario = new Inventaario();
                        inventaario.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "OTA LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario2 = new Inventaario();
                        inventaario2.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    case "LISÄÄ LAMPPU":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Taskulamppu lisätty Academy-kassiin.\n");
                        Inventaario inventaario3 = new Inventaario();
                        inventaario3.LisaaEsine(esine);
                        Console.ResetColor();
                        Jatka();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Ensiapulaukku();
                        break;
                }
            }
            
        }
    }
}
