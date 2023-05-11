create table MaxBook(
bid int NOT NULL IDENTITY(1,1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bPdate varchar(250) not null,
bPrice bigint not null,
bQuan bigint not null
)
insert into MaxBook (bName, bAuthor, bPubl, bPdate, bPrice, bQuan) values ('12 Reguli de Viata', 'Jordan Peterson','Trei', '12/02/2022', 79, 500);
select * from MaxBook