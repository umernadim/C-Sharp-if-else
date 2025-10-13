// See https://aka.ms/new-console-template for more information

//if-else statement 

//Console.WriteLine("Enter your name");
//var name = Console.ReadLine();
//Console.WriteLine($"My name is {name}");

//Console.WriteLine("Enter your age");
//var age = Convert.ToInt32(Console.ReadLine());
//if(age >= 18)
//{
//    Console.WriteLine("you are eligible to vote");
//}
//else
//{
//    Console.WriteLine("Sorry, You are not eligible to vote");
//}

//conditon 2

Console.WriteLine("Enter your marks");
var marks = Convert.ToInt32(Console.ReadLine());
if (marks >= 80 && marks <= 100){
    Console.WriteLine("Your got A-1");
}
else if(marks >= 70 && marks < 80)
{
    Console.WriteLine("You got A grade");
}
else if (marks >= 60 && marks < 70)
{
    Console.WriteLine("You got B grade");
}
else if (marks >= 50 && marks < 60)
{
    Console.WriteLine("You got C grade");
}
else if (marks >= 40 && marks < 50)
{
    Console.WriteLine("You got D grade");
}
else if (marks < 40)
{
    Console.WriteLine("You got fail");
}
else
{
    Console.WriteLine("Please, enter valid marks");
}



