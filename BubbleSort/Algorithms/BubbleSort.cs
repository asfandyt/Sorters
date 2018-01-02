

using System;

namespace Sort.Algorithms
{
    public class BubbleSort
    {
        public int[] List { get; set; }
        public bool OrderBy { get; set; }

        public BubbleSort()
        {
            List = new int[]{};
            OrderBy = true;
        }

        // Sort integers in ascending order
        public void SortIntAsc()
        {
            
            for (int i = 0; i < List.Length; i++) {

                for (int j = i + 1; j < List.Length; j++) {

                    if (List[i] > List[j])
                    {
                        int right = List[j];
                        List[j] = List[i];
                        List[i] = right;

                    }

                }

            }
        }

        // Sort integers in descending order
        public void SortIntDesc()
        {
            for (int i = List.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (List[i] > List[j])
                    {
                        int right = List[i];
                        List[i] = List[j];
                        List[j] = right;
                    }
                }
            }
        }

        // Print the list please
        public void PrintTheList()
        {
            foreach (var item in List)
            {
                Console.Write(item + ", ");
            }
        }

        //I have the best wifey in the worlds




    }
}
