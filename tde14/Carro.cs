public class Carro : Veiculo, IAceleravel, IFreavel {


    public Carro(string marca, string modelo)
    :base(marca, modelo)
    { 
    }

    public override void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }

    public void Acelerar(){
        Console.WriteLine($"O carro{Marca}, {Modelo} está acelerando");
    }

    public void Frear(){
        Console.WriteLine($"O carro{Marca}, {Modelo} está freando");
    }



}