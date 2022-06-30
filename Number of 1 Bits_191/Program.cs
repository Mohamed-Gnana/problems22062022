
uint n = 0b11111111111111111111111111111101;
int NumberOfOnes = 0;
for(int i = 0; i < 32; i++)
{
    NumberOfOnes += ((n >> i) & 1) == 1 ? 1 : 0;
}
Console.WriteLine(NumberOfOnes);