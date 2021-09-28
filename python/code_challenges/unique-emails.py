"""
This challenge is from leetcode https://leetcode.com/explore/challenge/card/september-leetcoding-challenge-2021/639/week-4-september-22nd-september-28th/3989/

The challenge was to assess the number of unique emails from a list of emails by converting the email strings into the actual emails:
- each string includes a single @ that divides the email. everything after the @ should be included. 
- prior to the @, "." is ignored, and if a "+" appears everything after the "+" but prior to the @ is ignored. 
- This challenge also specified that the formatting would be consistent - no characters outside lowercase letters and the three specified other characters, no empty strings, and always precisely 1 "@" with at least one character to be included both before and after it. 
"""

class Solution(object):
    def numUniqueEmails(self, emails):
        mailingList = {}
        """
        :type emails: List[str]
        :rtype: int
        """
        for email in emails:
            plus = False
            domain = False
            converted_mail = ""
            for char in email:
                if(char == "@"):
                    domain = True
                if(domain == True):
                    converted_mail += char
                elif(char == "+"):
                    plus = True
                elif(char != "." and plus != True):
                    converted_mail += char
            mailingList[converted_mail] = True
        return len(mailingList.keys())