public static class InterviewQuestion
{
    public static string[] Union(string[] words1, string[] words2)
    {
        var set = new HashSet<string>();

        foreach (var word in words1)
        {
            set.Add(word);
        }

        foreach (var word in words2)
        {
            set.Add(word);
        }

        return set.ToArray();
    }

    public static string[] Intersection(string[] words1, string[] words2)
    {
        var set = new HashSet<string>();
        var result = new HashSet<string>();

        foreach (var word in words1)
        {
            set.Add(word);
        }

        foreach (var word in words2)
        {
            if (set.Contains(word))
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}