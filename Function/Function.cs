namespace Function
{
    public enum SortOrder { Ascending, Descending }

    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            if (order == SortOrder.Ascending)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                        return false;
                }
                return true;
            }
            if (order == SortOrder.Descending)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                        return false;
                }
                return true;
            }
            return false;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += i;
                }
            }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = a;

            while (n > 1)
            {
                result *= a + t;
                a += t;
                n--;
            }

            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            if (alim > a)
                return 0;

            double sum = a;

            while (a * t > alim)
            {
                a *= t;
                sum += a;
            }

            return sum;
        }
    }
}