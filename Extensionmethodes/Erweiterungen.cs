using System.Text;

namespace Extensionmethodes {
    internal static class Erweiterungen {
        public static void BuchstabenZaehlen(this string s) {
            int ergebnis = 0;
            foreach (char item in s) {
                if (char.IsLetter(item)) {
                    ergebnis++;
                }
            }
            Console.WriteLine(ergebnis);
        }
        public static void WoerterZaehlen(this string s) {
            int ergebnis = 1;
            for (int i = 0; i < s.Length; i++) {
                if (char.IsWhiteSpace(s[i])) {
                    if (i - 1 >= 0 && i + 1 < s.Length) {
                        if (char.IsLetter(s[i - 1]) || char.IsLetter(s[i + 1])) {
                            ergebnis++;
                        }
                    }
                }
            }
            Console.WriteLine(ergebnis);

            //Zur Ausgabe der gezählten Wörter.
            //
            //string[] woerter = s.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string item in woerter) {
            //    Console.WriteLine(item);
            //}
        }
        public static void AddCopyright(this string s, int abstand) {
            string[] woerter = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            s = "";
            for (int i = 0; i < woerter.Length; i++) {
                if(i % (abstand+1) == 0) {
                    s += " BITLC Neuss ";
                }
                s += woerter[i] +" ";
            }
            Console.WriteLine(s);

            //StringBuilder sb = new StringBuilder();
            //int ergebnis = 0;
            //int x = 0;
            //string cache = "BITLC Neuss ";
            //string cache2 = s;
            //Console.WriteLine(s.Count());
            //for (int i = 0; i < s.Length; i++) {
            //    if (char.IsWhiteSpace(s[i]) && !(char.IsLetter(s[i]))) {
            //        if (i - 1 >= 0 && i + 1 < s.Length) {
            //            if (char.IsLetter(s[i - 1]) && char.IsLetter(s[i + 1])) {
            //                ergebnis++;
            //                if (ergebnis % abstand == 0) {
            //                    cache += s.Substring(x, i);
            //                    cache += " BITLC Neuss ";
            //                    x = i;
            //                }
            //            }
            //        }
            //    }

            //}
            //Console.WriteLine(cache);
            //for (int i = 0; i < woerter.Length; i++) {
            //    if (i % (abstand - 1) == 0) {
            //        woerter[i] += " BITLC Neuss";
            //    }
            //}
            //s = "";
            //foreach (string item in woerter) {
            //    s += item + " ";
            //}
            //Console.WriteLine(s);
            //int ergebnis = 1;
            //string cache = s;
            //List<int> zahlen = new();
            //StringBuilder sb = new();
            //for (int i = 0; i < s.Length; i++) {
            //    if (char.IsWhiteSpace(s[i])) {
            //        if (i - 1 >= 0 && i + 1 < s.Length) {
            //            if (char.IsLetter(s[i - 1]) && char.IsLetter(s[i + 1])) {
            //                ergebnis++;
            //            }
            //        }
            //    }
            //    if (ergebnis % (abstand + 1) == 0 || i == 0) {
            //        zahlen.Add(i);
            //    }
            //}

            //foreach (int item in zahlen) {
            //    cache = cache.Insert(zahlen[item], "BITLC Neuss ");
            //}
            //s = cache;
            //Console.WriteLine(s);
        }
    }
}
