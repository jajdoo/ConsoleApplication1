

#include <iostream>
#include <cmath>
#include "DigRadSort.h"


using namespace hw4;

DigRadSort::DigRadSort(unsigned long int arr[], int n, int digit_no, int radix) :
radix(radix)
{
	using namespace std;

	radixSlots = new vector<unsigned long int>[radix];

	for (int i=0 ; i<n ; i++)
	{
		int digit = (arr[i] / (unsigned long int)pow(radix, digit_no - 1)) % radix;
		radixSlots[digit].push_back(arr[i]);
	}
}

DigRadSort::DigRadSort(const DigRadSort& r)
{
	using namespace std;

	radix = r.radix;
	radixSlots = new vector<unsigned long int>[radix];

	for (int i = 0; i < radix; i++)
	{
		radixSlots[i] = r.radixSlots[i];
	}
}

DigRadSort& DigRadSort::operator= (const DigRadSort& r)
{
	using namespace std;

	if (this == &r) return *this;

	if ( radixSlots!=nullptr )
		delete[] radixSlots;
	
	radix = r.radix;
	radixSlots = new vector<unsigned long int>[radix];

	for (int i = 0; i < radix; i++)
	{
		radixSlots[i] = r.radixSlots[i];
	}

	return *this;
}

DigRadSort::~DigRadSort()
{
	delete[] radixSlots;
}


int DigRadSort::getiSize(int i) const
{
	return radixSlots[i].size();
}

unsigned long int DigRadSort::getij(int i, int j) const
{
	return radixSlots[i][j];
}

int DigRadSort::getRadix() const
{
	return radix;
}



std::ostream& operator<< (std::ostream& stream, DigRadSort& r)
{
	int i, j;
	for (i = 0; i < r.getRadix(); i++)
	{
		stream << "digit : " << i << ":";
		for (j = 0; j < r.getiSize(i); j++)
			stream << r.getij(i, j);

		stream << std::endl;
	}

	return stream;
}



void hw4::print(DigRadSort& r)
{
	std::cout << r;
}