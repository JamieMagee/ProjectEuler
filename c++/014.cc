#include <iostream>

using namespace std;

int main()
{
  int ans, len, longest = 0;
  int collatz[1000000] = {0};
  collatz[1] = 1;
  
  for (long long i = 2; i < 1000000; i++)
  {
    long long num = i;
    len = 0;
    while (num != 1)
    {
      num = num%2 ? 3*num + 1 : num/2;
      len++;
      if(num < 1000000 && collatz[num])
      {
        len += collatz[num];
        break;
      }
    }
    collatz[i] = len;
    if (len > longest)
    {
      ans = i;
      longest = len;
    }
  }
  
  cout << ans << endl;
  
}