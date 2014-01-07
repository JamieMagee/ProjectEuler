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
    if (i%11==0) 
    {
      j = 999;
      k = 1;
    }
    else
    {
      j = 990;
      k = 11;
    }
    for (j; j >= i; j-=k)
    {
      if (i*j <= largest) break;
      if (palindrome(i*j)) largest = i*j;
    }
  }
  cout << largest << endl;
}