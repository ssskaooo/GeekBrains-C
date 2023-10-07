void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while(index < length){
        collection[index] = new Random().Next(1,10);
        index++;
    
    }
}
void PrintArray(int[] col){
    int count = col.Length;
    int possition = 0;
    while(possition < count){
        System.Console.WriteLine(col[possition]);
        possition ++;
    }
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int possition = -1;

    while(index<count){
        if(collection[index] == find){
            possition = index;
            break;
        }
        index ++;
    }
    return possition;
}

int[] array = new int[10];


FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);