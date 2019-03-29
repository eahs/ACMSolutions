using System;

namespace ArtLatin
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter sentence: ");
                string[] words = Console.ReadLine().Split(' ');

                string vowels = "AEIOU";
                string Ans = "";

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (!vowels.Contains(word[0]) || word[0] == 'U')
                        {
                            if (word[0] == 'U' && word[word.Length - 1] == 'Q')
                            {
                                string temp = word[0].ToString();
                                word = word.Substring(1);
                                word += temp;
                            }
                            else if (word[0] == 'U' && word[word.Length - 1] != 'Q')
                                break;
                            else if (word[0] != 'U')
                            {
                                if (word.Length == 2)
                                {
                                    string t = word[0].ToString();
                                    word = word.Substring(1);
                                    word += t;
                                    break;
                                }
                                string temp = word[0].ToString();
                                word = word.Substring(1);
                                word += temp;
                            }
                        }
                    }

                    if (vowels.Contains(word[word.Length - 1]) && word[word.Length - 1] != 'U')
                        word += "KART";
                    else word += "ART";

                    Ans += word + " ";
                }

                Console.WriteLine("Translation: {0}", Ans);
            }
        }
    }
}
