using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Bu constructor turunde aynı anda 2 parametre gönderirsen alttakini de çalıştırır.
        public Result(bool success, string message):this(success)
        {
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
