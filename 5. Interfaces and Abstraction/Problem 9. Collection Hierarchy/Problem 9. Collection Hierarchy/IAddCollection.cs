
using System.Collections.Generic;

public interface IAddCollection
{
    List<string> Collection { get; set; }
    int Add(string item);
}
