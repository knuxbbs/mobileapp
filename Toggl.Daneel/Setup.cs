using UIKit;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using Toggl.Foundation.MvvmCross;
using Toggl.Foundation.DataSources;
using Toggl.Ultrawave.Network;
using Toggl.PrimeRadiant.Realm;
using Toggl.PrimeRadiant;
using Toggl.Daneel.Services;
using Toggl.Foundation.MvvmCross.Services;
using Toggl.Ultrawave;

namespace Toggl.Daneel
{
    public class Setup : MvxIosSetup
    {
        #if DEBUG
        private const ApiEnvironment environment = ApiEnvironment.Staging;
        #else
        private const ApiEnvironment environment = ApiEnvironment.Production;
        #endif

        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp() => new App();

        protected override IMvxTrace CreateDebugTrace() => new DebugTrace();

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            Mvx.RegisterType<ITogglDatabase, Database>();
            Mvx.RegisterType<ITogglDataSource, TogglDataSource>();
            Mvx.RegisterSingleton<IApiFactory>(new ApiFactory(environment));
            Mvx.RegisterSingleton<IMvxCommandHelper>(new MvxStrongCommandHelper());
            Mvx.RegisterSingleton<ITogglApi>(new TogglApi(environment, Credentials.None));
        }
    }
}
