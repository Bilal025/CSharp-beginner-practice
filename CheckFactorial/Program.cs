  //   bool Yes=true;
  //   bool No=false;  
    
  Console.WriteLine("--Note : Please Enter Positive Value--");
  do

  {
  int f1;

  Console.WriteLine("Enter a Value :"); //Enter value that need to get factorial vlue
  string f=Convert.ToString(Console.ReadLine()); //Converting the Value to String

    if (f=="quit")
    {
      break;
    }
      else
    {    
      f1=Convert.ToInt32(f); //Convert to int
      
    }
    if (f1<0)
      {
        
        Console.WriteLine("--Please read the note and try again--");
      
      }

  int r=1; //the result

  int i =1; //increasing value
  while (i<=f1)

    {
      r=r*i;
      i=i+1;
    }
      
      
      {
    
        Console.WriteLine("Factorial value of {0} is : {1}",f1,r);    //Print the sum of Factorial value   

        }
  //  Console.ReadLine();
  Console.WriteLine("Press Enter to continue or Enter \"quit\" to exit"); //statement
  string str = Console.ReadLine();
  if (str == "quit")
  break;
  // break (No)
  }

  while(true);
