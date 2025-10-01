using System.Reflection.Metadata;

namespace Inlämning;

class Item
{
    public string Name;

    public string Description;

    public string Owner;

// constructor
    public Item(string name, string description, string owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }

} 
