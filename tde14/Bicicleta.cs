public class Bicicleta : Veiculo, IAceleravel{
   public Bicicleta(string marca, string modelo)
   :base(marca,modelo)
   {
   }

   public void Acelerar(){
    Console.WriteLine($"A {Marca}, {Modelo} está pedalando mais rápido");
   }
   


   public override void Ligar(){
    Console.WriteLine($"A {Marca}, {Modelo} está pronto para o uso");
   }

}