using StorexApp.ViewModel;

namespace StorexApp.Internals
{
    public sealed class ViewModelLocator
    {
        public ViewModelLocator() {
            Main = new MainViewModel();
        }
        public MainViewModel Main { get; set; }
    }
}
