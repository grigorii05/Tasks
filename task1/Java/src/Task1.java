import java.util.ArrayList;
import java.util.List;

public class Task1 {
    public static List<Integer> findPath(int n, int m) {
        List<Integer> path = new ArrayList<>();
        path.add(1);

        int currnum = 1;
        do {
            for (int i = 1; i < m; i++) {
                if (currnum < n) currnum++;
                else currnum = 1;
            }
            if (currnum == 1) break;
            path.add(currnum);
        } while (true);

        return path;
    }

    public static void main(String[] args) {
        //TASK1
        if (args.length != 2) {
            System.out.println("Enter n and m !");
            System.exit(1);
        }

        List<Integer> result = findPath(Integer.parseInt(args[0]), Integer.parseInt(args[1]));
        for (int i = 0; i < result.size(); i++) {
            System.out.print(result.get(i));
        }
    }
}
