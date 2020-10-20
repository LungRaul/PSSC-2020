using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Choices;

namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class CreateQuestionResult
    {
        public interface ICreateQuestionResult { }

        public class QuestionCreated: ICreateQuestionResult
        {
            public Guid QuefileTi { get; private set; }

            public QuestionCreated(Guid quefileTi, string body)
            {
                QuefileTi = quefileTi;
            }
        }
        public class QuestionFaild: ICreateQuestionResult
         {
           public string Fail { get; set; } 
           public QuestionFaild(string failed)
            {
                Fail = fail;
            }

         }
        public class QuestionValidationFailed: ICreateQuestionResult
         {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
         }

    }

}
