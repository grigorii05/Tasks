import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Task2 {

    public static void main(String[] args) {
        //TASK2
        if (args.length != 2) {
            System.out.println("Enter circle and dot !");
            System.exit(1);
        }

        float a, b; // Координаты круга
        float R; // Радиус

        try {
            Scanner circle = new Scanner(new File(args[0]));
            a = circle.nextFloat();
            b = circle.nextFloat();
            R = circle.nextFloat();
            circle.close();

            Scanner dot = new Scanner(new File(args[1]));
            while (dot.hasNextFloat()) {
                float x = dot.nextFloat();
                float y = dot.nextFloat();
                if((x - a)* (x - a) + (y - b)* (y - b) == R*R) System.out.println(0);
                if((x - a) * (x - a) + (y - b) * (y - b) < R * R) System.out.println(1);
                if((x - a) * (x - a) + (y - b) * (y - b) > R * R) System.out.println(2);
            }
            dot.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}
