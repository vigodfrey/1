//string[] array = {"Hello", "2", "world", ":-)"};
//string[] array = {"1234", "1567", "-2", "computer science"};
string[] array = {"Russia", "Denmark", "Kazan"};

int string_length = 3;
string[] result_array = new string[array.Length] ;
int j=0;

for(int i=0 ; i<array.Length; i++)
   if(array[i].Length <= string_length)
   {
    result_array[j] = array[i];
    j+=1;
   }

result_array = result_array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.WriteLine("[{0}]", string.Join(", ", result_array));