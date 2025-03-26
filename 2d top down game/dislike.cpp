#include<iostream>
using namespace std;
int main()
{
    int t = 1;
    cin >> t;
    int k;
    while(t--)
    {cin >> k;
        
        while(1)
        {
           if(k %10 != 3 && k % 3 !=0)
           {
                cout << k << "\n";
                break;
           }
           
           k++;
        }
    }
}