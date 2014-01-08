#include <iostream>
#include <cmath>

using namespace std;

int gcd(int a, int b)
{
  return b ? gcd(b, a % b) : a;
}

int main()
{
  int s = 1000 / 2;
  int limit = ceil(sqrt(s))-1;
  int a, b, c, si, k;
  
  for (int i = 2; i < limit; i++)
  {
    if (!(s % i))
    {
      si = s / i;
      while (!(si % 2)) si /= 2;
      k = (i % 2) ? i + 2 : i + 1;
      while (k < 2*i && k <= si)
      {
        if (!(si % k) && gcd(k,i) == 1)
        {
          int d = s / (k*i);
          int n = k-i;
          a = d*(i*i-n*n);
          b = 2*d*i*n;
          c = d*(i*i+n*n);
        }
        k += 2;
      }
    }
  }
  cout << a*b*c << endl;
}
