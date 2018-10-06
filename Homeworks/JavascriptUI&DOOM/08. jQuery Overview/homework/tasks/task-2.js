/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var $selector;
    if(selector != null && selector != undefined && typeof selector === 'string'){
      $selector = $(selector);
      if($selector.length == 0){
        throw Error('invalid element not found');
      }
    }

    $selector.on('click', '.button', changeVisibility);

    var buttonsAndContents = $selector.find('.button, .content');

    for (var q = 0; q < buttonsAndContents.length; q += 1) {
      if (buttonsAndContents[q].className == 'button') {
          buttonsAndContents[q].textContent = 'hide';
      }
  }

  function changeVisibility() {
    var $clickedButton = $(this);
    var $currentContentElement = findContentSiblingIfExist($clickedButton);

    if($currentContentElement != null){
      if($currentContentElement.css('display') == 'none'){
        $clickedButton.text('hide');
        $currentContentElement.css('display', '');
      } else {
        $currentContentElement.css('display', 'none');
        $clickedButton.text('show');
      }
    }
  }

  function findContentSiblingIfExist(currentButton) {

    var $currentSibling = $(currentButton).next();

    while($currentSibling){
      if($currentSibling.hasClass('content')){
        return $currentSibling;
      } else if($currentSibling == null || $currentSibling == undefined || $currentSibling.hasClass('button')) {
return null;
      }
      $currentSibling = $currentSibling.next();
    }
  }
  };
};

module.exports = solve;