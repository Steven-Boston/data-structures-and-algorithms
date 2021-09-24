class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """

        xCount = 0
        yCount = 0
        while xCount<len(nums):
            while yCount<len(nums):
                if nums[xCount] + nums[yCount] == target and xCount != yCount:
                    return [xCount, yCount]
                else:
                    yCount += 1
            else: xCount += 1