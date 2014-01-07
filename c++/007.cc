#include <iostream>
#include <cmath>

using namespace std;

bool prime(int n)
{
  if (n == 1) return false;
  else if (n < 4) return true;
  else if (n % 2 == 0) return false;
  else if (n < 9) return true;
  else if (n% 3 == 0) return false;
  else
  {
    int r = floor(sqrt(n));
    int f = 5;
    for (f; f <= r; f+=6)
    {
      if (n % f == 0) return false;
      if (n % (f + 2) == 0) return false;
    }
  }
  return true;
}

int main() {
  int candidate = 1, i = 1;
  while (i < 10001)
  {
    candidate += 2;
    if (prime(candidate)) i++;
  }
  cout << candidate << endl;
}