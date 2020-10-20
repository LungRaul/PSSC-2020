using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Profile.Domain.CreateProfileWorkflow
{
    public struct CreateProfileCmd
    {
        [Required]
        public string Titlu { get; private set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; private set; }
        [Required]
        [EmailAddress]
        public List<string> Tags { get; private set; }

        public CreateQuestionCmd(string titu, string body, List<string> tags)
        {
            Titlu=titlu;
            Body = body;
            Tags = tags;
        }
    }
}
