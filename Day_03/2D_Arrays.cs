// 3 rows, 2 columns
int[,] grid = new int[3, 2];

grid = new int[,] 
       { 
        { 1, 2 },
        { 3, 404 },
        { 54, 6 }
       };


int[,] matrix = {
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};

Console.WriteLine(matrix[0, 0]);    // 1
Console.WriteLine(grid[1, 1]);    // 4
Console.WriteLine(grid[2, 0]);    // 5

// Loop through 2D array
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}