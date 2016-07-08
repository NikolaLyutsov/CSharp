function solve(args) {
    var input = args[0].split('\n'),
    n = +input[0],
    arr = input[1].split(' '),
    k,
    count = 0;

    for(k = 0; k < n - 1; k += 1) {
        if(Bigger(k, arr)){
            count += 1;
        }
    }

    console.log(count);

    function Bigger(i, array) {
        if(+i === 0 || +i >= array.lenght - 1){
            return false;
        }

        if(+array[i] > +array[i - 1] && +array[i] > +array[i + 1]){
            return true;
        } else{
            return false;
        }
    }
}
