namespace LeetCode.Arrays
{
    public partial class Solution
    {
        public int[] TopKFrequentV1(int[] nums, int k)
        {
            Dictionary<int, int> numsFrequency = new();
            foreach (int num in nums)
            {
                if (!numsFrequency.TryAdd(num, 1))
                {
                    numsFrequency[num]++;
                }
            }
            numsFrequency = numsFrequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            List<int> result = new();
            foreach (var element in numsFrequency)
            {
                if (k >= 1)
                {
                    result.Add(element.Key);
                    k--;
                }
                else
                {
                    break;
                }
            }
            return result.ToArray();
        }

        public int[] TopKFrequentV2(int[] nums, int k)
        {
            Dictionary<int, int> numsFrequency = new();
            List<int> result = new();
            foreach (int num in nums)
            {
                if (!numsFrequency.TryAdd(num, 1))
                {
                    numsFrequency[num]++;
                }
            }
            PriorityQueue<int, int> priorityQueue = new();
            foreach (var element in numsFrequency)
            {
                priorityQueue.Enqueue(element.Key, element.Value);
                if (priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }
            while (priorityQueue.Count > 0)
            {
                result.Add(priorityQueue.Dequeue());
            }
            return result.ToArray();
        }
    }
}