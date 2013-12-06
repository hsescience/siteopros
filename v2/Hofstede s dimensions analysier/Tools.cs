using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Hofstede_s_dimensions_analysier
{
    public class Tools
    {
        public static long transitionFromDec(long value,
                                                int basement) //number of levels for dimensions
        {
            long res = 0, k = 1;
            while (value > 0)
            {
                res = res + (value % basement) * k;
                k *= 10;
                value /= basement;
            }
            return res;
        }

        public static double generateNumberOfSets(int numberOfLevels,
                                                    int numberOfDimensions)
        {
            return Math.Pow(numberOfLevels, numberOfDimensions);
        }

        public static int[] splitIntoDigits(long number,
                                                int numberOfLevels,
                                                int numberOfDimensions)
        {
            //long nonDecNumber = Tools.transitionFromDec(number, numberOfLevels);
            int[] digits = new int[numberOfDimensions];

            digits[numberOfDimensions - 1] = ((int)(number % 10));
            for (int i = 1; i <= numberOfDimensions; i++)
            {

                if (number == 0)
                {
                    break;
                }

                else
                {
                    digits[numberOfDimensions - i] = ((int)(number % 10));
                    number /= 10;
                }
            }
            return digits;
        }

        public static List<string> hypercubeCellParser(int[] cellIndex, string[, , , , ,] hypercube, bool[] missingRanks)
        {
            List<string> clearedSentences = new List<string>();
            string[] stringSeparators = new string[] { "\n" };
            string[] sentences = hypercube[cellIndex[0],
                                            cellIndex[1],
                                            cellIndex[2],
                                            cellIndex[3],
                                            cellIndex[4],
                                            cellIndex[5]].Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < missingRanks.Length; i++)
            {
                if (missingRanks[i])
                {
                    string[] partsSeparator;
                    string[] parts;

                    try
                    {
                        partsSeparator = new string[] { "metaphors: " };
                        parts = sentences[1].Split(partsSeparator, StringSplitOptions.None);
                        sentences[1] = sentences[1].Replace(parts[i + 2], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "mentalModels: " };
                        parts = sentences[2].Split(partsSeparator, StringSplitOptions.None);
                        sentences[2] = sentences[2].Replace(parts[i + 2], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "navigation: " };
                        parts = sentences[3].Split(partsSeparator, StringSplitOptions.None);
                        sentences[3] = sentences[3].Replace(parts[i + 2], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "interaction: " };
                        parts = sentences[4].Split(partsSeparator, StringSplitOptions.None);
                        sentences[4] = sentences[4].Replace(parts[i + 2], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "appearance: " };
                        parts = sentences[5].Split(partsSeparator, StringSplitOptions.None);
                        sentences[5] = sentences[5].Replace(parts[i + 2], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "fonts: " };
                        parts = sentences[6].Split(partsSeparator, StringSplitOptions.None);
                        sentences[6] = sentences[6].Replace(parts[parts.Length - i - 1], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "colors: " };
                        parts = sentences[7].Split(partsSeparator, StringSplitOptions.None);
                        sentences[7] = sentences[7].Replace(parts[parts.Length - i - 1], "");
                    }
                    catch (Exception ex) { }
                    try
                    {
                        partsSeparator = new string[] { "images: " };
                        parts = sentences[8].Split(partsSeparator, StringSplitOptions.None);
                        sentences[8] = sentences[8].Replace(parts[parts.Length - i - 1], "");
                    }
                    catch (Exception ex) { }
                }
            }

            for (int i = 1; i < sentences.Length - 2; i++) //missing combination code string in the beggining and two empty strings in the end
            {
                switch (i)
                {
                    case 1:
                        sentences[i] = sentences[i].Replace("metaphors: ", "");
                        sentences[i] = sentences[i].Replace("metaphors: ", "");
                        sentences[i] = sentences[i].Replace("Metaphors:", "");
                        sentences[i] = sentences[i].Replace("metaphors:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 2:
                        sentences[i] = sentences[i].Replace("mentalModels: ", "");
                        sentences[i] = sentences[i].Replace("MentalModels: ", "");
                        sentences[i] = sentences[i].Replace("mentalModels:", "");
                        sentences[i] = sentences[i].Replace("MentalModels:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 3:
                        sentences[i] = sentences[i].Replace("navigation: ", "");
                        sentences[i] = sentences[i].Replace("Navigation: ", "");
                        sentences[i] = sentences[i].Replace("navigation:", "");
                        sentences[i] = sentences[i].Replace("Navigation:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 4:
                        sentences[i] = sentences[i].Replace("interaction: ", "");
                        sentences[i] = sentences[i].Replace("Interaction: ", "");
                        sentences[i] = sentences[i].Replace("interaction:", "");
                        sentences[i] = sentences[i].Replace("Interaction:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 5:
                        sentences[i] = sentences[i].Replace("appearance: ", "");
                        sentences[i] = sentences[i].Replace("Appearance: ", "");
                        sentences[i] = sentences[i].Replace("appearance:", "");
                        sentences[i] = sentences[i].Replace("Appearance:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 6:
                        sentences[i] = sentences[i].Replace("fonts: ", "");
                        sentences[i] = sentences[i].Replace("Fonts: ", "");
                        sentences[i] = sentences[i].Replace("fonts:", "");
                        sentences[i] = sentences[i].Replace("Fonts:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 7:
                        sentences[i] = sentences[i].Replace("colors: ", "");
                        sentences[i] = sentences[i].Replace("Colors: ", "");
                        sentences[i] = sentences[i].Replace("Colors:", "");
                        sentences[i] = sentences[i].Replace("colors:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                    case 8:
                        sentences[i] = sentences[i].Replace("images: ", "");
                        sentences[i] = sentences[i].Replace("Images: ", "");
                        sentences[i] = sentences[i].Replace("images:", "");
                        sentences[i] = sentences[i].Replace("Images:", "");
                        clearedSentences.Add(sentences[i]);
                        break;
                }
            }

            return clearedSentences;
        }

        public static void writeVote(string code,
            double PDI_mark,
            double IDV_mark,
            double MAS_mark,
            double UAI_mark,
            double LTO_mark,
            double IVR_mark,
            string country, string UIfeature, bool like)
        {
            StreamWriter sw = new StreamWriter(@"C:\ВШЭ\4 курс\Диплом\Hofstede s dimensions analysier\Hofstede s dimensions analysier\docs\results.txt", true);
            sw.WriteLine("\n" + code);
            sw.WriteLine(PDI_mark + " " +
            IDV_mark + " " +
            MAS_mark + " " +
            UAI_mark + " " +
            LTO_mark + " " +
            IVR_mark);
            sw.WriteLine(country);
            sw.WriteLine(UIfeature);
            if (like)
                sw.WriteLine("Like");
            else
                sw.WriteLine("Dislike");
            sw.WriteLine();
            sw.Close();
        }

        public static void writeFeedback(string code,
            double PDI_mark,
            double IDV_mark,
            double MAS_mark,
            double UAI_mark,
            double LTO_mark,
            double IVR_mark,
            string country, string feedback)
        {
            StreamWriter sw = new StreamWriter(@"C:\ВШЭ\4 курс\Диплом\Hofstede s dimensions analysier\Hofstede s dimensions analysier\docs\results.txt", true);
            sw.WriteLine("\nFeedback");
            sw.WriteLine(code);
            sw.WriteLine(PDI_mark + " " +
            IDV_mark + " " +
            MAS_mark + " " +
            UAI_mark + " " +
            LTO_mark + " " +
            IVR_mark);
            sw.WriteLine(country);
            //foreach (string str in feedback)
            sw.WriteLine(feedback);
            sw.WriteLine();
            sw.Close();
        }
    }
}
