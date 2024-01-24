namespace Boda_BlazorWASM_PowerAutomate
{
    using Microsoft.JSInterop;
    using System.Threading.Tasks;

    public static class ScrollInterop
    {
        public static ValueTask ScrollToBottom(this IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeVoidAsync("window.scrollToBottom");
        }

        public static ValueTask ScrollByPixels(this IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeVoidAsync("window.scrollByPixels");
        }

        public static ValueTask ScrollToElement(this IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeVoidAsync("window.scrollToElement");
        }
    }

}
