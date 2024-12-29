
using Core.Helper.Helper;

var peoples = new List<People>()
{
    new People()
    {
        Id = "1",
        Name = "Ninh",
        Age = "21"
    },
    new People()
    {
        Id = "2",
        Name = "Nam",
        Age = "25"
    }
};
var peopleDTO = SimpleMappingHelper.Mapping<People, PeopleDTO>(peoples);
foreach (var p in peopleDTO)
{
    Console.WriteLine(p);
}

class People
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
}
class PeopleDTO
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"Hello my name is {Name}, age is {Age} and Id: {Id}";
    }
}