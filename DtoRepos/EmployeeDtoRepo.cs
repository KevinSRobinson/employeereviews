using Dtos;
using System.Collections.Generic;
using System.Linq;


namespace DtoRepos
{
    public interface IEmployeeDtoRepo
    {
        IEnumerable<EmployeeDto> Get();
    }

    public class EmployeeDtoRepo : IEmployeeDtoRepo
    {
        private EmployeeReviewsContext _ctx;

        public EmployeeDtoRepo(EmployeeReviewsContext ctx){
            _ctx = ctx;
        }

        public IEnumerable<EmployeeDto> Get()
        {
            return _ctx.Employees.Select(x=> new EmployeeDto() { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName});
        }
    }
}
