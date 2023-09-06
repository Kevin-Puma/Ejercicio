Console.WriteLine("Seleccione la categoría del hotel");
Console.WriteLine("1) 3 estrellas");
Console.WriteLine("2) 5 estrellas");

string categoriaTexto = Console.ReadLine();

Console.WriteLine("Ingrese los días que se quedara hospedado");

string diasTexto = Console.ReadLine();
float categoria = float.Parse(categoriaTexto);
int dias = int.Parse(diasTexto);
float pago = 0f;

switch (categoria)
{
    case 1:
        if (dias <= 5 && 1 <= dias)
        {
            pago = 100 * dias + (7 * dias);
        }
        else if (dias >= 6 && dias <= 10)
        {
            pago = 85 * dias + (7 * dias);
        }
        else if (dias >= 11)
        {
            pago = 70 * dias + (7 * dias);
        }
        break;
    case 2:
        if (dias <= 5 && dias >= 1)
        {
            pago = 300 * dias + (7 * dias);
        }
        else if (dias >= 6 && dias <= 10)
        {
            pago = 270 * dias + (7 * dias);
        }
        else if (dias >= 11)
        {
            pago = 250 * dias + (7 * dias);
        }
        break;
    default:
        Console.WriteLine("Por favor seleccione una de las alternativas");
        break;
}
Console.WriteLine("El pago es de: S/" + pago);
Console.ReadKey();
