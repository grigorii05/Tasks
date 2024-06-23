import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Task4 {

    public static void main(String[] args) {

        List<Integer> nums = new ArrayList<>();
        try {
        Scanner numbers = new Scanner(new File(args[0]));
        while (numbers.hasNextFloat()) {
            int x = numbers.nextInt();
            nums.add(x);
        }
        numbers.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

        int average = nums.stream().reduce(0, Integer::sum) / nums.size();
        int moves = nums.stream().mapToInt(num -> Math.abs(num - average)).sum();

        System.out.println("Минимальное количество ходов: " + moves);
    }
}
