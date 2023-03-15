﻿using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    "15906304",
    "Mario Miziara",
     "91",
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447", e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447", e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "991340447", e1);
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto() );

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadeRodas = 4;
car.quantidadeAssentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Azul";
bicicleta.quantidadeRodas = 2;
bicicleta.quantidadeAssentos = 1;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadeRodas = 15;
aviao.quantidadeAssentos = 171;
aviao.TemMotor = true;

List<Veiculo> veiculoLista = new List<Veiculo>();

veiculoLista.Add(car);
veiculoLista.Add(aviao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista) 
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Qtd itens da lista" + veiculoLista.Count);

//Crie duas listas
//Uma listaa de Produtos com 400 produtos
//Outra lista de Clientes com 250 clientes

Random rand = new Random();

List<Produto> lsProdutos = new List<Produto>();
for (int i = 0; i < rand.Next(200,500); i++)
{
    Produto p = new Produto(i, "Produto tal" + i, i / 2 * 15);
    lsProdutos.Add(p);
}

foreach(var item in lsProdutos) 
{
    Console.WriteLine(item.ExibirDados());
}

List<Cliente> ListaClientes = new List<Cliente>();
for (int i = 0; i < rand.Next(200, 500); i++)
{
    Endereco e = new Endereco(1, "Rua", "18701240", "1", "", "");
    Cliente p = new Cliente(i, "Nome" + i, "3331-5555", e);
    ListaClientes.Add(p);
}

foreach(var item in ListaClientes)
{
    Console.WriteLine(item.ExibeDadosCliente());
}

Console.WriteLine("Qts de clientes na lista" + ListaClientes.Count);