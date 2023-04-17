string[] Array1 = {"Bob", "Constantinopolis", "Antiochia", "Arm", "451", "42"};
string[] Result = new string [Array1.Length];
int j = 0;
for(int i = 0; i < Array1.Length;i++)
{
    if (Array1[i].Length <=3)
    {
      Result[j] = Array1[i];
      j++;
    }
}
var str = string.Join(" ", Result);
Console.WriteLine(str);