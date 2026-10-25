using System.Globalization;

namespace Gachlab.Consulting.Site.Localization;

public interface ISiteCopyProvider
{
    SiteCopy For(CultureInfo culture);
}
