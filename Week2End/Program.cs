using System;
using System.ComponentModel;
using System.Threading.Channels;

class Program
{
    //8. Soru Metot

    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
    }

    //9. Soru Metot
    static int Q9Total(int q9num1,int q9num2)
    {
        return q9num1 + q9num2;
    }
    static void Main()
    {
        //1. Soru

        Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");

        //2. Soru

        string q2string = "Lorem ipsum dolor";
        int q2int = 0;

        Console.WriteLine(q2string);
        Console.WriteLine(q2int);

        //3. Soru

        Random q3random = new Random();
        int q3rnd = q3random.Next();
        Console.WriteLine(q3rnd);

        //4. Soru

        Random q4random = new Random();
        int q4rnd = q4random.Next();
        Console.WriteLine(q4rnd%3);

        //5. Soru

        Console.Write("Lütfen yaşınızı giriniz: ");
        int q5age =Convert.ToInt32(Console.ReadLine());
        if(q5age < 18)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }

        //6. Soru

        for(int i = 0; i < 10; i++) 
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        //7. Soru

        Console.Write("İlk ismi giriniz: ");
        string firstName = Console.ReadLine();
        Console.Write("İkinci ismi giriniz: ");
        string secondName = Console.ReadLine();

        string newFirstName = firstName;

        Console.WriteLine(secondName);
        Console.WriteLine(newFirstName);

        //8. Soru

        BenDegerDondurmem();

        //9. Soru
        Console.Write("İlk sayıyı giriniz");
        int q9firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı giriniz");
        int q9secondNum = Convert.ToInt32(Console.ReadLine());
        int q9sum = Q9Total(q9firstNum, q9secondNum);
        Console.WriteLine("Toplam:" + q9sum);

        //10. Soru

        static string BoolToString(bool value)
        {
            if (value)
            {
                return "true";
            }
            else
            {
                return "false";
            }

        }

        Console.WriteLine("Lütfen true yada false değeri giriniz.");
        bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());

        string result = BoolToString(trueOrFalse);
        Console.WriteLine("Seçiminiz:" + result);

        //11. Soru

        Console.WriteLine("Lütfen 1. kişinin yaşını giriniz");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen 2. kişinin yaşını giriniz");
        int age2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen 3. kişinin yaşını giriniz");
        int age3 = Convert.ToInt32(Console.ReadLine());
        int oldestAge = MaxAge(age1, age2, age3);
        Console.WriteLine("En yaşlı: " + oldestAge);


        static int MaxAge(int age1,int age2,int age3)
        {
            int oldest = age1;
            if(age2 > oldest)
            {
                oldest = age2;
            }
            if (age3 > oldest) 
            { 
                oldest = age3;
            }
            return oldest;
        }

        //12. Soru 

        //Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

        static int FindMaxNumber(List<int> numbers)
        {
            int max = numbers[0];
            foreach(int number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        Console.WriteLine("İstediğiniz kadar sayı girebilirsiniz. Çıkış yapmak için 'exit' yazınız.");

        List<int> numbers = new List<int>();

        while (true) 
        { 
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if(int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
        }
        if(numbers.Count > 0)
        {
            int maxNumber = FindMaxNumber(numbers);
            Console.WriteLine("Max number is : " + maxNumber);

        }

        //13. Soru

        static string ReplaceName(string name1, string name2) 
        {
            string tempName = name1;
            name1 = name2;

            Console.WriteLine("İlk isim: " + name2 + "\nİkinci isim: " + tempName);

            return tempName;
        }
        Console.WriteLine("Lütfen ilk ismi giriniz: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("Lütfen ikinci ismi giriniz: ");
        string name2 = Console.ReadLine();

        ReplaceName(name1, name2);

        //14. Soru

        static bool CheckNum(int num)
        {
            bool check;
            if (num%2 == 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            Console.WriteLine("Sayınız tek ise false, çift ise true ifadesini alırsınız: " + check );
            return check;
        }

        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int num = Convert.ToInt32(Console.ReadLine());

        CheckNum(num);

        //15. Soru

        static int Distance(int speed, int time)
        {
            return speed * time;
        }

        Console.WriteLine("Lütfen hızınızı giriniz(m/s): ");
        int speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen zamanı yazınız(s): ");
        int time = Convert.ToInt32(Console.ReadLine());

        double distance = Distance(speed, time);

        Console.WriteLine("Mesafe: " + distance);

        //16. Soru

        // Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

        static double Alan(double r)
        {
            int pi = 3;
            return (r * r) * pi;
        }

        Console.WriteLine("Lütfen yarıçapı giriniz: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double alan = Alan(r);

        Console.WriteLine("Dairenin alanı:" + alan);

        //17. Soru

        static string Upper(string upperOne)
        {
            return upperOne.ToUpper();
        }

        static string Lower(string lowerOne)
        {
            return lowerOne.ToLower();
        }

        string origin = "Zaman bir GeRi SayIm";
        string upperOne = Upper(origin);
        Console.WriteLine(upperOne);
        string lowerOne = Lower(origin);
        Console.WriteLine(lowerOne);

        //18. Soru

        string wordWithSpace = "    Selamlar   ";

        string newWord = wordWithSpace.Trim();
        Console.WriteLine(newWord);
    }


}