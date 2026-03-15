
//int[] numberArray = new int[5];
//string[] weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri"];

//for (int i = 0; i < numberArray.Length; i++)
//{
//    numberArray[i] = i;
//    Console.WriteLine(numberArray[i]);
//    Console.WriteLine(weekDays[i]);
//}

//foreach (string day in weekDays)
//{
//    Console.WriteLine(day);
//}

using System.Diagnostics.Metrics;

int[,] array2D = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,] array2DValue = { { 1, 2 }, { 3, 4 } };
// [1] [2]
// [3] [4]


Console.WriteLine(array2DValue[0, 0]);
array2DValue[1, 0] = 5;
Console.WriteLine(array2DValue[1,0]);


string[,] ticTacToeField =
{
    {"O","O","X"},
    {"O","X","O"},
    {"X","O","O"}
};

Console.WriteLine(ticTacToeField[1,2]);

int[,,] array3D = new int[3, 3, 3];
// 3 Dimentional Array

string[,,] simple3DArray =
{
    {
        {"000", "001"},
        {"010", "011"}
    },
    {
        {"100", "101"},
        {"110", "111"}
    },
    {
        {"200", "201"},
        {"210", "211"}
    }
};

simple3DArray[2, 1, 0] = "The value is now overwritten";

Console.WriteLine(simple3DArray[2,1,0]);

int[] myArray = new int[5];
            
for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = i + 1;
    Console.WriteLine(myArray[i]);
}

Console.WriteLine("\nAdvanced Exercise");

int[,] exercise2DArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// [1] [2] [3]
// [4] [5] [6]
// [7] [8] [9]
for (int row = 0; row < exercise2DArray.GetLength(0); row++)
{
    int sumOfRows = 0; // Reset sum for every new row

    // Inner loop iterates through each Column in that row
    for (int col = 0; col < exercise2DArray.GetLength(1); col++)
    {
        sumOfRows += exercise2DArray[row, col];
    }

    Console.WriteLine(sumOfRows);
}


//int counter = 0;
//do
//{
//    counter++;

//    sumOfRows += (exercise2DArray[0, counter]);
//    Console.WriteLine(sumOfRows);
//} while (counter != 3);

Console.ReadKey(); 