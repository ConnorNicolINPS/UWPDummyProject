namespace UWPDummyProject.Core
{
    using MvvmCross.Core.ViewModels;
    using UWPDummyProject.Core.ViewModels;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
