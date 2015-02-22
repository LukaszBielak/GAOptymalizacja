using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAOptymalizacja
{
    class GA
    {
        List<double> bestAdapted = new List<double>();
        List<string> tmpPop = new List<string>();
        List<int> partialLengths = new List<int>();
        private string child;
        private string mutantChild;
        private int chromosomeSize = 15;
        private double mutationprob = 0.50;
        private double crossoverProb = 0.50;
        private int populationSize = 30;
        private int generations = 100000;
        private int selectionTournamentSize = 3;

        double[,] limitation = new double[,] { { 12.1, -3 }, { 5.8, 4.1 } };

        Random rand = new Random();
        private string generateRandomGenes(int lenght)
        {
            string genes = "";

            while (genes.Length < lenght)
            {


                if (rand.NextDouble() <= 0.5)
                {
                    genes = genes + "0";
                }
                else
                {
                    genes = genes + "1";
                }
            }
            return genes;
        }

        private double evaluationOfAdaptation(string genes)
        {
            //int cost = 0;

            //for (int i = 0; i < genes.Length; i++)
            //{
            //    string c = genes.Substring(i, 1);

            //    if (c == "1")
            //    {
            //        cost = cost + 1;
            //    }
            //}
            //return cost;

            var unknown = calculateUnknown(genes);

            var funceval = 20 + (Math.Pow(unknown.ElementAt(0), 2) - 10 * Math.Cos(2 * Math.PI * unknown.ElementAt(0))) + (Math.Pow(unknown.ElementAt(1), 2) - 10 * Math.Cos(2 * Math.PI * unknown.ElementAt(1)));

            return funceval;
        }

        private string bestChromosome(string currentBest, List<string> population)
        {
            double bestScore = currentBest == "" ? 9999 : evaluationOfAdaptation(currentBest);
            string best = currentBest;
            int index = 0;
            foreach (var score in bestAdapted)
            {

                if (score < bestScore)
                {
                    bestScore = score;
                    best = population.ElementAt(index);
                }
                index++;
            }

            return best;
        }

        private List<string> selection(List<string> population, List<double> bestAdapted)
        {
            List<string> pop = new List<string>();

            do
            {
                string bestChromosome = "";
                double bestFitness = 9999;

                for (int i = 0; i < selectionTournamentSize; i++)
                {
                    int selection = rand.Next(0, bestAdapted.Count - 1);

                    if (bestAdapted.ElementAt(selection) < bestFitness)
                    {
                        bestFitness = bestAdapted.ElementAt(selection);
                        bestChromosome = population.ElementAt(selection);
                    }
                }
                pop.Add(bestChromosome);

            } while (pop.Count < population.Count);


            return pop;
        }
        private string crossover(string p1, string p2)
        {
            if (rand.NextDouble() > crossoverProb)
            {
                return p1;
            }
            else
            {
                int cut = rand.Next(1, p1.Length - 1);
                string s = "";

                for (int i = 0; i < cut; i++)
                {
                    s = s + p1.Substring(i, 1);
                }

                for (int j = cut; j < p2.Length; j++)
                {
                    s = s + p2.Substring(j, 1);
                }

                return s;
            }
        }

        private string mutation(string chromosome)
        {
            string s = "";

            for (int i = 0; i < chromosome.Length; i++)
            {
                string c = chromosome.Substring(i, 1);

                if (rand.NextDouble() < mutationprob)
                {
                    if (c == "0")
                    {
                        s = s + 1;
                    }
                    else
                    {
                        s = s + 0;
                    }
                }
                else
                {
                    s = s + c;
                }
            }
            return s;
        }


        private List<string> reproduce(List<string> tmpPop)
        {
            List<string> pop = new List<string>();

            for (int i = 0; i < tmpPop.Count; i++)
            {
                string p2 = null;
                if (i % 2 == 0)
                {
                    p2 = tmpPop.ElementAt(i + 1);
                }
                else
                {
                    p2 = tmpPop.ElementAt(i - 1);
                }

                child = crossover(tmpPop.ElementAt(i), p2);
                mutantChild = mutation(child);
                pop.Add(mutantChild);
            }

            return pop;
        }

        private double chromosomeLenght(double max, double min)
        {
            double zm = (max - min) * Math.Pow(10, 4);
            int pow = 0;
            double parialLenght = 0;
            do
            {
                pow++;
                parialLenght = Math.Pow(2, pow);

            } while (parialLenght < zm);

            return pow;
        }

        private List<double> calculateUnknown(string chromosome)
        {

            List<double> restriction = new List<double>();
            for (int i = 0; i < partialLengths.Count; i++)
            {
                string startPart = chromosome.Substring(0, partialLengths.ElementAt(i));
                chromosome = chromosome.Remove(0, partialLengths.ElementAt(i));
                long l = Convert.ToInt64(startPart, 2);

                double x = limitation[i, 1] + l * ((limitation[i, 0] - limitation[i, 1]) / (Math.Pow(2, partialLengths.ElementAt(i)) - 1));
                restriction.Add(x);
            }
            return restriction;

        }


        public string evolve()
        {
            //rastigin
            #region rastigin

            double length = 0;


            partialLengths = new List<int>();
            for (int r = 0; r <= 1; r++)
            {
                double partialLenght = chromosomeLenght(limitation[r, 0], limitation[r, 1]);
                length = length + partialLenght;
                partialLengths.Add((int)partialLenght);

            }
            chromosomeSize = (int)length;



            #endregion

            List<string> population = new List<string>();
            string best = "";

            for (int i = 1; i <= populationSize; i++)
            {
                population.Add(generateRandomGenes(chromosomeSize));
            }

            for (int j = 1; j <= generations; j++)
            {
                bestAdapted = new List<double>();
                foreach (var chromosome in population)
                {
                    bestAdapted.Add(evaluationOfAdaptation(chromosome));
                }

                best = bestChromosome(best, population);
                tmpPop = selection(population, bestAdapted);

                population = reproduce(tmpPop);

                Console.WriteLine(best + "Score: " + evaluationOfAdaptation(best));
            }

            return best;
        }
    }
}
