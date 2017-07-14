using System;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question.Ask("SOLID it is?");

            var handle = new SeniorProgrammerHandle(new MiddleProgrammerHandle());
            handle.GiveAnswerToQuestion();

            Console.ReadKey();
        }
    }
}