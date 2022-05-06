using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public ServiceResult(bool issc, T data, string msg)
        {
            IsSuccess = issc;
            Data = data;
            Message = msg;
        }
    }
}
