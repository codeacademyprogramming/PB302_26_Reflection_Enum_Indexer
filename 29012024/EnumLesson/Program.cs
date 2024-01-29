
using EnumLesson;

Exercise ex1 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "Low"
};
Exercise ex2 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "High"
};
Exercise ex3 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "Medium"
};
Exercise ex4 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "Medium"
};
Exercise ex5 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "high"
};
Exercise ex6 = new Exercise
{
    Name = "Algorith1",
    Subject = "Programming",
    Level = "Advanced"
};

Group gr1 = new Group
{
    No = "P101",
    Type = GroupType.Programming
};

Group gr2 = new Group
{
    No = "P102",
    Type = GroupType.Design
};

Group gr3 = new Group
{
    No = "P104",
    Type = GroupType.Programming
};


Group[] groups = { gr1, gr2, gr3 };


Console.WriteLine("Group types:");
foreach (var item in Enum.GetNames(typeof(GroupType)))
{
    Console.WriteLine(item);
};

Console.WriteLine("\nGroup types:");
foreach (var item in Enum.GetValues(typeof(GroupType)))
{
    Console.WriteLine((byte)item+"-"+item);
};

string typeStr;
byte typeByte;
do
{
    Console.WriteLine("Select group type");
    typeStr = Console.ReadLine();
} while (!Byte.TryParse(typeStr,out typeByte) || !Enum.IsDefined(typeof(GroupType),typeByte));




//GroupType newGroupType = (GroupType)Enum.Parse(typeof(GroupType), typeStr);
GroupType newGroupType = (GroupType)typeByte;

Group gr4 = new Group
{
    No = "P105",
    Type = newGroupType
};

Console.WriteLine(gr4.Type);



foreach (var group in groups)
{
    if(group.Type == GroupType.Programming)
    {
        Console.WriteLine(group.No);
    }
}





