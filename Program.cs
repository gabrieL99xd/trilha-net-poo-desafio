using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var Nokia = new Nokia("123132131" , "1" , "1Q1" , 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Wpp");

var Iphone = new Iphone("3333", "2" , "2C2" , 128);

Iphone.Ligar();
Iphone.InstalarAplicativo("Wpp");