#include <iostream>
#include <cmath>

using namespace std;

int main()
{
  long n = 600851475143;
  int factor, lastfactor;
  if (n%2==0)
  {
    lastfactor = 2;
    n /= 2;
    while (n%2==0) n /= 2;
  }
  else
  {
    lastfactor = 1;
    factor = 3;
  }
  while (n>1 && factor <= sqrt(n))
  {
    if (n%factor==0)
    {
      n /= factor;
      lastfactor=factor;
      while (n%factor==0) n /= factor;
    }
    factor += 2;
  }
  cout << (n==1?lastfactor:n) << endl;
}