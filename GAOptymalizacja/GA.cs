using System;
using System.Collections.Generic;
using System.Globalization;
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
        Dictionary<double, double> points = new Dictionary<double, double>();
        double[,] limitation;
        private string child;
        private string mutantChild;
        private double X1Max, X1Min, X2Max, X2Min;
        private string function;
        private int chromosomeSize;
        private double mutationprob;
        private double crossoverProb;
        private int populationSize;
        private int generations;
        private int selectionTournamentSize = 3;

        public GA(string function, string X1Max, string X1Min, string X2Max, string X2Min, string wielkośćPopulacji, string krzyżowanieProp, string mutacjaProp, string Epoki, List<int> partialLengths )
        {
            this.function = function;
            this.X1Max = Double.Parse(X1Max, CultureInfo.InvariantCulture);
            this.X1Min = Double.Parse(X1Min, CultureInfo.InvariantCulture);
            this.X2Max = Double.Parse(X2Max, CultureInfo.InvariantCulture);
            this.X2Min = Double.Parse(X2Min, CultureInfo.InvariantCulture);
            this.populationSize = Int32.Parse(wielkośćPopulacji);
            this.crossoverProb = Double.Parse(krzyżowanieProp, CultureInfo.InvariantCulture);
            this.mutationprob = Double.Parse(mutacjaProp, CultureInfo.InvariantCulture);
            this.generations = Int32.Parse(Epoki);
            this.partialLengths = partialLengths;

            limitation = new double[,] { { this.X1Max, this.X1Min }, { this.X2Max, this.X2Min } };
        }


     

        

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

        private double evaluationOfAdaptation(string genes, string function)
        {

            var unknown = calculateUnknown(genes);

            if(function == "Rastrigin")
            {
                var rastrigin = 20 + (Math.Pow(unknown.ElementAt(0), 2) - 10 * Math.Cos(2 * Math.PI * unknown.ElementAt(0))) + (Math.Pow(unknown.ElementAt(1), 2) - 10 * Math.Cos(2 * Math.PI * unknown.ElementAt(1)));
                return rastrigin;
            }
            else if(function == "Michalewicz")
            {
                var michalewicz = (Math.Sin(unknown.ElementAt(0)) * (Math.Pow(Math.Sin(Math.Pow(unknown.ElementAt(0), 2) / Math.PI), 2)) + Math.Sin(unknown.ElementAt(1) * (Math.Pow(Math.Sin(Math.Pow(2 * unknown.ElementAt(0), 2) / Math.PI), 10))));
                return -michalewicz;
            
            }
            return 0;
            
        }

        private string bestChromosome(string currentBest, List<string> population)
        {
            double bestScore = currentBest == "" ? 9999 : evaluationOfAdaptation(currentBest, function);
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


        public Dictionary<double, double> evolve()
        {
            //rastigin
            #region rastigin

            double length = partialLengths.ElementAt(0) + partialLengths.ElementAt(1);
            
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
                    bestAdapted.Add(evaluationOfAdaptation(chromosome, function));
                }


                best = bestChromosome(best, population);
                tmpPop = selection(population, bestAdapted);

                population = reproduce(tmpPop);

                points.Add((double)j, evaluationOfAdaptation(best, function));
                Console.WriteLine(best + "Score: " + evaluationOfAdaptation(best, function));
            }

            return points;
        }
    }
}
