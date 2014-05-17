

#include <iostream>

#include "DigRadSort.h"

int main()
{
	using namespace std;
	using namespace hw4;

	unsigned long int arr1[17] =
	{ 654321, 123456, 765432, 234567, 876543,
	345678, 987654, 456789, 109876, 658901,
	210987, 789012, 321098, 890321, 452109,
	901234, 543210 };

	unsigned long int arr2[20] =
	{ 0x9abc, 0xcba9, 0xabcd, 0xdbca, 0xbcde,
	0xedcb, 0xcdef, 0xfedc, 0xef01, 0x10fe,
	0xf012, 0x210f, 0x1234, 0x4321, 0x2345,
	0x5432, 0x3456, 0x4567, 0x7654, 0x5678 };

	DigRadSort drs1(arr1, 17, 5, 10);
	DigRadSort drs2(arr2, 20, 3, 16);


	DigRadSort drs3 = DigRadSort(arr2, 20, 3, 16);
	drs3 = move(drs2);

	cout << "drs1 = " << endl;
	print(drs1);

	drs1 = drs2;
	cout << "drs2 = " << endl;
	print(drs1);

	cout << "drs2 = " << endl;

	int i, j;
	for (i = 0; i < 16; i++)
	{
		printf("digit: %x:  ", i);
		for (j = 0; j < drs2.getiSize(i); j++)
			printf("  %lx ", drs2.getij(i, j));
		printf("\n");

	} // for

	cin >> i;
} // main
