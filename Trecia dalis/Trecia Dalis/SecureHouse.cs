using System;
using System.Collections.Generic;
using System.Text;
using Trecia_dalis.Trecia_Dalis;

namespace Pirma_dalis.Trecia_Dalis
{
    class SecureHouse : House, ISecurity
    {
        SecureWindows sw = new SecureWindows();


        public void checkEntriePoints(bool entries)
        {
            sw.checkEntriePoints(entries);
        }

        public void openEntriePoints()
        {
            sw.openEntriePoints();
        }

        public void closeEntriePoints()
        {
            sw.closeEntriePoints();
        }
    }
}
