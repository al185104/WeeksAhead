
namespace WeeksAhead.ViewModels
{
    [QueryProperty(nameof(User), nameof(User))]
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        User _user;

        [RelayCommand]
        async Task InitAsync()
        {
            // ISSUE! It's coming in here with User as null on Android but isn't null on Windows.
            try
            {
                IsBusy = true;

                await Task.Delay(1000);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
