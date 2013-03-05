using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Rendering
{
    public interface IGraphicProperties
    {
        String AssetID { get; set; }

        float Scale { get; set; }
    }
}
