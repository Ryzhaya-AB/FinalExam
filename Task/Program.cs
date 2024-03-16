string[] massOne = new string[5] { "window", "red", "13", "dog", "1458" };
            string[] massTwo = new string[massOne.Length];
            void FillMass(string[] massOne, string[] massTwo)
            {
                int count = 0;
                for (int i = 0; i < massOne.Length; i++)
                {
                    if (massOne[i].Length <= 3)
                    {
                        massTwo[count] = massOne[i];
                        count++;
                    }
                }
            }
            void PrintMass(string[] mass)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"{mass[i]} ");
                }
                Console.WriteLine();
            }
            FillMass(massOne, massTwo);
            PrintMass(massTwo);