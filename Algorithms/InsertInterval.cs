// Source : https://leetcode.com/problems/insert-interval/ 
// Author : codeyu 
// Date : Saturday, December 10, 2016 10:31:28 PM 

/**********************************************************************************
*
* Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
* 
* You may assume that the intervals were initially sorted according to their start times.
* 
* 
* Example 1:
* Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9].
* 
* 
* 
* Example 2:
* Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].
* 
* 
* 
* This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    /**
     * Definition for an interval.
     * public class Interval {
     *     public int start;
     *     public int end;
     *     public Interval() { throw new NotImplementedException("TODO");start = 0; end = 0; }
     *     public Interval(int s, int e) { start = s; end = e; }
     * }
     */
    public class Solution057
    {
        public static IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            List<Interval> res = new List<Interval>();
            if (intervals.Count == 0)
            {
                res.Add(newInterval);
                return res;
            }
            int i = 0;
            while (i < intervals.Count && intervals[i].end < newInterval.start)
            {
                res.Add(intervals[i]);
                i++;
            }
            if (i < intervals.Count)
                newInterval.start = Math.Min(newInterval.start, intervals[i].start);
            res.Add(newInterval);
            while (i < intervals.Count && intervals[i].start <= newInterval.end)
            {
                newInterval.end = Math.Max(newInterval.end, intervals[i].end);
                i++;
            }
            while (i < intervals.Count)
            {
                res.Add(intervals[i]);
                i++;
            }
            return res;
        }     
    }
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
}

