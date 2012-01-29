using System;
using System.Collections.Generic;

namespace ABClasses {
    public static class Updates {
        /// <summary>
        /// perform the "updates" functions on each item in the Enumerable
        /// http://stackoverflow.com/questions/361921/list-manipulation-in-c-sharp-using-linq#answer-361958
        /// </summary>
        /// <typeparam name="T">any object</typeparam>
        /// <param name="source">the Enumerable that need be updated</param>
        /// <param name="updates">some functions (at least one, or an array) that get T and return void</param>
        public static void Update<T>(this IEnumerable<T> source, params Action<T>[] updates) {
            if (source == null)
                throw new ArgumentNullException("source");

            if (updates == null)
                throw new ArgumentNullException("updates");

            foreach (T item in source)
                foreach (Action<T> update in updates)
                    update(item);
        }
    }
}
