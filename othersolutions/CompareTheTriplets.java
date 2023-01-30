import java.io.*;
import java.util.*;

public class CompareTheTriplets {
    public static void main(String[] args) throws IOException {
        Scanner scn = new Scanner(System.in);
        List<Integer> a = new ArrayList<>();
        List<Integer> b = new ArrayList<>();
        for (int i = 0; i < 3; i++) {
            a.add(scn.nextInt());
        }
        
        for (int i = 0; i < 3; i++) {
            b.add(scn.nextInt());
        }

        System.out.println(compareTriplets(a, b));
    }

    public static List<Integer> compareTriplets(List<Integer> a, List<Integer> b) {
        int countA = 0, countB = 0;
        for (int i = 0; i < a.size(); i++){
            countA += ( a.get(i) > b.get(i)) ? 1 : 0; 
            countB += ( a.get(i) < b.get(i)) ? 1 : 0;
        }
        List<Integer> miLista = new ArrayList<Integer>(Arrays.asList(countA, countB));
        return miLista;
    }

}
