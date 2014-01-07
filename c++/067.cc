#include <iostream>
#include <fstream>

using namespace std;

int main(){
  int ans = 0, m[100][100];
  ifstream file("../assets/067.txt");
  
  for(int i = 0; i < 100; ++i)
  {
    for(int j = 0; j <= i; ++j) 
    {
      file >> m[i][j];
    }
  }
  
  for(int i = 1; i < 100; ++i)
  {  
    for(int j = 0; j <= i; ++j)
    {
      if(!j) m[i][j] += m[i - 1][j];
      else if(j == i) m[i][j] += m[i - 1][j - 1];
      else m[i][j] += max(m[i - 1][j], m[i - 1][j - 1]);
    }
  }
  
  for(int i = 0; i < 100; ++i)
  {
    if(m[99][i] > ans) ans = m[99][i];
  }
  
  cout << ans << endl;  
}