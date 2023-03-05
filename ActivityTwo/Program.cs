namespace TaskActivityTwo
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            TaskFourCases();
        }

        static void TaskOneCases()
        {
            TaskOne caseOne = new TaskOne(new int[] { 1, 3, 5 });
            TaskOne caseTwo = new TaskOne(new int[] { 4, 5, 6, 7, 8, 9 });
            TaskOne caseThree = new TaskOne(new int[] { 2, 1, 6, 9, 11 });
            TaskOne caseFour = new TaskOne(new int[] { 3, 1, 6, 7, 11 });
        }

        static void TaskTwoCases()
        {
            TaskTwo caseOne = new TaskTwo(new int[] { 1, 2, 4, 0, 0, 7, 5 });
            TaskTwo caseTwo = new TaskTwo(new int[] { 1, 0, 2, 4, 0, 5, 7 });
            TaskTwo caseThree = new TaskTwo(new int[] { 1, 7, 2, 0, 4, 5, 0 });
        }

        static void TaskThreeCases()
        {
            TaskThree caseOne = new TaskThree("a");
            TaskThree caseTwo = new TaskThree("b");
            TaskThree caseThree = new TaskThree("c");
            TaskThree caseFour = new TaskThree("d");
            TaskThree caseFive = new TaskThree("e");
        }

        static void TaskFourCases()
        {
            TaskFour caseOne = new TaskFour();
        }

        static void TaskFiveCases()
        {
            TaskFive caseOne = new TaskFive(new int[] { 10, 20, 10, 40, 50, 60, 70 }, 50);
        }
    }

    class TaskOne
    {
        public TaskOne(int[] numArr)
        {
            bool shouldSkip = false;
            int sum = 0;

            for(int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == 6)
                {
                    shouldSkip = true;
                    continue;
                }

                if (numArr[i] == 9)
                {
                    shouldSkip = false;
                    continue;
                }

                if (shouldSkip)
                {
                    continue;
                }

                sum += numArr[i];
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }

    class TaskTwo
    {
        public TaskTwo(int[] numArr)
        {
            int[] toMatch = new int[] {0,0,7};
            int[] zerosSeven = new int[] {};

            for (int i = 0; i < numArr.Length; i++)
            {
                if(zerosSeven.Length != 3)
                {
                    if (numArr[i] == 0 || numArr[i] == 7)
                    {
                        zerosSeven = zerosSeven.Append(numArr[i]).ToArray();
                    }
                }
                else
                {
                    break;
                }
            }

            bool isMatch = false;
            for (int i = 0; i < zerosSeven.Length; i++)
            {
                if (zerosSeven[i] == toMatch[i])
                {
                    isMatch = true;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(isMatch);
        }
    }

    class TaskThree
    {
        public Dictionary<string, string> bigLetters = new Dictionary<string, string>()
        {
            {"a", "  *  \n * * \n*****\n*   *\n*   *\n" },
            {"b", "**** \n*   *\n*****\n*   *\n**** \n" },
            {"c", "*****\n*    \n*    \n*    \n*****\n" },
            {"d", "**** \n*   *\n*   *\n*   *\n**** \n" },
            {"e", "*****\n*    \n*****\n*    \n*****\n" },
        };

        public TaskThree(string letter)
        {
            Console.WriteLine(this.bigLetters[letter]);
        }
    }

    class TaskFour
    {
        public TaskFour()
        {
            int x = 1, y = 2, z = 0;
            int sum = 2;
            int iteration = 2;

            Console.WriteLine("Fibonacci Sequence:");
            Console.Write(x + " " + y + " ");
            while(x + y < 4000000)
            {
                z = x + y;
                if(z % 2 == 0)
                {
                    sum += z;
                }
                Console.Write(z + " ");
                x = y;
                y = z;
                iteration++;
            }

            Console.WriteLine($"\nSum of even-values terms: {sum}");
        }
    }

    class TaskFive
    {
        public TaskFive(int[] numbers, int target)
        {
            bool isFound = false; ;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (isFound)
                {
                    break;
                }

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        Console.WriteLine($"Indices: {i},{j}");
                        isFound = true;
                        break;
                    }
                }
            }
        }
    }

    #region TaskSix
    /**
     * Task 6 algorithm;
     * 
     * 1. Chunk/Split list into 2 list.
     * 2. If the sum of one of the list is an odd number, 
     * repeat step 1 to the list which has the odd sum
     * until it comes down to 2 numbers and compare
     * which ones an odd number.
     * 
     * Example:
     * list = [2,3,8,10,16,4,20,12]
     * Chunk #1 and Compare Sum: [2,3,8,10] = Odd Sum, [16,4,20,12]
     * Chunk #2 and Compare Sum: [2,3] = Odd Sum [8,10]
     * Chunk #3 and Compare: [2,3] Odd = 3
    */
    #endregion
}