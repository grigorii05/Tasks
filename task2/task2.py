import  sys

def main():
    if len(sys.argv) != 3:
        print("Enter circle and dot !")
        sys.exit(1)

    with open(sys.argv[1], 'r') as circle:
        a, b = map(float, circle.readline().split())
        R = float(circle.readline())

    with open(sys.argv[2], 'r') as dot:
        for line in dot:
            x, y = map(float, line.split())
            if (x - a) ** 2 + (y - b) ** 2 == R ** 2:
                print(0)
            elif (x - a) ** 2 + (y - b) ** 2 < R ** 2:
                print(1)
            elif (x - a) ** 2 + (y - b) ** 2 > R ** 2:
                print(2)


if __name__ == "__main__":
    main()