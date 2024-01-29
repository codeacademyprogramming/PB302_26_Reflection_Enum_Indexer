using Reflection;
using System.Reflection;

var assebmy = Assembly.GetExecutingAssembly();

Product pr1 = new Product();
Type ty;


ty = typeof(Product);
//ty = pr1.GetType();

Console.WriteLine(CheckClass(typeof(Product), Assembly.GetExecutingAssembly()));


Console.WriteLine("All members");
foreach (var member in ty.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
	Console.WriteLine(member.Name);
}

Console.WriteLine("\nAll fields");
foreach (var member in ty.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
	if(member.Name == "_price")
	{
        Console.WriteLine(member.Name);
		member.SetValue(pr1, 10);
    }
}

Console.WriteLine("\nAll methods");
foreach (var member in ty.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
	if(member.Name == "get_GetPrice")
	{
        Console.WriteLine(member.Invoke(pr1,null));
		break;
    }
}

Console.WriteLine(pr1.GetPrice);


Student std1 = new Student { Fullname = "Fullname1" };
Student std2 = new Student { Fullname = "Fullname2" };
Student std3 = new Student { Fullname = "Fullname3" };
Teacher tch1 = new Teacher(1500) { Fullname = "Fullname4" };
Teacher tch2 = new Teacher(2500) { Fullname = "Fullname5" };
Teacher tch3 = new Teacher(4500) { Fullname = "Fullname6" };

Human[] humans = {std1, std2, std3, tch1,tch2, tch3};

Console.WriteLine(CalcSumSalary(humans));

double CalcSumSalary(object[] humans)
{
    double total = 0;
    for (int i = 0; i < humans.Length; i++)
    {
        if (humans[i] is Teacher tch)
        {
            var salary = (double)tch.GetType().GetField("_salary", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).GetValue(tch);
            total += salary;
        }
    }

    return total;
}

void ShowFields(object obj)
{
    var type = obj.GetType();
    var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

    foreach ( var field in fields ) {
        Console.WriteLine(field.Name);
    }
}






bool CheckClass(Type classType,Assembly assembly)
{
	foreach (var type in assembly.GetTypes())
	{
		if (type == classType) return true;
	}

	return false;
}





