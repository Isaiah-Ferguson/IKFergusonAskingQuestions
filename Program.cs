﻿//Isaiah Keith Ferguson
//10/18/2022
//Asking questions
//Asking the user their name and what time they woke up. must use data validation
//Peer Reviewed by:


Console.Clear();

string answer = "";
bool Troof1 = true;
int NewAnswer = 0;

while(answer != "end"){
Console.WriteLine("Goodmorning, what's your name?");
string response = Console.ReadLine();
Troof1 = Int32.TryParse(response, out NewAnswer);

if (Troof1 == true){ Console.WriteLine("Those are just numbers! don't lie to me!!");}
else
{
Console.WriteLine($"{response}? Wow what a mysterious name!! What time did you wake up?");
string response1 = Console.ReadLine();

Console.WriteLine($"{response1} wow I woke up about 10 minutes after you!");
}
Console.WriteLine("Type End to Terminate the program or press enter to replay.");
answer = Console.ReadLine().ToLower();
}