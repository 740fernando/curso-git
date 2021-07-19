using System;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
            Console.WriteLine("Bom dia");
            Console.WriteLine("Como você está hoje?");
            Console.ReadLine();
            /*Como criar um novo repositório Git
             * 1) Recomentável: Ative a visualização de arquivos oculos e extensões
             * 2) Inclua um arquivo .gitignore na pasta inicial do repositório, contendo as especificações apropriadas para seu tipo de projeto
             * -Crie um arquivo txt chamado git
             * -Aperte shift e depois clique com o botão direito do mouse e selecione a opção " abrir janela de comando aqui"
             * - renomeio arquivo pelo cmd
             * - comando : " ren git.txt .gitignore "
             * 3) No git bash execute o comando:
             * -git init
             * 
             * Configurando o Usuário: 
             * 1) Defina para o Git quem você é 
             * git config --global user.name "Seu nome"
             * git config --global user.email "Seu email"
             * ATENÇÃO: é importante você colocar o mesmo email que você vai usar para se cadastrar no GitHub
             * 
             * Como salvar uma "versão" do seu projeto
             * A ação de salvar " versão" do projeto chama se "commit"
             *  git status -mostra o status do projeto:
             *  -VERMELHO - aruqivos não rastrados (untracked)
             *  -VERDE - arquivo prontos para serem "commitados" (stage)
             *  
             *  Como gerar uma versão do projeto
             *  São duas etapas:
             *  1) Coloque os arquivos modificados na área de "stage";
             *  git add.
             *  2) Realiza o commit:
             *  git commit -m "Descrição do commit"
             *  
             *  Como saber se o commit deu certo?
             *  Digite o comando :
             *  git log
             *  
             *  E se eu esquecer de especificar a mensagem no commit?
             *  Se você esquecer de especificar a mensagem do commit, o Git
                Bash vai abrir o VIM para edição.
                Para sair do VIM tecle <ESC> e depois digite:
                :q!
                Tecle <ENTER>
                
                E se eu me perder e quiser voltar ao estado do commit atual?
                1) Descartar todas modificações, voltando ao estado do commit atual:
                git clean -df
                git checkout

                E se quiser desfazer o último commit?
                1) Remover o último commit mantendo as alterações nos arquivos:
                 git reset --soft HEAD~1
                2) Remover o último commit Inclusive as alterações nos arquivos(PERIGO!):
                git reset --hard HEAD~1
                
                E se eu quiser somente dar uma olhada em uma versão anterior?
                1) Navegar entre commits, alterando os arquivos temporariamente:
                    git checkout <código do commit>
                2) Voltar para o último commit:
                    git checkout <nome do branch>
            
            Visão geral do Github
            
            • É um serviço de armazenamento remoto de repositórios Git • Interface com usuário via web
            • Padrão da indústria para armazenamento de projetos de código aberto
            • Maior hospedeiro de código fonte do mundo
            • Planos pagos para repositórios privados
            • É uma "rede social" de repositórios Git. Dica: currículo!

            Criando um repositório remoto no Github
            • Faça login no Github
            • Crie um repositório vazio (sem readme, sem gitignore e sem licença)

            Associando um repositório remoto ao seu repositório local

            1) Associar nosso repositório local ao repositório remoto, dando o
            apelido de "origin" a ele:
            git remote add origin <URI do repositório remoto>

            2) Associar o repositório local a um outro repositório remoto, porém
            mantendo o mesmo apelido:
            git remote set-url origin <URI do repositório remoto>

            Como enviar o repositório local para o Github
            git push -u origin master
            Nota: se você usou a opção -u, nas próximas vezes que for subir o branch master,
            basta fazer:
            git push
            Nota: veja o quanto é fácil visualizar as diferenças entre os commits no Github!

             */
        }
    }
}