
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
