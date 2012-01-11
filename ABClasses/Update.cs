using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABClasses {
    class Update {
        public static void Update<T>(this IEnumerable<T> source, params Action<T>[] updates) {
            if (source == null)
                throw new ArgumentNullException("source");

            if (updates == null)
                throw new ArgumentNullException("updates");

            foreach (T item in source) {
                foreach (Action<T> update in updates) {
                    update(item);
                }
            }
        }
    }
}
