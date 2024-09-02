// // // See https://aka.ms/new-console-template for more information
// // using System.Linq.Expressions;

// // Console.WriteLine("Hello, World!");
// // string opt1; string opt2 ; string opt1v2 ; string opt2v2 ; string opt2v2v1 ; string opt2v2v2;
// // opt1 = Console.ReadLine();
// // int
// //  Console.WriteLine("hejsan");
// //  Console.ReadLine();
// //  for (int i = 0; i <= 10; i = i + 2) 

// // {
// //   Console.WriteLine(i);
// // }

// while (1 ==1 )
// {
// Console.WriteLine("användarnamn");

// string name = Console.ReadLine();

// if (name.ToLower() == "Jacob" )

// {

//   Console.WriteLine("loggad in");

//   break;

// }
// else if (name == "Jacke006")
// {System.Console.WriteLine("nja du kommer in");
// break; } 
// else

// { System.Console.WriteLine("nej");} }

// //{} alt gr 7

// Console.ReadLine();
using System.Globalization;
using System.Net.Sockets;
string repeat;
string opt1;
string opt2;
string klar;
opt2 = "hjk";
klar = "nej";
opt1 = "h";
repeat = "1";
System.Console.WriteLine("det var en gång en åsna. Åsnan Älskade  ");
while (klar == "nej"){
if (repeat == "1"){
System.Console.WriteLine("Grönsaker/åsnekött");
opt1=Console.ReadLine();}
if (opt1.ToLower() == "grönsaker") {
System.Console.WriteLine("Åsnan gillade grönsaker speciellt morötter men en dag hade åsnan käkat upp alla morötter så han skulle ut på");
System.Console.WriteLine("äventyr/chilla");

opt2 = Console.ReadLine();
repeat = "2";}
 else if (opt1.ToLower() == "åsnekött")
 {
if (repeat == "2") {
System.Console.WriteLine("Den här åsnan var något av vad man kallar en lönnmördare när det kommer till andra åsner. hans största rädsla var att åsnepolisen skulle gräva i hans trädgård! Men åsnan var väldigt sugen på åsnekött ska han käka sin");
System.Console.WriteLine("Bästa kompis/Föräldrar");
opt2 =Console.ReadLine ();
repeat = "3";
}}

if (opt2.ToLower() == "äventyr") {
  System.Console.WriteLine("Åsnan gick därför ut på stan och snodde ett stånd med alla morötter en åsna kan vilja ha i livet!!");
klar = "ja";
break;
}
else if (opt2.ToLower() == "chilla") {System.Console.WriteLine("åsnan stannade därför hemma och chillade!");
klar = "ja";

break;
}
 
 if (opt2.ToLower() == "bästa kompis") {
  System.Console.WriteLine("Åsnan tänkte på alla dom dumma saker Sven hade gjort mot honom och bestämde sig för att han skulle bli nästa veckas mat.");
 klar = "ja";
 break;}

if (opt1.ToLower() == "föräldrar"){
  System.Console.WriteLine("Skaffa hjälp!");
  klar = "ja";

}
}

Console.ReadLine();