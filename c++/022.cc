#include <iostream>
#include <string>
#include <algorithm>
#include <vector>
#include <fstream>

using namespace std;

int namesum(string s)
{
  int sum = 0;
  for (unsigned int i = 0; i < s.size(); i++) sum += s[i] - '@';
  return sum;
}

int main()
{
  ifstream file("assets/022.txt");
  string curr;
  vector<string> names;
  int ans = 0;
  
  while (getline(file, curr, ',')) names.push_back(curr.substr(1, curr.length()-2));
  sort(names.begin(), names.end());
  for (unsigned int i = 0; i < names.size(); i++) ans += (i+1) * namesum(names[i]);
  cout << ans << endl;
}