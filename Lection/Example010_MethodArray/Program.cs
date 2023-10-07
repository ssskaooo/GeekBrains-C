int[] array = {1,22,334,89,4,56,611,72,89};

int n = array.Length;
int find = 611;

int index = 0;

while(index < n){
    
    if(array[index] == find){
        System.Console.WriteLine(index);
        break;
    }
    index ++;
}
