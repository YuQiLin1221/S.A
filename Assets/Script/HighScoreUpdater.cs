using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScoreUpdater : MonoBehaviour
{
    private string filePath;

    private void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "highScores.txt");
    }

    public void UpdateHighScore(string user, int score)
    {
        List<string> lines = new List<string>();

        if (File.Exists(filePath))
        {
            lines.AddRange(File.ReadAllLines(filePath));
        }

        lines.Add($"{user}: {score}");

        // Sort scores in descending order
        lines.Sort((a, b) => int.Parse(b.Split(':')[1].Trim()).CompareTo(int.Parse(a.Split(':')[1].Trim())));

        // Keep only top 10 scores
        if (lines.Count > 10)
        {
            lines.RemoveRange(10, lines.Count - 10);
        }

        File.WriteAllLines(filePath, lines.ToArray());
    }
}
