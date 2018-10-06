$.fn.colorpicker = function() {

    let $root = $(this);

    let $colorPickerPanel = $('<div/>')
        .addClass('color-picker-panel')
        .css('width', '100px')
        .css('heigth', '300px')
        .css('position', 'relative')
        .hide()
        .appendTo($root);

    let $hexInput = $('<input/>')
        .addClass('input-hex')
        .val('HEX')
        .css('color', '#C4C4C6')
        .css('position', 'absolute')
        .css('top', '200px')
        .css('left', '30px')
        .css('width', '130px')
        .appendTo($colorPickerPanel);

    let $secondInput = $('<input/>')
        .addClass('input-RGB')
        .val('RGB')
        .css('color', '#C4C4C6')
        .css('position', 'absolute')
        .css('top', '230px')
        .css('left', '30px')
        .css('width', '130px')
        .appendTo($colorPickerPanel);

    let $thirdInput = $('<input/>')
        .addClass('input-the-color')
        .css('position', 'absolute')
        .css('top', '195px')
        .css('left', '200px')
        .css('width', '130px')
        .css('height', '60px')
        .appendTo($colorPickerPanel);

    let $closeButton = $('<img/>')
        .addClass('exit-button')
        .attr('src', '../task-2/imgs/close.png')
        .css('width', '32px')
        .css('heigth', '32px')
        .css('position', 'absolute')
        .css('top', '10px')
        .css('left', '10px')
        .appendTo($colorPickerPanel)
        .click(function() {
            $colorPickerPanel.hide();
            $root.css('width', '40px').css('height', '40px');
            $img.show();
        });


    let $colorPalete = $('<img/>')
        .addClass('color-palete')
        .attr('src', '../task-2/imgs/color-picker.png')
        .css('width', '300px')
        .css('height', '160px')
        .css('position', 'absolute')
        .css('top', '10px')
        .css('left', '65px')
        .appendTo($colorPickerPanel);




    let canvas = document.createElement('canvas');

    canvas.width = $colorPalete.css('width');
    canvas.height = $colorPalete.css('height');
    let $canvas = $(canvas);
    $canvas.appendTo($colorPickerPanel);
    //canvas.drawImage($colorPalete, 0, 0, $colorPalete.css('width'), $colorPalete.css('height'));

    let $img = $('<img/>')
        .addClass('color-picker-img')
        .attr('src', "../task-2/imgs/icon.jpg")
        .css('width', '40px')
        .css('heigth', '40px')
        .appendTo($root)
        .click(function() {
            $(this).hide();
            $root.css('width', '400px').css('height', '300px');
            $colorPickerPanel.show();
        })


}