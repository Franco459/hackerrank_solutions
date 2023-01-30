import java.io.*;
import java.util.*;

public class SimpleArraySum {
    public static void main(String[] args) throws IOException {
        ArrayList<Integer> ar = new ArrayList<>();
        Scanner scn = new Scanner(System.in);

        int amount = scn.nextInt();
        for (int i = 0; i < amount; i++) {
            ar.add(0, scn.nextInt());
        }
        System.out.println(simpleArraySum(ar));
    }

    public static int simpleArraySum(List<Integer> ar) {
    // Write your code here
        int sum = 0;
        for(int i : ar){
            sum += i;
        }
        return sum;
    }
}

