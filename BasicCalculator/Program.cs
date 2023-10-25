// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dígite o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dígite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Selecione a operação: ");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multipliacação");
Console.WriteLine("4 - Divisão");

int opecacao = Convert.ToInt32(Console.ReadLine());
int resultado = 0;

switch (opecacao)
{
	case 1:
		resultado= numero1 + numero2; 
		break;	
	case 2:
		resultado= numero1 - numero2; 
		break;
	case 3:
		resultado= numero1 * numero2; 
		break;
	case 4:	
		resultado= numero1 / numero2;
		break;
	default:
		Console.WriteLine("Operação inválida!");
		break;
}

Console.WriteLine($"O resultado é: {resultado}");

