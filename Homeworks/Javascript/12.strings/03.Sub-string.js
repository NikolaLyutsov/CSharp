function solve(args) {
    var word = args[0].toLowerCase(),
    txt = args[1].toLowerCase();
    reg = new RegExp(word, 'g');
      console.log(txt.match(reg).length);
}
solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);