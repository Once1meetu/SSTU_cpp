#include <iostream>
#include <conio.h>
#include <cmath>

using namespace std;

//ln(x)

int main()
{
	double n,h;
n_enter:
	cout<<"enter N\n";
	cin>>n;
	if (n<=1) {cout<<"wrong n\n"; goto n_enter;}
h_enter:
	cout<<"enter h,  0.1<=h<=0.001\n";
	cin>>h;
	if ((h>0.1)||(h<0.001)) {cout<<"wrong h\n"; goto h_enter;}
	for (register double i=1;i<=n;i+=h)
	{
		cout<<"ln(";cout<<i<<")="<<log(i)<<'\n';
	}
	return 0;
}