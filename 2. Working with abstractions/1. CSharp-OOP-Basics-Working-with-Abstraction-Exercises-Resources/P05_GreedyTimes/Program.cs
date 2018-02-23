using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3_Septeber
{
    class Program
    {
        static void Main(string[] args)
        {
            var bagCapacity = double.Parse(Console.ReadLine().Trim());
            var input = Console.ReadLine();
            var originalInput = input
                .Trim()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var lowarInput = input
                .Trim()
                .ToLower()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var currGoldAmount = 0d;
            var collection = new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase);
            var patternGem = @"(^| )[a-z]{1,}gem($| )";
            var patterncash = @"(^| )[a-z]{3}($| )";
            var gemRegex = new Regex(patternGem);
            var cashRegex = new Regex(patterncash);
            var gemSum = 0d;
            var cashSum = 0d;


            for (int i = 0; i < lowarInput.Length - 1; i++)
            {
                if (lowarInput[i] == "gold")
                {
                    if (currGoldAmount + double.Parse(originalInput[i + 1]) <= bagCapacity)
                    {
                        if (!collection.ContainsKey("Gold"))
                        {
                            collection["Gold"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                        }
                        if (!collection["Gold"].ContainsKey("Gold"))
                        {
                            collection["Gold"]["Gold"] = 0;
                        }

                        currGoldAmount = currGoldAmount + double.Parse(originalInput[i + 1]);
                        collection["Gold"]["Gold"] = currGoldAmount;
                    }
                }
                else if (gemRegex.IsMatch(lowarInput[i]))
                {
                    var currGem = originalInput[i];
                    var currGemAmount = double.Parse(originalInput[i + 1]);
                    if (gemSum + currGemAmount <= currGoldAmount && gemSum + currGemAmount + currGoldAmount + cashSum <= bagCapacity)
                    {
                        if (!collection.ContainsKey("Gem"))
                        {
                            collection["Gem"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                        }
                        if (!collection["Gem"].ContainsKey(currGem))
                        {
                            collection["Gem"][currGem] = 0;
                        }
                        collection["Gem"][currGem] = collection["Gem"][currGem] + currGemAmount;
                        gemSum = gemSum + currGemAmount;
                    }
                }
                else if (cashRegex.IsMatch(lowarInput[i]))
                {
                    var currCash = originalInput[i];
                    var currCashAmount = double.Parse(originalInput[i + 1]);
                    if (cashSum + currCashAmount <= gemSum && gemSum + cashSum + currCashAmount + currGoldAmount <= bagCapacity)
                    {
                        if (!collection.ContainsKey("Cash"))
                        {
                            collection["Cash"] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                        }
                        if (!collection["Cash"].ContainsKey(currCash))
                        {
                            collection["Cash"][currCash] = 0;
                        }
                        collection["Cash"][currCash] = collection["Cash"][currCash] + currCashAmount;
                        cashSum = cashSum + currCashAmount;
                    }
                }
            }

            foreach (var type in collection.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"<{type.Key}> ${type.Value.Values.Sum()}");
                foreach (var item in type.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}
