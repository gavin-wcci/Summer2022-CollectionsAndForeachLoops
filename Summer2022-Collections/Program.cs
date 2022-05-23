//Collections

//Arrays
//Make a collection of people
//type[] arrayName = { item1 , item2 , item3 , etc }
string[] people = {"Gavin", "Davis", "Michael", "Thomas", "Emily"};
//initializing an array with just the length
string[] pets = new string[5];

//showing an individual item in the array to the console
Console.WriteLine(people[4]);

//changing an individual index in a collection
people[0] = "Aden";
//The ^above^ line of code changes the value of the name at position 0 (also known as the first item in the array). So when we print it, instead of "Gavin" it will say "Aden"
Console.WriteLine(people[0]);

//foreach loop
//a loop that allows us to act upon all items within a collection
foreach (string person in people)
{
    Console.WriteLine(person + "!");
}

//List
// a collection that can grow and shrink 
// Making a new list:
List<string> students = new List<string>();
// showing the number of items in the list:
Console.WriteLine(students.Count + ": after initialization");
//adding a student to the list:
students.Add("Miguel");
//getting the updated count to show it has grown (not required):
Console.WriteLine(students.Count + ": after adding one student");
//adding another collection to the list:
students.AddRange(people);
//getting the updated count to show it has grown (not required):
Console.WriteLine(students.Count + ": after adding the people array");
//printing out each student in our students list:
Console.WriteLine(students[0]);
foreach (string student in students)
{
    Console.WriteLine(student);
}


