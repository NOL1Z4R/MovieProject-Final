using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MovieProject.Localization
{
    public static class MovieProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MovieProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MovieProjectLocalizationConfigurer).GetAssembly(),
                        "MovieProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
