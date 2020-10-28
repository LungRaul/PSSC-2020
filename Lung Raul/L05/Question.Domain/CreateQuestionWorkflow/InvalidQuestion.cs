using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestion : Exception
    {
        public InvalidQuestion()
        {

        }

        public InvalidQuestion(string que) : base($"Invalid question format.")
        {
        }
    }
}