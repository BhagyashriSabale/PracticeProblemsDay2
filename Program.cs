﻿namespace PracticeProblemDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Practice Problem Day 2");
            Console.WriteLine("Please Choose one program from below list");
            Console.WriteLine("\n1.NumbersEqualorNot\n2.Evenodd\n3.VotingAge\n4.ArithmeticOperations\n5.WeekDaywithWeekdayNumber\n6.Factorial\n7.Powerof2\n8.SumofSquare\n9.ReverseWord\n10.SomOfNaturalNumbers\n11.LargestNumber");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    NumbersEqualorNot number = new NumbersEqualorNot();
                    number.num();
                    break;
                case 2:
                    Evenodd evenodd = new Evenodd();    
                    evenodd.EvenOdd();
                    break;
                case 3:
                    VotingAge3 vote=new VotingAge3();
                    vote.AgeVote();
                    break;
                case 4:
                    ArithmeticOperations operations=new ArithmeticOperations();
                    operations.Operations();
                    break;
                case 5:
                    Weekday weekday=new Weekday();
                    weekday.WeekdayNumber();
                    break;
                case 6:
                    Factorial factorial=new Factorial();
                    factorial.Fact();
                    break;
                case 7:
                    Powerof2 powerof2=new Powerof2();
                    powerof2.Power2();
                    break;
                case 8:
                    SumofSquares sum=new SumofSquares();
                    sum.Squares();
                    break;
                case 9:
                    ReverseWord word=new ReverseWord();
                    word.Reverse();
                    break;
                case 10:
                    SumofnaturalNumbers Sum=new SumofnaturalNumbers();
                    Sum.sumofFirst5NaturalNumbers();
                    break;
                case 11:
                    LargestNum large=new LargestNum();
                    large.LargestNumber();
                    break;

            }
            
        }
    }
}