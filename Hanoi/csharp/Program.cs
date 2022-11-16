Console.Write("Number of disks: ");
var n = Convert.ToInt32(Console.ReadLine());
Hanoi("1", "2", "3", n);

void Hanoi(string fromBar, string toBar, string helpBar, int n) {
    if (n == 1) {
        PrintMove(fromBar, toBar);
    }
    else {
        Hanoi(fromBar, helpBar, toBar, n - 1);
        PrintMove(fromBar, toBar);
        Hanoi(helpBar, toBar, fromBar, n - 1);
    }
}

void PrintMove(string fromBar, string toBar) {
    Console.WriteLine($"Move from {fromBar} to {toBar}");
}