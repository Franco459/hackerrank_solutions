import java.io.*;

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        String S = bufferedReader.readLine();

        bufferedReader.close();
        
        exceptionTry(S);
    }
    
    public static void exceptionTry(String S){
        try{
            System.out.println(Integer.parseInt(S));
        }
        catch(NumberFormatException e){
            System.out.println("Bad String");
        }
    }
}