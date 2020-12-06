#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL, "RUS"); // 1251

	char text[] = { 'h','i', '\0' };
	char text2[] = "hello";

	cout << text << endl;
	cout << sizeof(text2) << endl;

	for (int i = 0; i < sizeof(text2); i++)
	{
		cout << text2[i] << " : " << int(text2[i]) << endl;
	}

	system("pause");
}