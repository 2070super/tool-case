#include<stdio.h>
int main()
{
	int a, b, c,d,f;
	scanf("%d %d", &a, &b);
	f = a * b;
	if (a < b)
	{
		c = a;
		a = b;
		b = c;
	}
	
	while(a%b!=0)
	{
		 d= a % b;
		a = b;
		b = d;
	}
	printf("%d", f/b);
}
