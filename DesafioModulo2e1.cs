class DesafioModulo2e1{
    public static void Main (String[] args){

        Console.WriteLine("[------------------------------------- Bem vindes ------------------------------------]");
        Console.WriteLine("Você deve escolher um número inteiro se você acertar o número recebe 10 pontos se você");
        Console.WriteLine(" digitar um número acima ou abaixo recebe 5 pontos e se não acertar não recebe nada.");
        Console.WriteLine("[--------------------------  Escolha a dificuldade do seu jogo: ----------------------]");
        Console.WriteLine("[-------------------------- [ 1 ] Dificuldade de 1 até 10 ----------------------------]");
        Console.WriteLine("[-------------------------- [ 2 ] Dificuldade de 1 até 20 ----------------------------]");
        Console.WriteLine("[-------------------------- [ 3 ] Dificuldade de 1 até 50 ----------------------------]");
        Console.WriteLine("[-------------------------- [ 4 ] Dificuldade de 1 até 100 ---------------------------]");
        Console.WriteLine("[-------------------------- [ 5 ] Dificuldade de 1 até 1000 --------------------------]");
        Console.WriteLine("[-------------------------- Pode digitar por favor de 1 à 5:--------------------------]");
        int dificuldade =Convert.ToInt16(Console.ReadLine());
      
        //regras do jogo
        int acertouPontos = 10;
        int numProximoPontos = 5;

        int acertos = 0;
        int chegouPerto = 0;
        int errou = 0;
        int pontuacao = 0;
    
        //Criando uma instância da classe Random
        Random random = new Random();
        
        int num1a10 = 0;
        int num1a20 = 0;
        int num1a50 = 0;
        int num1a100 = 0;
        int num1a1000 = 0;

        List<Int32> numerosInseridos = new List<int>();
        List<Int32> numerosRandomizados = new List<int>();
        List<Int32> numerosAcertados = new List<int>();
        List<Int32> numerosErrados = new List<int>();

        switch (dificuldade){
            case 1:
                Console.WriteLine("[-------------- Você selecionou a dificuldade 1: digite números de 1 a 10 ------------]");
                Console.WriteLine("[------------------------- Digite 5 números 1 de cada vez:  --------------------------]");
                
                
                for(int i = 0; i < 5; i++){
                    // Gerando um número inteiro aleatório entre 1 e 10;
                    num1a10 = random.Next(1, 10);
                    numerosRandomizados.Add(num1a10);
                    Console.WriteLine("[-------------------------------- Insira o " + ( i + 1 ) + "ª número: --------------------------------]");
                    numerosInseridos.Add(Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 0; i < numerosInseridos.Count && i < numerosRandomizados.Count; i++){

                    if(numerosInseridos[i] == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += acertouPontos;
                    }

                    if(numerosInseridos[i] - 1 == numerosRandomizados[i] || numerosInseridos[i] + 1 == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += numProximoPontos;
                        chegouPerto++;
                        errou--;
                    }

                    if (numerosInseridos[i] != numerosRandomizados[i]){
                        numerosErrados.Add(numerosInseridos[i]);
                        errou++;
                    }
                }

                Console.WriteLine("O sistema gerou os seguintes números:" + string.Join(", ", numerosRandomizados));
                Console.WriteLine("Você digitou os seguintes números:" + string.Join(", ", numerosInseridos));
                Console.WriteLine("Você acertou um total de " + acertos + " números, parabéns!");
                Console.WriteLine("Você passou perto de um total de " + chegouPerto + " números, parabéns!");
                Console.WriteLine("Você errou um total de " + errou + " números, :(");
                Console.WriteLine("Você fez um total de pontos de: " + pontuacao);
                
                break;
            case 2:
                Console.WriteLine("[-------------- Você selecionou a dificuldade 2: digite números de 1 a 20 ------------]");
                Console.WriteLine("[------------------------- Digite 5 números 1 de cada vez:  --------------------------]");

                

                 for(int i = 0; i < 5; i++){
                    // Gerando um número inteiro aleatório entre 1 e 20;
                    num1a20 = random.Next(1, 20);
                    numerosRandomizados.Add(num1a10);
                    Console.WriteLine("[-------------------------------- Insira o " + ( i + 1 ) + "ª número: --------------------------------]");
                    numerosInseridos.Add(Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 0; i < numerosInseridos.Count && i < numerosRandomizados.Count; i++){

                    if(numerosInseridos[i] == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += acertouPontos;
                    }

                    if(numerosInseridos[i] - 1 == numerosRandomizados[i] || numerosInseridos[i] + 1 == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += numProximoPontos;
                        chegouPerto++;
                        errou--;
                    }

                    if (numerosInseridos[i] != numerosRandomizados[i]){
                        numerosErrados.Add(numerosInseridos[i]);
                        errou++;
                    }
                }

                Console.WriteLine("O sistema gerou os seguintes números:" + string.Join(", ", numerosRandomizados));
                Console.WriteLine("Você digitou os seguintes números:" + string.Join(", ", numerosInseridos));
                Console.WriteLine("Você acertou um total de " + acertos + " números, parabéns!");
                Console.WriteLine("Você passou perto de um total de " + chegouPerto + " números, parabéns!");
                Console.WriteLine("Você errou um total de " + errou + " números, :(");
                Console.WriteLine("Você fez um total de pontos de: " + pontuacao);

                break;
            case 3:
                Console.WriteLine("[-------------- Você selecionou a dificuldade 1: digite números de 1 a 50 ------------]");
                Console.WriteLine("[------------------------- Digite 5 números 1 de cada vez:  --------------------------]");

                

                 for(int i = 0; i < 5; i++){
                    // Gerando um número inteiro aleatório entre 1 e 50;
                    num1a50 = random.Next(1, 50);
                    numerosRandomizados.Add(num1a10);
                    Console.WriteLine("[-------------------------------- Insira o " + ( i + 1 ) + "ª número: --------------------------------]");
                    numerosInseridos.Add(Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 0; i < numerosInseridos.Count && i < numerosRandomizados.Count; i++){

                    if(numerosInseridos[i] == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += acertouPontos;
                    }

                    if(numerosInseridos[i] - 1 == numerosRandomizados[i] || numerosInseridos[i] + 1 == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += numProximoPontos;
                        chegouPerto++;
                        errou--;
                    }

                    if (numerosInseridos[i] != numerosRandomizados[i]){
                        numerosErrados.Add(numerosInseridos[i]);
                        errou++;
                    }
                }

                Console.WriteLine("O sistema gerou os seguintes números:" + string.Join(", ", numerosRandomizados));
                Console.WriteLine("Você digitou os seguintes números:" + string.Join(", ", numerosInseridos));
                Console.WriteLine("Você acertou um total de " + acertos + " números, parabéns!");
                Console.WriteLine("Você passou perto de um total de " + chegouPerto + " números, parabéns!");
                Console.WriteLine("Você errou um total de " + errou + " números, :(");
                Console.WriteLine("Você fez um total de pontos de: " + pontuacao);

                break;
            case 4:
                Console.WriteLine("[-------------- Você selecionou a dificuldade 4: digite números de 1 a 100 ------------]");
                Console.WriteLine("[------------------------- Digite 5 números 1 de cada vez:  --------------------------]");

                

                 for(int i = 0; i < 5; i++){
                    // Gerando um número inteiro aleatório entre 1 e 100;
                    num1a100 = random.Next(1, 100);
                    numerosRandomizados.Add(num1a10);
                    Console.WriteLine("[-------------------------------- Insira o " + ( i + 1 ) + "ª número: --------------------------------]");
                    numerosInseridos.Add(Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 0; i < numerosInseridos.Count && i < numerosRandomizados.Count; i++){

                    if(numerosInseridos[i] == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += acertouPontos;
                    }

                    if(numerosInseridos[i] - 1 == numerosRandomizados[i] || numerosInseridos[i] + 1 == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += numProximoPontos;
                        chegouPerto++;
                        errou--;
                    }

                    if (numerosInseridos[i] != numerosRandomizados[i]){
                        numerosErrados.Add(numerosInseridos[i]);
                        errou++;
                    }
                }

                Console.WriteLine("O sistema gerou os seguintes números:" + string.Join(", ", numerosRandomizados));
                Console.WriteLine("Você digitou os seguintes números:" + string.Join(", ", numerosInseridos));
                Console.WriteLine("Você acertou um total de " + acertos + " números, parabéns!");
                Console.WriteLine("Você passou perto de um total de " + chegouPerto + " números, parabéns!");
                Console.WriteLine("Você errou um total de " + errou + " números, :(");
                Console.WriteLine("Você fez um total de pontos de: " + pontuacao);

                break;
            case 5:
                Console.WriteLine("[-------------- Você selecionou a dificuldade 5: digite números de 1 a 1000 ------------]");
                Console.WriteLine("[------------------------- Digite 5 números 1 de cada vez:  --------------------------]");

                

                 for(int i = 0; i < 5; i++){
                    // Gerando um número inteiro aleatório entre 1 e 1000;
                    num1a1000 = random.Next(1, 1000);
                    numerosRandomizados.Add(num1a10);
                    Console.WriteLine("[-------------------------------- Insira o " + ( i + 1 ) + "ª número: --------------------------------]");
                    numerosInseridos.Add(Convert.ToInt32(Console.ReadLine()));
                }

                for (int i = 0; i < numerosInseridos.Count && i < numerosRandomizados.Count; i++){

                    if(numerosInseridos[i] == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += acertouPontos;
                    }

                    if(numerosInseridos[i] - 1 == numerosRandomizados[i] || numerosInseridos[i] + 1 == numerosRandomizados[i]){
                        numerosAcertados.Add(numerosInseridos[i]);
                        pontuacao += numProximoPontos;
                        chegouPerto++;
                        errou--;
                    }

                    if (numerosInseridos[i] != numerosRandomizados[i]){
                        numerosErrados.Add(numerosInseridos[i]);
                        errou++;
                    }
                }

                Console.WriteLine("O sistema gerou os seguintes números:" + string.Join(", ", numerosRandomizados));
                Console.WriteLine("Você digitou os seguintes números:" + string.Join(", ", numerosInseridos));
                Console.WriteLine("Você acertou um total de " + acertos + " números, parabéns!");
                Console.WriteLine("Você passou perto de um total de " + chegouPerto + " números, parabéns!");
                Console.WriteLine("Você errou um total de " + errou + " números, :(");
                Console.WriteLine("Você fez um total de pontos de: " + pontuacao);
              
                break;
            default:
                Console.WriteLine("Digite por favor um número válido");
                break;
        }
    }    
} 