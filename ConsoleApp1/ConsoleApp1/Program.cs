// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double Fun(int[] tab)
{
    double avg = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        avg += tab[i];
    }

    avg /= tab.Length;

    return avg;
}