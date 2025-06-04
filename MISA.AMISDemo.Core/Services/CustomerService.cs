using MISA.AMISDemo.Core.DTOs;
using MISA.AMISDemo.Core.Entities;
using MISA.AMISDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Core.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            
        }
        public MISAServiceResult InsertService(Customer entity)
        {   // Xứ lý nghiệp vụ:
            //... Check Email ...
            //Check mã khách hàng đã tồn tại hay chưa?
            //Sau khi đã hợp lệ thì thêm mới vào database
            var res = _customerRepository.Insert(entity);
            return new MISAServiceResult
            {
                Success = true,
                Data = res,
            };
        }
    }
}
