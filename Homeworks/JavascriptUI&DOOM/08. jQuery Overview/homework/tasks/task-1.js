/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
   if(selector != undefined && selector != null && typeof count == 'number' && count > 1){
     let ulElement = $('<ul/>')
     .addClass('items-list');

     let counter = 0;

     do{
       ulElement.append($('<li/>')
       .addClass('list-item')
       .text('List item #' + counter));
       counter +=1;
     } while(counter < count)
   
   $(selector).append(ulElement);
  } else {
    throw Error('invalid');
  }
};
};

module.exports = solve;