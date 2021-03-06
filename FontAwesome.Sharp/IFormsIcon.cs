using System.ComponentModel;
using System.Drawing;

namespace FontAwesome.Sharp
{
    public interface IFormsIcon
    {
        [Category("FontAwesome")]
        IconChar Icon { get; set; }
        [Category("FontAwesome")]
        int IconSize { get; set; }
        [Category("FontAwesome")]
        Color IconColor { get; set; }
    }
}