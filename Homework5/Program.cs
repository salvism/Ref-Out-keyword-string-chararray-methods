using System;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4 };
            MakeNewArray(ref array, 5);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int number = 4;
            AddTen(ref number);

            Console.WriteLine(number);


            int point = 104;
            CorrectPoint(ref point);

            Console.WriteLine(point);

            int[] numbers = { 1, 2, 3, 4, 5, 6 ,7 };

            MakeEven(ref numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Methods

            Console.WriteLine(char.IsDigit('4'));
            Console.WriteLine(char.IsDigit('s'));
            Console.WriteLine(char.IsLetter('m'));
            Console.WriteLine(char.IsLetter('1'));
            Console.WriteLine(char.IsLetterOrDigit('H'));
            Console.WriteLine(char.IsLetterOrDigit('+'));
            Console.WriteLine(char.IsLower('f'));
            Console.WriteLine(char.IsLower('F'));
            Console.WriteLine(char.IsUpper('W'));
            Console.WriteLine(char.IsUpper('w'));
            Console.WriteLine(char.ToUpper('s'));

            string sentence = "Hello World";
            var wordsArray = sentence.Split(" ");

            var newSentence = String.Join(" * ", wordsArray);

            Console.WriteLine(newSentence);

            string str = "Salvi";
            str = str.ToUpper();
            Console.WriteLine(str);

            Console.WriteLine(str.Contains("VI"));

            str = "Salvi Ismayilzada";
            var word = str.Substring(6, 11);
            Console.WriteLine(word);
            Console.WriteLine(str.IndexOf("a"));
            Console.WriteLine(str.LastIndexOf("a"));
            str = str.Replace("Ismayilzada", "P231");
            Console.WriteLine(str);
            str = "  Hello,  World!  ";
            str = str.Trim();
            Console.WriteLine(str);
            Console.WriteLine(str.StartsWith("Hello"));
            Console.WriteLine(str.EndsWith("123"));

            int[] ints = { 2, 1, 4, 3, 5, 7, 6, 8, 9 };
            var index = Array.LastIndexOf(ints, 4);
            Console.WriteLine(index);
            Array.Sort(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            Array.Reverse(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            Array.Clear(ints, 0, 4);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

        }

        //- Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
        //Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
        //arrayim dəyişilməli və arrayin  içində əvəlki elementləri,
        //əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.
        static void MakeNewArray(ref int[] arr, int value)
        {
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
            }

            int[] newArr = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[count-1] = value;

            arr = newArr;
        }

        //Verilmis ededi 10 vahid artiran metod
        static void AddTen(ref int num)
        {
            num += 10;
        }

        //Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 eden metod.
        //0-100 araligindadirsa oldugu kimi qalsin
        static void CorrectPoint(ref int point)
        {
            if (point < 0)
            {
                point = 0;
            }
            else if (point > 100)
            {
                point = 100;
            }
        }

        //Verilmis ededler siyahisini yalniz cut deyerler qalan yeni bir arraye-e ceviren metod

        static void MakeEven(ref int[] num)
        {
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] newNum= new int[count];
            int j = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    newNum[j] = num[i];
                    j++;
                }
            }

            num= newNum;
        }


    }
}
