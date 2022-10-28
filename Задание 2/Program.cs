int m = InputNumbers( "Введите m: " );
int n = InputNumbers( "Введите n: " );

Console.Write( "рандомное число с: " );
int randomVal1 = Convert.ToInt32( Console.ReadLine() );

Console.Write( "рандомное число по: " );
int randonVal2 = Convert.ToInt32( Console.ReadLine() );

int[,] arr = new int[ m, n ];
FillArrayRandomNumbers( arr );
PrintArray( arr );

int[,] positionSmallElement = new int[ 1, 2 ];
positionSmallElement = FindPositionSmallElement( arr, positionSmallElement );
Console.Write( $"Позиция элемента: \n" );
PrintArray( positionSmallElement );

int[,] arrayWithoutLines = new int[ arr.GetLength( 0 ) - 1, arr.GetLength( 1 ) - 1 ];
DeleteLines( arr, positionSmallElement, arrayWithoutLines );
Console.WriteLine( $"\nПолучившийся массив:" );
PrintArray( arrayWithoutLines );


int InputNumbers( string input )
{
  Console.Write( input );
  int output = Convert.ToInt32(Console.ReadLine());
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

int[,] FindPositionSmallElement( int[,] arr, int[,] position )
{
  int temp = arr[ 0, 0 ];
  for ( int i = 0; i < arr.GetLength( 0 ); ++i )
  {
    for ( int j = 0; j < arr.GetLength(1); ++j )
    {
      if ( arr[ i, j ] <= temp )
      {
        position[ 0, 0 ] = i;
        position[ 0, 1 ] = j;
        temp = arr[ i, j ];
      }
    }
  }
  Console.WriteLine( $"\nMинимальный элемент: {temp}" );
  return position;
}

void DeleteLines( int[,] arr, int[,] positionSmallElement, int[,] arrayWithoutLines )
{
  int k = 0, l = 0;
  for ( int i = 0; i < arr.GetLength( 0 ); ++i )
  {
    for ( int j = 0; j < arr.GetLength( 1 ); ++j )
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[ k, l ] = arr[ i, j ];
        l++;
      }
    }
    l = 0;
    if ( positionSmallElement [0, 0 ] != i )
    {
      k++;
    }
  }
}
