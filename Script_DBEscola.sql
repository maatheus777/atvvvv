create database DBEscola;

use DBEscola;

create table tblAlunos(
   id int not null primary key auto_increment,
   nome varchar(50) not null,
   idade int not null,
   unidade char(1) not null,
   serie int not null,
   turma char(1) not null
);

insert into tblAlunos values (null, 'KAUAN ALVES', 16, 'F', 2, 'E');
insert into tblAlunos values (null, 'GABRIELLA CAMPANHA', 16, 'F', 2, 'E');
insert into tblAlunos values (null, 'IZADORA IVE', 17, 'F', 2, 'E');
insert into tblAlunos values (null, 'NICOLAS PERES', 17, 'F', 2, 'E');
insert into tblAlunos values (null, 'SAMUEL MAIA', 17, 'F', 2, 'E');

select * from tblAlunos;


