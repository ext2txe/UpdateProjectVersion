using ClFramework;
using System.Security.Cryptography.X509Certificates;

namespace UpdateProjectVersion
{
    public class UpvSettings : BaseSettings
    {
        public UpvSettings(string settingsFile) : base(settingsFile)
        {
        }

        public string MyBaseFolder { get => GetString("BaseFolder"); set => SetString("BaseFolder", value); }
        public string MyTargetFile { get => GetString("MyTargetFile"); set => SetString("MyTargetFile", value); }


    }
}
