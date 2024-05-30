// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using HashingSaltTest;
using System.Text;

HashingAndSaltingPasswords saltTest = new HashingAndSaltingPasswords();
var haspassword =saltTest.HashPasword("MaheshDivekar", out var salt);
var saltstring = Convert.ToBase64String(salt);
bool ishashmatch = saltTest.VerifyPassword("MaheshDivekar", haspassword, salt);
bool ishashmatch1 = saltTest.VerifyPassword("MaheshDivekar", haspassword, Convert.FromBase64String(saltstring));
Console.WriteLine("Hello, World!");
