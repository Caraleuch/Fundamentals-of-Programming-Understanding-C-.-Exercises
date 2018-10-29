using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsOfProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Hey, give me first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Thanks, now give me second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The result of adding {0} and {1} is {2}",
                firstNum, secondNum, (firstNum + secondNum));

            //Exercise 2
            Console.WriteLine("What is the lenght of your room?");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your room?");
            int width = int.Parse(Console.ReadLine());
            const int priceCarpetingPerSqareFoot = 22;
            int result = priceCarpetingPerSqareFoot * lenght * width;
            Console.WriteLine("It will cost {0} $", result);

            //Exercise 3
            Console.WriteLine("This is simple calculator. Give me amount of minutes.");
            int givenMinutes = int.Parse(Console.ReadLine());
            int numOfHours = givenMinutes / 60;
            int numOfMinutes = givenMinutes % 60;
            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes",
                givenMinutes, numOfHours, numOfMinutes);

            //Exercise 4 if-else
            Console.WriteLine("Give me hourly pay rate");
            double hourlyPayRate = double.Parse(Console.ReadLine());
            if (hourlyPayRate < 7.50 || hourlyPayRate > 49.00)
            {
                Console.WriteLine("Sorry, something is wrong");
            }
            else
            {
                Console.WriteLine("Ëverything is fine");
            }

            //5: Lawn-mowing service
            Console.WriteLine("What is the length of your yard?");
            double lengthLawn = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of your yard?");
            double widthLawn = double.Parse(Console.ReadLine());
            double squareFeet = lengthLawn * widthLawn;
            double priceWeek;
            if (squareFeet < 400)
            {
                priceWeek = 25;
            }
            else if (lengthLawn * widthLawn >= 400 && lengthLawn * widthLawn < 600)
            {
                priceWeek = 35;
            }
            else
            {
                priceWeek = 50;
            }
            Console.WriteLine("Your weekly fee is {0} and total fee will be {1}", priceWeek, priceWeek * 20);

            //6: Guess a number
            Random randomGenerator = new Random();
            int myRandom = randomGenerator.Next(1, 11);
            Console.WriteLine("Guess a number between 1 and 10.");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine("The random nymber was {0}", myRandom);
            if (guess == myRandom)
            {
                Console.WriteLine("Wow, you guessed correctly");
            }
            else if (guess < myRandom)
            {
                Console.WriteLine("Sorry, you were too low...");
            }
            else
            {
                Console.WriteLine("Sorry, you guessed too high");
            }

            //Exercise 7
            double payRate;
            do
            {
                Console.WriteLine("What is an hourly pay rate?");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);
            Console.WriteLine("The valid pay rate is between 5.65 and 49.99.");
            Console.WriteLine("Your rate was {0}", payRate);

            //8: Sums the integers
            int total = 0;
            int x;
            for (x = 1; x < 51; x++)
            {
                total += x;
            }
            Console.WriteLine("The sum of numbers from 1 to 50 is {0}", total);

            //9: Random 1-10 LOOP
            Random randomGen = new Random();
            int happyRandom = randomGen.Next(1, 11);
            int happyGuess;
            int amount = 1;
            do
            {
                Console.WriteLine("Ok, guess the number between 1 and 10");
                happyGuess = int.Parse(Console.ReadLine());
                if (happyGuess < happyRandom)
                {
                    Console.WriteLine("Sorry, too low");
                }
                else if (happyGuess > happyRandom)
                {
                    Console.WriteLine("Sorry, too high");
                }
                amount++;
            } while (happyGuess != happyRandom);
            Console.WriteLine("Yea, the number was {0}, you tried {1} times",
                happyRandom, amount);

            //10: Package Delivery Service
            string[] packages = new string[6] { "1111", "2323", "2324", "7523", "1234", "9999" };
            Console.WriteLine("Hello, what is your package zipcode?");
            string user = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < packages.Length; i++)
            {
                if (user == packages[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Yea, we have it");
            }
            else
            {
                Console.WriteLine("Sorry, its not in our database");
            }
            Console.ReadLine();

            //11: Students
            Console.WriteLine("Hello, teacher. How many students do you have?");
            int amountStudents = int.Parse(Console.ReadLine());

            double highestGrade = 0;
            double averageGrade = 0;
            string highestGradeName = "";

            string[] students = new string[amountStudents];
            double[] grades = new double[amountStudents];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("What is the name of the {0} student?", i + 1);
                students[i] = Console.ReadLine();
                Console.WriteLine("What is the grade of the {0} student?", i + 1);
                grades[i] = int.Parse(Console.ReadLine());
                averageGrade += grades[i];
                if (grades[i] > highestGrade)
                {
                    highestGrade = grades[i];
                    highestGradeName = students[i];
                }
            }
            averageGrade /= amountStudents;
            Console.WriteLine("The average of students grade is {0}", averageGrade);
            Console.WriteLine("The highest grade was {0} of a {1}", highestGrade, highestGradeName);
            Console.ReadLine();

            //12: Hangman?
            string[] database = new string[20]
            {
                "bonbons", "lovesick", "flirt", "cute", "soulmate", "crush", "serenade", "admire", "romantic", "darling",
                "eternal", "dreamboy", "whisper", "honeybun", "everlasting", "beloved", "bewitched", "handsome", "romance", "special"
            };
            Random randomGen2 = new Random();
            int randomizer = randomGen2.Next(0, database.Length);
            string pickedWord = database[randomizer];
            string displayedWord = "";
            for (int i = 0; i < pickedWord.Length; i++)
            {
                displayedWord += "_";
            }
            Console.WriteLine(pickedWord);
            int round = 1;
            int mistake = 0;
            int possibleMistakes = 10;
            string usedLetters = "";
            char key = '1';

            Console.WriteLine("Hello in my Hangman");
            while (mistake < possibleMistakes && displayedWord != pickedWord)
            {
                Console.WriteLine("This is your {0} round, you still can make {1} mistakes.", round, possibleMistakes - mistake);
                Console.WriteLine();
                for (int i = 0; i < displayedWord.Length; i++)
                {
                    Console.Write("{0} ", displayedWord[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" If you want to guess a word, type {0}", key);
                Console.WriteLine();
                char guessedLetter = char.Parse(Console.ReadLine());
                if (guessedLetter == key)
                {
                    Console.WriteLine("Ok, guess the word:");
                    string yourTry = Console.ReadLine();
                    if (yourTry == pickedWord)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Oh, wow, you did it");
                        displayedWord = yourTry;
                    }
                    else
                    {
                        Console.WriteLine("God, not good");
                        mistake++;
                    }
                }
                if (pickedWord.Contains(guessedLetter))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yay, you guessed one letter");
                    usedLetters += guessedLetter;
                    for (int i = 0; i < pickedWord.Length; i++)
                    {
                        if (pickedWord[i] == guessedLetter)
                        {
                            displayedWord = displayedWord.Remove(i, 1);
                            displayedWord = displayedWord.Insert(i, guessedLetter.ToString());
                        }
                    }
                }
                else if (!pickedWord.Contains(guessedLetter) && !(guessedLetter == key))
                {
                    usedLetters += guessedLetter;
                    mistake++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Well, mistake. Keep trying.");
                }
                round++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Used letters: {0}", usedLetters);
                Console.ResetColor();
            }
            if (displayedWord == pickedWord)
            {
                Console.WriteLine("Congrats, you guessed the word correctly. This was {0}", displayedWord);
            }
            else
            {
                Console.WriteLine("It seems that you lost. You guessed only {0}. The actual word was {1}.", displayedWord, pickedWord);
            }

            //13: Multiplication Table
            Console.WriteLine("Type a number to multiplicate it");
            int nummy = int.Parse(Console.ReadLine());
            MultiplicationTable(nummy);

            //14: Square and Cube Method
            Console.WriteLine("Type a num to square it and to give a cube of it");
            int nummy2 = int.Parse(Console.ReadLine());
            int squared = Square(nummy2);
            int cubed = Cube(nummy2);
            Console.WriteLine("Square of it is {0} and cube is {1}", squared, cubed);

            //15: Sum Methode
            Sum(2);
            Sum(2, 3, 4, 4, 5);
            Sum(1, 2, 2, 2, 22222, 4, 5, 6, 66, 7, 777, 7);
            int[] myArray = { 1, 3, 4 };
            Sum(myArray);

            //16: Classes
            Square[] squares = new Square[10];
            for (int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("{0} x {0} = {1}", squares[i].Side, squares[i].Area);
            }

            //17: Taxpayer
            Taxpayer[] taxpayers = new Taxpayer[10];
            for (int i = 0; i < taxpayers.Length; i++)
            {
                taxpayers[i] = new Taxpayer();
                Console.WriteLine("Type SSN for payer #{0}", i + 1);
                taxpayers[i].SocialNumber = Console.ReadLine();
                Console.WriteLine("Type your yearly gross income, payer #{0}", i + 1);
                taxpayers[i].Income = double.Parse(Console.ReadLine());
                Console.WriteLine("The owned tax for payer #{0} is {1}", i + 1, taxpayers[i].TaxOwed);
            }

            //18: Harold's Home Service
            Job j1 = new Job(4, 12, "cleaning house");
            Console.WriteLine("{0},{1},{2},{3}", j1.Description,j1.Time, j1.RatePerHour, j1.Fee);
            Job j2 = new Job(2, 14, "ironing clothes");
            Console.WriteLine("{0},{1},{2},{3}", j2.Description, j2.Time, j2.RatePerHour, j2.Fee);
            Job j3 = j1 + j2;
            Console.WriteLine("{0},{1},{2},{3}", j3.Description, j3.Time, j3.RatePerHour, j3.Fee);



        }
        public static void MultiplicationTable(int number)
        {
            for (int i =1; i <11; i++)
            {
                int multi = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, multi);
            }
        }
        public static int Square(int num)
        {
            return num * num;
        }
        public static int Cube(int num)
        {
            return Square(num) * num;
        }
        public static void Sum (params int[] array)
        {
            int answer = 0;
            for (int i=0; i<array.Length;i++)
            {
                answer += array[i];
            }
            Console.WriteLine("The sum of these numbers is {0}", answer);
        }
    }
}
