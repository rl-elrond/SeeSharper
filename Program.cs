/*using System;
namespace _2704_G01
{
    class Program
    {
        
Schreiben Sie bitte ein C#-Programm, das 
a) eine Integer-Variable g einführt, die für alle Funktionen in der Klasse 'Program' gültig ist
b) eine Integer-Variable l einführt, die nur im Main gültig ist
c) eine Funktion besitzt, die im Main aufgerufen werden kann und g-mal "Hallo" auf der Konsole ausgibt 
d) im Main l-mal "Welt" auf der Konsole ausgibt
e) zur Kontrolle im Main die beiden Werte g und l auf der Konsole ausgibt
f) die Konsole bis zu einem beliebigen Tastendruck festhält

Hinweis: 
Das Erlernen von ANSI C war nicht sinnlos ;-) ...
... for-Schleifen sehen bei C# genauso aus wie bei C

        static public int g; //g ist eine Eigenschaft der Klasse Programm
                             // g ist deshalb statisch, weil es eine Eigenschaft der Klasse Programm ist

        static void Ausgabe() //Ausgabe() ist deshalb statisch, weil es eine Methode der Klasse  (Programm) ist
        {
            for (int i=0; i<g; i++) //i ist eine lokale Variable der for-Schleife
            {
                Console.WriteLine((i+1).ToString()+ ". Hallo");   //i.ToString() wandelt die Binärzahl i in eine Zeichenkette um
                                                            // .ToString() kann bei konkatenation weggelassen werden
                                                            // + verknüpft zwei zeichenketten (Konkatenation)
            }
        }
        static void Main(string[] args)
        {
            int l;
            g = 5;
            Ausgabe();
            l = 4;
            for (int i=0; i<l; i++)
            {
                Console.WriteLine("Welt");
            }
            {
                Console.WriteLine("1. Moeglichkeit");
                Console.WriteLine("g = {0} l = {1}", g, l);
                Console.WriteLine("2. Möglichkeit");
                Console.WriteLine("g = " + g + " l = " + 1);
                // Festhalten der Konsole
                Console.ReadKey();
            }
        }
    }
}


//'' kennzeichnet nur ein Zeichen, ""Zeichenketten
using System;

namespace _Tag_01_A02
{
    class Program
    {

        static void Main(string[] args)
        { 
           // Int32 i = 300;
           // uInt16 i = 200;
            ushort i = 5;
            float fZahl = 9.99f; // bei Float-Variablen nachfolgendes "f" lieber DOUBLE nehmen
            double dZahl = 9.99;
            char cZeichen = 'A';
            string sKette = "";  //Initalisierung des Strings auf leere Zeichenkette
            for (int j = 0; j<i; j++)
            {
                sKette = sKette + fZahl + cZeichen;
                Console.WriteLine(sKette);
            }
            for (int j = 0; j<3; j++)
            {
                Console.WriteLine(sKette);
            }
            Console.ReadKey();

        }
    }
}
*/
/*
 * If-Anweisung und Funktionen
 * Sie bauen einen Roboter. In diesen ist eine Batterie eingebaut.
 * Erzeugen Sie eine Integer Variable "batterieLaufzeit" mit dem Wert 5.
 * Anschließend implementieren Sie eine Methode "IstBatterieLaufzeitNiedrig"
 * Diese Methode soll true zurück geben, wenn die Laufzeit kleiner 2 ist, sonst false.
 * 
 * Erstellen Sie eine String Variable "aufgabe" und weisen Sie ihr "Ich reiche Butter" zu.
 * Implementieren Sie eine Methode "FühreAufgabeAus", die auf dem Bildschirm die Variable "aufgabe" ausgibt,
 * wenn "IstBatterieLaufzeitNiedrig" false liefert und dann die Batterie Laufzeit um 1 reduziert, 
 * sonst soll "Ich muss aufgeladen werden" in der Konsole erscheinen.
 * 
 * Lassen Sie in der Main den Roboter fünf mal in einer Schleife Butter reichen.

using System;

namespace _Tag_01_A03
{
    class Program
    {   //attribute dieser klasse
        static int batterieLaufzeit = 5; //muss static statt public oder private damit man damit arbeiten kann, verbleiben in der klasse
        static string aufgabe = "Ich reiche Butter";
        static bool IstBatterieLaufzeitNiedrig() //ist der Funktionskopf
        {
            if (batterieLaufzeit < 2)
                return true;
            else
                return false;

        }
        static void FuehreAufgabeAus() //an der () und dem return-wert erkennt man dass es eine methode ist
        {
            if (!IstBatterieLaufzeitNiedrig()) //also wenn "istbatterie..." false(!=nicht)
            {
                Console.WriteLine(aufgabe);
                batterieLaufzeit--;
            }
            else
                Console.WriteLine("Bitte Aufladen");

        }
        static void Main(string[] args) //im Programm ist die class Program die einzige mit der Main-Methode
        {
            for (int i = 0; i < 5; i++)
                FuehreAufgabeAus();
        }
     }
}
 
 // TAG II Operationen und Operatoren
using System;

namespace _Tag_01_A03
{
    class Program
    {
static void Main()
        {
            //Console.WriteLine(Environment.UserName);
            //besondere Operatoren in C#
            // typeof-Operator
            /*
            int i = 5;
            float fZahl = 5.0f;
            Console.WriteLine(typeof(int)); //Anzeige der.net Typbezeichnung

            //is-operator
            //typ einer variablen püfen

            if (fZahl is int) Console.WriteLine("die variable fZahl ist vom typ integer"); //{} fassen anweisungen zu einer zusammen, bei einer brauchen wir die nicht
            else Console.WriteLine("fZahl ist nicht integer");
            //Console.ReadKey(); //macht VisualStudio automatisch...in den Optionen Debugger option

            // sizeof-operator
            //liefert die Größe des Datentyps in Byte

            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(bool));

            // Rangfolge von Operatoren an bestimmten Beispielen
            int x = 0;
            bool b = false;

            Console.WriteLine(!b && ++x > 1 || x << 1 > 2); // << left-shift multiplikation mit 2, weil
                                                            // Verschiebung um eine Bit-Stelle nach Links

            Console.WriteLine((!b && ++x > 1) || (x << 1 > 2)); //Klammern haben die höchste Priorität und werden von innen nach aussen aufgelöst
            
            int k = 5;
            int l = 1024;
            for (int i=0; i <5; i++)
            {
                k = k << 1;
                l = l >> 1;
                Console.WriteLine("k = " + k + " l = "+l);
            }
            //Eingaben von der Konsole mit Console.Readline()
            //Alle Zeichenketten erfolgen in Form von Zeichenketten
            string eingabeZeichenkette = null; //oder ""
            int eingabeZahl = 0;
            Console.ReadKey();

        }
    }
}

using System;

namespace _Tag_02_A03
{
    class Program
    {
        static void Main()
        {
            string eingabeZeichenkette = null; //oder ""
            int eingabeZahl = 0;

            Console.WriteLine("Bitte einen Text eingeben"+Environment.NewLine);
            eingabeZeichenkette = Console.ReadLine();

            Console.WriteLine("Bitte eine Zahl eingeben");
            eingabeZahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Text = " + eingabeZeichenkette + Environment.NewLine+ "Zahl = " + (eingabeZahl+20));

            Console.ReadKey();
        }
    }
}
using System;

namespace _Tag_02_Aufgabe1
{
    class Program
    {
        static void Main()
        {
            string eingabeName = null;

            Console.WriteLine("Bitte einen Namen eingeben" + Environment.NewLine);
            eingabeName = Console.ReadLine();

            Console.WriteLine(Environment.NewLine+"Name = " + eingabeName);

            Console.ReadKey();
        }
    }
}
using System;
using System.Threading;

namespace _Tag_02_Aufgabe2
{
    class Program
    {
        static void Main()
        {
            int counter = 10;
            for (; counter < 11 && counter > 0; counter--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(counter + Environment.NewLine);

            
            
            }
            Console.ReadKey();
        }
    }
}
*//*
using System;

namespace _Tag_02_Aufgabe3
{
    class Program
    {
        static void Main()
        {
            double zahl1;
            double zahl2;
            string opfer = "";
            do
            {
                Console.WriteLine("Tasche-Reschner made Simple" + Environment.NewLine + "-----------------------------------------------------" + Environment.NewLine);
                Console.WriteLine("Bitte geben Sie die erste Zahl ein: ");
                zahl1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die zweite Zahl ein: ");
                zahl2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Rechenart ein: ");
                opfer = Console.ReadLine();
                switch (opfer)
                {
                    case "+":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " + " + zahl2 + " = " + (zahl1 + zahl2));
                        break;
                    case "-":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " - " + zahl2 + " = " + (zahl1 - zahl2));
                        break;
                    case "/":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " / " + zahl2 + " = " + (zahl1 / zahl2));
                        break;
                    case "*":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " * " + zahl2 + " = " + (zahl1 * zahl2));
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Valide Rechenarten : +,-,*,/.");
                        break;
                }
                Console.WriteLine("Nochmal? Drücken Sie N zum Beenden"+Environment.NewLine + Environment.NewLine);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.N);           
        }
    }
}
*//*
using System;

namespace _Tag_02_Aufgabe3
{
    class Program
    {
        static void Main()
        {
            double zahl1;
            double zahl2;
            string opfer = "";
            do
            {
                Console.WriteLine("Jetzt mal übertreiben" + Environment.NewLine + "-----------------------------------------------------" + Environment.NewLine);
                Console.WriteLine("Bitte geben Sie ihre Rechenaufgabe ein: ");
                zahl1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die zweite Zahl ein: ");
                zahl2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie die Rechenart ein: ");
                opfer = Console.ReadLine();
                switch (opfer)
                {
                    case "+":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " + " + zahl2 + " = " + (zahl1 + zahl2));
                        break;
                    case "-":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " - " + zahl2 + " = " + (zahl1 - zahl2));
                        break;
                    case "/":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " / " + zahl2 + " = " + (zahl1 / zahl2));
                        break;
                    case "*":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " * " + zahl2 + " = " + (zahl1 * zahl2));
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Valide Rechenarten : +,-,*,/.");
                        break;
                }
                Console.WriteLine("Nochmal? Drücken Sie N zum Beenden" + Environment.NewLine + Environment.NewLine);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.N);
        }
    }
}
*//*
string aufgabe = "";
double[] einzelZahlen = aufgabe.Split(new double[] { '+'|'-'|'/'|'*' });
Console.WriteLine(splitedNames[0]);
*/
using System;

namespace _Tag_02_Aufgabe3
{
    class Program
    {
        static void Main()
        {
            string eingabe = "";
            string[] einzelZahlen = eingabe.Split("[-+*/]");
            string[] operatoren = eingabe.Split("[1234567890]");
            string[] zwischenErgebnis = 
            do
            {
                Console.WriteLine("Jetzt mal übertreiben" + Environment.NewLine + "-----------------------------------------------------" + Environment.NewLine);
                Console.WriteLine("Bitte geben Sie ihre Rechenaufgabe ein: ");
                eingabe = Console.ReadLine();
                switch (operatoren)
                {
                    case operatoren == + :
                        Console.WriteLine("--------------------" + Environment.NewLine + einzelZahlen[0] + " "+ operatoren[0]+" " + einzelZahlen[1] + (einzelZahlen[0] + einzelZahlen[1]), einzelZahlen[]++);
                        break;
                    case "-":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " - " + zahl2 + " = " + (zahl1 - zahl2));
                        break;
                    case "/":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " / " + zahl2 + " = " + (zahl1 / zahl2));
                        break;
                    case "*":
                        Console.WriteLine("--------------------" + Environment.NewLine + zahl1 + " * " + zahl2 + " = " + (zahl1 * zahl2));
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Valide Rechenarten : +,-,*,/.");
                        break;
                }
                Console.WriteLine("Nochmal? Drücken Sie N zum Beenden" + Environment.NewLine + Environment.NewLine);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.N);
        }
    }
}