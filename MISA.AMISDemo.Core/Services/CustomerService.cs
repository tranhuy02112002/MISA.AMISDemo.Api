using MISA.AMISDemo.Core.Entities;
using MISA.AMISDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Core.Services
{
    internal class CustomerService : ICustomerService
    {
           ICustomerRepository customerRepository;
        public object InsertService(Customer entity)
        {   // Xứ lý nghiệp vụ:
            //... Check Email ...
            //Check mã khách hàng đã tồn tại hay chưa?
            //Sau khi đã hợp lệ thì thêm mới vào database
            var res = customerRepository.Insert(entity);
            throw new NotImplementedException();
        }
    }
}
