using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            //Message getter yani set edilemez bir değişkendir.
            //Getter'lar read only'dir ve read only'ler sadece constructor içinde set edilebilir.
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
