using system;

class Number{

    public static int PrintLastDigit(int number){
        int LastDigit = number % 10;
        return Console.WriteLine(LastDigit);
    }

}