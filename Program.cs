//Lists
//Lists, like arrays, are a "Class" that holds a collection of data
//Boo! I have invaded your comments -Maddie

//Blank List
//Unlike arrays, a blank list does NOT need to define how many spaces it has available
//You can expand your lists as much or as little as you like. 
List<string> colors = new List<string>();

//The other advantage of lists is that they have a cacophany of methods that help you manipulate your data
colors.Add("Blue");

//Accessing  Values inside of a List
//We treat this list in a almost identical fashion to how we get data from an array, with its indexes! 
Console.WriteLine(colors[0]);

colors.Insert(0, "Red");

Console.WriteLine(colors[0]);
Console.WriteLine(colors[1]);
Console.WriteLine("-----------------------");
colors.Add("Yellow");
//foreach goes through ALL of the pieces of your List, saves it into the local variable, runs the code, and then starts over with the next piece until all pieces have been run through the code
foreach(string color in colors){
    Console.WriteLine(color);
}

Console.WriteLine("-----------------------");
Console.WriteLine("Let's put our values in alphabetical order!");
colors.Sort(); 
foreach(string color in colors){
    Console.WriteLine(color);
}

List<int> numbers = new List<int>{4, 5, 7, 15, 3};
numbers.Sort(); 
foreach(int num in numbers){
    Console.WriteLine(num);
}

//What about if I need to know how long my list is? 
//.Length will not work, that is for arrays!
Console.WriteLine(numbers.Count);
Console.WriteLine("-----------------------");

//So we know how to add things in, both on the end or in a specific place, what about removing items?
//.Remove() will removed a very specific item by matching whatever you pass in.
numbers.Remove(15);

//.RemoveAt() will take an item out at the provided index
// numbers.RemoveAt(0);
foreach(int num in numbers){
    Console.WriteLine(num);
}
Console.WriteLine("-----------------------");

//How to tell if a given value exists
//Contains returns a bool
Console.WriteLine(numbers.Contains(22));
if(numbers.Contains(39)){
    numbers.Remove(7);
}
else{
    Console.WriteLine("The list does not contain that value!");
}
foreach(int num in numbers){
    Console.WriteLine(num);
}

Console.WriteLine("The number 5 is at the index of: " + numbers.IndexOf(5));
Console.WriteLine("-----------------------");

List<int> reverseMe = new List<int>{1, 2, 3, 4, 5};
reverseMe.Reverse(); 
foreach(int num in reverseMe){
    Console.WriteLine(num);
}


//List of Arrays
string[] julius = {"Julius", "21", "Blue"};

List<string[]> students = new List<string[]>{
    new string[] {"David", "40", "Blue"},
    new string[] {"Bryan", "30", "Black"},
    new string[] {"Duc", "37", "Yellow"},
    julius
};

foreach(string[] data in students){
    Console.WriteLine(data[2]);
}
            //Name of List    index of list      Index of internal array
Console.WriteLine(students    [3]                [2]);

// for(int i = 0; i < 4; i++){
//     Console.WriteLine("Info about the student " + students[i][0] + ":");
//     Console.WriteLine("Age: " + students[i][1]);
//     Console.WriteLine("Favorite Color: " + students[i][2]);
//     Console.WriteLine("-----------------------");
// }

//Nested for loops
//This will allow you to print out all the pieces from your arrays in the list in order
Console.WriteLine("-----------------------");

for(int i = 0; i < students.Count; i++){
    for(int j = 0; j < students[i].Length; j++){
        Console.Write(students[i][j] + "  ");
    }
    Console.WriteLine("");
    Console.WriteLine("------------------");
}
