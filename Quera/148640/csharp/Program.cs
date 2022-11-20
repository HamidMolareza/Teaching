namespace csharp;

public static class Program {
    public static void Main() {
        var numOfQuestions = Convert.ToInt32(Console.ReadLine());
        var keys = Console.ReadLine();
        var numOfPersons = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < numOfPersons; i++) {
            var personAnswers = new List<string>(numOfQuestions);
            for (var j = 0; j < numOfQuestions; j++)
                personAnswers.Add(Console.ReadLine());

            var score = CalculateScore(personAnswers, keys);
            Console.WriteLine(score);
        }
    }

    private static int CalculateScore(this IReadOnlyList<string> personAnswers, string keys) {
        var correctAnswers = 0;
        var wrongAnswers = 0;

        for (var i = 0; i < keys.Length; i++) {
            var markedCount = personAnswers[i].Count(a => a == '#');
            if (markedCount < 1)
                continue;

            if (markedCount > 1 || personAnswers[i][keys[i] - 'A'] != '#')
                wrongAnswers++;
            else
                correctAnswers++;
        }

        return (3 * correctAnswers) - wrongAnswers;
    }
}