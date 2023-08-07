// Switch
var lugar = 4;
switch (lugar)
{
    case 1:
        Console.WriteLine("Quedaste en primer lugar");
        break;
    case 2:
        Console.WriteLine("Quedaste en segundo lugar");
        break;
    case 3:
        Console.WriteLine("Quedaste en tercer lugar");
        break;
        case 4:
        case 5:
            Console.WriteLine("Casi lo lograste");
        break;
    default: Console.WriteLine("Mejor suerte a la proxima");
        break;
}