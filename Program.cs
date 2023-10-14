
Dictionary<string, string> usuariosCadastrados = new Dictionary<string, string>();
usuariosCadastrados.Add("otavio.felicio@topayrh.com.br", "senha123456");
usuariosCadastrados.Add("lucas.gregory@topayrh.com.br", "lucas123456");


void LogoTopayRH()
{
    Console.WriteLine(@"
▀▀█▀▀ █▀▀█ █▀▀█ █▀▀█ █░░█ ▒█▀▀█ ▒█░▒█ 
░▒█░░ █░░█ █░░█ █▄▄█ █▄▄█ ▒█▄▄▀ ▒█▀▀█ 
░▒█░░ ▀▀▀▀ █▀▀▀ ▀░░▀ ▄▄▄█ ▒█░▒█ ▒█░▒█");
}


void LoginInicial()
{
    LogoTopayRH();
    Console.WriteLine("\n\nBem vindo a topayRh!\n\n");
    Thread.Sleep(1000);
    Console.WriteLine("Faça seu login!\n");
    Console.Write("Email de acesso: ");
    string emaildigitado = Console.ReadLine();

    if (usuariosCadastrados.ContainsKey(emaildigitado))
    {
        Console.Write("Digite sua senha de acesso: ");
        string senhadigitada = Console.ReadLine();
        while (usuariosCadastrados[emaildigitado] != senhadigitada)
        {
            Console.WriteLine("\nSenha incorreta. Tente novamente.");
            Thread.Sleep(1000);
            Console.Write("\nDigite sua senha de acesso: ");
            senhadigitada = Console.ReadLine();
        }

        {
            Console.WriteLine("\n\nBem vindo ao sistema!");
            Thread.Sleep(3000);
            Console.Clear();
            CadastrarUsuario();
        }
    }
    else
    {
        Console.WriteLine("Email incorreto.");
        Thread.Sleep(2500);
        Console.Clear();
        LoginInicial();
    }
}

void CadastrarUsuario()
{
    LogoTopayRH();
    Console.WriteLine("\n\nCadastro de novos usuários.\n");
    Thread.Sleep(1000);
    Console.WriteLine("Digite os dados do novo funcionário.\n");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Matricula: ");
    int matricula = int.Parse(Console.ReadLine());
    Console.Write("Telefone: ");
    string telefone = Console.ReadLine();
    Console.Write("Email corporativo: ");
    string emailNovo = Console.ReadLine();
    if (emailNovo.Contains("@topayrh.com.br"))
    {
        Console.Write("Digite sua senha: ");
        string senhaNova = Console.ReadLine();
        Console.Write("Confirme sua senha: ");
        string senhaNovaConfirma = Console.ReadLine();
        while (senhaNova != senhaNovaConfirma)
        {
            Console.Write("\nConfirme corretamente sua senha: ");
            senhaNovaConfirma = Console.ReadLine();
        }
        {
            usuariosCadastrados.Add(emailNovo, senhaNova);
            Console.WriteLine("Usuario e senha cadastrados com sucesso. ");
            Thread.Sleep(3000);
            Console.Clear();
            LoginInicial();
        }
    }
    else
    {
        Console.WriteLine("Seu email precisa ser da empresa topayRH.");
        Thread.Sleep(3000);
        Console.Clear();
        CadastrarUsuario();

    }
}

LoginInicial();
