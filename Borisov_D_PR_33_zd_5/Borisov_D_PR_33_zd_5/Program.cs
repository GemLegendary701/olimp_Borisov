string[] lines = File.ReadAllLines("input.txt");
int n = int.Parse(lines[0]);
string[] speedTime = lines[1].Split(' ');
int v = int.Parse(speedTime[0]);
int t = int.Parse(speedTime[1]);
int rast = v * t;
int k = rast % n;
File.WriteAllText("output.txt", k.ToString());
