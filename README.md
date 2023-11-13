# AcademiaDotNetDesafioAmigoSecreto
Desafio realizado para Academia .NET em C# utilizando Windows Forms

2) Desafio: Windows Form + Listas + Arquivo
    Tendo como base o programa do Amigo Secreto, refatorá-lo para que funcione em um ambiente gráfico Windows Forms
        A interface de comunicação é livre, ou seja, cada um pode organizar a forma de se comunicar com o usuário. Porém, todas
        as funcionalidades precisam estar presentes.
            - Cadastrar amigo
            - Listar amigos
            - Gerar amigo secreto
    
            - Para o desafio usar ou criar:
                1) classe Amigo: nome e email (getter e setter); método construtor;
                2) lista de amigos
                3) arquivo amigos.csv (com dados dos amigos, linha a linha, com os dados separados por ;)
                    Gustavo Castagna;gus.castagna@ufn.edu.br
                    Alexandre Nonato;alex.nonato@ufn.edu.br
                4) arquivo secretos.csv (com nome de um amigo e seu respectivo amigo secreto, separados por ;)
                    Gustavo Castagna;gus.castagna@ufn.edu.br;Alexandre Nonato;alex.nonato@ufn.edu.br

# Minhas percepções

- Interface amigável
- Criei o Botão Espiar, para facilitar o desenvolimento.
- Os arquivos amigos.csv e secreto.csv estão na pasta bin->Degug->net6.0-windows
- Tentei deixar o mais intuitivo possível, então para o cadastro de amigos você pode usar o ENTER etc...
