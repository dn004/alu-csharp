using System;

namespace MyMath{

    public class Operations{

        public static int Max(List<int> nums)
        {
            int listLength = nums.Count;
            if (listLength == 0)
            {
                return 0;
            }
            else
            {
                if (nums != null)
                {
                    int MaxSoFar = nums[0];
                    for (int i = 1; i < listLength; i++)
                    {
                        if (nums[i] > MaxSoFar)
                        {
                            MaxSoFar = nums[i];
                        }
                    }

                    return MaxSoFar;
                }
            }

            return 0;
        }
    }
}