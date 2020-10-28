using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.Question;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class VQuestion
    {
        public Result<V1Question> VQuestion(UnverQuestion question){
            return new GoodQuestion(question.Question,question.Tags);
        }
    }
}