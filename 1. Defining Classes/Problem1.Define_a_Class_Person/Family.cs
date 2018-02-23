using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private List<Person> persons;

    public Family()
    {
        this.persons=new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.persons.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.persons.OrderByDescending(x => x.Age).First();
    }

    public List<Person> GetFamilyMembersMoreThan30Years()
    {
       return persons.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
    }


}
