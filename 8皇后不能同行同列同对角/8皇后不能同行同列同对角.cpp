#include<stdio.h>
#include<math.h>
long int a[8]; 
int panding()
{ int f,i,j;
f = 1;
    for ( i=1; i<=7; i++ )
    {
        for ( j=i+1; j<=8; j++ )
        {
            if ( abs(a[j]-a[i]) == j-i)
            {
                f = 0;
                break;
            }
        }
    }

    return f;
}

main()
{ long int j,i,k,b,c[9]={0},d,e,n;
for( i=12345678; i<=87654321; i++ )
{ b=i;
for(j=0;j<9;j++)
{c[j]=0;
}
for(j=0;j<8;j++)
 {
 k=pow(10,7-j);
 a[j]=b/k;
  e=a[j];
  c[e]++;
  b=b%k;
 }
  if(c[0]==0&&c[1]==1&&c[2]==1&&c[3]==1&&c[4]==1&&c[5]==1&&c[6]==1&&c[7]==1&&c[8]==1)
  { n=panding();
  if(n==1)
  {for(j=0;j<8;j++)
  {printf("ги%d,%d),",j+1,a[j]);
  }
  printf("\n");
  }
}
  else
  {continue;
  }}} 
 
