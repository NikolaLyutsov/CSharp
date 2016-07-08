'use strict';
function solve(args) {
    let output = '';
    let matchTags = /<.*?>/ig;

    for (let line of args) {
        output += line.replace(matchTags, '').trim();
    }

    console.log(output);
}
solve(['<html>',
        '  <head>',
        '    <title>Sample site</title>',
        '  </head>',
        '  <body>',
        '    <div>text',
        '      <div>more text</div>',
        '      and more...',
        '    </div>',
        '    in body',
        '  </body>',
        '</html>'
    ]);