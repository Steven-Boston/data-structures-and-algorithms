# Solution to this challenge https://leetcode.com/problems/climbing-stairs/submissions/
# Summary: for a number of stairs n, return the number of unique ways to traverse the stairs either 1 or 2 steps at a time
class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        if(n==1):
            return 1
        if(n==2):
            return 2
        a = 0
        b = 1
        c = 2
        while(n>2):
            a = b
            b = c
            c = a + b
            n = n-1
        return c