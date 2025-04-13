using System.Text;

string message = "Alice";
int age = 30;
Console.WriteLine($"Her name is {message} & age is {age}");



double price = 1245.78956;
string formatted =string.Format("Price is {0:C2}",price);
Console.WriteLine(formatted);

DateTime dateTime = DateTime.Now;
string dateStr = string.Format("Today is {0:ddd,MMM dd yyyy}", dateTime);
Console.WriteLine(dateStr);


//string immutability
string messageStr = "Hi,its me,Mia";
string upperMessage=messageStr.ToUpper();
Console.WriteLine(upperMessage);

//String Builder
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(messageStr);
stringBuilder.Append(" Append new line");
Console.WriteLine(stringBuilder.ToString());
