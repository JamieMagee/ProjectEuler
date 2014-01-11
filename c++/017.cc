#include <iostream>
#include <string>
#include <algorithm>

using namespace std;
    
string word(int n)
{
  string units[20] = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
  string tens[10] = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
  return n < 20 ? units[n] : n >= 20 && n < 100 ? tens[n/10] + " " + units[n%10] : n >= 100 && n < 1000 ? units[n/100] + " Hundred " + ((n%100) ? "and " : "") + word(n%100) : "one thousand";
}

int main()
{
  int ans = 0;
  string num;
  
  for (int i = 1; i <= 1000; i++)
  {
    num = word(i);
    num.erase(remove_if(num.begin(), num.end(), ::isspace), num.end());
    ans += num.length();
  }
  cout << ans << endl;
}