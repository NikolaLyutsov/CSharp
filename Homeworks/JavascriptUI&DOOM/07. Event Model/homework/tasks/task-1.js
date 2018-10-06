/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
  return function (selector) {
    if (typeof selector === 'string'){
      selector = document.getElementById(selector);
      if(selector == null){
        throw Error('selector not found');
      }
     } else if(!(selector instanceof HTMLElement)){
       throw Error('invalid selector');
     }

     let buttons = document.getElementsByClassName('button');
     let contents = document.getElementsByClassName('content');

     buttons = [].slice.apply(buttons);

     buttons.forEach(button => {
       button.textContent = 'hide';
     });

     $(selector).on('click', '.button', changeVIsibility);
    };

    function changeVIsibility(event){
      let targetButton = event.target;
      let targetButtonSibling = findContentSiblingIfExist(targetButton);

      if(targetButtonSibling !== null){
        if(targetButtonSibling.style.display == '') {
          targetButtonSibling.style.display = 'none';
          targetButton.innerHTML = 'show';
        } else {
          targetButtonSibling.style.display = '';
          targetButton.innerHTML = 'hide';
        }
      }
    }

    function findContentSiblingIfExist(targetEl){

      debugger;

      let currentSibling = targetEl.nextElementSibling;

      if(currentSibling == null ||
      currentSibling == undefined ||
    currentSibling.className == 'button') {
      return null;
    } else if (currentSibling.className == 'content'){
      return currentSibling;
    }

    return findContentSiblingIfExist(currentSibling);
    }
  };
};

module.exports = solve;