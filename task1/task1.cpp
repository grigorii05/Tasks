#include <iostream>
#include <string>
#include <vector>

std::vector<int> findPath(int n, int m) {
	std::vector<int> path;
	path.push_back(1);

	int currnum = 1;
	do {
		for (int i = 1; i < m; i++) {
			if (currnum < n) currnum++;
			else currnum = 1;
		}
		if (currnum == 1) break;
		path.push_back(currnum);
	} while (true);

	return path;
}

int main(int argc, char* argv[]) {

	//TASK1
	if (argc != 3) {
		printf("Enter n and m !\n");
		exit(1);
	}

	std::vector<int> result = findPath(std::stoi(argv[1]), std::stoi(argv[2]));

	for (int i = 0; i < result.size(); i++) {
		std::cout << result[i];
	}
	std::cout << std::endl;

	return 0;
}