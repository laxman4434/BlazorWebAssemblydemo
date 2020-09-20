using EmployeeManagement.App.Components;
using EmployeeManagement.App.Services;
using EmployeeManagement.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
