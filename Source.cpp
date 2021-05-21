#include <iostream>
#include <string>

#include "Header.h"
using namespace std;




int main()
{
	Vec3 aVector = Vec3(2, -3, 4);
	Vec3 bVector = Vec3(1, 2, 5);

	Vec3 sum = aVector.Add(1);
	Vec3 sumB = aVector.Add(bVector);

	Vec3 sumC = aVector.Subtract(bVector);
	Vec3 sumD = bVector.Subtract(aVector);
	Vec3 sumE = bVector.Subtract(3);

	Vec3 mirror = aVector.Negate();

	cout << sum.getX() << ", " << sum.getY() << ", " << sum.getZ() << endl;
	cout << sumB.getX() << ", " << sumB.getY() << ", " << sumB.getZ() << endl;


	cout << sumC.getX() << ", " << sumC.getY() << ", " << sumC.getZ() << endl;
	cout << sumD.getX() << ", " << sumD.getY() << ", " << sumD.getZ() << endl;
	cout << sumE.getX() << ", " << sumE.getY() << ", " << sumE.getZ() << endl;

	cout << mirror.getX() << ", " << mirror.getY() << ", " << mirror.getZ() << endl;


	return 0;
}