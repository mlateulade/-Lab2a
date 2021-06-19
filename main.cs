using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Enter the name of the item");//prompt for ItemName
    var ItemName = Console.ReadLine();
    Console.WriteLine("Enter the quantity");
    var Quantity = Console.ReadLine();
    Console.WriteLine("Enter the price");
    var Price = Console.ReadLine();
    
    //convert str value to int 
    int x1 = Convert.ToInt32(Quantity);
    //convert str value to double
    double y1 = Convert.ToDouble(Price);
    
    //multiply x1 and y1
    double z = (x1*y1);
    Console.WriteLine("Total price of " +ItemName +" = $" +z);







   
  }
}