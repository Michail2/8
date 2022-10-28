int m = InputNumbers( "Введите число строк 1-й матрицы: " );
int n = InputNumbers( "Введите число столбцов 1-й матрицы (и строк 2-й): " );
int p = InputNumbers( "Введите число столбцов 2-й матрицы: " );

Console.Write( "рандомное число с: " );
int randomVal1 = Convert.ToInt32( Console.ReadLine() );

Console.Write( "рандомное число по: " );
int randonVal2 = Convert.ToInt32( Console.ReadLine() );

int[,] firstMartrix = new int[ m, n ];
FillArrayRandomNumbers( firstMartrix );
Console.WriteLine( $"\nПервая матрица:" );
PrintArray( firstMartrix );

int[,] secomdMartrix = new int[ n, p ];
FillArrayRandomNumbers( secomdMartrix );
Console.WriteLine( $"\nВторая матрица:" );
PrintArray( secomdMartrix );

int[,] resultMatrix = new int[ m, p ];

MultiplyMatrix( firstMartrix, secomdMartrix, resultMatrix );
Console.WriteLine( $"\nПроизведение первой и второй матриц:" );
PrintArray( resultMatrix );

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for ( int i = 0; i < resultMatrix.GetLength( 0 ); ++i )
  {
    for ( int j = 0; j < resultMatrix.GetLength( 1 ); ++j )
    {
      int sum = 0;
      for ( int k = 0; k < firstMartrix.GetLength( 1 ); ++k )
      {
        sum += firstMartrix[ i, k ] * secomdMartrix[ k, j ];
      }
      resultMatrix[ i ,j ] = sum;
    }
  }
}

int InputNumbers( string input )
{
  Console.Write( input );
  int output = Convert.ToInt32( Console.ReadLine() );
  return output;
}

void FillArrayRandomNumbers( int[,] arr )
{
    for ( int i = 0; i < arr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < arr.GetLength( 1 ); ++j )
        {
            arr[ i, j ] = new Random().Next( randomVal1, randonVal2 );
        }
    }
}

void PrintArray( int[,] arr )
{
    for ( int i = 0; i < arr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < arr.GetLength( 1 ); ++j )
        {
            Console.Write( arr[ i, j ] + " " );
        }
        Console.WriteLine( "" );
    }
}
