using MudBlazor;

namespace Boda_BlazorWASM_PowerAutomate.Components
{
    public class MyMudTheme : MudTheme
    {
        public MyMudTheme()
        {
            Palette = new Palette()
            {
                Primary = Colors.LightGreen.Lighten1,
                Secondary = Colors.LightGreen.Darken1,
                Tertiary = Colors.LightGreen.Lighten3,
                Dark = Colors.LightGreen.Darken3,
                DarkDarken = Colors.LightGreen.Darken4,
                DarkLighten = Colors.LightGreen.Darken2,
                PrimaryLighten = Colors.LightGreen.Lighten1,

                AppbarBackground = Colors.LightGreen.Lighten1,

            };
        }
    }
}
