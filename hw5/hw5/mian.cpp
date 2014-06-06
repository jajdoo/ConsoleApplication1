
#include <iostream>
#include "genericO1Array.h"

int main()
{
	using namespace std;
	using namespace hw5;
	int n = 20;
	GenericO1Array<double> darr1(n, 1.1);
	GenericO1Array<long> iarr1(n, 2);
	
	cout << "\nLength.darr1 = " << darr1.length() << endl;
	cout << "\nLength.iarr1 = " << iarr1.length() << endl;

	for (int i = 0; i < n; i += 2)
	{
		darr1[i] = i*10.0;
		iarr1[i] = i * 100;
	} // for

	cout << "\ndarr1 = " << endl;
	for (int i = 0; i < n; i++)
		cout << "darr1[" << i << "] = " << darr1[i] << endl;

	cout << "\niarr1 = " << endl;
	for (int i = 0; i < n; i++)
		cout << "iarr1[" << i << "] = " << iarr1[i] << endl;

	int a;
	cin >> a;
} // main
