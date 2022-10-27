// See https://aka.ms/new-console-template for more information
using prj_contas;
/*
Corrente obj_cc = new Corrente();

obj_cc.Agencia = "7800";
obj_cc.Numero = "99991";
obj_cc.Saldo = 0;
obj_cc.Limite = 1000;

//obj_cc.Imprimir(obj_cc.Agencia, obj_cc.Numero, obj_cc.Saldo);

Poupanca obj_cpp = new Poupanca();

obj_cpp.Agencia = "33344";
obj_cpp.Numero = "12345";
obj_cpp.Saldo = 500;
obj_cpp.Aniversario = 15;


/*
Console.WriteLine("Agência: " + obj_cc.Agencia);
Console.WriteLine("Número: " + obj_cc.Numero);
Console.WriteLine("Saldo: " + obj_cc.Saldo);
Console.WriteLine("Limite: " + obj_cc.Limite);
*/
/*
Console.WriteLine("Agência: " + obj_cc2.Agencia);
Console.WriteLine("Número: " + obj_cc2.Numero);
Console.WriteLine("Saldo: " + obj_cc2.Saldo);
Console.WriteLine("Limite: " + obj_cc2.Limite);
*/ 

//Console.WriteLine(obj_cc./*Imprimir*/ToString());

//Console.WriteLine(obj_cpp./*Imprimir*/ToString());


Corrente obj_cc = new Corrente("3030-0","1988",101);
/*
string ret;
ret = obj_cc.ToString();
Console.WriteLine($"{ret}");
*/
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"************************************");
//obj_cc.Depositar(100);
Console.WriteLine($"{obj_cc.Depositar(100)}");

Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"************************************");

Console.WriteLine($"{obj_cc.Sacar(300)}");
Console.WriteLine($"{obj_cc.ToString()}");





