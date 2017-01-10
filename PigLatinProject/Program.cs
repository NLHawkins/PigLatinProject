using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ypetay omesay uffstay!");

            string pigString = Console.ReadLine();


            //Starts with a vowel
            char firstLetter = pigString[0];
            char secondLetter = pigString[1];
            char thirdLetter = pigString[2];
            char fourthLetter = pigString[3];
            char[] vowelArray = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowelArray)

                if (firstLetter.ToString().ToLower().Contains(vowel))


                {

                    Console.WriteLine(pigString + "way");
                }

            foreach (char vowel in vowelArray)

                if (secondLetter.ToString().ToLower().Contains(vowel))

                {

                    string pigCon = pigString.Remove(0, 1);

                    Console.WriteLine(pigCon[0].ToString().ToUpper() + pigCon.Substring(1) + firstLetter.ToString().ToLower() + "ay");
                }

            foreach (char vowel in vowelArray)

                if (thirdLetter.ToString().ToLower().Contains(vowel))

                {

                    string pig2Cons = pigString.Remove(0, 2);

                    Console.WriteLine(pig2Cons[0].ToString().ToUpper() + pig2Cons.Substring(1) + firstLetter.ToString().ToLower() + secondLetter.ToString());


                }

            foreach (char vowel in vowelArray)

                if (fourthLetter.ToString().ToLower().Contains(vowel))

                {

                    string pig3Cons = pigString.Remove(0, 3);

                    Console.WriteLine(pig3Cons[0].ToString().ToUpper() + pig3Cons.Substring(1) + firstLetter.ToString().ToLower() + secondLetter.ToString() + thirdLetter.ToString());


                }
        }
}
