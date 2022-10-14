public class Conversor{
    private byte[] vector;
    private byte[] compressed;

    public void set_num(byte[] numbers){
        vector = numbers;
        compressed = new byte[numbers.Length / 2];
    }

    public void compression(){
        for (int i=0, j=0; i<vector.Length; i += 2, j++)
            compressed[j] = (byte)((vector[i] >> 4 << 4) + (vector[i+1] >> 4));
        
    }

    public void printc(){
        foreach (var x in compressed){
            Console.Write(x + " ");
        }
        Console.WriteLine("");
    }
    public void print_vector(){
        foreach (var x in vector)
            Console.Write(x + " ");
        Console.WriteLine(" ");
    }

    public void decompression(){
        for (int i=0, j=0; i < vector.Length; i+=2, j++)
        {
            vector[i] = (byte)(compressed[j] & 240);
            vector[i+1] = (byte)(compressed[j] << 4);
        }
    }

}