using MudBlazor;
using MudBlazor.Utilities;

namespace Boda_BlazorWASM_PowerAutomate.Components
{
    public class MyMudTheme : MudTheme
    {
        public MyMudTheme()
        {
            Palette = new Palette()
            {
                Primary = new MudColor("BFD09A"),
                Secondary = new MudColor("B3CEC3"),
                Tertiary = new MudColor("808285"),
                Dark = Colors.Shades.Black,
                DarkDarken = Colors.Shades.Black,
                DarkLighten = Colors.Shades.Black,
                PrimaryLighten = Colors.Shades.Black,

                AppbarBackground = new MudColor("BFD09A"),

            };
        }
    }
}
