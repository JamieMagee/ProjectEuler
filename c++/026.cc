#include <iostream>

using namespace std;

int cycle(int n)
{
  int length = 1;
  int remainder = 10 % n;
  
  while (remainder != 1)
  {
    remainder = remainder * 10 % n;
    length++;
  }
  return length;
}


int main()
{
  int length = 0, ans;
  
  for (int i = 999; i > 2; i-=2)
  {
    if (i % 5)
    {
      if (cycle(i) > length)
      {
        ans = i;
        length = cycle(i);
      }
    }
  }
    
  cout << ans << endl;
}