using System;

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

        Console.Write("İlk ismi giriniz:");
        string firstName = Console.ReadLine();
        Console.Write("İkinci ismi giriniz:");
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


    }
}