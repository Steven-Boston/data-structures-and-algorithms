def reverse(self, x):
        """
        :type x: int
        :rtype: int
        """
        isNegative = False
        intString = str(x)
        reversed = ''
        for digit in intString:
          if(digit == '-'):
            isNegative = True
          else:
            reversed = digit + reversed
        newInt = int(reversed)
        if(isNegative):
          newInt = newInt * -1
        if(newInt > 2 ** 31 - 1 or newInt < -2 ** 31 ):
          return 0
        return newInt