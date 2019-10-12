using System;
using System.Collections.Generic;
using System.Text;

namespace Pirma_dalis.Trecia_Dalis
{
    interface ISecurity
    {
        void checkEntriePoints(bool entries);

        void openEntriePoints();

        void closeEntriePoints();
    }
}
