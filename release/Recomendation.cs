using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace Hofstede_s_dimensions_analysier
{
    public class Recomendation
    {
        public const int numberOfDimensions = 6;
        public const int numberOfLevels = 3;
        public const int numberOfUIfeatures = 10;

        private const string pathToHypercube = "C:\\ВШЭ\\4 курс\\Диплом\\Hofstede s dimensions analysier\\hypercube.txt";

        private string dimension;
        private string level;

        private string metaphors;       //Essential concepts in words, images, sounds, touch
        private string mentalModels;    //Organization of data, functions, tasks, roles, or people at work or play, static or mobile
        private string navigation;      //Movement through mental models via windows, dialogue boxes, buttons, links, etc.
        private string interaction;     //Input/output techniques, feedback
        private string appearance;      //Visual, verbal, acoustic, tactile

        private string fonts;
        private string colors;
        private string images;

        public Recomendation(string dimension, //constructor
                                    string level,
                                    string metaphors,
                                    string mentalModels,
                                    string navigation,
                                    string interaction,
                                    string appearance,
                                    string fonts,
                                    string colors,
                                    string images)
        {
            this.dimension = dimension;
            this.level = level;
            this.metaphors = metaphors;
            this.mentalModels = mentalModels;
            this.navigation = navigation;
            this.interaction = interaction;
            this.appearance = appearance;
            this.fonts = fonts;
            this.colors = colors;
            this.images = images;
        }

        public static List<Recomendation> SetToDefault()
        {
            string[] allStrings = File.ReadAllLines("default_ru.txt", Encoding.Default);
            List<Recomendation> l = new List<Recomendation>();
            for (int i = 0; i < numberOfUIfeatures * numberOfDimensions * numberOfLevels; i += 3 * numberOfUIfeatures + 1)
            {
                int k = i;
                Recomendation s = new Recomendation(allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++]);

                l.Add(s);

                for (int j = 0; j < numberOfLevels - 1; j++)
                {
                    k++;
                    s = new Recomendation(allStrings[i],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++],
                                                                allStrings[k++]);
                    l.Add(s);
                }
            }
            return l;
        }

        public static string[, , , , ,] transformToCube(List<Recomendation> list) //do not forget to change number of dimensions!
        {
            if (File.Exists(pathToHypercube))
            {
                File.Delete(pathToHypercube);
            }

            // Create the file.
            using (FileStream fs = File.Create(pathToHypercube)) { }

            string[, , , , ,] hypercube = new string[numberOfLevels, numberOfLevels, numberOfLevels, numberOfLevels, numberOfLevels, numberOfLevels];

            double numberOfRecomendations = Tools.generateNumberOfSets(numberOfLevels, numberOfDimensions);
            for (int i = 0; i < numberOfRecomendations; i++)
            {
                long numberOnNewBase = Tools.transitionFromDec(i, numberOfLevels);
                int[] digits = Tools.splitIntoDigits(numberOnNewBase, numberOfLevels, numberOfDimensions);
                string numberOfRecomendation = digits[0].ToString() + digits[1].ToString() + digits[2].ToString() + digits[3].ToString() + digits[4].ToString() + digits[5].ToString();

                string s = "metaphors: " + list[digits[0]].metaphors + " " + list[digits[1] + numberOfLevels].metaphors + " " + list[digits[2] + numberOfLevels * 2].metaphors + " " + list[digits[3] + numberOfLevels * 3].metaphors + " " + list[digits[4] + numberOfLevels * 4].metaphors + " " + list[digits[5] + numberOfLevels * 5].metaphors + "\n";
                hypercube[digits[0],
                            digits[1],
                            digits[2],
                            digits[3],
                            digits[4],
                            digits[5]] = i + " " + numberOfRecomendation + " \n" +
                                            "metaphors: " + list[digits[0]].metaphors + " " + list[digits[1] + numberOfLevels].metaphors + " " + list[digits[2] + numberOfLevels * 2].metaphors + " " + list[digits[3] + numberOfLevels * 3].metaphors + " " + list[digits[4] + numberOfLevels * 4].metaphors + " " + list[digits[5] + numberOfLevels * 5].metaphors + "\n" +
                                            "mentalModels: " + list[digits[0]].mentalModels + " " + list[digits[1] + numberOfLevels].mentalModels + " " + list[digits[2] + numberOfLevels * 2].mentalModels + " " + list[digits[3] + numberOfLevels * 3].mentalModels + " " + list[digits[4] + numberOfLevels * 4].mentalModels + " " + list[digits[5] + numberOfLevels * 5].mentalModels + "\n" +
                                            "navigation: " + list[digits[0]].navigation + " " + list[digits[1] + numberOfLevels].navigation + " " + list[digits[2] + numberOfLevels * 2].navigation + " " + list[digits[3] + numberOfLevels * 3].navigation + " " + list[digits[4] + numberOfLevels * 4].navigation + " " + list[digits[5] + numberOfLevels * 5].navigation + "\n" +
                                            "interaction: " + list[digits[0]].interaction + " " + list[digits[1] + numberOfLevels].interaction + " " + list[digits[2] + numberOfLevels * 2].interaction + " " + list[digits[3] + numberOfLevels * 3].interaction + " " + list[digits[4] + numberOfLevels * 4].interaction + " " + list[digits[5] + numberOfLevels * 5].interaction + "\n" +
                                            "appearance: " + list[digits[0]].appearance + " " + list[digits[1] + numberOfLevels].appearance + " " + list[digits[2] + numberOfLevels * 2].appearance + " " + list[digits[3] + numberOfLevels * 3].appearance + " " + list[digits[4] + numberOfLevels * 4].appearance + " " + list[digits[5] + numberOfLevels * 5].appearance + "\n" +
                                            "fonts: " + list[digits[0]].fonts + " " + list[digits[1] + numberOfLevels].fonts + " " + list[digits[2] + numberOfLevels * 2].fonts + " " + list[digits[3] + numberOfLevels * 3].fonts + " " + list[digits[4] + numberOfLevels * 4].fonts + " " + list[digits[5] + numberOfLevels * 5].fonts + "\n" +
                                            "colors: " + list[digits[0]].colors + " " + list[digits[1] + numberOfLevels].colors + " " + list[digits[2] + numberOfLevels * 2].colors + " " + list[digits[3] + numberOfLevels * 3].colors + " " + list[digits[4] + numberOfLevels * 4].colors + " " + list[digits[5] + numberOfLevels * 5].colors + "\n" +
                                            "images: " + list[digits[0]].images + " " + list[digits[1] + numberOfLevels].images + " " + list[digits[2] + numberOfLevels * 2].images + " " + list[digits[3] + numberOfLevels * 3].images + " " + list[digits[4] + numberOfLevels * 4].images + " " + list[digits[5] + numberOfLevels * 5].images + "\n" +
                                            "\n";

                System.IO.StreamWriter writer = new System.IO.StreamWriter(pathToHypercube, true, Encoding.Default);
                writer.WriteLine(hypercube[digits[0], digits[1], digits[2], digits[3], digits[4], digits[5]]);
                writer.Close();
            }
            return hypercube;
        }
    }
}
