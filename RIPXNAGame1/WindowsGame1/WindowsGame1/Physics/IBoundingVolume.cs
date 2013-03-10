using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIPXNAGame.Physics
{
    interface IBoundingVolume
    {
        Contact collideWith(BoundingSphere pBV, long pGameTime);
    }
}
