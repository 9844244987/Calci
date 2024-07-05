// See https://aka.ms/new-console-template for more information
using System;
namespace Application
{
    class Calculator{
        static int num1;
        static int num2;
        static int res;
        static int ope;
        public static void Main(string[] args){
            Console.WriteLine("please Enter the First Number");
            num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("please Enter the Second Number");
            num2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("please Enter the Operation need to be performed 1.Add 2.subtract 3.divide 4.modulus");//Enter 1 for addition,2 for subtraction so on
            ope=Int32.Parse(Console.ReadLine());
            switch(ope){
                case 1:
                res=num1 + num2;
                break;
                case 2:
                res=num1 - num2;
                break;
                case 3:
                res=num1 / num2;
                break;
                case 4:
                res=num1 % num2;
                break;
            }
            Console.WriteLine("this is the Final Result");
            Console.WriteLine(res);
       


        }
    }
}
