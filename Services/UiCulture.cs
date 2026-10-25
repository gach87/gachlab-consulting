using System.Globalization;
using Gachlab.Consulting.Site.Localization;
using Microsoft.JSInterop;

namespace Gachlab.Consulting.Site.Services;

public sealed class UiCulture
{
    private const string StorageKey = "gachlab-consulting-lang";
    private readonly ISiteCopyProvider _copy;
    private readonly IJSRuntime _js;

    public UiCulture(ISiteCopyProvider copy, IJSRuntime js)
    {
        _copy = copy;
        _js = js;
    }

    public string Lang { get; private set; } = "es";
    public SiteCopy Copy => _copy.For(new CultureInfo(Lang));
    public event Action? Changed;

    public async Task InitializeAsync()
    {
        try
        {
            var stored = await _js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
            if (stored is "es" or "en")
                Lang = stored;
        }
        catch (JSException)
        {
            // prerender / unavailable
        }
    }

    public async Task SetAsync(string lang)
    {
        if (lang is not ("es" or "en"))
            return;
        Lang = lang;
        try
        {
            await _js.InvokeVoidAsync("localStorage.setItem", StorageKey, lang);
        }
        catch (JSException)
        {
        }

        Changed?.Invoke();
    }
}
