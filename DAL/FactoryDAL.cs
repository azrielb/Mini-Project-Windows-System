using System.Collections.Generic;
using BE;

namespace DAL {
    public class FactoryDAL {
        public static Idal<List<Room>, List<Tour_Agency>, List<Reservation>> getDAL() {
            return Dal_imp.Singleton;
        }
    }
}
