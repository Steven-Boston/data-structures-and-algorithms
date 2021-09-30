var longestPalindrome = (s) => {
    let longest = s[0];
    arr = [...s];
    arr.forEach((letter, idx) => {
      for(let i = arr.length-1; i>idx; i--) {
        if(arr[i] == arr[idx]) {
          let l = idx;
          let r = i;
          while(l<r) {
            l++;
            r--;
            console.log(`left(${l}) = ${arr[l]}, right(${r}) = ${arr[r]}`);
            if (arr[l] != arr[r]) {
              console.log(`missed: ${arr[l]} != ${arr[r]}`);
              break;
            };
            if(!l<r) {
              let newPal = arr.slice(idx, i+1).join('');
              console.log(`newPal = ${newPal}`);
              if(newPal.length > longest.length) {
                longest = newPal;
              };
            };
          };
        };
      };
    });
    return longest;
};