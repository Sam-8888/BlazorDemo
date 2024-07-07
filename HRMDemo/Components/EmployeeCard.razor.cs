using DomainData;
using HRMDemo.Services;
using Microsoft.AspNetCore.Components;

namespace HRMDemo.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }


        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("Last name cannot be empty");
            }

        }
    }
}
