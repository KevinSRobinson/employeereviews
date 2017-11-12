using Dtos;
using System.Collections.Generic;
using System.Linq;


namespace DtoRepos
{
    public interface IEmployeeDtoRepo
    {
        IEnumerable<EmployeeDto> Get();
        void Create(EmployeeDto employeeDto);
        void Update(EmployeeDto employeeDto);
    }

    public class EmployeeDtoRepo : IEmployeeDtoRepo
    {
        private EmployeeReviews _ctx;

        public EmployeeDtoRepo(EmployeeReviews ctx){
            _ctx = ctx;
        }

        public IEnumerable<EmployeeDto> Get()
        {
            return _ctx.Employees.Select(x => new EmployeeDto() { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName });
        }

        public void Create(EmployeeDto employeeDto)
            {

                var employee = new Employee()
                {
                    Id = employeeDto.Id,
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    Tel = employeeDto.Tel
                };

                _ctx.Employees.Add(employee);
            _ctx.SaveChanges();
            }
       

        public void Update(EmployeeDto employeeDto)
        {
           var employee = _ctx.Employees.FirstOrDefault(x => x.Id == employeeDto.Id);
                        
            employee.FirstName = employeeDto.FirstName;
            employee.LastName = employeeDto.LastName;
            employee.Tel = employeeDto.Tel;
                   
            _ctx.SaveChanges();
        }
    }
}

