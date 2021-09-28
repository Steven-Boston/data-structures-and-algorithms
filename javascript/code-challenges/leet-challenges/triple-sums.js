var threeSum = function(nums) {
  let output = [];
  nums.forEach((num1, idx) =>{
      nums.forEach((num2, id2) =>{
          if(id2 != idx) {
              nums.forEach((num3, id3)=>{
                  if((num1 + num2 + num3 == 0) && (id3 != idx) && (id3 != id2)) {
                      let newTrip = [num1, num2, num3];
                      newTrip.sort((a,b)=>a-b);
                      if(!output.some((arr)=>(arr[0]==newTrip[0] && arr[1]==newTrip[1] && arr[2]==newTrip[2]))) {
                          output.push(newTrip); 
                      };
                  };
              }); 
          };
      });
  });
  return output;
};