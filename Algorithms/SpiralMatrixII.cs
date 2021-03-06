// Source : https://leetcode.com/problems/spiral-matrix-ii/ 
// Author : codeyu 
// Date : Saturday, December 10, 2016 10:33:16 PM 

/**********************************************************************************
*
* Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
* 
* 
* For example,
* Given n = 3,
* 
* You should return the following matrix:
* 
* [
*  [ 1, 2, 3 ],
*  [ 8, 9, 4 ],
*  [ 7, 6, 5 ]
* ]
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution059 
    {
        public static int[,] GenerateMatrix(int n) 
        {
            if(n<0) return null;  
            var result = new int[n,n];  
            var top = 0;
            var bottom = n-1;
            var left = 0;
            var right = n-1;  
            var num = 1;
            while(top <= bottom)  
            {  
                if(top == bottom)
                {
                    result[top, top] = num++;
                }
                //first line
                for(int i=left;i<right;i++)  
                {  
                    result[top, i] = num++;  
                }  
                //right line
                for(int i=top;i<bottom;i++)  
                {  
                    result[i, right] = num++;  
                }  
                //bootom line
                for(int i=right;i>left;i--)  
                {  
                    result[bottom, i] = num++;  
                } 
                //left line 
                for(int i=bottom;i>top;i--)  
                {  
                    result[i,left] = num++;  
                } 
                top++;
                bottom--;
                left++;
                right--; 
            }  
             
            return result;
        }
    }
}

