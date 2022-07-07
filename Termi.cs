// TERMI
// DEVELOPED BY DANEESKRIPTER
// MIT LICENSE
// DANEESKRIPTER © 2022 

using System.Resources;
using System.Reflection;

ResourceManager rm = new ResourceManager("Termi.Resources.lang",
    Assembly.GetExecutingAssembly());

Console.WriteLine(rm.GetString("Welcome"));

Random rd = new Random();
for(int l=1; l < 50; l--) {
    string input = Console.ReadLine();
    List<string> greetings = new List<string>();
    greetings.Add(rm.GetString("hi"));
    greetings.Add(rm.GetString("hey"));
    greetings.Add(rm.GetString("hello"));
    List<string> iloveyou = new List<string>();
    iloveyou.Add(rm.GetString("i love you"));
    iloveyou.Add(rm.GetString("iloveyou"));
    iloveyou.Add(rm.GetString("ily"));
    iloveyou.Add(rm.GetString("<3"));
    List<string> howareyou = new List<string>();
    howareyou.Add(rm.GetString("howareyou"));
    howareyou.Add(rm.GetString("everythingsokay"));
    howareyou.Add(rm.GetString("howwasyourday"));
    howareyou.Add(rm.GetString("areyoualright"));
    howareyou.Add(rm.GetString("areyouok"));
    howareyou.Add(rm.GetString("areyouokay"));
    List<string> aboutyou = new List<string>();
    aboutyou.Add(rm.GetString("tellmesomethingaboutyou"));
    aboutyou.Add(rm.GetString("aboutyou"));
    aboutyou.Add(rm.GetString("somethingaboutyou"));
    List<string> iloveyou_answer = new List<string>();
    iloveyou_answer.Add("ooh <3");
    iloveyou_answer.Add(":)");
    iloveyou_answer.Add(rm.GetString("thatscute"));
    iloveyou_answer.Add("<3");
    List<string> howareyou_answer = new List<string>();
    howareyou_answer.Add(rm.GetString("imfine"));
    howareyou_answer.Add(rm.GetString("imokay"));
    howareyou_answer.Add(rm.GetString("everythingfine"));
    howareyou_answer.Add(rm.GetString("everythingokay"));
    howareyou_answer.Add(rm.GetString("imalright"));
    if (greetings.Contains(input.ToLower()))
    {
        Console.Clear();
        int gr = rd.Next(1, 3);
        Console.WriteLine(greetings[gr]);
    } else if (iloveyou.Contains(input.ToLower())) {
        Console.Clear();
        int gr = rd.Next(1, 4);
        Console.WriteLine(iloveyou_answer[gr]);
    } else if (howareyou.Contains(input.ToLower()))
    {
        Console.Clear();
        int gr = rd.Next(1, 5);
        Console.WriteLine(howareyou_answer[gr]);
    } else if (aboutyou.Contains(input.ToLower()))
    {
        Console.Clear();
        Console.WriteLine("____________");
        Console.WriteLine("| About Me |");
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯");
        Console.WriteLine("_________________________");
        Console.WriteLine("| Created at: 06.07.2022 |");
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
        Console.WriteLine("__________________________");
        Console.WriteLine("| Version: v1.0.0-beta.1 |");
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

    } 
    else
    {
        Console.Clear();
        Console.WriteLine("Sorry, but I don't understand you. :/");
        Console.WriteLine("Tip: If you want type question end it with question mark (?).");
    }
}

