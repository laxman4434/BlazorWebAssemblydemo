using EmployeeManagement.Shared;
using System.Collections.Generic;

namespace EmployeeManagement.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
