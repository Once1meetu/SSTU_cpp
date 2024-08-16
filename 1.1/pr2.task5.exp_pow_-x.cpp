#include<iostream>
#include<cmath>

using namespace std;

//exp^-x

int main()
{
	long double x,eps,f=1,s=0;
	int fact=1;
	short i=1;
again:
	system("CLS");
	cout<<"enter x, accurasy eps\n";
	cin>>x>>eps;
	if ((eps<0)||(eps==0)*(x!=0)||x<1)
	{
		cout<<"You want too much, press enter\n";
		system("pause");
		goto again;
	}
	do{
		fact*=i; 
		s=pow((-x),i)/fact;
		f+=s;
		i++;
	}while (abs(s)>eps);
	cout<<"exp^-"<<x<<'='<<f;
	system("pause");
	return 0;
}
