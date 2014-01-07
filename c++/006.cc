#include <iostream>
#include <cmath>

using namespace std;

int main()
{
  int l = 100;
  int sum = l*(l+1)/2;
  int sum_sq = (2*l + 1)*(l + 1)*l/6;
  cout.precision(8);
  cout << pow(sum, 2) - sum_sq << endl;
}