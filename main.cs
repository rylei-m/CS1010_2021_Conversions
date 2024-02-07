using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("hey");

    //string (any text)
    //int (a whole number)
    //doubnle (a number w/ decimal)
    //boolean (true or false)

    Console.WriteLine("How much Money: ");
    string sMoney = Console.ReadLine();

    //Console.WriteLine("Wallet + 5: " + sMoney +5);

    double money = Convert.ToDouble(sMoney);

    money += 5;
    Console.WriteLine("With 5 extra, you have " + money);

    string sHealth = "25";
    int health = Convert.ToInt32(sHealth);
  }
}