import java.io.*;
import java.rmi.server.SocketSecurityException;
import java.util.*;

public class day17_MoreExceptions {
    /**
     * @param args
     */
    public static void main(String[] args) {
        int n, p, total, amount;
        Scanner scn = new Scanner(System.in);
        amount = scn.nextInt();
        for (int i = 0; i < amount; i++){
            try {
                n = scn.nextInt();
                p = scn.nextInt();
                if (n < 0 || p < 0) throw new RuntimeException();
                System.out.println((int)Math.round(Math.pow(n, p)));
                
            } catch (Exception e) {
                System.out.println("n and p should be non-negative");
            }
        }
    }
}
