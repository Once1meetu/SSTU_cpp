#include<iostream>
#include<cmath>

using namespace std;

//what day of a week?

int main()
{
	int date;
	metka:
	cout<<"what day is in today? 1<=date<=365\n";
	cin>>date;
	if (!((1<=date)*(date<=365))){
	cout<<"mistake, press enter\n";
	system("pause");
	system("CLS");
	goto metka;
	}
	date%=7;
	cout<<"today is\t";
	switch(date)
	{
		case 0:cout<<"sunday";break;
		case 1:cout<<"monday";break;
		case 2:cout<<"tuesday";break;
		case 3:cout<<"wednesday";break;
		case 4:cout<<"thursday";break;
		case 5:cout<<"friday";break;
		case 6:cout<<"saturday";break;
	}
	return 0;
}