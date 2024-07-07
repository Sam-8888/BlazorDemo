using Microsoft.AspNetCore.Components;

namespace HRMDemo.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
