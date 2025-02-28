using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace JSONHandeling
{
    internal class Program16
    {
        static void Main()
        {
            string jsonFilePath = "IPL_Matches.json";
            string csvFilePath = "IPL_Matches.csv";
            string censoredJsonPath = "Censored_IPL_Matches.json";
            string censoredCsvPath = "Censored_IPL_Matches.csv";

            // Process JSON
            if (File.Exists(jsonFilePath))
            {
                var matches = ReadJson(jsonFilePath);
                ApplyCensorship(matches);
                WriteJson(matches, censoredJsonPath);
            }

            // Process CSV
            if (File.Exists(csvFilePath))
            {
                var matches = ReadCsv(csvFilePath);
                ApplyCensorship(matches);
                WriteCsv(matches, censoredCsvPath);
            }

            Console.WriteLine("Censorship applied successfully. Check output files.");
        }

        // Function to Mask Team Names
        static string MaskTeamName(string team)
        {
            var words = team.Split(' ');
            if (words.Length > 1)
                words[1] = "***";
            return string.Join(" ", words);
        }

        // Function to Read JSON
        static List<Match> ReadJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Match>>(json);
        }

        // Function to Write JSON
        static void WriteJson(List<Match> matches, string filePath)
        {
            string json = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Function to Read CSV
        static List<Match> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<Match>().ToList();
            }
        }

        // Function to Write CSV
        static void WriteCsv(List<Match> matches, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(matches);
            }
        }

        // Function to Apply Censorship
        static void ApplyCensorship(List<Match> matches)
        {
            foreach (var match in matches)
            {
                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                // Update scores dictionary keys
                Dictionary<string, int> newScores = new Dictionary<string, int>();
                foreach (var entry in match.Score)
                {
                    newScores[MaskTeamName(entry.Key)] = entry.Value;
                }
                match.Score = newScores;
            }
        }
    }

    // Match Class to Map JSON and CSV Data
    public class Match
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
}
