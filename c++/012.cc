#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

vector<int> sieve(int x)
{
  vector<bool> sieve(x+1);
  vector<int> primes;

  for (int i = 2; i <= x; i++) sieve[i] = true;

  for (int i = 2; i <= floor(sqrt(x)); i++)
  {
    if (sieve[i])
    {
      for (int j = i*i; j <= x; j+=i)
      {
        sieve[j] = false;
      }
    }
  }

  for (int i = 2; i < sieve.size(); i++)
  {
    if (sieve[i]) primes.push_back(i);
  }
  return primes;
}

int main()
{
  int n = 3, divn = 2, factors = 0, n1, divn1, exp;
  vector<int> primes = sieve(1000);
  
  while (factors < 500)
  {
    n++;
    n1 = n;
    if (!(n1%2)) n1 /= 2;
    divn1 = 1;
    for (int i = 0; i < primes.size() ; i++)
    {
      if (primes[i] * primes[i] > n1)
      {
        divn1 *= 2;
        break;
      }
      exp = 1;
      while (!(n1 % primes[i]))
      {
        exp++;
        n1 /= primes[i];
      }
      if (exp) divn1 *= exp;
      if (n1 == 1) break;
    }
    factors = divn*divn1;
    divn = divn1;
  }
  cout << n*(n-1)/2 << endl; 
}