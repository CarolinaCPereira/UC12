// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using T16CodBackEnd.Classes;

        PessoaFisica novaPF = new PessoaFisica();

        novaPF.nome = "Ana";
        novaPF.cpf = 25686854;
        novaPF.dataNasc = new DateTime(1998, 01, 01);
        novaPF.endereco = "Rua Lua, 123";
        novaPF.rendimento = 12000.00f;

        Console.WriteLine(novaPF.nome);
        Console.WriteLine(novaPF.cpf);
        Console.WriteLine(novaPF.dataNasc);
        Console.WriteLine(novaPF.endereco);
        Console.WriteLine(novaPF.rendimento);

        Console.WriteLine("Nome do funcionário: " + novaPF.nome);
        Console.WriteLine($"Nome do funcionário: {novaPF.nome} - cpf: {novaPF.cpf}");
