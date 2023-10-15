using MovieProject.Debugging;

namespace MovieProject
{
    public class MovieProjectConsts
    {
        public const string LocalizationSourceName = "MovieProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4c043359183941d38455534e7b976cd1";
    }
}
