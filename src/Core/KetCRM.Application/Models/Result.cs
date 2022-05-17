using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Models
{
    public class Result<T>
    {
        public T? Value { get; set; }
        public string? Message { get; set; }
        public bool Succeeded { get; set; }

        internal Result(T value)
        {
            Value = value;
            Succeeded = true;
        }

        internal Result(string message)
        {
            Value = default(T);
            Message = message;
            Succeeded = false;
        }

        public static Result<T> Success(T value)
        {
            return new Result<T>(value);
        }

        public static Result<T> Failure(string errors)
        {
            return new Result<T>(errors);
        }
    }
}
