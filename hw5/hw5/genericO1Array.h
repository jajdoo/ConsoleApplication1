
#ifndef _GENERIC_O1_ARRAY_H__
#define _GENERIC_O1_ARRAY_H__

#include "O1Array.h"

namespace hw5
{
	// dec
	template<typename T>
	class GenericO1Array : public O1Array
	{
	public:
		GenericO1Array(int n, T p);
		~GenericO1Array();
		int length();

		T& operator[](int idx);
		const T& operator[](int idx) const;
		
	private:
		T p;
		T* A;
		int n;
	};



	// def
	template<typename T>
	GenericO1Array<T>::GenericO1Array(int n, T p) :
		O1Array(n),
		p(p),
		n(n),
		A(new T[n])
	{
	};
	
	template<typename T>
	GenericO1Array<T>::~GenericO1Array()
	{
		delete[] A;
	};
	
	template<typename T>
	int GenericO1Array<T>::length()
	{
		return n;
	};
	
	template<typename T>
	T& GenericO1Array<T>::operator[](int idx)
	{
		if (!isInitialized(idx))
		{
			initiIndex(idx);
			A[idx] = p;
		}

		return A[idx];
	};
	
	template<typename T>
	const T& GenericO1Array<T>::operator[](int idx) const
	{
		if (isInitialized(idx))
			return A[idx];
		else
			return p;
	};
}




#endif