using Microsoft.AspNetCore.Http;
using MISA.AMISDemo.Core.Entities;
using MISA.AMISDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Core.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public object ImportService(IFormFile excelFile)
        {
            throw new NotImplementedException();
        }

        public object InsertService(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
