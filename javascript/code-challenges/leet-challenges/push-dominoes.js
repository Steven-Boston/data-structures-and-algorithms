
PushDominoes = (dominoes) => {
      return dominoes.map((domino, idx)=>{
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
                  } else if (next == dominoes.length){
                      while(previous >= 0) {
                        if( dominoes[next] == 'R') {
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
      });
  };