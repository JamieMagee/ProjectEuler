#include <iostream>
#include <vector>
#include <numeric>

using namespace std;

int main()
{
  vector<int> fib;
  
  int a = 1, b = 1, c = 0;
  
  while (c <= 4000000)
  {
    c = a + b;
    if (c%2==0) fib.push_back(c);
    a = b;
    b = c;
  }
  
  int sum = accumulate(fib.begin(), fib.end(), 0);
  
  cout << sum << endl;
  
}