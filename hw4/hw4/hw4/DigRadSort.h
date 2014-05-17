
#pragma once

#include <vector>
#include <iostream>

namespace hw4
{
	class DigRadSort
	{
	public:
		DigRadSort(unsigned long int arr[], int n, int digit_no, int radix);
		DigRadSort(const DigRadSort& r);
		DigRadSort(const DigRadSort&& r);
		~DigRadSort();

		int getRadix() const;
		int getiSize(int i) const;
		unsigned long int getij(int i, int j) const;

		DigRadSort& operator= (const DigRadSort& r);
		DigRadSort& operator= (const DigRadSort&& r);

	private:
		std::vector<unsigned long int>* radixSlots; 
		int radix;
	};

	std::ostream& operator<< (std::ostream& stream, DigRadSort& r);
	void print(DigRadSort& r);
}