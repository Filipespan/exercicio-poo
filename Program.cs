using System;

// 1. Interface
public interface IImprimivel
{
    void Imprimir();
}

// 2. Classe abstrata
public abstract class Documento
{
    // Atributo
    public string Titulo { get; set; }

    // Método concreto
    public void ExibirTitulo()
    {
        Console.WriteLine($"Título do documento: {Titulo}");
    }

    // Método abstrato
    public abstract void Processar();
}

// 3. Classe concreta: Relatório
public class Relatorio : Documento, IImprimivel
{
    public override void Processar()
    {
        Console.WriteLine("Processando o relatório... (Calculando métricas e dados)");
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo o relatório... [Enviando para a impressora na sala A]");
    }
}

// 3. Classe concreta: Contrato
public class Contrato : Documento, IImprimivel
{
    public override void Processar()
    {
        Console.WriteLine("Processando o contrato... (Validando cláusulas e assinaturas)");
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo o contrato... [Gerando vias físicas em papel timbrado]");
    }
}

// 4. Método Main
class Program
{
    static void Main(string[] args)
    {
        // Criação dos objetos
        Relatorio meuRelatorio = new Relatorio { Titulo = "Relatório de Vendas - Q3" };
        Contrato meuContrato = new Contrato { Titulo = "Contrato de Prestação de Serviços" };

        // Testando o Relatório
        Console.WriteLine("--- Ações do Relatório ---");
        meuRelatorio.ExibirTitulo();
        meuRelatorio.Processar();
        meuRelatorio.Imprimir();

        Console.WriteLine();

        // Testando o Contrato
        Console.WriteLine("--- Ações do Contrato ---");
        meuContrato.ExibirTitulo();
        meuContrato.Processar();
        meuContrato.Imprimir();
    }
}