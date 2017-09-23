<Query Kind="Program" />

void Main()
{
	string[] margen = {"Fidalgo", "Comandante militar", "nascimento: 1467, Belmonte,Portugal","Falecimento: 1520,Santarém", "Seu nome é : Pedro alvares cabral"};
	string[] CopiaMargen = (string[])margen.Clone();
	string[] pedro = {"Erro", "Erro", "Erro"};
	string[] CopiaPedro = (string[])pedro.Clone();
	
	string a;
	Console.WriteLine("Digite a Resposta Correta!!");
	Console.WriteLine("Quem Descobriu o brasil?");
	a = Console.ReadLine();
	if ((a == "Pedro Alvares Cabral")||(a == "pedro alvares cabral")||(a == "Pedro alvares cabral")||(a == "Pedro alvares")||(a == "pedro alvares"))
	{
		Console.WriteLine("Resposta Correta... \n Então abriremos o programa!");
		Console.WriteLine(CopiaMargen);
	}
	else 
	{
		Console.WriteLine("Resposta incorreta.... \n Então não abriremos o programa!");
		Console.WriteLine(CopiaPedro);
	}
	
}

// Define other methods and classes here