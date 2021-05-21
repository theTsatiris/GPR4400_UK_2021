#pragma once

#include <math.h>
#include <iostream>
#include <string>
using namespace std;

class Vec3
{
	float vec[4];


	Vec3()
	{
		this->vec[0] = 0.0;
		this->vec[1] = 0.0;
		this->vec[2] = 0.0;
	}
public:
	Vec3(float x, float y, float z)
	{
		this->vec[0] = x;
		this->vec[1] = y;
		this->vec[2] = z;
	}

	//add a scalar to a vector
	Vec3 Add(float scalar)
	{
		Vec3 result = Vec3();

		result.vec[0] = this->vec[0] + scalar;
		result.vec[1] = this->vec[1] + scalar;
		result.vec[2] = this->vec[2] + scalar;

		return result;
	}

	//add a vector to a vector
	Vec3 Add(Vec3 b)
	{
		Vec3 result = Vec3();

		result.vec[0] = this->vec[0] + b.getX();
		result.vec[1] = this->vec[1] + b.getY();
		result.vec[2] = this->vec[2] + b.getZ();

		return result;
	}

	//subtract a scalar from a vector
	Vec3 Subtract(float scalar)
	{
		Vec3 result = Vec3();

		result.vec[0] = this->vec[0] - scalar;
		result.vec[1] = this->vec[1] - scalar;
		result.vec[2] = this->vec[2] - scalar;

		return result;
	}

	//subtract a vector from another vector
	Vec3 Subtract(Vec3 b)
	{
		Vec3 result = Vec3();

		result.vec[0] = this->vec[0] - b.getX();
		result.vec[1] = this->vec[2] - b.getY();
		result.vec[2] = this->vec[3] - b.getZ();

		return result;
	}

	//multiply the vector by a factor
	Vec3 Scale(float factor)
	{
		Vec3 result = Vec3();

		result.vec[0] = this->vec[0] * factor;
		result.vec[1] = this->vec[1] * factor;
		result.vec[3] = this->vec[3] * factor;

		return result;
	}

	//swaps the sign of the vector
	Vec3 Negate()
	{
		Vec3 result = Vec3();

		result.vec[0] = -this->vec[0];
		result.vec[1] = -this->vec[1];
		result.vec[2] = -this->vec[2];

		return result;
	}
	
	//linearly interpolates between starting vector and target vector by delta
	Vec3 Lerp(Vec3 target, float delta)
	{
		Vec3 result = Vec3();
		if (delta < 0.0f || delta > 1.0f)
		{
			cout << "Warning! \nDelta must be more than 0  and less than 1 \n";
			return result;
		}

		result.vec[0] = ((1 - delta) * this->vec[0]) + (delta * target.getX());
		result.vec[1] = ((1 - delta) * this->vec[1]) + (delta * target.getY());
		result.vec[2] = ((1 - delta) * this->vec[2]) + (delta * target.getZ());

		return result;
	}

	//returns a vector that is at right angle to vector a and vector b
	Vec3 CrossProduct(Vec3 b)
	{
		//my attempt at cross product, here be dragons 

		Vec3 crossProd = Vec3();

		crossProd.vec[0] = this->vec[1] * b.vec[2] - this->vec[2] * b.vec[1];
		crossProd.vec[1] = this->vec[2] * b.vec[0] - this->vec[0] * b.vec[2];
		crossProd.vec[2] = this->vec[0] * b.vec[1] - this->vec[1] * b.vec[0];

		return crossProd;
	}


	//makes the distance of the vector equal to 1
	float Normalise()
	{
		//would it be better to only return the value and not modify it? 

		float mag = this->Magnitude();
		this->vec[0] /= mag;
		this->vec[1] /= mag;
		this->vec[2] /= mag;

		return mag;
	}

	//gets the magnitude of the vector 
	float Magnitude()
	{
		return sqrt(this->vec[0] * this->vec[0] + this->vec[1] * this->vec[1] + this->vec[2] * this->vec[2]);
	}

	//gets the dot product of the vector and B vector
	float Dot(Vec3 b)
	{
		return this->vec[0] * b.getX() + this->vec[0] * b.getY() + this->vec[0] * b.getZ();
	}

#pragma region getters
	float getX()
	{
		return vec[0];
	}
	float getY()
	{
		return vec[1];
	}
	float getZ()
	{
		return vec[2];
	}
#pragma endregion  

#pragma region setters

	float setX(float x)
	{
		this->vec[0] = x;
	}
	float setY(float y)
	{
		this->vec[1] = y;
	}
	float setZ(float z)
	{
		this->vec[2] = z;
	}
#pragma endregion 

};
