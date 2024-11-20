#include <iostream>

using namespace std;

#define SIZE 5

template <typename T>
class LinearQueue
{
private:
	int size;
	int rear;
	int front;

	T container[SIZE];
public:
	LinearQueue()
	{
		size = 0;
		rear = 0;
		front = 0;

		for (int i = 0; i < SIZE; i++)
		{
			container[i] = NULL;
		}
	}

	void Push(T data)
	{
		if (rear >= SIZE)
		{
			cout << "Linear Queue Overflow" << endl;
		}
		else
		{
			container[rear++] = data;

			size++;
		}
	}
};

int main()
{
	LinearQueue<int> linearQueue;

	linearQueue.Push(10);
	linearQueue.Push(20);

	return 0;
}
