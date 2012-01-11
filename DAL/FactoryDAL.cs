using System;
using System.Collections.Generic;
using System.Linq;
using BE;

namespace DAL {
    public class FactoryDAL {
        public static Idal<List<Room>, List<Tour_Agency>, List<Reservation>> getDAL() {
            return Dal_imp.Singleton();
        }
    }
}
