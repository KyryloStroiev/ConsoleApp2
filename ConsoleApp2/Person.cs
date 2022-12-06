using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public Person( int id, string name, string lastname )
    {
        Id = id;
        Name = name;
        LastName = lastname;
    }
    public Person() { }
}
