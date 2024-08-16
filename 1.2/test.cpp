# include <iostream>
# include <stdio.h>
# include <time.h>
# include <math.h>
using namespace std;
int main()
{
	int n,m,t;
	do
	{
		cout<<"enter integer lenth n,m of array B from [2,50]"<<endl;
		fflush(stdin);
		t=scanf("%d",&n);
		if (t==0||n>50||n<2) cout<<"wrong n"<<endl;
		t=scanf("%d",&m);
		if (t==0||m>50||m<2) cout<<"wrong m"<<endl;
	}
	while (n>50||n<2||m>50||m<2);
	int B[n][m];
	char f;
metka:
	cout<<"do you want to input B from the keyboard?('y'-yes, 'n'-no)"<<endl;
	cin>>f;
	switch (f)
	{
		case 'y':
			for (int i=0; i<n; i++)
			{
				for (int j=0; j<m; j++)
				{
					again:
					cout<<"enter B["<<i<<"]["<<j<<"], remember 0<=B["<<i<<"]["<<j<<"]<=200"<<endl;
					cin>>B[i][j];
					if (B[i][j]<0||B[i][j]>200) 
					{
						cout<<"inappropriate value"<<endl;
						goto again;
					}
				}
			}
		break;
		case 'n':
			srand(time(NULL));
			for (int i=0; i<n; i++)
			{
				for (int j=0; j<m; j++)
				{
					B[i][j]=rand()%201;
				}
			}
		break;
		default:
			cout<<"wrong key\n";
			goto metka;
	}
	int A[n];
	for (int i=0; i<n; i++)
	{
		do
		{
			cout<<"enter A["<<i<<"] of vector, remember 0<=A["<<i<<"]<=10\n";
			cin>>A[i];
		}
		while (A[i]>10||A[i]<0);
	}
	cout<<"Array B:\n";
	for (int i=0; i<n; i++)
	{
		for (int j=0; j<m; j++)
		{
			cout<<B[i][j]<<'\t';
		}
		cout<<endl;
	}
	cout<<"Array A:\n";
	for (int i=0; i<n; i++) cout<<A[i]<<'\t';
	cout<<endl;
	for (int i=0; i<n; i++)
	{
		while (A[i]--!=0)
		{
			t=B[i][0];
			for (int j=0; j<m-1; j++)
			{
				B[i][j]=B[i][j+1];
			}
			B[i][m-1]=t;
		}
	}
	cout<<"result:\n";
	for (int i=0; i<n; i++)
	{
		for (int j=0; j<m; j++)
		{
			cout<<B[i][j]<<'\t';
		}
		cout<<endl;
	}
	system("pause");
	return 0;
}