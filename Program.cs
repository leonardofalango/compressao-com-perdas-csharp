//using System
// Não é necessário colocar pois tem o implicit using

// é possivel declarar funções e metodos dentro do main, porem para fins de organização eu não vou faze-lo


byte[] txhais = new byte[6220800];



Conversor con = new Conversor();

con.set_num(txhais);
// con.print_vector();

var start = DateTime.Now;

con.compression();
con.decompression();

var end = DateTime.Now;
// con.print_vector();
Console.WriteLine($"Tempo: {(end - start).TotalMilliseconds} ms");
