namespace Exercise02
{
    ///Auteur: Emerick Dorval
    /// Description: Read 5 grades (0-100) into an array, then display the average, the highest, and the lowest.
    ///              Display a letter grade or “Pass/Fail” based on the average. Practice: arrays, loops, double vs int.
    /// Date: 16-11-2026
    class Program
    {
        static void Main(string[] args)
        {
            int[] aiNotes = { 50, 80, 75, 62, 92 };

            Console.WriteLine($"Moyenne: {MoyenneNotes(aiNotes)}");
        }

        private static int MoyenneNotes(int[] p_aiNotes)
        {
            int iTotal = 0;

            for (int i = 0; i <= p_aiNotes.Length - 1; i++)
            {
                iTotal += p_aiNotes[i];
            }
            int iReponse = iTotal / p_aiNotes.Length;

            return iReponse;
        }


    }
}
