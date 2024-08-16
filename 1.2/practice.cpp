# include <iostream>
# include <stdio.h>
using namespace std;
int main()
{
	int n,t;
	do
	{
		cout<<"enter integer n lenth of A from [2,20]"<<endl;
		fflush(stdin);
		t=scanf("%d",&n);
		if (t==0||n>20||n<2) cout<<"wrong n"<<endl;
	}
	while (n>20||n<2);
	double A[n];
	for (int i=0; i<n; i++)
	{
		again:
		cout<<"enter A["<<i<<"], remember -2000<=A["<<i<<"]<=2000"<<endl;
		cin>>A[i];
		if (A[i]<-2000||A[i]>2000) 
		{
			cout<<"inappropriate value"<<endl;
			goto again;
		}
	}
	int neg, NEG, pos, POS; neg=NEG=pos=POS=666;
	double C[n], B[n];
	int c,b; c=b=0;//count where to enter
	for (int i=0; i<n; i++)
	{
		if (A[i]<0)
		{
			C[c]=A[i];
			if (c++==0) neg=i;
			NEG=i;
		}
		if (A[i]>0)
		{
			B[b]=A[i];
			if (b++==0) pos=i;
			POS=i;
		}
	}
	cout<<"Array A\t";
	for (int i=0; i<n; i++) cout<<A[i]<<'\t';
	cout<<endl<<"Array B\t";
	for (int i=0; i<b; i++) cout<<B[i]<<'\t';
	cout<<endl<<"Array C\t";
	for (int i=0; i<c; i++) cout<<C[i]<<'\t';
	cout<<endl;
	if (pos!=666)cout<<"the first and the last positive values are A["<<pos<<"] and A["<<POS<<"]\n";
	else cout<<"there are no positive values\n";
	if (neg!=666)cout<<"the first and the last negative values are A["<<neg<<"] and A["<<NEG<<"]\n";
	else cout<<"there are no negative values\n";
	system("pause");
	}