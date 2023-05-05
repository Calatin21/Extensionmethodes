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
                        if (char.IsLetter(s[i - 1]) && char.IsLetter(s[i + 1])) {
                            ergebnis++;
                        }
                    }
                }
            }
            Console.WriteLine(ergebnis);
            //string[] woerter = s.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(woerter.Length);
        }
        public static void AddCopyright(this string s, int abstand) {
            //string[] woerter = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string item in woerter) {
            //    Console.WriteLine(item);
            //}
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            Console.WriteLine(sb);
            //for(int i = 0; i  ; i++) { }
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
