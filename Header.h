#pragma once


class Vec3
{
	float x;
	float y;
	float z;

	Vec3()
	{
		this->x = 0.0;
		this->y = 0.0;
		this->z = 0.0;
	}
public:
	Vec3(float x, float y, float z)
	{
		this->x = x;
		this->y = y;
		this->z = z;
	}



	//add a scalar to a vector
	Vec3 Add(float scalar)
	{
		Vec3 result = Vec3();

		result.x = this->x + scalar;
		result.y = this->y + scalar;
		result.z = this->z + scalar;

		return result;
	}

	//add a vector to a vector
	Vec3 Add(Vec3 b)
	{
		Vec3 result = Vec3();

		result.x = this->x + b.getX();
		result.y = this->y + b.getY();
		result.z = this->z + b.getZ();

		return result;
	}

	//subtract a scalar from a vector
	Vec3 Subtract(float scalar)
	{
		Vec3 result = Vec3();

		result.x = this->x - scalar;
		result.y = this->y - scalar;
		result.z = this->z - scalar;

		return result;
	}

	//subtract a vector from another vector
	Vec3 Subtract(Vec3 b)
	{
		Vec3 result = Vec3();

		result.x = this->x - b.getX();
		result.y = this->y - b.getY();
		result.z = this->z - b.getZ();

		return result;
	}

	//multiply the vector by a factor
	Vec3 Scale(float factor)
	{
		Vec3 result = Vec3();

		result.x = this->x * factor;
		result.y = this->y * factor;
		result.z = this->z * factor;

		return result;
	}

	Vec3 Negate()
	{
		Vec3 result = Vec3();

		result.x = -this->x;
		result.y = -this->y;
		result.z = -this->z;

		return result;
	}

#pragma region getters
	float getX()
	{
		return x;
	}
	float getY()
	{
		return y;
	}
	float getZ()
	{
		return z;
	}
#pragma endregion  

#pragma region setters

	float setX(float x)
	{
		this->x = x;
	}
	float setY(float y)
	{
		this->y = y;
	}
	float setZ(float z)
	{
		this->z = z;
	}
#pragma endregion 

};