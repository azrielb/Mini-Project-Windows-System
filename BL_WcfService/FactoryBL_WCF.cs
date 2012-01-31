using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace BL_WcfService {
    public class FactoryBL_WCF {
        public static IBL_WCF<List<Room>, List<Tour_Agency>, List<Reservation>> getBL { get { return BL_WCF_imp.Singleton; } }
    }
}
