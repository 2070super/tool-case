using System;
using System.Diagnostics;
namespace test01
{
    class Program
    {
        public class insertionsorter//插入排序
        {
            public int[] list;
            public void Sort(){
                for(int i=1;i<list.Length;i++)
                {
                    int t=list [i];
                    int j=i;
                    while((j>0)&&(list[j-1]>t))
                    {
                        list[j]=list[j-1];
                        j--;
                    }
                    list[j]=t;
                }
            Console.WriteLine("Insertion done.");
            }
        }
        public class BubbleSorter//冒泡排序
        {
            public int[] list;
            public void Sort()
            {
                int i,j,temp;
                bool done=false;
                j=1;
                while((j<list.Length)&&(!done))
                {
                    done=true;
                    for(i=0;i<list.Length-j;i++)
                    {
                        if(list[i]>list[i+1])
                        {
                            done=false;
                            temp=list[i];
                            list[i]=list[i+1];
                            list[i+1]=temp;
                        }
                    }
                    j++;
                }
          Console.WriteLine("Bubble done");  }
        }
        public class SelectionSorter//选择排序
        {
            private int min;
            public int[] list;
            public void Sort()
            {
                for(int i=0;i<list.Length-1;i++)
                {
                    min=1;
                    for(int j=i+1;j<list.Length;j++)
                    {
                        if(list[i]<list[min])
                        min=j;
                    }
                int t=list[min];
                list[min]=list[i];
                list[i]=t;
                }
            Console.WriteLine("SelectionSorter done"); }
        }
        static void Main(string[] args)
        {
            insertionsorter sorter1=new insertionsorter();
            BubbleSorter sorter2=new BubbleSorter();
            SelectionSorter sorter3=new SelectionSorter();
            int icount=1000;
            Random random=new Random();
            sorter1.list=new int[icount];
            sorter2.list=new int[icount];
            sorter3.list=new int[icount];
            for(int i=0;i<icount;++i)
            {
                sorter1.list[i]=sorter2.list[i]=sorter3.list[i]=random.Next();//随机数组
            }
             Stopwatch stwatch = new Stopwatch();//计时器设置
            stwatch.Start();//计时器开始
            sorter1.Sort();//插入排序开始
            sorter2.Sort();////冒泡排序开始
            sorter3.Sort();//选择排序开始
            stwatch.Stop();//计时器停止
            Console.WriteLine(stwatch.Elapsed.TotalMilliseconds);//输出时间
            Console.ReadKey();//按任意键继续

        }
    }
}
