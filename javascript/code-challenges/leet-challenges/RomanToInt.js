var romanToInt = function(s) {
  let result = 0;
  const romanKey = {
      'I': 1,
      'V': 5,
      'X': 10,
      'L': 50,
      'C': 100,
      'D': 500,
      'M': 1000
  }
  for(let i=0; i<s.length; i++){
      if(i+1 != s.length) {
          result = (romanKey[s[i]] < romanKey[s[i+1]]) ? result -= romanKey[s[i]] : result += romanKey[s[i]];
      } else {
        result += romanKey[s[i]];
      }
  }
  return result;
};