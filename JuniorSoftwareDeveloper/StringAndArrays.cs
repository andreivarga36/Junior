namespace JuniorSoftwareDeveloper
{
    public class StringAndArrays
    {
        //Implementează o metodă (i.e. countOccurrencesIgnoreCase(String[] array, String key)) care determină numărul
        //de elemente key din cadrul array și returnează această valoare. Metoda nu ține cont de tipul literelor
        //(i.e. majuscule vs. minuscule). Testează metoda în main pentru cât mai multe cazuri de excepție.

        public static int CountOccurrencesIgnoreCase(String[] array, string key)
        {
            if (!IsValidInput(array, key))
            {
                Console.WriteLine("Datele introduse sunt gresite. Array-ul si key-ul trebuie sa contina valori");
            }

            int count = 0;

            foreach (var element in array)
            {
                if (string.Compare(element, key, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsValidInput(string[] array, string key)
        {
            return array.Length > 0 && !string.IsNullOrEmpty(key);
        }


        //Un număr palindrom este un număr care este egal cu simetricul său (ex: 121, 10001, 22344322, 88, 7 etc.). Similar,
        //un șir de caractere este palindrom dacă este identic cu simetricul său (ex: „abba“, „ana“, „noon“, „radar“,
        //„madam“). Implementează o metodă (i.e. isPalindromeIgnoreCase(String)) care determină dacă un șir de caractere
        //primit ca parametru este sau nu palindrom, fără a se ține cont de tipul literelor (i.e. majuscule vs. minuscule). Testează metoda în main pentru cât mai multe cazuri de excepție
        public static bool IsPalindromeIgnoreCase(string word)
        {
            string reversedWord = ReverseString(word);

            return string.Compare(word, reversedWord, StringComparison.CurrentCultureIgnoreCase) == 0;
        }


        //Pornind de la experiența acumulată la exercițiul anterior, implementează o metodă (i.e. isPalindromeIgnoreCasePRO(String))
        //care determină dacă o propoziție este palindrom, ignorând diferențele de litere mari / mici și toate caracterele
        //care nu sunt litere. Similar exercițiului precedent, metoda va returna true dacă șirul de caractere este
        //palindrom, sau false în caz contrar. 
        public static bool IsPalindromeIgnoreCasePro(string sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if (!char.IsLetter(sentence[i]))
                {
                    sentence = sentence.Remove(i, 1);
                }
            }

            string reversedSentence = ReverseString(sentence);

            return string.Compare(sentence, reversedSentence, StringComparison.CurrentCultureIgnoreCase) == 0;
        }

        private static string ReverseString(string word)
        {
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i].ToString();
            }

            return reversedWord;
        }
    }
}
