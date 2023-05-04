using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeksAhead.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [RelayCommand]
        Task LoginAsync() => Shell.Current.GoToAsync($"//{nameof(HomePage)}",
            new Dictionary<string, object> {
                ["User"] = new User
                {
                    Birthday = new DateTime(1990, 08, 01),
                    Name = "Adrian",
                    TargetAge = 40
                },
            });
    }
}
