#include<stdio.h>
#include<math.h>
int main()
{
	int n = 3;
	double t, f = 1.0, sum = 1.0, k, i = 1.0;
	double pi = 0.5;
	for (k = 0; k < 10; k++)
		i = i / 10;
	while (1)
	{
		t = pow(0.5, n);
		
		 f = 1.00000000000000000/n;
		sum = sum * (n - 2) / (n - 1);
		k = f * t * sum;//printf("%f", f);
		if (k >= i)
		{
			pi = pi + k;
			n = n + 2;
		}
		else
			break;
	}
	printf("%.30f", 6*pi);	
	return 0;
}