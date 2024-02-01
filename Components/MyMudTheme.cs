using MudBlazor;
using MudBlazor.Utilities;

namespace teseractal_web.Components
{
    public class MyMudTheme : MudTheme
    {
        public MyMudTheme()
        {

            Palette = new PaletteLight()
            {
                Primary = Colors.BlueGrey.Default,
                Secondary = Colors.BlueGrey.Lighten1,
                AppbarBackground = Colors.BlueGrey.Default,
            };
            PaletteDark = new PaletteDark()
            {
                Primary = Colors.BlueGrey.Darken1
            };
            //Palette = new Palette()
            //{
            //    //Primary = new MudColor("BFD09A"),
            //    //Secondary = new MudColor("B3CEC3"),
            //    //Tertiary = new MudColor("808285"),

            //    Primary = Colors.BlueGrey.Default,
            //    Secondary = Colors.BlueGrey.Lighten3,
            //    Tertiary = Colors.BlueGrey.Darken3,


            //    //Primary = Colors.Blue.Default,
            //    //Secondary = Colors.Blue.Lighten3,
            //    //Tertiary = Colors.Blue.Darken3,

            //    Dark = Colors.Shades.Black,
            //    DarkDarken = Colors.Shades.Black,
            //    DarkLighten = Colors.Shades.Black,
            //    PrimaryLighten = Colors.Shades.Black,

            //    AppbarBackground = Colors.BlueGrey.Default,
            //    //AppbarBackground = Colors.Blue.Darken3,


            //};
        }
    }
}
