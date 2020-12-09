using System;
using System.Collections.Generic;
using System.Linq;

namespace SA2_Samuel_Campos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Receitas> R = new List<Receitas>();
            List<Ingredientes> I = new List<Ingredientes>();
            inicio:
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("-             Gestão de Receitas de Culinária             -");
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("- 1 - Cadastrar receitas                                  -");
            Console.WriteLine("- 2 - Editar receitas                                     -");
            Console.WriteLine("- 3 - Eliminar receitas                                   -");
            Console.WriteLine("- 4 - Cadastrar Ingredientes                              -");
            Console.WriteLine("- 5 - Listar Todas Receitas                               -");
            Console.WriteLine("- 6 - Listar Receitas/Dificuldade                         -");
            Console.WriteLine("- 7 - Listar Receitas/Categoria                           -");
            Console.WriteLine("- 8 - Listar Receitas/Tempo                               -");
            Console.WriteLine("- 9 - Fechar Sistema                                      -");
            Console.WriteLine("___________________________________________________________");
            Console.Write("Insira a opção: ");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            int acao;
            switch(opc)
            {
                case 1:
                    Receitas receitas = new Receitas();
                    Console.WriteLine("Insira o nome da receita ");
                    receitas.N_receita = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Insira o tempo de preparação ");
                    receitas.T_preparacao = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Insira a dificulade da receita ");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("- 1 - Fácil                   -");
                    Console.WriteLine("- 2 - Médio                   -");
                    Console.WriteLine("- 3 - Díficil                 -");
                    Console.WriteLine("_______________________________");
                    int decisao =int.Parse(Console.ReadLine());
                    receitas.Dificuldade = "";
                    if (decisao == 1)
                    {
                        receitas.Dificuldade = "Fácil";
                    }
                    else if (decisao == 2)
                    {
                        receitas.Dificuldade = "Médio";
                    }
                    if (decisao == 3)
                    {
                        receitas.Dificuldade = "Díficil";
                    }
                    Console.Clear();
                    decisao = 0;
                    Console.WriteLine("Insira o Número de porções por pessoa ");
                    receitas.N_pessoas = Console.ReadLine();
                    Console.Clear();
                    inic:
                    Console.WriteLine("Ingredientes disponiveis: ");
                    foreach (var item in I)
                    {
                        Console.WriteLine("Codigo " + item.cod + ":" + item.N_ingredientes + "\n");
                    }
                    Console.WriteLine("");
                    Console.Write("Insira o cod do ingrediente que você vai usar: ");
                    int i_cod = int.Parse(Console.ReadLine());
                    var costelinha = I.Find(item => item.cod == i_cod);
                    Console.WriteLine("");
                    Console.Write("Quantidade de ingredientes usados: ");
                    receitas.Q_ingredientes = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Deseja inserir mais algum ingrediente a receita se sim digite 1 se não digite 2");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto inic;
                    }
                    Console.WriteLine("Insira a categoria ");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("- 1 - Carne                   -");
                    Console.WriteLine("- 2 - Peixe                   -");
                    Console.WriteLine("- 3 - Marisco                 -");
                    Console.WriteLine("- 4 - Pastelaria              -");
                    Console.WriteLine("- 5 - Sobremesas              -");
                    Console.WriteLine("- 6 - Outros                  -");
                    Console.WriteLine("_______________________________");
                    decisao = int.Parse(Console.ReadLine());
                    receitas.Categoria = "";
                    if (decisao == 1)
                    {
                        receitas.Categoria = "Carne";
                    }
                    else if (decisao == 2)
                    {
                        receitas.Categoria = "Peixe";
                    }
                    else if (decisao == 3)
                    {
                        receitas.Categoria = "Marisco";
                    }
                    else if (decisao == 4)
                    {
                        receitas.Categoria = "Pastelaria";
                    }
                    else if (decisao == 5)
                    {
                        receitas.Categoria = "Sobremesas";
                    }
                    if (decisao == 6)
                    {
                        receitas.Categoria = "Outros";
                    }
                    Console.Clear();
                    Console.WriteLine("Insira a descrição ");
                    receitas.Desc = Console.ReadLine();
                    if (I.Count < 1)
                    {
                        receitas.Cod1 = 1;
                    }
                    else
                    {
                        receitas.Cod1 = I.Last().cod + 1;
                    }
                    R.Add(receitas);
                    Console.Clear();
                    acao = 0;
                    Console.WriteLine("Deseja inserir mais alguma receita se sim digite 1 se não digite 2");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto case 1;
                    }
                    goto inicio;

                case 2:
                    foreach (var item in R)
                    {
                        Console.WriteLine($"Código: {item.Cod1} | Nome: {item.N_receita} |\n");
                    }
                    Console.WriteLine("Escolha a receita que deseja editar: ");
                    int cod = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    var confereCod = R.Find(item => item.Cod1 == cod);
                    if (confereCod == null)
                    {
                        Console.Write("Código inválido.");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 2;
                    }
                    Console.Clear();
                    decisao = 0;
                    while (decisao != 7)
                    {
                    subMenuIngredientes:

                        Console.WriteLine("\t1 - Nome da receita.\n");
                        Console.WriteLine("\t2 - Tempo de preparo.\n");
                        Console.WriteLine("\t3 - Dificuldade.\n");
                        Console.WriteLine("\t4 - Pessoas por porção.\n");
                        Console.WriteLine("\t5 - Categoria.\n");
                        Console.WriteLine("\t6 - Descrição.\n");
                        Console.WriteLine("\t7 - Voltar ao menu.\n");
                        Console.WriteLine();
                        Console.Write("Insira a opção que deseja: ");
                        decisao = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        if (decisao == 1)
                        {
                            Console.Write("Insira o novo nome da receita: ");
                            confereCod.N_receita = Console.ReadLine();
                            Console.Clear();
                            goto subMenuIngredientes;
                        }

                        if (decisao == 2)
                        {
                            Console.Write("Insira o novo preço do ingrediente: ");
                            confereCod.T_preparacao = Console.ReadLine();
                            Console.Clear();
                            goto subMenuIngredientes;
                        }

                        if (decisao == 3)
                        {
                            Console.WriteLine("Insira a dificulade da receita ");
                            Console.WriteLine("_______________________________");
                            Console.WriteLine("- 1 - Fácil                   -");
                            Console.WriteLine("- 2 - Médio                   -");
                            Console.WriteLine("- 3 - Díficil                 -");
                            Console.WriteLine("_______________________________");
                            int opcao = int.Parse(Console.ReadLine());
                            confereCod.Dificuldade = "";
                            if (opcao == 1)
                            {
                                confereCod.Dificuldade = "Fácil";
                            }
                            else if (opcao == 2)
                            {
                                confereCod.Dificuldade = "Médio";
                            }
                            if (opcao == 3)
                            {
                                confereCod.Dificuldade = "Díficil";
                            }
                            Console.Clear();
                        }
                        if (decisao == 4)
                        {
                            Console.WriteLine("Insira a quantidade de pessoas servidas por porção: ");
                            confereCod.N_pessoas = Console.ReadLine();
                            Console.Clear();
                            goto subMenuIngredientes;
                        }

                        if (decisao == 5)
                        {
                            Console.WriteLine("_______________________________");
                            Console.WriteLine("- 1 - Carne                   -");
                            Console.WriteLine("- 2 - Peixe                   -");
                            Console.WriteLine("- 3 - Marisco                 -");
                            Console.WriteLine("- 4 - Pastelaria              -");
                            Console.WriteLine("- 5 - Sobremesas              -");
                            Console.WriteLine("- 6 - Outros                  -");
                            Console.WriteLine("_______________________________");
                            Console.WriteLine("\nInsira a categoria: ");
                            int opcao = Convert.ToInt16(Console.ReadLine());

                            if (opcao == 1)
                            {
                                confereCod.Categoria = "Carne";
                            }
                            else if (opcao == 2)
                            {
                                confereCod.Categoria = "Peixe";
                            }
                            else if (opcao == 3)
                            {
                                confereCod.Categoria = "Marisco";
                            }
                            else if (opcao == 4)
                            {
                                confereCod.Categoria = "Pastelaria";
                            }
                            else if (opcao == 5)
                            {
                                confereCod.Categoria = "Sobremesas";
                            }
                            if (opcao == 6)
                            {
                                confereCod.Categoria = "Outros";
                            }
                        }

                        if (decisao == 6)
                        {
                            Console.Write("Insira a nova descrição da receita: ");
                            confereCod.Desc = Console.ReadLine();
                        }
                    }
                    goto inicio;

                case 3:
                    foreach (var item in R)
                    {
                        Console.WriteLine($"Código: {item.Cod1} | Nome: {item.N_receita} |\n");
                    }
                    Console.WriteLine("Escolha a receita que deseja editar: ");
                    cod = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    confereCod = R.Find(item => item.Cod1 == cod);
                    if (confereCod == null)
                    {
                        Console.Write("Código inválido.");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 2;
                    }
                    R.Remove(confereCod);
                    goto inicio;

                case 4:
                    Ingredientes ingredientes = new Ingredientes();
                    Console.WriteLine("Insira o nome do ingrediente ");
                    ingredientes.N_ingredientes = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Insira o preço unitario do ingrediente ");
                    ingredientes.Cotacao = Double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Insira a unidade de medida do valor unitario ");
                    ingredientes.U_medida = Console.ReadLine();
                    Console.Clear();
                    if (I.Count < 1)
                    {
                        ingredientes.cod = 1;
                    }
                    else
                    {
                        ingredientes.cod = I.Last().cod+1;
                    }
                    I.Add(ingredientes);
                    Console.WriteLine("Deseja inserir mais algum ingrediente se sim digite 1 se não digite 2");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto case 4;
                    }
                    goto inicio;

                case 5:
                    foreach (var item in R)
                    {
                        Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "Nome da receita - " + item.N_receita + ", " + "Tempo de preparação - " + item.T_preparacao + ", " + "Dificuldade - " + item.Dificuldade + ", " + "Porção por pessoa - " + item.N_pessoas + ", " + "Categoria - " + item.Categoria + ", " + "Desc - " + item.Desc + "\n");
                    }
                    Console.ReadKey();
                    goto inicio;

                case 6:
                    decisao = 0;
                    Console.WriteLine("   Dificuldade das receitas    ");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("- 1 - Fácil                   -");
                    Console.WriteLine("- 2 - Médio                   -");
                    Console.WriteLine("- 3 - Díficil                 -");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("");
                    Console.Write("Insira a dificulade da receita: ");
                    decisao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (decisao == 1)
                    {
                        foreach (var item in R)
                        {
                            if (item.Dificuldade == "Fácil")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 2)
                    {
                        foreach (var item in R)
                        {
                            if (item.Dificuldade == "Médio")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 3)
                    {
                        foreach (var item in R)
                        {
                            if (item.Dificuldade == "Díficil")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    Console.ReadKey();
                        goto inicio;
                
                case 7:
                    Console.WriteLine("          categorias           ");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("- 1 - Carne                   -");
                    Console.WriteLine("- 2 - Peixe                   -");
                    Console.WriteLine("- 3 - Marisco                 -");
                    Console.WriteLine("- 4 - Pastelaria              -");
                    Console.WriteLine("- 5 - Sobremesas              -");
                    Console.WriteLine("- 6 - Outros                  -");
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("");
                    Console.Write("Insira a categoria: ");
                    decisao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (decisao == 1)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Carne")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 2)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Peixe")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 3)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Marisco")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    if (decisao == 4)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Pastelaria")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 5)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Sobremesas")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    else if (decisao == 6)
                    {
                        foreach (var item in R)
                        {
                            if (item.Categoria == "Outros")
                            {
                                Console.WriteLine("Codigo receita " + item.Cod1 + ":" + "\n Nome da receita - " + item.N_receita + ", " + "\n Tempo de preparação - " + item.T_preparacao + ", " + "\n Dificuldade - " + item.Dificuldade + ", " + "\n Porção por pessoa - " + item.N_pessoas + ", " + "\n Categoria - " + item.Categoria + ", " + "\n Desc - " + item.Desc + "\n");
                            }
                        }
                    }
                    Console.ReadKey();
                    goto inicio;

                case 8:
                    R.Sort(delegate(Receitas r1, Receitas r2)
                    {
                        return r1.T_preparacao.CompareTo(r2.T_preparacao);
                    });

                    R.ForEach(delegate (Receitas r)
                    {
                        Console.WriteLine($"Nome receita: {r.N_receita} | Tempo preparo: {r.T_preparacao} |");
                    });
                    goto inicio;

                case 9:
                    Environment.Exit(0);
                    goto inicio;
            }
        }
    }
}