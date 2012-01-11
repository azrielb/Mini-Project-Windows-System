namespace ABClasses
{
    class Checkings
    {
        /// <summary>
        /// This functions takes a number, and return whether the number is a valid israeli ID num.
        /// </summary>
        /// <param name="idnum"></param>
        /// <returns></returns>
        public static bool CheckIdNum(ulong idnum)
        {
            if (idnum == 0) return false;
            int sum = 0;
            for (; idnum > 0; idnum /= 100)
            {
                int num = (int)(idnum % 100);
                int lefter = (num / 10) * 2;
                sum += (num % 10) + lefter - (lefter > 9 ? 9 : 0);
            }
            return (sum % 10 == 0);
        }
    }
}
