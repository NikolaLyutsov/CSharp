function solve(args){
  var persons = [],
  youngestPerson = {},
  i;

  for (i = 0; i < args.length; i+=3) {
    persons[i/3] = makePerson(args[i], args[i+1], +args[i+2]);
  }

  youngestPerson = persons[0];

  for (i = 1; i < persons.length; i++) {
    if (youngestPerson.age > persons[i].age) {
      youngestPerson = persons[i];
    }
  }

  console.log(youngestPerson.firstname + ' ' + youngestPerson.lastname);

function makePerson(firstname, lastname, age){
  return{
    firstname: firstname,
    lastname: lastname,
    age: age
  };
}
}
solve([
  'Gosho', 'Petrov', '32',
  'Bay', 'Ivan', '81',
  'John', 'Doe', '42'
]);
