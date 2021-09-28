/**
 * This challenge is from leetcode: https://leetcode.com/problems/add-two-numbers/
 * The challenge asks for a function that adds two numbers that are represented one digit at a time in reverse via a linkedList, outputting the sum in the same format. 
 * 
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
 var addTwoNumbers = function(l1, l2) {
  current1 = l1.next;
  current2 = l2.next;
  let carry = 0;
  let startVal = l1.val + l2.val;
  if(startVal > 9) {
      carry = 1;
      startVal -= 10;
  }
  let result = new ListNode((startVal));
  current3 = result;
  
  while(current1 != null || current2 != null) {
      value = (current1 ? current1.val : 0) + (current2 ? current2.val : 0) + carry;
      if(value > 9) {
          carry = 1;
          value -= 10;
      } else {
          carry = 0;
      }
      current3.next = new ListNode((value));
      current1 = current1 ? current1.next : null;
      current2 = current2 ? current2.next : null;
      current3 = current3.next;
  }
  if(carry) {
      current3.next = new ListNode(1);
  }
  return result;
};