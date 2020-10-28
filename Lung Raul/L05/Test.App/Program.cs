using Question.Domain.CreateNewQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Net;
using LanguageExt;
using static Question.Domain.CreateNewQuestionWorkflow.CreateNewQuestionResult;
using static Question.Domain.CreateNewQuestionWorkflow.Question;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var questionResult = UnverQuestion.Create("Yes", new List<string>() {"yes1","yes2"});


            questionResult.Match(
                    Succ: question =>
                    {
                        VoteQuestion(question);
                        Console.WriteLine("good to vote ");
                        return Unit.Default;
                    },
                    Fail: ex =>
                    {
                        Console.WriteLine($"Error. Reason: {ex.Message}");
                        return Unit.Default;
                    }
                );
            Console.ReadLine();
        }
        private static void VoteQuestion(UnverQuestion question)
        {
            var Question5 = new VerQuestion().V1Question(question);
           Question5.Match(
                    QuestionVote=>
                    {
                        new VoteQuestion().SendPermisiuneToVote(QuestionVote);
                        return Unit.Default;
                    },
                    ex =>
                    {
                        Console.WriteLine("Can t Vote Question");
                        return Unit.Default;
                    }
                );
        }

    }
}