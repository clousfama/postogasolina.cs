using System;

public class Posto{


public static void Main(){
		
		
		string tipocombustivel, tipopagamento;
		double litros, valor, valorpago;
		
		Console.WriteLine("Informe qual combustivel o cliente abasteceu!");
		Console.WriteLine("A - Álcool");
		Console.WriteLine("G - Gasolina");
		tipocombustivel = Console.ReadLine().ToUpper();
		
        Console.WriteLine("Informe qual tipo de pagamento!");
		Console.WriteLine("D - Dinheiro");
		Console.WriteLine("C - Cartão");
		tipopagamento = Console.ReadLine().ToUpper();

		Console.Write("Informe q quantidade de Litros: ");
		litros = double.Parse(Console.ReadLine());
		
		
		
		switch (tipocombustivel)
		{
			case "A":
				valorpago = (litros *2.50);			
				Console.Write("O Valor a ser pago é R$ " + valorpago);
				
				
				break;
				
			case "G":									
					valorpago = (litros *4.00);		
					Console.Write("O Valor a ser pago é R$ " + valorpago);
				
				break;
			default:
				Console.Write("Opção invalida!");
				break;					
		}                              	
			

		
	}
}