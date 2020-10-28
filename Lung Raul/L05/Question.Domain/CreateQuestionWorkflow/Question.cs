using CSharp.Choices;
using LanguageExt.Common;
using Question.Domain.CreateQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class Question
    {
        public interface Question1 { }

        public class GoodQuestion : QueText
        {
            public string Question { get; private set; }
            public List<string> Tags { get; private set; }
            private GoodQuestion(string question, List<string> tags)
            {
                Question = question;
                Tags = tags;
            }

            public static Result<GoodQuestion> Create(string question, List<string> tags)
            {
                if (IsQuestionTextValid(question) && IsTagsValid(tags))
                {
                    return new GoodQuestion(question, tags);
                }
                else if (!IsQuestionTextValid(question))
                {
                    return new Result<GoodQuestion>(new InvalidQuestion(question));
                }
                else 
                {
                    return new Result<GoodQuestion>(new InvalidTags(tags));
                }
            }

            public static bool QuestionText(string question)
            {
                if (question.Length <= 1000)
                {
                    return true;
                } 
                else
                {
                return false;
                }
            }

            public static bool TagsNumbber(List<string> tags)
            {
                if (tags.Count>=1 && tags.Count<=3)
                {
                    return true;
                }
                else
               {
                return false;
               }
            }
        }
        
        public class GoodQuestionOk :  QueText
        {
            public string Question { get; private set; }
            public List<string> Tags { get; private set; }

            internal GoodQuestionOk(string question, List<string> tags)
            {
                Question = question;
                Tags = tags;
            }
        }
    }
}