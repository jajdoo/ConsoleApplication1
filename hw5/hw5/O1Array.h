
#ifndef _O1_ARRAY_H__
#define _O1_ARRAY_H__

namespace hw5
{

	class O1Array
	{
	public:
		O1Array(int n);
		~O1Array();

	protected:
		void initiIndex(int i);
		bool isInitialized(int i);

	private:
		int* B;
		int* C;
		int top;
	};
}

#endif