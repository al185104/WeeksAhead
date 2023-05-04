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
        //{
        //    try
        //    {
        //        IsBusy = true;
        //        await Task.Delay(1000);

        //        await Shell.Current.GoToAsync($"//{nameof(HomePage)}?",true,
        //            new Dictionary<string, object> {
        //                ["User"] = new User {
        //                    Birthday = new DateTime(1990,08,01),
        //                    Name = "Adrian",
        //                    TargetAge = 40
        //                },
        //            });
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
    }
}
