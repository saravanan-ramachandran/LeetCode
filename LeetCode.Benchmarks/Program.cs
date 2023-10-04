﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LeetCode.Arrays;

namespace LeetCode.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.Method, BenchmarkDotNet.Order.MethodOrderPolicy.Alphabetical)]
[HideColumns("Error", "StdDev", "Median", "RatioSD")]
public class Program
{
    private int[] nums = new int[1000];
    private static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    [GlobalSetup]
    public void Setup()
    {
        foreach(int i in nums)
        {
            nums[i] = Random.Shared.Next();
        }
    }

    //[Benchmark]
    //public void ContainsDuplicateV1()
    //{
    //    Solution solution = new();
    //    solution.ContainsDuplicateV1(nums);
    //}
    //[Benchmark]
    //public void ContainsDuplicateV2()
    //{
    //    Solution solution = new();
    //    solution.ContainsDuplicateV2(nums);
    //}
    //[Benchmark]
    //public void ContainsDuplicateV3()
    //{
    //    Solution solution = new();
    //    solution.ContainsDuplicateV3(nums);
    //}

    [Benchmark]
    public void GroupAnagramsV1()
    {
        string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        Solution solution = new();
        solution.GroupAnagramsV1(strs);
    }
    [Benchmark]
    public void GroupAnagramsV2()
    {
        string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        Solution solution = new();
        solution.GroupAnagramsV2(strs);
    }
}