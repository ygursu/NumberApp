static void Main(string[] args)
{
    int yuzler = 0, onlar = 0, birler = 0, girilen;

    string sonuc = "";
    Console.Write("Sayıyı Giriniz >>> ");

    girilen = Convert.ToInt32(Console.ReadLine());

    if (girilen <= 0 || girilen >= 1000)
    {
        Console.WriteLine("Lütfen 0 ile 1000 arasında bir sayı giriniz");
    }

    if (girilen > 99)
    {
        yuzler = girilen / 100;

        if (girilen - (yuzler * 100) == 0)
        {
            goto ifSonu;
        }

        onlar = (girilen - (yuzler * 100)) / 10;

        birler = girilen - ((yuzler * 100) + (onlar * 10));
    }
    else if (girilen > 9)
    {
        onlar = girilen / 10;

        birler = girilen - (onlar * 10);
    }
    else
    {
        birler = girilen;
    }


ifSonu:

    if (yuzler > 0)
    {
        switch (yuzler)
        {
            case 1:
                sonuc = "C";
                break;

            case 2:
                sonuc = "CC";
                break;

            case 3:
                sonuc = "CCC";
                break;

            case 4:
                sonuc = "CD";
                break;

            case 5:
                sonuc = "D";
                break;

            case 6:
                sonuc = "DC";
                break;

            case 7:
                sonuc = "DCC";
                break;

            case 8:
                sonuc = "DCC";
                break;

            case 9:
                sonuc = "CM";
                break;
        }
    }
    if (onlar > 0)
    {
        switch (onlar)
        {
            case 1:
                sonuc = sonuc + "X";
                break;

            case 2:
                sonuc = sonuc + "XX";
                break;

            case 3:
                sonuc = sonuc + "XXX";
                break;

            case 4:
                sonuc = sonuc + "XL";
                break;

            case 5:
                sonuc = sonuc + "L";
                break;

            case 6:
                sonuc = sonuc + "LX";
                break;

            case 7:
                sonuc = sonuc + "LXX";
                break;

            case 8:
                sonuc = sonuc + "LXXX";
                break;

            case 9:
                sonuc = sonuc + "XC";
                break;
        }
    }

    if (birler > 0)
    {
        switch (birler)
        {
            case 1:
                sonuc = sonuc + "I";
                break;

            case 2:
                sonuc = sonuc + "II";
                break;

            case 3:
                sonuc = sonuc + "III";
                break;

            case 4:
                sonuc = sonuc + "IV";
                break;

            case 5:
                sonuc = sonuc + "V";
                break;

            case 6:
                sonuc = sonuc + "VI";
                break;

            case 7:
                sonuc = sonuc + "VII";
                break;

            case 8:
                sonuc = sonuc + "VIII";
                break;

            case 9:
                sonuc = sonuc + "IX";
                break;
        }
    }

    Console.WriteLine(sonuc.ToString());
    Console.ReadKey();
}

