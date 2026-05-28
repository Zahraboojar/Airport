using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Share
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public static OperationResult Success(string message = "")
        {
            return new OperationResult
            {
                IsSuccess = true,
                Message = message
            };
        }

        public static OperationResult Failed(string message)
        {
            return new OperationResult
            {
                IsSuccess = false,
                Message = message
            };
        }

        public static OperationResult Failed(object unCurrectEmail)
        {
            throw new NotImplementedException();
        }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }

        public static OperationResult<T> Success(T data, string message = "")
        {
            return new OperationResult<T>
            {
                IsSuccess = true,
                Data = data,
                Message = message
            };
        }
        public static OperationResult<T> Failed(string message, T defaultData = default)
        {
            return new OperationResult<T>
            {
                IsSuccess = false,
                Message = message,
                Data = defaultData
            };
        }
    }
}
