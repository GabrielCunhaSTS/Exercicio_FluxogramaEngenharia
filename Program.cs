char escolhaUsuario;

Console.WriteLine("--- Fluxograma da Engenharia ---");

do{
    Console.Write("O objeto está se movendo? (S)im ou (N)ão: ");
    string entrada = Console.ReadLine()!.Trim().ToUpper();
    if (entrada == "S" || entrada == "N"){
        escolhaUsuario = Convert.ToChar(entrada);
        break;
    }
    else{
        Console.WriteLine("Resposta inválida. Digite apenas (S) para Sim ou (N) para Não");
    }
} while (true);

if (escolhaUsuario == 'S'){
    do{
        Console.Write("O objeto deveria se mover? (S)im ou (N)ão: ");
        string entrada = Console.ReadLine()!.Trim().ToUpper();
        if (entrada == "S" || entrada == "N"){
            escolhaUsuario = Convert.ToChar(entrada);
            break;
        }
        else{
            Console.WriteLine("Entrada inválida. Digite apenas 'S' para Sim ou 'N' para Não.\n");
        }
    } while (true);

    if (escolhaUsuario == 'S'){
        Console.WriteLine("Ótimo!");
    }
    else{
        Console.WriteLine("Use Silver Tape!");
    }
}
else{
    do
    {
        Console.Write("O objeto deveria se mover? (S)im ou (N)ão: ");
        string entrada = Console.ReadLine()!.Trim().ToUpper();
        if (entrada == "S" || entrada == "N"){
            escolhaUsuario = Convert.ToChar(entrada);
            break;
        }
        else{
            Console.WriteLine("Entrada inválida. Digite apenas 'S' para Sim ou 'N' para Não.\n");
        }
    } while (true);

    if (escolhaUsuario == 'N'){
        Console.WriteLine("Ótimo!");
    }
    else{
        Console.WriteLine("Use WD-40!");
    }
}

Console.Write("\nPressione qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();
