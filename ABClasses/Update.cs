using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABClasses {
    public static class Updates {
        /// <summary>
        /// http://stackoverflow.com/questions/361921/list-manipulation-in-c-sharp-using-linq#answer-361958
        /// </summary>
        /// <typeparam name="T">any object</typeparam>
        /// <param name="source">the collection</param>
        /// <param name="updates"></param>
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
