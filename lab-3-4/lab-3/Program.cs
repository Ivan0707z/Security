﻿using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Intrinsics.Arm;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;

            do
            {
                Console.WriteLine("Вибір:");
                Console.WriteLine("1, злом грубою силою");
                Console.WriteLine("2, хешування з використанням різних алгоритмів");
                Console.WriteLine("3, хешування з hmac");
                Console.WriteLine("4, реєстрація користувача + аутентифікація");
                Console.Write("Ваш вибір -> ");
                option = Console.ReadLine();

                if (option == "1")
                {

                    String correctHash = "po1MVkAE7IjUUwu61XxgNg==";
                    String attemptHash = "";

                    int first = 0;
                    int second = 0;
                    int third = 0;
                    int fourth = 0;
                    int fifth = 0;
                    int sixth = 0;
                    int seventh = 0;
                    int eighth = 0;
                    int cracks = 0;

                    string[] array = new string[10];
                    array[0] = "0";
                    array[1] = "1";
                    array[2] = "2";
                    array[3] = "3";
                    array[4] = "4";
                    array[5] = "5";
                    array[6] = "6";
                    array[7] = "7";
                    array[8] = "8";
                    array[9] = "9";


                    while (!attemptHash.Equals(correctHash))
                    {
                        if (first == array.Length)
                        {
                            second++;
                            first = 0;
                        }

                        if (second == array.Length)
                        {
                            third++;
                            second = 0;
                        }

                        if (third == array.Length)
                        {
                            fourth++;
                            third = 0;
                        }

                        if (fourth == array.Length)
                        {
                            fifth++;
                            fourth = 0;
                        }

                        if (fifth == array.Length)
                        {
                            sixth++;
                            fifth = 0;
                        }

                        if (sixth == array.Length)
                        {
                            seventh++;
                            sixth = 0;
                        }

                        if (seventh == array.Length)
                        {
                            eighth++;
                            seventh = 0;
                        }

                        if (eighth == array.Length)
                        {
                            break;
                        }

                        string attempt = array[eighth] + array[seventh] + array[sixth] + array[fifth]
                            + array[fourth] + array[third] + array[second] + array[first];

                        byte[] attemptInArray = Encoding.Unicode.GetBytes(attempt);
                        attemptInArray = ComputeHashMd5(attemptInArray);
                        attemptHash = Convert.ToBase64String(attemptInArray);

                        Console.WriteLine(attempt + "         " + attemptHash);
                        first++;
                        cracks++;
                    }
                    Console.WriteLine("> Спроби злому: " + cracks);
                    Console.ReadLine();


                }

                else if (option == "2")                                                  
                {
                    Console.Write("Введіть повідомлення, для якого ви хочете розрахувати хеш-коди ->  ");
                    string message = Console.ReadLine();
                    Console.WriteLine("");

                    byte[] messageInArray = Encoding.Unicode.GetBytes(message);       

                    var md5ForStr = ComputeHashMd5(messageInArray); 
                    var SHA1ForStr = ComputeHashSHA1(Encoding.Unicode.GetBytes(message)); 
                    var SHA256ForStr = ComputeHashSHA256(messageInArray);
                    var SHA384ForStr = ComputeHashSHA384(messageInArray);
                    var SHA512ForStr = ComputeHashSHA512(messageInArray);

                    Console.WriteLine($"Hash MD5:{Convert.ToBase64String(md5ForStr)}"); 
                    Console.WriteLine($"Hash SHA1:{Convert.ToBase64String(SHA1ForStr)}");
                    Console.WriteLine($"Hash SHA256:{Convert.ToBase64String(SHA256ForStr)}");
                    Console.WriteLine($"Hash SHA384:{Convert.ToBase64String(SHA384ForStr)}");
                    Console.WriteLine($"Hash SHA512:{Convert.ToBase64String(SHA512ForStr)}");
                    Console.WriteLine("");

                }

                else if (option == "2")                                                 
                {

                    String correctHash = "po1MVkAE7IjUUwu61XxgNg==";
                    String attemptHash = "";

                    int first = 0;
                    int second = 0;
                    int third = 0;
                    int fourth = 0;
                    int fifth = 0;
                    int sixth = 0;
                    int seventh = 0;
                    int eighth = 0;
                    int cracks = 0;

                    string[] array = new string[10];
                    array[0] = "0";
                    array[1] = "1";
                    array[2] = "2";
                    array[3] = "3";
                    array[4] = "4";
                    array[5] = "5";
                    array[6] = "6";
                    array[7] = "7";
                    array[8] = "8";
                    array[9] = "9";

                    
                    while (!attemptHash.Equals(correctHash))
                    {
                        if (first == array.Length)
                        {
                            second++;
                            first = 0;
                        }

                        if (second == array.Length)
                        {
                            third++;
                            second = 0;
                        }

                        if (third == array.Length)
                        {
                            fourth++;
                            third = 0;
                        }

                        if (fourth == array.Length)
                        {
                            fifth++;
                            fourth = 0;
                        }

                        if (fifth == array.Length)
                        {
                            sixth++;
                            fifth = 0;
                        }

                        if (sixth == array.Length)
                        {
                            seventh++;
                            sixth = 0;
                        }

                        if (seventh == array.Length)
                        {
                            eighth++;
                            seventh = 0;
                        }

                        if (eighth == array.Length)
                        {
                            break; 
                        }

                        string attempt = array[eighth] + array[seventh] + array[sixth] + array[fifth]
                            + array[fourth] + array[third] + array[second] + array[first];

                        byte[] attemptInArray = Encoding.Unicode.GetBytes(attempt);
                        attemptInArray = ComputeHashMd5(attemptInArray);
                        attemptHash = Convert.ToBase64String(attemptInArray);

                        Console.WriteLine(attempt + "         " + attemptHash);
                        first++;
                        cracks++;
                    }
                    Console.WriteLine("> Attempts to crack: " + cracks);
                    Console.ReadLine(); 

                    
                }

                else if (option == "3")
                {
                    int amountSHA1 = 20;       
                    int amountSHA256 = 32;    
                    int amountSHA512 = 64;     

                   
                    Console.Write("Введіть повідомлення, для якого ви хочете розрахувати хеш-коди ->  ");
                    string message = Console.ReadLine();

                    Console.WriteLine("");
                    byte[] messageInArray = Encoding.Unicode.GetBytes(message);        

                
                    byte[] keySHA1 = cryptoKey(amountSHA1);
                    byte[] keySHA256 = cryptoKey(amountSHA256);
                    byte[] keySHA512 = cryptoKey(amountSHA512);


                    
                    var HmacSHA1 = ComputeHmacSHA1(messageInArray, keySHA1);
                    var HmacSHA256 = ComputeHmacSHA256(messageInArray, keySHA256);  
                    var HmacSHA512 = ComputeHmacSHA512(messageInArray, keySHA512);

                    Console.WriteLine($"HMAC SHA1:{Convert.ToBase64String(HmacSHA1)}"); 
                    Console.ReadLine();
                    Console.WriteLine($"HMAC SHA256:{Convert.ToBase64String(HmacSHA256)}");
                    Console.ReadLine();
                    Console.WriteLine($"HMAC SHA512:{Convert.ToBase64String(HmacSHA512)}");
                    Console.WriteLine("");

                    var Hmac2SHA1 = ComputeHmacSHA1(messageInArray, keySHA1);
                    var Hmac2SHA256 = ComputeHmacSHA256(messageInArray, keySHA256);  
                    var Hmac2SHA512 = ComputeHmacSHA512(messageInArray, keySHA512);

                    Console.WriteLine($"HMAC SHA1 (second hashing):{Convert.ToBase64String(Hmac2SHA1)}"); 
                    Console.ReadLine();
                    Console.WriteLine($"HMAC SHA256 (second hashing):{Convert.ToBase64String(Hmac2SHA256)}");
                    Console.ReadLine();
                    Console.WriteLine($"HMAC SHA512 (second hashing):{Convert.ToBase64String(Hmac2SHA512)}");
                    Console.WriteLine("");

                    Console.Write("SHA1 check: ");
                    CheckHash(HmacSHA1, Hmac2SHA1);
                    Console.ReadLine();
                    Console.Write("SHA256 check: ");
                    CheckHash(HmacSHA256, Hmac2SHA256);
                    Console.ReadLine();
                    Console.Write("SHA512 check: ");
                    CheckHash(HmacSHA512, Hmac2SHA512);
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("");

                }

                else if (option == "4")
                {
                  
                    int amountSHA1 = 20, amountSHA256 = 32, amountSHA512 = 64;

                   
                    string username, password, usernameCheck, passwordCheck;

                    byte[] keySHA1, keySHA256, keySHA512, passwordInArray;


                   
                    Console.WriteLine();
                    Console.WriteLine("Початок реєстрації користувача ");
                    Console.Write("Введіть своє ім'я користувача ->  ");
                    username = Console.ReadLine();                          
                    Console.Write("Введіть ваш пароль ->  ");
                    password = Console.ReadLine();                          
                    Console.WriteLine();
                    Console.WriteLine();

                    passwordInArray = Encoding.Unicode.GetBytes(password);  

                   
                    keySHA1 = cryptoKey(amountSHA1);
                    keySHA256 = cryptoKey(amountSHA256);
                    keySHA512 = cryptoKey(amountSHA512);

                   
                    var HmacSHA1 = ComputeHmacSHA1(passwordInArray, keySHA1);
                    var HmacSHA256 = ComputeHmacSHA256(passwordInArray, keySHA256);  
                    var HmacSHA512 = ComputeHmacSHA512(passwordInArray, keySHA512);
                    Console.WriteLine();
                    Console.WriteLine("SHA1: " + Convert.ToBase64String(HmacSHA1));
                    Console.ReadLine();                                                                                
                    Console.WriteLine("SHA256: " + Convert.ToBase64String(HmacSHA256));
                    Console.ReadLine();
                    Console.WriteLine("SHA512:  " + Convert.ToBase64String(HmacSHA512));
                    Console.ReadLine();
                    Console.WriteLine();


                   
                    Console.WriteLine("Початок автентифікації користувача ");
                    Console.Write("Введіть своє ім'я користувача ->  ");
                    usernameCheck = Console.ReadLine();               
                    Console.Write("Введіть ваш пароль ->  ");
                    passwordCheck = Console.ReadLine();               

                    var Hmac2SHA1 = ComputeHmacSHA1(passwordInArray, keySHA1);
                    var Hmac2SHA256 = ComputeHmacSHA256(passwordInArray, keySHA256); 
                    var Hmac2SHA512 = ComputeHmacSHA512(passwordInArray, keySHA512);
                    Console.WriteLine();
                    Console.WriteLine("SHA1: " + Convert.ToBase64String(Hmac2SHA1));
                    Console.ReadLine();                                                                                
                    Console.WriteLine("SHA256: " + Convert.ToBase64String(Hmac2SHA256));
                    Console.ReadLine();
                    Console.WriteLine("SHA512:  " + Convert.ToBase64String(Hmac2SHA512));
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.ReadLine();

                    Console.Write("SHA1 check: ");
                    CheckHash(HmacSHA1, Hmac2SHA1);
                    Console.ReadLine();
                    Console.Write("SHA256 check: ");
                    CheckHash(HmacSHA256, Hmac2SHA256);
                    Console.ReadLine();
                    Console.Write("SHA512 check: ");
                    CheckHash(HmacSHA512, Hmac2SHA512);
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            } while (option != "0");
        }


       
        public static int CheckHash(byte[] hash1, byte[] hash2)
        {
            if (Convert.ToBase64String(hash1) == Convert.ToBase64String(hash2))
            {
                Console.WriteLine("Хеші повідомлення точні");
            }
            else
            {
                Console.WriteLine("Хеші не точні. Повідомлення пошкоджено");
            }
            return 1;
        }


       
        public static byte[] cryptoKey(int amount)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) 
            {
                var Key = new byte[amount];
                rng.GetBytes(Key);
                return Key;
            }
        }


       
        public static byte[] ComputeHmacSHA1(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacSHA256(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacSHA512(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }


      
        static byte[] ComputeHashMd5(byte[] messageInArray)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(messageInArray);
            }
        }

        static byte[] ComputeHashSHA1(byte[] messageInArray)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(messageInArray);
            }
        }

        static byte[] ComputeHashSHA256(byte[] messageInArray)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(messageInArray);
            }
        }

        static byte[] ComputeHashSHA384(byte[] messageInArray)
        {
            using (var sha384 = SHA384.Create())
            {
                return sha384.ComputeHash(messageInArray);
            }
        }

        static byte[] ComputeHashSHA512(byte[] messageInArray)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(messageInArray);
            }
        }

    }
}