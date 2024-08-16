#include<iostream>
#include<stdlib.h>

using namespace std;

//calculation the blood alcohol content in ppm

int main()
{
	float m, alco_m, alco_p;
	cout<<"enter ur weight\n";
	cin>>m;
	cout<<"enter the amount of alcohol consumed in milliliters\n";
	cin>>alco_m;
	cout<<"enter the percentage of alcohol in the drink\n";
	cin>>alco_p;
	if (alco_p>1) alco_p/=100;
	m*=0.7;//only 70% of our body is water
	alco_m*=alco_p;//amount of ethanol in milliliters
	alco_m*=0.79;//convert milliliters of ethanol to grams
	alco_m*=0.9;//taking into account the absorbation of ethanol into the blood
	cout<<fixed;
	cout.precision(2);
	cout<<"the blood alcohol content is\t"<<alco_m/m<<"\t ppm\n";
	if(alco_m/m<0.16)cout<<"You may drive"; else cout<<"You can't drive";
	return 0;
};