
Console.WriteLine("\n\n Welcome To the Store \n");

int totalPrice = 0;
string selected = "";   
int unitPrice = 0;

Console.WriteLine(" Id  Item                        Unit Price \n"+

                  "\n"+
                  "GRAINS \n" + 
                
                  " 1   Rice                         Rs.150 \n" +
                  " 2   Corn                         Rs.230 \n" +
                  " 3   Oats                         Rs.180 \n" +
                  " 4   Barley                       Rs.150 \n" +
                  " 5   Wheat                        Rs.100 \n" +

                  "\n"+
                  "Fresh Produce \n" + 
                
                  " 6   Apples                       Rs.70 \n" +
                  " 7   Bananas                      Rs.150 \n" +
                  " 8   Avocados                     Rs.50 \n" +
                  " 9   Carrots                      Rs.60 \n" +
                  " 10  Broccoli                     Rs.70 \n" +
                  " 11  Potatoes                     Rs.90 \n" +
                  " 12  Tomatoes                     Rs.100 \n" +

                  "\n"+
                  "MEAT/PROTEIN \n" + 
                
                  " 13  Chicken                      Rs.1500 \n" +
                  " 14  Fish                         Rs.350 \n");
                                                              
do{

  Console.Write("Please enter the id of the food -> "); 
  selected = Console.ReadLine().ToLower();
          
  switch(selected){
      
    case "1":          
      unitPrice = 150;
      totalPrice = totalPrice + unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
      break;
    
    case "2":
      unitPrice = 230;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
      break;
    
    case "3":
      unitPrice = 180;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
      break;
      
    case "4":
      unitPrice = 150;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
    break;
    
    case "5":
      unitPrice = 100;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
      break;
      
    case "6":
      unitPrice = 70;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." + totalPrice);
      break;
      
    case "7":
      unitPrice = 150;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "8":
      unitPrice = 50;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "9":
      unitPrice = 60;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "10":
      unitPrice = 70;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "11":
      unitPrice = 90;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "12":
      unitPrice = 100;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);         
      break;
      
    case "13":
      unitPrice = 1500;
      totalPrice = totalPrice +unitPrice;
      Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
      Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;
      
    case "14":
        unitPrice = 350;
        totalPrice = totalPrice +unitPrice;
        Console.WriteLine("Added, write \'exit\' to End \'clear\' to clear the cart");
        Console.WriteLine("Total: " + "Rs." +  totalPrice);
      break;  
      
    case "exit":
      break;
    
    case "clear":
      totalPrice = 0;
      Console.WriteLine("Cleared the cart, Add again -> Rs." + totalPrice);
      break;             
    
    default:
      Console.WriteLine("Wrong choice, choose again");
      break;
                
  }
} while(selected != "exit");

Console.WriteLine("Your Total Amount : " + "Rs." + totalPrice);
Console.WriteLine("Thank you for purchasing");


