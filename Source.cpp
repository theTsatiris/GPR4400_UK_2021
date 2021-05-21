#include <iostream>
#include <string>
#include "Header.h"

using namespace std;




int main()
{
	Vec3 aVector = Vec3(2, 5, 6);
	Vec3 bVector = Vec3(-4, 1, 2);

	//Vec3 sum = aVector.Add(1);
	//Vec3 sumB = aVector.Add(bVector);

	//Vec3 sumC = aVector.Subtract(bVector);
	//Vec3 sumD = bVector.Subtract(aVector);
	//Vec3 sumE = bVector.Subtract(3);

	//Vec3 mirror = aVector.Negate();

	//cout << sum.getX() << ", " << sum.getY() << ", " << sum.getZ() << endl;
	//cout << sumB.getX() << ", " << sumB.getY() << ", " << sumB.getZ() << endl;


	//cout << sumC.getX() << ", " << sumC.getY() << ", " << sumC.getZ() << endl;
	//cout << sumD.getX() << ", " << sumD.getY() << ", " << sumD.getZ() << endl;
	//cout << sumE.getX() << ", " << sumE.getY() << ", " << sumE.getZ() << endl;

	//cout << mirror.getX() << ", " << mirror.getY() << ", " << mirror.getZ() << endl;

	//for (float delta = 0.1f; delta <= 1.0f; delta += 0.1f)
	//{
	//	Vec3 lerp = aVector.Lerp(bVector, delta);

	//	cout << lerp.getX() << ", " << lerp.getY() << ", " << lerp.getZ() << endl;
	//}

	//aVector.Normalise();

	//cout << aVector.getX() << ", " << aVector.getY() << ", " << aVector.getZ() << endl;

	//cout << aVector.Dot(bVector) / (aVector.Magnitude() * bVector.Magnitude());


	cout << aVector.CrossProduct(bVector).getX() << ", " << aVector.CrossProduct(bVector).getY() << ", " << aVector.CrossProduct(bVector).getZ() << endl;




	return 0;
}
