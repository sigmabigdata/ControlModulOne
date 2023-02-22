string[] arrayOrigial = new string[5] {"maximim", "max", "minimum", "min", "123"};
string[] arrayFinal = new string[arrayOrigial.Length];


int count = 0;
    
    for (int i = 0; i < arrayOrigial.Length; i++)
    {
    if(arrayOrigial[i].Length <= 3)
        {
        arrayFinal[count] = arrayOrigial[i];
        count++;
        }
    }





