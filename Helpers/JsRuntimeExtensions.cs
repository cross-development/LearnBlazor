using Microsoft.JSInterop;

namespace LearnBlazor.Helpers;

public static class JsRuntimeExtensions
{
    public static async Task ToasterSuccess(this IJSRuntime jsRuntime, string message)
    {
        await jsRuntime.InvokeVoidAsync("showToaster", "success", message);
    }

    public static async Task ToasterError(this IJSRuntime jsRuntime, string message)
    {
        await jsRuntime.InvokeVoidAsync("showToaster", "error", message);
    }
}