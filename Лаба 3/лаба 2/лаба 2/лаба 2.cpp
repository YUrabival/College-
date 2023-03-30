#include <iostream>
using namespace std;

class goods
{
	string name;
	static float persent;
	float price;
public:
	goods()
	{
		name = "Null";
		price = 0;
	}
	void input()
	{

		cout << "print name - ";
		cin >> name;
		cout << "print prise - ";
		cin >> price;
		price+= price*persent;
	}
	void output()
	{
		cout << "name "<< name << " with persent " << price << endl;
	}
	~goods()
	{
		cout << "delete"<< endl;
	}
};
float goods::persent = 0.50;
int main()
{
	goods x;
	x.input();
	x.output();
}


