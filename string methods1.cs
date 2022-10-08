using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name1 = "HelloWorld";
            string name2 = "Hello";
            Console.WriteLine(name1.Contains(name2));
            Console.WriteLine(name1.Equals(name2));
            Console.WriteLine(name1.GetType());
            Console.WriteLine(name1.GetHashCode());
            Console.WriteLine(name2.IsNormalized());

        }
        #region practice
        //int a = 5;
        //int b = a;
        //b = 18;
        //Console.WriteLine(a+" "+b);

        //int[] numbers1 = { 1, 3, 4, 5, 6, 7, 8 };
        //int[] numbers2 = numbers1;
        //numbers2[0] = 99;
        //Console.WriteLine(numbers1[0]+" "+numbers2[0]);

        //int num;
        //ShowNum(out num);
        //Console.WriteLine(num);

        //string name1 = "qoshqar";
        //string name2 = name1;
        //name2 = "Cavid";
        //Console.WriteLine(name1);
        //Console.WriteLine(name2);

        //string name1 = "qoshqar";
        //CheckStr(out name1);
        //Console.WriteLine(name1);
        //CheckStr(name1);
        //Console.WriteLine(name1);

        //string name1 = new string("lale");
        //Console.WriteLine(name1);

        //Boolean IsMarried = new Boolean(); 
        //string name = "Hello Ramil";
        //name = String.Empty;
        //Console.WriteLine(name.Trim());
        //Console.WriteLine(name);
        //if (name.EndsWith("il"))
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");
        //}
        //name.ToLower();
        //if(name.ToLower().StartsWith("R")) ;
        //Console.WriteLine(name.ToLower());
        //Console.WriteLine(name.LastIndexOf("a"));
        //Console.WriteLine(name.Replace("Ramil","Resul"));
        //Console.WriteLine(name.Remove(4));
        //Console.WriteLine(name.Substring(3));

        //var result = name.ToCharArray();
        //Console.WriteLine(result);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //string text = null;
        //if (string.IsNullOrEmpty(text))
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //Console.WriteLine("no");




        //public static void CheckStr(out string str)
        //{
        //    str = "mahir";

        //    Console.WriteLine(str);
        //}
        //public static void ShowNum(out int num)
        //{ 
        //   num = 100;
        //num += 2;
        //    Console.WriteLine(num);
        //}

        #endregion


    }
}
