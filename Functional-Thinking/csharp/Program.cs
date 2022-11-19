namespace csharp;

public static class Program {
    public static void Main() {
        var students = new List<Student> {
            new() {
                Name = "Ali",
                Age = 23,
                Average = 19.78
            },
            new() {
                Name = "Sasan",
                Age = 22,
                Average = 14.71
            },
            new() {
                Name = "Mohammad",
                Age = 22,
                Average = 19.27
            },
            new() {
                Name = "AliReza",
                Age = 12,
                Average = 20
            },
            new() {
                Name = "Hasan",
                Age = 18,
                Average = 19.91
            }
        };

        Console.WriteLine($"{nameof(Solution1)}: ");
        Solution1(students);

        Console.WriteLine("----------------------------------");

        Console.WriteLine($"{nameof(Solution2)}: ");
        Solution2(students);
    }

    public static void Solution1(List<Student> students) {
        var targetStudents = new List<Student>();
        foreach (var student in students) {
            if (student.Age <= 16)
                continue;
            targetStudents.Add(student);
        }

        targetStudents = targetStudents
            .OrderByDescending(student => student.Average)
            .ToList();
        
        if (targetStudents.Count <= 1)
            return;
        
        targetStudents.RemoveAt(0);

        var limit = targetStudents.Count > 2 ? 2 : targetStudents.Count;
        for (var i = 0; i < limit; i++) {
            Console.WriteLine(targetStudents[i].Name);
        }
    }

    public static void Solution2(IEnumerable<Student> students) {
        var result = students
            .Where(student => student.Age > 16)
            .OrderByDescending(student => student.Average)
            .Skip(1)
            .Take(2)
            .Select(student => student.Name);

        foreach (var student in result) {
            Console.WriteLine(student);
        }
    }
}