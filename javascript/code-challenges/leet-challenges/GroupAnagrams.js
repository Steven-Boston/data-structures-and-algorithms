//solution for https://leetcode.com/problems/group-anagrams/

var groupAnagrams = function(strs) {
  buckets = {};
  strs.forEach(str=>{
    let strkey = [...str].sort().join('');
    if(buckets[strkey]) {
      buckets[strkey].push(str);
    } else {
      buckets[strkey] = [str];
    }
  });
  return Object.values(buckets);
}