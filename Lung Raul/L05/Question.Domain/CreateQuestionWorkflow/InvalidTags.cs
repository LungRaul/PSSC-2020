using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidTags : Exception
    {
        public InvalidTags()
        {

        }

        public InvalidTags(List<string> tags) : base($"The maximum value allowed is 3")
        {

        }
    }
}