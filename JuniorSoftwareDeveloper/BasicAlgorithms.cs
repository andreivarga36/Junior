namespace JuniorSoftwareDeveloper
{
    public class BasicAlgorithms
    {
        // Scrie o metodă care primește ca parametru un număr natural x și apoi afișează
        // cifrele numarului (in ordine inversa)
        // suma cifrelor

        public static void Calculate(int x)
        {
            string convertedNumber = x.ToString();
            string reversedNumber = "";
            int sum = 0;

            for (int i = convertedNumber.Length - 1; i >= 0; i--) 
            {
                reversedNumber += $"{convertedNumber[i]},";
                sum += int.Parse(convertedNumber[i].ToString());
            }

            Console.WriteLine($"Cifrele numarului inversate: {reversedNumber}");
            Console.WriteLine($"Suma este: {sum}");
        }

    
        //    Se citește un număr natural n și apoi n numere întregi.Scrie un program care calculează și afișează:
        //cel mai mic număr(valoarea minimă din șir).
        //cel mai mare număr(valoarea maximă din șir).
        //media aritmetică a numerelor(calculată ca sumă a tuturor numerelor împărțită la numărul de numere).
        public static void Calculate()
        {
            int totalNumbers = Convert.ToInt32(Console.ReadLine());
            int[] numbersArray = new int[totalNumbers];

            for (int i = 0; i < totalNumbers; i++)
            {
                int selectedNumber = Convert.ToInt32(Console.ReadLine());
                numbersArray[i] = selectedNumber;
            }

            Console.WriteLine($"Cel mai mic numar: {numbersArray.Min()}");
            Console.WriteLine($"Cel mai mare numar: {numbersArray.Max()}");
            Console.WriteLine($"Media aritmetica:{numbersArray.Sum() / numbersArray.Length}");
        }


        //Scrie o metodă care să determine dacă un număr dat este număr prim.Metoda va returna true dacă numărul este număr
        //prim și false în caz contrar.

        public static bool IsPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) 
                {
                    return false;
                }
            }

            return true;
        }


        //  Scrie un algoritm care citește de la tastatură un număr n și afișează toate numerele prime până la n
        //  (inclusiv), începând cu 2. 
        public static void DisplayPrimeNumbers()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++) 
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        //3.2. Implementează un program care afișează toți divizorii proprii (adică toți divizorii fără 1 și numărul însuși)
        //ai unui număr natural n citit de la tastatură. În cazul în care numărul este prim (i.e. nu are divizori proprii),
        //programul va afișa mesajul Este numar prim.
        public static void DisplayNumberDivisors()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrimeNumber(number))
            {
                Console.WriteLine($"{number} este numar prim");
                return;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
