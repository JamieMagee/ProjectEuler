#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

bool palindrome(long long int a)
{
  string c = to_string(a), b = c;
  reverse(c.begin(), c.end());
  return b == c;
}

int main()
{
  int largest = 0, j, k; 
  
  for (int i = 999; i >= 100; i--)
  {
    j = i % 11 ? 990 : 999;
    k = i % 11 ? 11 : 1;
    for ( ; j >= i; j-=k)
    {
      if (i*j <= largest) break;
      if (palindrome(i*j)) largest = i*j;
    }
  }
  cout << largest << endl;
}
