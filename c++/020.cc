#include <iostream>

using namespace std;

int main ()
{
  int carry = 0, ans = 0;
  int digits[158] = { 1 };

  for(int mul = 1; mul <= 100; mul++)
  {
    for(int i = 0; i <= 157; i++)
    {
      digits[i] = (digits[i] * mul) + carry;
      carry = digits[i] / 10;
      digits[i] %= 10;
    }
  }

  for(int i = 0; i <= 157; i++) ans += digits[i];
  
  cout << ans << endl;

}