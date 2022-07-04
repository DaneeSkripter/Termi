// TERMI
// DEVELOPED BY DANEESKRIPTER
// MIT LICENSE
// DANEESKRIPTER © 2022 

Console.WriteLine("Hello, my name is Termi, I am terminal assistent. I'm here for you!");

Random rd = new Random();
for(int l=1; l < 50; l--) {
    string input = Console.ReadLine();
    // ANSWERS
    // IF YOU WANT TO TRANSLATE TERMI, PLEASE CHANGE THESE ANSWERS
    string[] greetings = { "hello", "hi", "hey", "sup" };

    if (greetings.Contains(input.ToLower()))
    {
        Console.Clear();
        int gr = rd.Next(1, 4);
        Console.WriteLine(greetings[gr]);
    }
}

