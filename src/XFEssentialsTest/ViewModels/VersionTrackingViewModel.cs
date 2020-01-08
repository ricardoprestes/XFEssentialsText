using Xamarin.Essentials;

namespace XFEssentialsTest.ViewModels
{
    public class VersionTrackingViewModel : BaseViewModel
    {
        public string FirstAccess => VersionTracking.IsFirstLaunchEver ? "Yes" : "No";
        //current version and build
        public string CurrentVersion => VersionTracking.CurrentVersion;
        public string CurrentBuild => VersionTracking.CurrentBuild;
        //previous version and build
        public string PreviousVersion => VersionTracking.PreviousVersion;
        public string PreviousBuild => VersionTracking.PreviousBuild;

    }
}
