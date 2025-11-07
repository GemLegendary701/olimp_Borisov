string[] lines = File.ReadAllLines("input.txt");
int n = int.Parse(lines[0]);
int[] diameters = lines[1].Split().Select(int.Parse).ToArray();
int[] indices = new int[diameters.Length];
for (int i = 0; i < indices.Length; i++)
{
    indices[i] = i + 1;
}
for (int i = 0; i < diameters.Length - 1; i++)
{
    for (int j = 0; j < diameters.Length - i - 1; j++)
    {
        if (diameters[j] > diameters[j + 1])
        {
            int tempDiam = diameters[j];
            diameters[j] = diameters[j + 1];
            diameters[j + 1] = tempDiam;

            int tempIdx = indices[j];
            indices[j] = indices[j + 1];
            indices[j + 1] = tempIdx;
        }
    }
}
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    for (int i = 0; i < n; i++)
    {
        int upperBallIndex = indices[i];
        int lowerBallIndex = indices[2 * n - 1 - i];
        writer.WriteLine($"{lowerBallIndex} {upperBallIndex}");
    }
}