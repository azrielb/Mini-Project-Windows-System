﻿using System.Collections.Generic;
using BE;

namespace BL {
    public class FactoryBL {
        public static IBL<List<Room>, List<Tour_Agency>, List<Reservation>> getBL { get { return BL_imp.Singleton; } }
    }
}
