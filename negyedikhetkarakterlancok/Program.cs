namespace negyedikhetkarakterlancok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1feladat
            // 1.feladat
            //int codeZ = (int)'Z';
            //Console.WriteLine(codeZ);

            /*string asd = "Szia csumi";
            char[] charasd = asd.ToCharArray();

            charasd[3] = 'g';
            asd = new string(charasd);
            Console.WriteLine(asd);
            */
            #endregion

            #region igazi 1 feladat
            /*
            Console.Write("Adj meg egy szöveget: ");
            string input = Console.ReadLine();

            int betukDB = 0;
            int szamokDB = 0;

            char[] maganhangzok = new char[]{'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű'};
            int maganhangzokDB = 0;

            //végig járjuk a szöveg karaktereit
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i])) //ha a szöveg i-edik eleme betű
                {
                    betukDB++;
                    if (maganhangzok.Contains(input.ToLower()[i]))
                        maganhangzokDB++;
                }
                else if (char.IsDigit(input[i]))
                    szamokDB++;

            }

            #region maganhangzok masik fele megoldas
            /*
            string letter = "aeiou";
            int letterCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (input[i] == letter[j]) letterCount++;
                }
            }
            
            #endregion

            Console.WriteLine($"Betűk száma: {betukDB}");
            Console.WriteLine($"Számjegyek száma: {szamokDB}");
            Console.WriteLine($"Magánhangzók száma: {maganhangzokDB}");*/
            #endregion

            Console.Write("Adj meg egy szöveget: ");
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            input = input.Replace("?", "");
            input = input.Replace("!", "");



            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            /*input = input.ToLower();
            bool egyezik = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    egyezik = false;
                    break;
                }
            }

            if(egyezik) Console.WriteLine("Egyezik");
            */

            //reversed = new string(input.Reverse().ToString());
            //Console.WriteLine("r " + reversed);

            //if(reversed == input) Console.WriteLine("ja");

            
            if(reversed.ToLower().Trim() == input.ToLower().Trim())
                Console.WriteLine("A szöveg palindrom");
            else
                Console.WriteLine("A szöveg nem palindrom");

            Console.WriteLine($"Eredeti szöveg:" + input);
            Console.WriteLine($"Fordított szöveg:" + reversed);

            Console.ReadKey();
            Console.Clear();

            Console.Write("Adj meg egy rendszámot: ");
            input = Console.ReadLine();

            char[] formatted = new char[7];
            input = input.ToUpper().Replace(" ", "");
            input = input.ToUpper().Replace("-", "");

            input = input.Substring(1, 2) + " " + input.Substring(2, 2) + "-" + input.Substring(4,3);

            Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}
