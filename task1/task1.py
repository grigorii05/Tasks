import  sys

def findPath(n, m):
    path = [1]
    currnum = 1
    while True:
        for i in range(1, m):
            if currnum < n:
                currnum += 1
            else:
                currnum = 1
        if currnum == 1:
            break
        path.append(currnum)
    return path

def main():
    if len(sys.argv) != 3:
        print("Enter n and m !")
        sys.exit(1)

    result = findPath(int(sys.argv[1]), int(sys.argv[2]))
    for num in result:
        print(num, end="")

if __name__ == "__main__":
    main()