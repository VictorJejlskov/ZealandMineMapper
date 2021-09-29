namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public static int ThreeNumbers(int a, int b, int c)
        {
            int resultA = TwoNumbers(a,b);
            int resultB = TwoNumbers(a, c);
            int resultC = TwoNumbers(resultA, resultB);

            //if (b > a)
            //{
            //    result = b;
            //    if (c > b)
            //    {
            //        result = c;
            //    }
            //}
            //else
            //{
            //    result = a;
            //    if (c > a)
            //    {
            //        result = c;
            //    }
            //}

            return resultC;
        }

        public static int TwoNumbers(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }

        public static int FourNumbers(int a, int b, int c, int d)
        {
            int resultA = TwoNumbers(a, b);
            int resultB = TwoNumbers(c, d);
            int resultC = TwoNumbers(resultA, resultB);
            return resultC;
        }


        #endregion
    }
}