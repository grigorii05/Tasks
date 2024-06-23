#include <iostream>
#include <string>
#include <fstream>

int main(int argc, char* argv[]) {

	//TASK2
	if (argc != 3) {
		printf("Enter circle and dot !\n");
		exit(1);
	}

	float a, b; // Координаты центра круга
	float R; // Радиус круга

	std::ifstream circle(argv[1]);
	if (circle.is_open())
	{
		circle >> a >> b;
		circle >> R;
	}
	circle.close();

	std::ifstream dot(argv[2]);
	if (dot.is_open())
	{
		float x, y;
		while (dot >> x >> y)
		{
			if((x - a)* (x - a) + (y - b)* (y - b) == R*R) std::cout << 0 << std::endl;
			if((x - a) * (x - a) + (y - b) * (y - b) < R * R) std::cout << 1 << std::endl;
			if((x - a) * (x - a) + (y - b) * (y - b) > R * R) std::cout << 2 << std::endl;
		}
	}
	dot.close();

	return 0;
}