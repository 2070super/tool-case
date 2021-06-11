int sumOddLengthSubarrays(int* arr, int arrSize){
int ans=0,b=0;
for(int i=0;i<arrSize;i++)
{   
    b=0;
    if(arr[i]%2!=0)
    {ans=ans+arr[i];}
    b=arr[i];
    
for(int j=i+1;j<arrSize;j++)
{
    b=b+arr[j];
    if(b%2!=0)
    {
        ans=ans+b;
    }
}}
return ans;
}