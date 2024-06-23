#include <iostream>
#include <vector>
#include <fstream>

int main(int argc, char* argv[]) {

	if (argc != 2) {
		printf("Enter argument !\n");
		exit(1);
	}

	std::vector<int> nums;
	int num;
	std::ifstream numbers(argv[1]);
	if (numbers.is_open())
	{
		while (numbers >> num)
		{
			nums.push_back(num);
		}
	}
	numbers.close();

	int average = 0;
	for (int i = 0; i < nums.size(); i++) {
		average += nums[i];
	}
	average = average / nums.size();

	int moves = 0;
	for (int num : nums) {
		moves += std::abs(num - average);
	}

	std::cout << "Минимальное количество ходов: " << moves << std::endl;

	return 0;
}