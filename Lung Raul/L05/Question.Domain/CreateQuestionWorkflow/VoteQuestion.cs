using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Question.Domain.CreateNewQuestionWorkflow.CreateQuestionResult;
using static Question.Domain.CreateNewQuestionWorkflow.Question;

namespace Question.Domain.CreateNewQuestionWorkflow
{
    public class VoteQuestion
    {
        public Task SendPermisiuneToVote(VQuestion question)
        {
            return Task.CompletedTask;
        }
    }
}