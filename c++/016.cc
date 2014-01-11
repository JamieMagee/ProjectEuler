#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int main()
{
  string num = to_string((long double)pow(2, 1000));
  int ans = 0, i = 0;
  while (isdigit(num[i])) 
  {
    ans += num[i] - '0';
    i++;
  }
  cout << ans << endl;
}