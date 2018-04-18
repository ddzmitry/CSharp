<Query Kind="Statements" />


var list = new List<int>(){73,32,76,79,86,69};
Console.WriteLine(list.Select(x => (char)x));
var fizzBuzz = list.ToDictionary(x => x.ToString(),x => x %15 ==0 ? "fizzBuzz":x%3==0? "Fizz":x%5==0? "Buzz":x.ToString());
Console.WriteLine(fizzBuzz);

var li = new Dictionary<int,string>(){
	{0,"Dzmitry"},
	{1,"Anastasia"},
	{2,"Sophie"},
	
};

Console.WriteLine(li[2]);
