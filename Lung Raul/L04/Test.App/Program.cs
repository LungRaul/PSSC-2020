using Question.Domain.CreateQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Net;
using static Question.Domain.CreateQuestionWorkflow.CreateQuestionResult;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = new CreateQuestionCmd("Question","This is a question","c++");
            var result = CreateQuestion(cmd);

            result.Match(
                    ProcessQuestionCreated,
                    ProcessQuestioFailed,
                    ProcessInvalidQuestion
                );

            Console.ReadLine();
        }


        private static ICreateQuestionResult ProcessInvalidQuestion(QuestionValidationFailed validationErrors)
         {
            Console.WriteLine("Question validation failed: ");
            foreach (var error in validationErrors.ValidationErrors)
             {
                Console.WriteLine(error);
             }
             return validationErrors;
         }
            
       private static ICreateQuestionResult ProcessQuestionFailed(QuestionFailed questionFaild)
        {
            Console.WriteLine($"Question not posted: {questionFaild.Fail}");
            return questionFaild;
        }
       private static ICreateQuestionResult ProcessQuestionCreated(QuestionCreated quefileTi)
        {
            Console.WriteLine($"Question {quefileTi.QuefileTi}");
            return quefileTi;
        }
       public static ICreateQuestionResult QuestionCreated(CreateQuestionCmd createQuestionCommand)
        {
            if (string.IsNullOrWhiteSpace(createQuestionCommand.Title))
            {
                var errors = new List<string>() { "Invlaid Title" };
                return new QuestionValidationFailed(errors);
            }

            var result = new QuestionCreated(quefileTi, createQuestionCommand.Title);

            //execute logic
            return result;
        }
    }
}

