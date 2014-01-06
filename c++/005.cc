#include <iostream>
#include <cmath>
#include <vector>

using namespace std;

int main()
{
  int k = 20, i = 0;
  unsigned long long n = 1;
  vector<int> p = { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, a(p.size(), 1);
  bool check = true;
  
  while (p.at(i) <= k)
  {
    if (check)
    {
      if (p.at(i) <= sqrt(k))
      {
        a.at(i) = (floor(log(k)/log(p.at(i))));
      }
      else check = false;
    }
    n *= pow(p.at(i), a.at(i));
    i++;
  }
  cout << n << endl;
}
