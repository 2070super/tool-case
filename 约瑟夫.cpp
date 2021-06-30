#include<stdio.h>
#include<memory.h>
main() 
{
	int N,data[1000],status[1000];
	memset(data,0,sizeof(data));
	memset(status,0,sizeof(status));
	int i=0;
	scanf("%d",&N);
	while(i<N)
{ 
		scanf("%d",&data[i]);
		i++;
	}
	int T;
	scanf("%d",&T);
	int count = 0;
	int index = -1;
	while(count<N)
	{
		int i=0;
		while(1)
		{
			index = (index+1)%N;
			if(status[index] == 0 )
			{
				i++;
			}
			if(i == T)
			{
				++count;
				status[index] = count;
				T = data[index];
				break;
			}
		}
	}
	for(int i=1;i<=N;i++)
	{
		for(int j=0;j<N;j++)
		if(status[j] == i)
			printf("第%d个出列的是第%d人\n",i,j+1);
	}
	} 


