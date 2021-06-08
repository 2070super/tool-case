using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
      public class Bubble/*冒泡排序*/
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
        public class insertion/*插入排序*/
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
        
        public class Selection/*选择排序*/
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
           Console.WriteLine("SelectionSorter done");  }
        }
        static void Main(string[] args)
        {
            insertion sorter1=new insertion();
            Bubble sorter2=new Bubble();
            Selection sorter3=new Selection();
            int size=2000;
            Random random=new Random();
            sorter1.list=new int[size];
            sorter2.list=new int[size];
            sorter3.list=new int[size];
            for(int i=0;i<size;++i)
            {
                sorter1.list[i]=sorter2.list[i]=sorter3.list[i]=random.Next();/*在数组中产生2000个待排序的随机数*/
            }
            Thread thread1 = new Thread(new ThreadStart(sorter1.Sort));/*插入排序线程*/
            Thread thread2 = new Thread(new ThreadStart(sorter2.Sort));/*冒泡排序线程*/
            Thread thread3 = new Thread(new ThreadStart(sorter3.Sort));/*选择排序线程*/
            Stopwatch time = new Stopwatch();/*初始化计时器*/
            time.Start();
            /*多线程开始*/
            thread1.Start();
            thread2.Start();
            thread3.Start();
            while (true)
            {
               if (thread1.ThreadState ==System.Threading.ThreadState.Stopped&&thread2.ThreadState == System.Threading.ThreadState.Stopped&&thread3.ThreadState == System.Threading.ThreadState.Stopped)/*判定各线程结束*/
               {
                   time.Stop();
                   Console.WriteLine(time.Elapsed.TotalMilliseconds);
                   break;
               }
            }
            Console.ReadKey();

            
        }
    }
}
