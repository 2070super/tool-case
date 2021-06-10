
#include<stdio.h>
main()
{printf("请输入一个数字：");
int a,k=0;
scanf("%d",&a);
if(a%3==0) k=k+1;
if(a%7==0) k=k+3;
if(a%9==0) k=k+5;
switch(k)
{case 0:printf("不能被任何数整除");break;
case 1:printf("能被3整除");break;
case 3:printf("能被7整除");break;
case 4:printf("能被9整除");break;
case 5:printf("能被3和7整除");break;
case 6:printf("能被3和9整除");break;
case 9:printf("能被3，7，9整除");break;}
 } 
