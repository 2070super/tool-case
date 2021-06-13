using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个十六进制数：");

            int a = Convert.ToInt32(Console.ReadLine());//输入

            int[] d = new int[100];//创建存放每一位的数组
         
            int i = 0;
            int c = 0;
            while(a!=0)//当a=0时，短除法运行结束
            {
                c = a % 16;//求其余数
                d[i] =c;//将余数存入
                i++;//记录数组使用长度
                a = a / 16;//得出商
            }
            for(int j=i-1;j>=0;j--)
            {
                
                if(d[j]<9)//小于九直接输出，大于9转化为字符
                {
                   Console.Write("{0}",d[j]);
                }
                else
                {  
                    Console.Write("{0}",(char)(d[j] + 65 -10));
                }

            }
            }
        }
    }
