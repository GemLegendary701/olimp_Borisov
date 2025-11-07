string[] parts = File.ReadAllText("input.txt").Split();
int k = int.Parse(parts[0]);
int n = int.Parse(parts[1]);
int res = n / k;
File.WriteAllText("output.txt", res.ToString());
