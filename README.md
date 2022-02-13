# Sistema de Gerencimento de Universidades

O Sistema de Gerenciamento de Universidades é um gerenciador de universidades que possui o propósito de auxiliar na administração de alunos, funcionários,
professores, coordenadores, cursos e setores de uma Universidade.
Projeto desenvolvido para o segundo semestre do curso de Engenharia de Software, para a disciplina de Prática Profissional

## 📋 Entidades
- **Pessoa**: id, nome, idade, sexo, estado civil, e-mail, telefone_id, endereco_id;
- **Telefone**: id, operadora, DDD, fixo/celular;
- **Endereço**: id, país, estado, cidade, bairro, rua, número e CEP;
- **Aluno**: RA, curso_id, tipo de entrada;
- **Professor**: RA;
- **Curso**: id, nome, materia_id, coordenador_id, área, períodos;
- **Matéria**: id, nome, carga horária, professor_id;
- **Funcionário**: setor_id, cargo;
- **Setor**: id, tipo do setor, localização;
- **Coordenador**: RA.

## 🤝 Relacionamento entre Entidades
- uma Pessoa possui um Telefone - Relacionamento 1..1 (um para um)
- uma Pessoa possui um Endereço - Relacionamento 1..1 (um para um)
- um Aluno está matriculado em um Curso, mas um Curso pode ter vários Alunos - Relacionamento 1..n ou 1..* (um para muitos)
- um Professor leciona uma matéria ou mais matérias mas uma matéria só pode lecionada por um professor - Relacionamento 1..n ou 1..* (um para muitos)
- um Curso possui várias Matérias - Relacionamento 1..n ou 1..* (um para muitos)
- uma Matéria pode ser vinculada a vários Cursos - Relacionamento 1..n ou 1..* (um para muitos)
- um Coordenador pode ser vinculado a vários Cursos, mas um Curso só pode ter um Coordenador - Relacionamento 1..n ou 1..* (um para muitos)
- um Setor pertence a vários Funcionários mas um Funcionário só pertence a um Setor - Relacionamento 1..n ou 1..* (um para muitos)

## 🛠 Tecnologias 

- C#
