using Business.Concrete;
using Entities.Concrete;
using Workaround;

var person = new Person
{
    DateOfBirthYear = 2002,
    FirstName = "Jeyhun",
    LastName = "Abilov",
    NationalIdentity = 123
};

var list = new MyList<int>{5,6,8,4,0};

list.Add(10);

Console.WriteLine(list.Get(list.Count - 1));

var foreignerManager = new ForeignerManager();
var personManager = new PersonManager();

var pttManager = new PttManager(personManager);
pttManager.GiveMask(person);