using System;
using System.Collections.Generic;
using System.Text;




namespace Atividade1LP2
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Banco Sol = new Banco("Sol");
            Agencia Aracati = new Agencia("Aracati");
            Agencia Fortim = new Agencia("Fortim");
            Agencia Beberibe = new Agencia("Beberibe");

            
            Sol.AdicionarAgencia(Aracati);
            Sol.AdicionarAgencia(Fortim);
            Sol.AdicionarAgencia(Beberibe);

            
            ContaCorrente cliente1 = new ContaCorrente("Solange");
            ContaPoupanca cliente2 = new ContaPoupanca(100, DateTime.Now, "Sheila");
            ContaCorrente cliente3 = new ContaCorrente("Nilo");
            ContaPoupanca cliente4 = new ContaPoupanca(100, DateTime.Now, "Demétrio");
            ContaCorrente cliente5 = new ContaCorrente("Francisca");
            ContaPoupanca cliente6 = new ContaPoupanca(100, DateTime.Now, "Conceição");

           
            cliente1.Depositar(25);
            cliente2.Depositar(50);
            cliente3.Depositar(100);
            cliente4.Depositar(150);
            cliente5.Depositar(200);
            cliente6.Depositar(225);
          
            Aracati.AdicionarContaCorrente(cliente1);
            Aracati.AdicionarContaPoupanca(cliente2);
            Fortim.AdicionarContaCorrente(cliente3);
            Fortim.AdicionarContaPoupanca(cliente4);
            Beberibe.AdicionarContaCorrente(cliente5);
            Beberibe.AdicionarContaPoupanca(cliente6);

          
            int opcao = 1, redundancia = 0;
            while (opcao != 0)
            {
                Console.WriteLine("***SEJA BEM VINDO(A)!***");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Para abrir conta");
                Console.WriteLine("2 - Para fechar conta");
                Console.WriteLine("3 - Para consultar saldo");
                Console.WriteLine("4 - Para depositar saldo");
                Console.WriteLine("5 - Para sacar saldo");
                Console.WriteLine("6 - Para transferir Saldo");
                Console.WriteLine("0 - Para sair");

                opcao = Int32.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Volte sempre!");
                    return;
                }
                else if (opcao == 1)
                {
                    
                    Console.Clear();
                    int auxiliar;
                    string nomeAgencia;
                    Agencia novaconta;
                    Console.WriteLine("***Abrindo Conta***");
                    Console.WriteLine("Lista de Agências Disponíveis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da Agência escolhida: \n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    novaconta = Sol.BuscarAgencia(nomeAgencia);

                    if (novaconta == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    

                    Console.WriteLine("Digite 1 - Para Conta Poupança");
                    Console.WriteLine("Digite 2 - Para Conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        

                        string nome;
                        Console.WriteLine("Informe o seu nome: \n");
                        nome = Console.ReadLine();
                        ContaPoupanca nova = new ContaPoupanca(100, DateTime.Now, nome);
                        novaconta.AdicionarContaPoupanca(nova);
                        Console.Clear();
                        Console.WriteLine("Seja bem-vindo (a)" + nome + " agora você se tornou cliente do Banco Sol!");
                        Console.ReadKey();
                        continue;
                    }
                    else if (auxiliar == 2)
                    {
                        
                        string nome;

                        Console.WriteLine("Informe o seu nome: \n");
                        nome = Console.ReadLine();
                        ContaCorrente nova = new ContaCorrente(nome);
                        novaconta.AdicionarContaCorrente(nova);
                        Console.Clear();
                        Console.WriteLine("Seja bem-vindo (a)" + nome + " agora você se tornou cliente do Banco Sol!");
                        Console.ReadKey();
                        continue;
                    }


                }
                else if (opcao == 2)
                {

                    Console.Clear();
                    int auxiliar;
                    string nomeAgencia;
                    Agencia excluirconta;
                    Console.WriteLine("***Fechando Conta***");
                    Console.WriteLine("Lista de Agências Disponíveis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da Agência da sua conta: \n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    excluirconta = Sol.BuscarAgencia(nomeAgencia);

                    if (excluirconta == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    

                    Console.WriteLine("Digite 1 - Para Conta Poupança");
                    Console.WriteLine("Digite 2 - Para Conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        

                        string nome;
                        Console.WriteLine("Informe o seu nome: \n");
                        nome = Console.ReadLine();
                        excluirconta.ExcluircontaP(nome);
                        Console.ReadKey();
                        continue;
                    }
                    else if (auxiliar == 2)
                    {
                        
                        string nome;
                        Console.WriteLine("Informe o seu nome: \n");
                        nome = Console.ReadLine();
                        excluirconta.Excluirconta(nome);
                        Console.ReadKey();
                        continue;

                    }


                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("***Consulta de saldo***");
                    string nomeAgencia;
                    int auxiliar;
                    Agencia consultarsaldo;
                    Console.WriteLine("Lista de Agências Disponíveis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da Agência: \n");
                    nomeAgencia = Console.ReadLine();
                    consultarsaldo = Sol.BuscarAgencia(nomeAgencia);
                    if (consultarsaldo == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Digite 1 - Para Consultar Saldo de conta Poupança");
                    Console.WriteLine("Digite 2 - Para Consultar Saldo de conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        
                        ContaPoupanca consultar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n);
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarClienteP(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Saldo Atual: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }
                    if (auxiliar == 2)
                    {
                        
                        ContaCorrente consultar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarCliente(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Saldo Atual: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }

                }
                else if (opcao == 4)
                {
                   
                    Console.Clear();
                    Console.WriteLine("***Depósito***");
                    string nomeAgencia;
                    int auxiliar;
                    Agencia depositandosaldo;
                    Console.WriteLine("Listas de Agências Disponíveis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da Agência da sua conta: \n");
                    nomeAgencia = Console.ReadLine();
                    depositandosaldo = Sol.BuscarAgencia(nomeAgencia);
                    if (depositandosaldo == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Digite 1 - Para Consultar Saldo de Conta Poupança");
                    Console.WriteLine("Digite 2 - Para Consultar Saldo de Conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        
                        ContaPoupanca depositar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarClienteP(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor do Depósito: \n");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " foi depositado na conta de " + depositar.Titular + ", operação realizada com sucesso!");
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (auxiliar == 2)
                    {
                        ContaCorrente depositar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: /n");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarCliente(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor do Depósito: /n");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " foi depositado na conta de " + depositar.Titular + ", operação realizada com sucesso!");
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 5)
                {
                    
                    Console.Clear();
                    Console.WriteLine("***Saque***");
                    string nomeAgencia;
                    int auxiliar;
                    Agencia sacandosaldo;
                    Console.WriteLine("Lista de Agências Diponíveis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da sua Agência: \n");
                    nomeAgencia = Console.ReadLine();
                    sacandosaldo = Sol.BuscarAgencia(nomeAgencia);
                    if (sacandosaldo == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Digite 1 - Para Sacar Saldo de Conta Poupança");
                    Console.WriteLine("Digite 2 - Para Sacar Saldo de Conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        ContaPoupanca sacar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarClienteP(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor do Depósito: \n");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + "foi sacado da conta de:" + sacar.Titular + ", operação efetuada com sucesso!");
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (auxiliar == 2)
                    {
                        ContaCorrente sacar;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarCliente(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + " foi sacado da conta:" + sacar.Titular + ", operação efetuada com sucesso!");
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("***Tranferência de saldo***");
                    string nomeAgencia;
                    int auxiliar;
                    Agencia trasnferir;
                    Console.WriteLine("Lista de Agências Disponívéis: \n");
                    Sol.ListarAgencia();
                    Console.WriteLine("Informe o nome da Agência: \n");
                    nomeAgencia = Console.ReadLine();
                    trasnferir = Sol.BuscarAgencia(nomeAgencia);
                    if (trasnferir == null)
                    {
                        Console.WriteLine("Retornando ao Menu Inicial!");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Diite 1 - Para Trasferir Saldo de Conta Poupança");
                    Console.WriteLine("Diite 2 - Para Transferir Saldo de conta Corrente");
                    auxiliar = Int32.Parse(Console.ReadLine());
                    if (auxiliar == 1)
                    {
                        
                        ContaPoupanca trasferirP;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarClienteP(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor da Agência de Aracati a ser tranferido: \n");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            

                            Console.Clear();
                            Console.WriteLine("***Buscando conta para efetuar a tranferência***");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências Disponíveis: \n");
                            Sol.ListarAgencia();
                            Console.WriteLine("Informe o nome da sua Agência: \n");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = Sol.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Retornando ao Menu Inicial!");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite 1 - Para Trasferir Saldo para Conta Poupança");
                            Console.WriteLine("Diite 2 - Para Transferir Saldo para Conta Corrente");
                            auxiliar = Int32.Parse(Console.ReadLine());
                            if (auxiliar == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Informe o nome do Titular da Conta: \n");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Retornando ao Menu Inicial!");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + "foi retirado da conta de: " + trasferirP.Titular + " e " + valor + "foi depositado na conta de: " + receber.Titular + ", operações efetuadas com sucessos!");
                                Console.ReadKey();
                                continue;
                            }
                            else if (auxiliar == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Informe o nome do Titular da Conta: \n");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Retornando ao Menu Inicial!");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " foi retirado da conta de: " + trasferirP.Titular + " e " + valor + "foi depositado na conta de: " + receber.Titular + ", operações efetuadas com sucesso!");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Retornando ao Menu Inicial!");
                                Console.ReadKey();
                                continue;
                            }

                        }

                    }
                    if (auxiliar == 2)
                    {
                        
                        ContaCorrente trasferirP;
                        string cliente;
                        Console.WriteLine("Informe o nome do Titular da Conta: \n");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarCliente(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Retornando ao Menu Inicial!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Informe o valor da Agência de Aracati a ser tranferido: \n");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            

                            Console.Clear();
                            Console.WriteLine("***Buscando conta para efetuar a tranferência***");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências Disponíveis: \n");
                            Sol.ListarAgencia();
                            Console.WriteLine("Informe o nome da sua Agência: \n");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = Sol.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Retornando ao Menu Inicial!");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Digite 1 - Para Trasferir Saldo para Conta Poupança");
                            Console.WriteLine("Digite 2 - Para Transferir Saldo para Conta Corrente");
                            auxiliar = Int32.Parse(Console.ReadLine());
                            if (auxiliar == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Informe o nome do Titular da Conta: \n");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Retornando ao Menu Inicial!");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " foi retirado da conta de: " + trasferirP.Titular + " e " + valor + "foi depositado na conta de: " + receber.Titular + ", operações realizadas com sucesso!");
                                Console.ReadKey();
                                continue;
                            }
                            else if (auxiliar == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Informe o nome do Titular da Conta: \n");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Retornando ao Menu Inicial!");
                                    continue;
                                }
                                
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " foi retirado da conta de: " + trasferirP.Titular + " e " + valor + "foi depositado na conta de: " + receber.Titular + ", operações realizadas com sucesso");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Retornando ao Menu Inicial!");
                                Console.ReadKey();
                                continue;
                            }
                        }

                    }
                }
            }
        }
    }
}