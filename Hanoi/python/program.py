def hanoi(from_bar, to_bar, help_bar, n):
    if n == 1:
        print_move(from_bar, to_bar)
    else:
        hanoi(from_bar, help_bar, to_bar, n - 1)
        print_move(from_bar, to_bar)
        hanoi(help_bar, to_bar, from_bar, n - 1)


def print_move(from_bar, to_bar):
    print(f"Move from {from_bar} to {to_bar}")


n = int(input())
hanoi("1", "2", "3", n)