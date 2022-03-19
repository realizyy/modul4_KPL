// See https://aka.ms/new-console-template for more information

using System;
using modul4_1302204035;

Console.WriteLine("Hello, World!");
Penjumlahan<Double> count = new Penjumlahan<Double>();
Console.WriteLine("Hasil Penjumlahan : " + count.JumlahTigaAngka(13,02,20));
SimpleDataBase<int, DateTime> db = new SimpleDataBase<int, DateTime>();
db.AddData(00, DateTime.Now);//Data 0
db.AddData(13, DateTime.UtcNow);
db.AddData(02, DateTime.UtcNow);
db.AddData(20, DateTime.UtcNow);
db.PrintAllData();
