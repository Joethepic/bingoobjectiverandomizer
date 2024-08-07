
    var rand = new Random();
Console.WriteLine("Please enter the objectives you would like to add to the list please press enter after each objective. Type 'exit' when you have finished all your objectives");
string objective = Console.ReadLine();
StreamWriter outputfile;
outputfile = File.AppendText("Objectives.txt");
while (objective != "exit")
{
    outputfile.WriteLine(objective);
    objective = Console.ReadLine();
}
    outputfile.Close();
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
inputfile.Close(); 
