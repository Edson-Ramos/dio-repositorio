# Principais Comandos Para Git :school: 

- **Git init** - Usado para criar um novo repositório .git na pasta local
- **Git add** - Usado para adicionar novos arquivos para serem comitados (git add ".", "*", "nome do arquivo") . ou * Adiciona tudo.
- **Git Commit** - é usado para confirma as alterações feitas nos arquivos e prepara-ló para empurrar para o repositório remoto (git commit -m "Msg")
- **Git Config** - faz algumas configurações necessárias no git(git config --global user.email seuemail@.com/ git config --global user.name seu nome)
- **Git Status** - Retorna a situação atual dos arquivos que estão no repositório (git status)
- **Git Remote** - Verificar o caminho remoto do repositório(git remote -v)
- **Git  Remote Add** - Adicionar o link remoto do repositório do GitHub(antes é preciso criar um novo repositório no GitHub e pegar o link)(git remote add origin link do repositório) origin é um apelido poderia ser qualquer outro nome mas por padrão utilizamos origin.
- **Git Push** - empurra nossos arquivos que estão no repositório local para o repositório remoto no GitHub(git push origin master)
- **Git Pull** - Puxa o repositório remoto para o local caso aconteça algum conflito de versão(git pull origin master)
- **Git Clone** - Clona um repositório remoto para um repositório local(git clone link do repositório)
