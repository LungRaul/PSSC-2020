using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Question.Domain.CreateNewQuestionWorkflow.CreateNewQuestionResult;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    class VoteUp
    {
        public QuestionCreated VoteUp1(QuestionCreated question, VoteEnum vote)
        {
            var vot = question.Vot;
            vot.Append(vote);
            return new QuestionCreated(question.QuefileTi, question.Question, vot.Sum(v => Convert.ToInt32(v)), vot);
        }
    }
}