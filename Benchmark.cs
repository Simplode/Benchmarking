using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplodeShared
{
    internal class Benchmark
    {
        public static double BranchPrediction()
        {
            var a = 1.000000000000;
            var b = 1.003141592654;
            var c = 1.002718281828;
            for (var i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    a = a * b;
                    if (i % 3 == 0)
                    {
                        a = a * b;
                        if (i % 2 == 0)
                        {
                            a = a * b;
                            if (i % 3 == 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                        else
                        {
                            if (i % 3 != 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                    }
                    else
                    {
                        a = a * c;
                        if (i % 2 == 0)
                        {
                            a = a * b;
                            if (i % 3 == 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                        else
                        {
                            if (i % 3 != 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                    }
                } else
                {
                    if (i % 3 != 0)
                    {
                        a = a * b;
                        if (i % 2 == 0)
                        {
                            a = a * b;
                            if (i % 3 == 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                        else
                        {
                            if (i % 3 != 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                    }
                    else
                    {
                        a = a * c;
                        if (i % 2 == 0)
                        {
                            a = a * b;
                            if (i % 3 == 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                        else
                        {
                            if (i % 3 != 0)
                            {
                                a = a * b;
                            }
                            else
                            {
                                a = a * c;
                            }
                        }
                    }
                }

            }
            return a;
        }
        public static double TestDouble()
        {
            double result = 1;
            double i = 1;
            for(; i < 1000d; i++)
            {
                result = result * (i * 2d) / (i * 2d + 1) * (i * 2d) / (i * 2d + 1d);
            }
            result = result * (i * 2d);
            return result;
        }

        public static float TestFloat()
        {
            float result = 1;
            float i = 1;
            for (; i < 1000f; i++)
            {
                result = result * (i * 2f) / (i * 2f + 1f) * (i * 2f) / (i * 2f + 1f);
            }
            result = result * (i * 2f);
            return result;
        }

        public static Int32 TestInt32()
        {
            int result = 1000000;
            int i = 1;
            for (; i < 1000; i++)
            {
                result = result * (i * 2) / (i * 2 + 1) * (i * 2) / (i * 2 + 1);
            }
            result = result * (i * 2);
            return result;
        }

        public static Int64 TestInt64()
        {
            Int64 result = 10000000000000L;
            Int64 i = 1;
            for (; i < 1000L; i++)
            {
                result = result * (i * 2L) / (i * 2L + 1L) * (i * 2L) / (i * 2L + 1L);
            }
            result = result * (i * 2L);
            return result;
        }

    }
}
