
    var rand = new Random();
    StreamReader inputfile;
    inputfile = File.OpenText("Objectives.txt");
    string[] objectives = inputfile.ReadToEnd().Split('\n');
    int i = objectives.Length;
    int cobjective = 0;
    while (cobjective < 25 && cobjective < objectives.Length)
    {
        int RObjective = rand.Next(0, i);
        Console.WriteLine(objectives[RObjective]);
        cobjective++;
    }