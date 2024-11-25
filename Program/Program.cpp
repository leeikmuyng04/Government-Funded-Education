#include <iostream>

using namespace std;

class String
{
private:
	int size;
	char * container;

public:
	String()
	{
		size = 0;
		container = nullptr;
	}

	void operator = (const char * word)
	{
		int arraySize = strlen(word) + 1;

		size = strlen(word);

		if (container == nullptr)
		{
			container = new char[arraySize];

			for (int i = 0; i < arraySize; i++)
			{
				container[i] = word[i];
			}
		}
		else
		{
			char * newContainer = new char[arraySize];

			for (int i = 0; i < arraySize; i++)
			{
				newContainer[i] = word[i];
			}

			delete container;

			container = newContainer;
		}


	}

	char operator [ ] (const int & index)
	{
		return container[index];
	}

	int & Size()
	{
		return size;
	}

	~String()
	{
		if (container != nullptr)
		{
			delete [ ] container;
		}
	}

};

int main()
{
	String string;

	string = "Janna";

	for (int i = 0; i < string.Size(); i++)
	{
		cout << string[i];
	}

	cout << endl;

	string = "Bard";

	for (int i = 0; i < string.Size(); i++)
	{
		cout << string[i];
	}

	return 0;
}
