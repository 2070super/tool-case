#include<stdio.h>
main()
{int n=7;
int a[n][n]={0};
int x,y;
int b=1,k=1;
for(y=0;y<n;y++)  //先打印第一行 
{a[0][y]=k;
k++;
}

for(x=1;x<n;x++)
{a[x][n-1]=k;
k++;
}
for(y=n-1;y>0;y--)
{a[n-1][y-1]=k;
k++;
}y=0;x=n-1;
do{do{if(a[x-1][y]!=0)
	break;
	else
	{x--;
	a[x][y]=k;
	k++;
	}}while(b!=0);
	do{if(a[x][y+1]!=0)
	break;
	else
	{y++;
	a[x][y]=k;
	k++;}}while(b!=0);
		do
		{if(a[x+1][y]!=0)
	break;
	else
	{x++;
	a[x][y]=k;
	k++;}}
	while(b!=0);
	do
	{if(a[x][y-1]!=0)
	break;
	else
	{y--;
	a[x][y]=k;
	k++;}}
	while(b!=0);
	if(a[x+1][y]!=0&&a[x-1][y]!=0&&a[x][y-1]!=0&&a[x][y+1]!=0)
	break;	 	 
}while(b!=0);

int i,j;
for(i=0;i<n;i++)
{printf("\n");
for(j=0;j<n;j++)
printf("%3d ",a[i][j]);}
}
