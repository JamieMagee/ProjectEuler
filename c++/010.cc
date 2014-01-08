#include <iostream>
#include <cmath>

using namespace std;

int main()
{
  int sievelimit = (2000000-1)/2;
  bool sieve[(2000000-1)/2] = { 0 };
  int crosslimit = (floor(sqrt(2000000))-1)/2;
  
  for (int i = 1; i < crosslimit; i++)
  {
    if (!sieve[i])
    {
      for (int j = 2*i*(i+1); j < sievelimit; j+=2*i+1)
      {
        sieve[j] = true;
      }
    }
  }
  long sum = 2;
  for (int i = 1; i < sievelimit; i++) if (!sieve[i]) sum += 2*i+1;
  cout << sum << endl;
}