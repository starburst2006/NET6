// See https://aka.ms/new-console-template for more information




string DenVTydnu(int vstup)
{

    switch (vstup)
    {
        case 1:
            return "pondělí";
            break;
        case 2:
            return "úterý";
            break;
        case 3:
            return "středa";
            break;
        case 4:
            return "čtvrtek";
            break;
        case 5:
            return "pátek";
            break;
        case 6:
            return "sobota";
            //vikend = true;
            break;
        case 7:
            return "neděle";
            //   vikend = true;
            break;
        default:
            return "chyba";
            break;

    }
}

string den = DenVTydnu(2);
Console.WriteLine(den);


//int Suma(int a, int b)
//{
//    int sum = a + b;

//    return sum;
//}



//int sum = Suma(10, 15);
//Console.WriteLine(sum);