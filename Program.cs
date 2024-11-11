using System;
using System.ComponentModel.Design;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            // Console.Write("satr1: ");
            // var text = Console.ReadLine();
            // var countcat = text.Split("cat").Length-1;
            // var countdog = text.Split("dog").Length-1;
            // Console.WriteLine(countdog==countcat);

            // 2
            // Console.Write("satr: ");
            // var text = Console.ReadLine();
            // var count = 0;
            // for (var i = 0; i <text.Length; i++)
            // {
            //     if (text[i]=='c' && text[i+1]=='o' && text[i+3]=='e')
            //     {
            //         ++count;
            //     }
            // }
            //
            // Console.WriteLine(count);

            // 3
            // Console.Write("satr: ");
            // var text1 = Console.ReadLine();
            // Console.Write("satr: ");
            // var text2 = Console.ReadLine();
            //     if (text1.EndsWith(text2) )
            //     {
            //         Console.WriteLine(true);
            //     }
            //     else
            //     {
            //         Console.WriteLine(false);
            //     }

            // 4
            // Console.WriteLine("satr: ");
            // var text = Console.ReadLine();
            // var dotbool = false;
            // for (int i = 0; i < text.Length; i++)
            // {
            //     if (text.Substring(i, 3) == "xyz" && (i == 0 || text[i - 1] != '.'))
            //     {
            //         dotbool = true;
            //         break;
            //     }
            // }
            // Console.WriteLine("natija: " + dotbool);
            //

            // 5
            // Console.Write("satr1: ");
            // var text1 = Console.ReadLine(); 
            // Console.Write("satr2: ");
            // var text2 = Console.ReadLine();
            // var textedit = "";
            // var text1length = text1.Length;
            // var text2length = text2.Length;
            // var textmax = Math.Max(text1length, text2length);
            // for (int i = 0, j=0 ; i <textmax  ; i++, j++)
            // {
            //     if (i< text1length)
            //     {
            //         textedit += text1[i];
            //     }
            //
            //     if (j<text2length)
            //     {
            //         textedit += text2[j];   
            //     }
            // }
            //
            // Console.WriteLine(textedit);

            // 6
            // Console.Write("satr: ");
            // var text = Console.ReadLine(); 
            // Console.Write("son: ");
            // var number = int.Parse(Console.ReadLine());
            // var cuttext = text.Substring(text.Length-number);
            // var count = 0;
            // for (int i = 0; i < number; i++)
            // {
            //     Console.Write(cuttext);
            // }

            // 7
            // Console.Write("satr: ");
            // var text = Console.ReadLine(); 
            // Console.Write("son: ");
            // var number = int.Parse(Console.ReadLine());
            // for (int i = 0; i < number; i++)
            // {
            //     var cuttext = text.Substring(0,number-i);
            //     Console.Write(cuttext);
            // }

            // 8
            // Console.Write("satr: ");
            // var text = Console.ReadLine();
            // Console.Write("son: ");
            // var count= int.Parse(Console.ReadLine());
            // var substring = text.Substring(0, count);
            // for (int i = count; i < text.Length-count; i++)
            // {
            //     var substring2 = text.Substring(i, count);
            //     if (substring==substring2)
            //     {
            //         Console.WriteLine(true);
            //         return;
            //     }
            // }
            // Console.WriteLine(false);

            // 10
            // Console.Write("satr: ");
            // var text = Console.ReadLine();
            // var xyz = text.Contains("xyz");
            // var locationxyz = text.IndexOf("xyz");
            // var xyzFirst = text.Substring(0, locationxyz);
            // var xyzSecond = text.Substring(locationxyz+3);
            // if (xyz  && (Math.Abs(xyzFirst.Length - xyzSecond.Length) < 2)) 
            // {
            //     Console.WriteLine(true);
            //     
            // }
            // else
            // {
            //     Console.WriteLine(false);
            // }
            
            // 11
            Console.WriteLine("satr: ");
            var text = Console.ReadLine();
            if (text.StartsWith("bread") && text.EndsWith("bread"))
            {
                
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
    }
}