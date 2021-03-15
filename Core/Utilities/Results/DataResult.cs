using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //DataResult classtan inherit alıyor
        public T Data { get; }
        public DataResult(T data, bool success, string message):base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
    }
}
