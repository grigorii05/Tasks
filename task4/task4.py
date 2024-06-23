import  sys

def main():

    if len(sys.argv) != 2:
        raise ValueError('Please provide argument')
    
    nums = []
    with open(sys.argv[1], "r") as fp:
        line_list = fp.readlines()
        for line in line_list:
            line = line.rstrip()
            try:
                nums.append(int(line))
            except:
                pass

    average = sum(nums) // len(nums)
    moves = sum(abs(num - average) for num in nums)

    print("Минимальное количество ходов:", moves)

if __name__ == "__main__":
    main()