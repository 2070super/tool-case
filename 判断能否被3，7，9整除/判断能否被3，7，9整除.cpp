
#include<stdio.h>
main()
{printf("������һ�����֣�");
int a,k=0;
scanf("%d",&a);
if(a%3==0) k=k+1;
if(a%7==0) k=k+3;
if(a%9==0) k=k+5;
switch(k)
{case 0:printf("���ܱ��κ�������");break;
case 1:printf("�ܱ�3����");break;
case 3:printf("�ܱ�7����");break;
case 4:printf("�ܱ�9����");break;
case 5:printf("�ܱ�3��7����");break;
case 6:printf("�ܱ�3��9����");break;
case 9:printf("�ܱ�3��7��9����");break;}
 } 
