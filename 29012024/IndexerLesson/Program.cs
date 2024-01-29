

using IndexerLesson;
using IndexerLesson.Exceptions;

Group gr = new Group("P101", new Student[2] {new Student("Hikmet",77), new Student("Nermin", 77) });


getName:
Console.WriteLine("ilk telebenin adini daxil edin:");
string name = Console.ReadLine();
try
{
    gr.StudentList[0] = new Student(name, 55);
}
catch (DublicateStudentException e)
{
    Console.WriteLine(e.Message);
    goto getName;
}

Console.WriteLine(gr.StudentList[0]);
Console.WriteLine(gr.StudentList[1]);



