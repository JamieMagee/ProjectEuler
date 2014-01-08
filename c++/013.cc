#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>

using namespace std;

int main()
{
  string nums[100];
  ifstream file("assets/013.txt");
  for(int i = 0; i < 100; ++i)
  {  
    file >> nums[i];
    nums[i].resize(11);
  }
  long long sum = 0;
  
  for (int i = 0; i < 100; i++)
  {
    sum += atol(nums[i].c_str());
  }
  cout << sum/1000 << endl;
}