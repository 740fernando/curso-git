using System;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
            Console.WriteLine("Bom dia");
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
             */
        }
    }
}