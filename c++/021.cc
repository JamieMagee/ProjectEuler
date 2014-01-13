#include <iostream>

using namespace std;

int sod(int n)
{
  int sum = 1, p = 2, j;
  while(p * p <= n && n > 1)
  {
    if (!(n % p))
    {
      j = p * p;
      n /= p;
      while (!(n % p))
      {
        j *= p;
        n /= p;
      }
      sum *= j - 1;
      sum /= p - 1;
    }
    p = p == 2 ? 3 : p + 2;
  }
  if (n > 1) sum *= n + 1;
  return sum;
}

int sopd(int n)
{
  return sod(n) - n;
}

int main()
{
  int ans = 0, b;
  for (int a = 2; a < 10000; a++)
  {
    b = sopd(a);
    if (b > a) if (sopd(b) == a) ans += a + b;
  }
  cout << ans << endl;
}