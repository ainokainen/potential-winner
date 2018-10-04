﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliluokkia
{
    public class Hissikaytava
    {
        string vastaus;
        public void Avaa()
        {
            Console.WriteLine("Hissikäytävällä sijaitsevien kahden hissin ovet (A) seisovat varsin järkähtämättömän oloisina kiinni.\n" +
                "Vieressäsi ovat ovet Torvalds-huoneeseen (B), Java-ryhmän Hawking-luokkaan (C) ja vessaan (D).\n" +
                "Voit myös palata takaisin keittiöön (E).");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            if (Game.hissinappi == 0)
            {
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (Game.sahkoa == 1)
                        {
                            Console.WriteLine("Vaikka kerroksen varasähköt ovat päällä, ei hissi reagoi napinpainallukseen, koska rakennuksen pääsähköt ovat edelleen poikki.\n");
                        }
                        else
                        {
                            Console.WriteLine("Hissin nappi ei reagoi painallukseen, eivätkä hissien ovet avaudu milliäkään suurista ponnisteluista huolimatta.\n");
                        }
                        Console.ResetColor();
                        Game.hissinappi++;
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven Torvalds-huoneeseen.\n");
                        Console.ResetColor();
                        Torvalds torvalds = new Torvalds();
                        torvalds.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ovi on näköjään lukossa.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven Java-luokkaan.\n");
                        Console.ResetColor();
                        Hawking hawking = new Hawking();
                        hawking.Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
            else
            {
                switch (vastaus)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (Game.sahkoa == 1)
                        {
                            Console.WriteLine("Toiveikkaasti kokeilet hissin kutsunappia, vaikkei se viimeksi reagoinut painallukseen.\n" +
                                "Vaikka kerroksen varasähköt ovat päällä, ei hissi edelleenkään reagoi napinpainallukseen, koska rakennuksen pääsähköt ovat edelleen poikki.\n");
                        }
                        else
                        {
                            Console.WriteLine("Toiveikkaasti kokeilet hissin kutsunappia, vaikkei se viimeksi reagoinut painallukseen.\n" +
                            "Nappi ei tälläkään kertaa tee mitään.");
                        }
                        Console.ResetColor();
                        Game.hissinappi++;
                        Avaa();
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven Torvalds-huoneeseen.\n");
                        Console.ResetColor();
                        Torvalds torvalds = new Torvalds();
                        torvalds.Avaa();
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ovi on näköjään lukossa.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Avaat oven Java-luokkaan.\n");
                        Console.ResetColor();
                        Hawking hawking = new Hawking();
                        hawking.Avaa();
                        break;
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Siirryt keittiöön.\n");
                        Console.ResetColor();
                        Keittio keittio = new Keittio();
                        keittio.Avaa();
                        break;
                    case "KASSI":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Inventaario inventaario = new Inventaario();
                        Console.WriteLine(inventaario);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "H-HELP":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Heikki heikki = new Heikki();
                        heikki.Help();
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "HALP":
                    case "HELP":
                        Help help = new Help();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(help);
                        Console.ResetColor();
                        Avaa();
                        break;
                    case "KARTTA":
                        Kartta kartta = new Kartta();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        kartta.KutsuKartta();
                        Console.ResetColor();
                        Avaa();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Epäkelpo valinta.\n");
                        Console.ResetColor();
                        Avaa();
                        break;
                }
            }
        }
    }
}
