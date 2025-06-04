using MISA.AMISDemo.Core.Entities;
using MISA.AMISDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public int Delete(Customer entity)
        {   //Truy cập databse:
            //Xóa hết dữ liệu
            throw new NotImplementedException();
        }

        public int DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            //Truy cập database:
            //Lấy dữ liệu:
            return new List<Customer> { new Customer() {
       
                CustomerId = Guid.NewGuid(),
                CustomerCode = "Kh000333331",
                FullName = "Nguyễn Văn A"
            }
            };
        }

        public int Insert(Customer entity)
        {
            return 1;
        }

        public int Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
