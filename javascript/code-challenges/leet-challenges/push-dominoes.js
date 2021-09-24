
//initial attempt, fails on most neutrals near ends
pushDominoes = (dominoes) => {
  domArr = dominoes.split('');
  return domArr.map((domino, idx)=>{
      if(domino == '.') {
          let previous = idx-1;
          let next = idx+1;
          while(true) {
              if(previous < 0) {
                while(next < dominoes.length) {
                    if( dominoes[next] == 'L') {
                        return 'L';
                    } else if (dominoes[next] == 'R') {
                        return '.';
                    } else {
                        next++;
                    }
                }
                return '.';
              } else if (next >= dominoes.length){
                  while(previous >= 0) {
                    if( dominoes[previous] == 'R') {
                      return 'L';
                    } else if (dominoes[previous] == 'L') {
                      return '.';
                    } else {
                      previous--;
                    }
                  }  
              } else if((dominoes[previous] == 'L' && dominoes[next] == 'R') || 
                 (dominoes[previous] == 'R' && dominoes[next] == 'L')) {
                  return '.';
              } else if(dominoes[previous] == 'R') {
                  return 'R';
              } else if(dominoes[next] == 'L') {
                  return 'L';
              } else {
                  previous --;
                  next++;
              }
          }
      }
      return domino;
  }).join('');
};

//working solution based on solution from https://leetcode.com/problems/push-dominoes/discuss/858300/Javascript-or-2-pointers
pushDominoes = (dominoes) => {
  let l = 0;
  let r = 1;
  //add directionals to the ends for inspection
  const arr = ['L',...dominoes,'R'];
  while(l<arr.length-1) {
      //move past the neutrals to find the next directional
      while(arr[r] == '.') {
        r++;
      }
      //if the directionals match, resolve each neutral in between to the direction
      if(arr[l] == arr[r]) {
        for(let i=l+1; i<r; i++) {
          arr[i] = arr[l];
        }
      }
      //if directionals are R=><=L, adjust half the neutrals each way, leaving the middle one alone if apllicable
      if(arr[l] > arr[r]) {
        for(let i = 1; i <= (r-l-1)/2; i++) {
          arr[l + i] = 'R';
          arr[r - i] = 'L';
        }   
      } 
      //set l and r for next section
      l=r;
      r++;
  }
  //slice off the fake directionals and join back into a string
  return arr.slice(1,arr.length-1).join('');
};