/**
 * https://leetcode.com/problems/word-search/
 * additional bugfixes from https://leetcode.com/problems/word-search/discuss/811765/Javascript
 * @param {character[][]} board
 * example: [
 *            ["A","B","C","E"],
 *            ["S","F","C","S"],
 *            ["A","D","E","E"]
 *          ]
 * @param {string} word
 * @return {boolean}
 */
 var exist = (board, word) => {
  for(let i = 0; i<board.length; i++) {
    if(board[i].includes(word[0])) {
      for(let j = 0; j<board[i].length; j++) {
        if(board[i][j] == word[0]) {
           if(wordCheck(board, word, j, i)) { return true};
        };
      };
    };
  };
  return false;
};

var wordCheck = (board, word, col, row) => {
  let value = board[row][col];
  if(word.length == 1) {
    return true;
  };
  board[row][col] = null;
  if(col+1 < board[row].length && board[row][col+1] == word[1]) {if(wordCheck(board, word.slice(1), col+1, row)) {return true}};
  if(col-1 >= 0 && board[row][col-1] == word[1]) {if(wordCheck(board, word.slice(1), col-1, row)) {return true}};
  if(row+1 < board.length && board[row+1][col] == word[1]) {if(wordCheck(board, word.slice(1), col, row+1)) {return true}};
  if(row-1 >= 0 && board[row-1][col] == word[1]) {if(wordCheck(board, word.slice(1), col, row-1)) {return true}};
  board[row][col] = value;
  return false;
};