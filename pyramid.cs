using System;

class MainClass {
  public static void Main (string[] args) {
    int i,j;
    for(i = 0; i<=10 ; i++){

      for(j =10; j>i; j--){

        Console.Write(" ");
      }
      for(j =0; j<i; j++){
        Console.Write("* ");
      }
      Console.WriteLine("");
    }
  }
}
