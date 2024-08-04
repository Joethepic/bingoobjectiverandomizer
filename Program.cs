
    var rand = new Random();
    StreamReader inputfile;
    inputfile = File.OpenText("Objectives.txt");
    string[] objectives = inputfile.ReadToEnd().Split('\n');
    int i = objectives.Length;
Console.WriteLine("Type how many objectives you would like to have rolled from your objective list");
int nobjectives = Convert.ToInt32(Console.ReadLine());
int cobjective = 0;
while (cobjective < nobjectives && cobjective < objectives.Length)
{
    int RObjective = rand.Next(0, i);
    Console.WriteLine(objectives[RObjective]);
    cobjective++;
}
