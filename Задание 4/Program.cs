int n = InputNumbers("Введите количество строк: ");

double[,] pascalTriangle = new double[ n + 1, 2 * n + 1 ];

FillPascalTriangle( pascalTriangle );

Console.WriteLine();
PrintArray( pascalTriangle );

TransformationPascalTriangle( pascalTriangle );

Console.WriteLine();
PrintArray( pascalTriangle );

void TransformationPascalTriangle( double[ , ] arr )
{
    int lenght = arr.GetLength( 0 );
    int lenght1 = arr.GetLength( 1 );
  for ( int i = 0; i < lenght; ++i )
  {
    int count = 0;
    for ( int j = lenght1 - 1; j >= 0; j-- )
    {
      if ( arr[ i, j ] != 0 )
      {
        arr[ i, lenght1 / 2 + j - count] = arr[ i, j ];
        arr[ i, j ] = 0;
        count++;
      }
    }
  }
  arr[ lenght - 1, 0 ] = 1;
}

void FillPascalTriangle( double[,] pascalTriangle )
{
   int lenght = pascalTriangle.GetLength( 0 ); 
  for ( int k = 0; k < lenght; ++k )
  {
    pascalTriangle[ k, 0 ] = 1;
  }
  for ( int i = 1; i < lenght; ++i )
  {
    for ( int j = 1; j < i + 1; ++j )
    {
      pascalTriangle[ i, j ] = pascalTriangle[ i - 1, j ] + pascalTriangle[ i - 1, j - 1 ];
    }
  }
}

void PrintArray( double[,] arr )
{
    int lenght = arr.GetLength( 0 );
    int lenght1 = arr.GetLength( 1 );
  for ( int i = 0; i < lenght; ++i )
  {
    for ( int j = 0; j < lenght1; ++j )
    {
      if ( arr[ i, j ] != 0 )
      {
          Console.Write( $"{arr[i, j]} " );
      }
      else Console.Write( "  " );
    }
    Console.WriteLine();
  }
}

int InputNumbers( string input )
{
  Console.Write( input );
  int output = Convert.ToInt32( Console.ReadLine() );
  return output;
}
