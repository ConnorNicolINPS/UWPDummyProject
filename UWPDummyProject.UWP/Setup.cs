using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.WindowsUWP.Platform;
using MvvmCross.WindowsUWP.Views;
using Windows.UI.Xaml.Controls;

namespace UWPDummyProject.UWP
{
    public class Setup : MvxWindowsSetup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="rootFrame">The root frame.</param>
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        /// <summary>
        /// Creates the application.
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        /// <summary>
        /// Initializes the platform services.
        /// </summary>
        protected override void InitializePlatformServices()
        {
            base.InitializePlatformServices();
        }
    }
}