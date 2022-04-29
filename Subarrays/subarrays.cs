using System;

namespace Base
{

    class Program
    {

        public static int MaxSubarraySum(List<int> arr)
        {
            int result = arr[0];
            int localResult = arr[0];
            for(int i = 1; i < arr.Count(); i ++)
            {
                if(localResult > 0)
                {
                    localResult += arr[i];
                }
                else{
                    localResult = arr[i];
                }
                if(localResult > result)
                {
                    result = localResult;
                }
            }
            return result;
        }

        public static int MinSubarraySum(List<int> arr)
        {
            int result = arr[0];
            int localResult = arr[0];
            for(int i = 1; i < arr.Count(); i ++)
            {
                if(localResult < 0)
                {
                    localResult += arr[i];
                }
                else{
                    localResult = arr[i];
                }
                if(localResult < result)
                {
                    result = localResult;
                }
            }
            return result;
        }

        public static int MaxSubarrayProd(List<int> arr)
        {
            int result = arr[0];
            int localResultPos = arr[0];
            int localResultNeg = arr[0];
            for(int i = 1; i < arr.Count(); i ++)
            {
                int localResultMax, localResultMin;
                if(localResultPos * arr[i] > localResultNeg * arr[i])
                {
                    localResultMax = localResultPos * arr[i];
                    localResultMin = localResultNeg * arr[i];
                }
                else
                {
                    localResultMax = localResultNeg * arr[i];
                    localResultMin = localResultPos * arr[i];
                }
                if(arr[i] > localResultMax)
                {
                    localResultPos = arr[i];
                }
                else
                {
                    localResultPos = localResultMax;
                }
                if(arr[i] < localResultMin)
                {
                    localResultNeg = arr[i];
                }
                else
                {
                    localResultNeg = localResultMin;
                }
                if(localResultPos > result)
                {
                    result = localResultPos;
                }
            }
            return result;
        }

        public static int MinSubarrayProd(List<int> arr)
        {
            int result = arr[0];
            int localResultPos = arr[0];
            int localResultNeg = arr[0];
            for(int i = 1; i < arr.Count(); i ++)
            {
                int localResultMax, localResultMin;
                if(localResultPos * arr[i] > localResultNeg * arr[i])
                {
                    localResultMax = localResultPos * arr[i];
                    localResultMin = localResultNeg * arr[i];
                }
                else
                {
                    localResultMax = localResultNeg * arr[i];
                    localResultMin = localResultPos * arr[i];
                }
                if(arr[i] > localResultMax)
                {
                    localResultPos = arr[i];
                }
                else
                {
                    localResultPos = localResultMax;
                }
                if(arr[i] < localResultMin)
                {
                    localResultNeg = arr[i];
                }
                else
                {
                    localResultNeg = localResultMin;
                }
                if(localResultNeg < result)
                {
                    result = localResultNeg;
                }
            }
            return result;
        }

        public static int MaxCircularSubarraySum(List<int> arr)
        {
            int maxElem = arr[0];
            int arrSum = 0;
            for(int i = 0; i < arr.Count(); i ++)
            {
                if(arr[i] > maxElem)
                {
                    maxElem = arr[i];
                }
                arrSum += arr[i];
            }
            if(maxElem < 0)
            {
                return maxElem;
            }
            int maxSimpleSum = MaxSubarraySum(arr);
            int maxCircleSum = arrSum - MinSubarraySum(arr);
            if(maxSimpleSum > maxCircleSum)
            {
                return maxSimpleSum;
            }
            else
            {
                return maxCircleSum;
            }
        }

        public static int MinCircularSubarraySum(List<int> arr)
        {
            int minElem = arr[0];
            int arrSum = 0;
            for(int i = 0; i < arr.Count(); i ++)
            {
                if(arr[i] < minElem)
                {
                    minElem = arr[i];
                }
                arrSum += arr[i];
            }
            if(minElem < 0)
            {
                return minElem;
            }
            int minSimpleSum = MinSubarraySum(arr);
            int minCircleSum = arrSum - MaxSubarraySum(arr);
            if(minSimpleSum < minCircleSum)
            {
                return minSimpleSum;
            }
            else
            {
                return minCircleSum;
            }
        }

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}