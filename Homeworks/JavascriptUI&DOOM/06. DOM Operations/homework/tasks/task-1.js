/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    var after,
    toAppend = '',
    len = contents.length,
    div = document.createElement('div'),
    divElement,
    docFragment = document.createDocumentFragment();

    if(typeof element === 'string'){
      after = document.getElementById(element);
    }
    else if(element instanceof HTMLElement){
      after = element;
    }
    else{
      throw Error('no');
    }

    if(!contents || contents.some(function (contElement){
      return typeof contElement !== 'string' && typeof contElement !== 'number';
    })){
      throw Error('no');
    }

    after.innerHTML = '';

    for(var i = 0; i < contents.length; i+=1) {
      divElement = div.cloneNode(true);
      divElement.innerHTML = contents[i];
      docFragment.appendChild(divElement);
    }
    after.appendChild(docFragment);

  };
};