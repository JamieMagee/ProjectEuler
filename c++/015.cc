#include <iostream>

using namespace std;

int main()
{
  long long ans = 1;
  for (int i = 21; i < 41; i++)
  {
    ans *= i;
    ans /= (i - 20);
  }
  cout << ans << endl;
}