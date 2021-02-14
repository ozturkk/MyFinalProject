using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)//successi kapsamış oldu.Constractırın kendi içinde çalışmasına örnek
        {
            Message = message;//getter lar ctor içinde set edilebilirler. çünkü getterler readonlydir.
            
        }
        //Success set eder
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
