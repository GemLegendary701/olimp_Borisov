string[] lines = File.ReadAllLines("input.txt");
int n = int.Parse(lines[0]);
using (StreamWriter wr = new StreamWriter("output.txt"))
{
    for (int i = 1; i <= n; i++)
    {
        bool isPalind = true;
        string word = lines[i];
        int right = word.Length - 1;
        int left = 0;
        while (left < right)
        {
            if (char.ToUpper(word[left]) != char.ToUpper(word[right]))
            {
                isPalind = false;
                break;
            }
            left++;
            right--;
        }
        wr.WriteLine(isPalind ? "YES" : "NO");
    }
}
