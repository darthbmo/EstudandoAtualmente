// See https://aka.ms/new-console-template for more information

using EstudosGerais.Facade_Pattern;
using EstudosGerais.Adapter_Pattern.Interfaces;
using EstudosGerais.Adapter_Pattern;
using EstudosGerais.Command_Pattern;
using EstudosGerais.Throw;
using EstudosGerais.OOP;

#region Classe Triangulo
/*
Triangulo trianguloA = new Triangulo();
trianguloA.LadoA = 10.5d;
trianguloA.LadoB = 10.5d;
trianguloA.LadoC = 10.5d;

Triangulo trianguloB = new Triangulo();
trianguloB.LadoA = 10.5d;
trianguloB.LadoB = 10.5d;
trianguloB.LadoC = 10.5d;

//Apontam para endereços distintos na memória 
Console.WriteLine(trianguloA.Equals(trianguloB));
Console.WriteLine(trianguloA == trianguloB);

double ladosTrianguloA = trianguloA.CalcularAreaTriangulo(trianguloA.LadoA, trianguloA.LadoB, trianguloA.LadoC);
double ladosTrianguloB = trianguloB.CalcularAreaTriangulo(trianguloB.LadoA, trianguloB.LadoB, trianguloB.LadoC);

double ladosSegundoTrianguloA = trianguloA.CalcularAreaTriangulo();
double ladosSegundoTrianguloB = trianguloB.CalcularAreaTriangulo();

Console.WriteLine(ladosTrianguloA.ToString("F2", CultureInfo.InvariantCulture)); //F2 são 2 casas após o ponto flutuante;
Console.WriteLine(ladosTrianguloB.ToString("F2", CultureInfo.InvariantCulture)); //F2 são 2 casas após o ponto flutuante;

Console.WriteLine(ladosSegundoTrianguloA.ToString("F2", CultureInfo.InvariantCulture)); //F2 são 2 casas após o ponto flutuante;
Console.WriteLine(ladosSegundoTrianguloB.ToString("F2", CultureInfo.InvariantCulture)); //F2 são 2 casas após o ponto flutuante;
Console.WriteLine(trianguloA.ToString());
Console.WriteLine(trianguloB.ToString());
*/
#endregion

#region Classe ExamplesBooks
/*
ExamplesBooks examples = new ExamplesBooks();
Console.WriteLine(examples.CountCaracters("     k"));
Console.WriteLine(examples.CountCaracters("12@ k")); //length : 5;
Console.WriteLine(examples.CountCaracters("     "));

Console.WriteLine(examples.CountCaractersSecond("     k"));
Console.WriteLine(examples.CountCaractersSecond("12@ k")); //length : 4;
Console.WriteLine(examples.CountCaractersSecond("     "));

byte[] data = {0, 1, 2};
Console.WriteLine(examples.ConvertStringToUtfEigth("12@ k"));
Console.WriteLine(examples.ConvertUtfEigthToString(data));

Console.WriteLine(examples.CountCaractersOcourrences("12@ k")); //1 ocourrence;
Console.WriteLine(examples.RemovingCaracterToIndex(0, 1, "12@ k")); //2@ k removido o caracter do indice 1, a partir do indice 0;

Console.WriteLine(examples.WorkingInSubString("12@ k", "[]")); //assim não preciso usar o string.format, por causa do appendformat;

Console.WriteLine(examples.DatetimeParseExact("2021-03-04"));
Console.WriteLine(examples.DatetimeParseExactCultureInfo("2021-03-04"));
Console.WriteLine(examples.DatetimeParseExactOnFormatString());
Console.WriteLine(examples.DatetimeParseExactOnFormatStringII());

examples.DictionaryCollectionInitializer(); //imprimir dicionarios inicializados com o collection initializer;
Console.WriteLine(examples.DictionaryCollectionAddInCheck().FirstOrDefault()); //imprimir dicionario inicializado com o collection initializer com check de key;
Console.WriteLine(examples.DictionaryCollectionAddInCheck().LastOrDefault());

examples.DictionaryCollectionConcurrent(); //estudar mais;
examples.IEnumerableToDict();
examples.EnumerateDict();
examples.DictionaryToList();
bool resultadoRemovingFromDictionary = examples.RemovingFromDictionary(1);
bool resultadoSecondRemovingFromDictionary = examples.RemovingFromDictionary(3);
Console.WriteLine("resultadoRemovingFromDictionary: " + resultadoRemovingFromDictionary + " | " + "resultadoSecondRemovingFromDictionary: " + resultadoSecondRemovingFromDictionary);

examples.StackExamples();

//Teste substring;
var tel = "7932185996";
var ddd = tel.Substring(0, 2);
var telefone = tel.Substring(2);
Console.WriteLine(ddd + " " + telefone);



*/
#endregion

#region Struct
/*
var produto = new Produto(1, "Melão", EValidade.NaValidade); //senão for informado, será o valor default definido no construtor;
Console.WriteLine(produto.Id);
Console.WriteLine(produto.Name);
Console.WriteLine(produto.EstadoAtual);
Console.WriteLine((int)produto.EstadoAtual); //imprime o número definido no enumerable;
Console.WriteLine(produto.DscProduto(1, "Melão"));

*/
#endregion

#region _others
/*
var idsTelefones = new List<string> { "xxxx", "zzzz", "aaaaa" };
var idTelefone = "oooo";

//VERBOSO;
foreach (var str in idsTelefones)
{
    if (str.Contains(idTelefone))
    {
		Console.WriteLine(str);
		break;
	}
    else
    {
		Console.WriteLine("Web.");
		break;
    }
}

//OTIMIZADO;
var lnk = idsTelefones.Where(l => l.Contains(idTelefone)).FirstOrDefault();
Console.WriteLine(lnk);


//AG - CONTA;
var agenciaConta = "77 - 777777";
var agencia = agenciaConta.Trim().Split('-')[0];
var conta = agenciaConta.Trim().Split('-')[1];
Console.WriteLine($"AG: {agencia} | CONTA: {conta}.");

//AGS - CONTAS;
var agC = "22 - 777777; 00 - 000000; 88 8888888";
var repl = agC.Trim().Split(';');
var agR = repl[0].Split('-');
Console.WriteLine($"{agR[0]}{agR[1]}");


*/
#endregion

#region object

/*
var generic = new object();
var lstGeneric = new List<object>();
var dicGeneric = new Dictionary<object>();
generic.Nome = "0";
generic.Valor = "1";

dicGeneric.Add(generic);

lstGeneric.Add(generic);

foreach (var gg in dicGeneric)
{
    Console.WriteLine(gg);
}

*/
#endregion

#region Pedidos
/*
var pedido = new Pedido();
pedido = EstudosGerais.Exemplos.Pedido.NovoPedido();

Console.WriteLine(pedido.ToString());
*/
#endregion

#region Patterns

//Facade
var facade = new FacadeRestaurant();
facade.BuscarPizzaNormal();
facade.BuscarPizzaVegana();

//Adapter
ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();
var xmlLumia = lumiaXMLTarget.GetLumiaMobileXMLSpecifications();

Console.WriteLine(xmlLumia.InnerXml);

//Command
var commandResult = (State)new Receiver().Action(new Command(1, "Command One"));

Console.WriteLine($"Code: {commandResult.StatusCode} - Message: {commandResult.Message}");

//Observer



#endregion

#region Delegate



#endregion

#region ThrowLib

//ThrowExceptions.IfNullOrEmptyWhiteSpace("");
//ThrowExceptions.ThrowWhiteSpaceOrEmptyAndLength("..");

#endregion

//
SubClasse sbClass = new SubClasse();
sbClass.MetodoClassePai();


