
#include "O1Array.h"

using namespace hw5;

O1Array::O1Array(int n)
{
	B = new int[n];
	C = new int[n];
	top = 0;
};

O1Array::~O1Array()
{
	delete[] B;
	delete[] C;
}

void O1Array::initiIndex(int i)
{
	if (!isInitialized(i))
	{
		C[top] = i;
		B[i] = top;
		top++;
	}
};


bool O1Array::isInitialized(int i)
{
	if (0 <= B[i] && B[i] < top && C[B[i]] == i)
		return true;

	return false;
};
