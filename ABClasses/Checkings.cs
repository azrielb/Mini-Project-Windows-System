namespace ABClasses
{
    class Checkings
    {
        /// <summary>
        /// This function takes a number, and checks whether the number is a valid israeli ID num.
        /// The all valid ID's that are smaller than 100 are: 18,26,34,42,59,67,75,83,91.
        /// </summary>
        /// <param name="idnum"></param>
        /// <returns>the result of checking</returns>
        public static bool CheckIdNum(ulong idnum) {
            if (idnum == 0) return false;
            int sum = 0;
            do {
                int num = (int)(idnum % 100);
                int lefter = (num / 10) * 2;
                sum += (num % 10) + lefter - (lefter > 9 ? 9 : 0);
                idnum /= 100;
            } while (idnum > 0);
            return (sum % 10 == 0);
        }
    }
}
