using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //resulta constructor sayesinde döndürdük.
        //consructor 2 değer istiyor
        //get readonlydir ve CONSTRUCTOR'DA SET EDİLEBİLİR.
        public Result(bool success, string message):this(success)
        {
            
            //success'i set etme işini aşağıya verdik
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
