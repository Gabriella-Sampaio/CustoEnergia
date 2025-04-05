using System.Security.AccessControl;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("                 Bem vindo                  "); Thread.Sleep(500);
Console.WriteLine(@"        Aqui você calcula quanto seu        
           aparelho gasta por mês           

"); 
Thread.Sleep(1000);
Console.ResetColor();

Console.Write("Nome do aparelho                : ");
string nomeAparelho = Console.ReadLine()!;

Console.Write("Consumo do aparelho (em kWh/mês): ");
double consumoAparelho = Convert.ToDouble(Console.ReadLine());

Console.Write("Hora de uso por dia             : ");
double horaConsumo = Convert.ToDouble(Console.ReadLine());
Thread.Sleep(500);

double resultado = consumoAparelho * horaConsumo * 0.711;

Console.Write("Obrigada, aqui está seu resultado: 💻"); Thread.Sleep(700);
Console.Write("."); Thread.Sleep(400);
Console.Write("."); Thread.Sleep(400);
Console.Write("."); Thread.Sleep(800);

Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@$"
----------------------------------
 Custo de energia - {nomeAparelho.ToUpper().PadRight(14, ' ')}
----------------------------------");
Console.ResetColor();

Console.WriteLine(@$"----------------------------------
Consome {consumoAparelho} kWh/mês
Funcioa {horaConsumo}h por dia
Custo kwh: R$0,71
----------------------------------
Custo estimado por mês: {resultado:C}
----------------------------------
");