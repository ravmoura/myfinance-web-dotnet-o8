create database myfinance;

use myfinance;

create table planoconta(
	id int identity(1,1) not null,
	nome varchar(50) not null,
	tipo char(1) not null,
	primary key (id)
);

create table transacao(
	id int identity(1,1) not null,
	historico varchar(100) null,
	data datetime null,
	valor decimal(9,2),
	planocontaid int not null,
	primary key (id),
	foreign key (planocontaid) references planoconta(id)
);

insert into planoconta(nome, tipo) values('Combustível','D')
insert into planoconta(nome, tipo) values('Alimentação','D')
insert into planoconta(nome, tipo) values('Saúde','D')
insert into planoconta(nome, tipo) values('Manutenção Carro','D')
insert into planoconta(nome, tipo) values('Viagens','D')
insert into planoconta(nome, tipo) values('Salário','R')
insert into planoconta(nome, tipo) values('Juros Recebidos','R')
insert into planoconta(nome, tipo) values('Créditos de Dividendos','R')
insert into planoconta(nome, tipo) values('Restituição de IR','R')

SELECT * FROM planoconta

SET DATEFORMAT dmy;
insert into transacao(historico, data, valor, planocontaid) values('Combustível Blazer', getdate(), 489, 1)
insert into transacao(historico, data, valor, planocontaid) values('Almoço de Domingo', '18-05-2025 12:00', 150, 2)
insert into transacao(historico, data, valor, planocontaid) values('Peças da Blazer', '10-05-2025 03:00', 18000, 4)
insert into transacao(historico, data, valor, planocontaid) values('Salário', '12-05-2025 10:00', 10000, 6)
insert into transacao(historico, data, valor, planocontaid) values('ITAUSA', '14-05-2025 10:00', 678, 8)

select * from transacao
