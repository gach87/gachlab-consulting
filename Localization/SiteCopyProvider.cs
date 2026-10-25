using System.Globalization;

namespace Gachlab.Consulting.Site.Localization;

public sealed class SiteCopyProvider : ISiteCopyProvider
{
    public SiteCopy For(CultureInfo culture) => SiteCopyCatalog.For(culture);
}
