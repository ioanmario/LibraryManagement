create table NewStudent(
stuid int NOT NULL IDENTITY(1,1) primary key,
sname varchar(250) not null,
senroll varchar(250) not null,
sdep varchar(250) not null,
san bigint not null,
scontact bigint not null,
semail varchar(250) not null
)
insert into NewStudent (sname, senroll, sdep, san, scontact, semail) values ('Alex Iordache', '381564','Electronica', 3, 07123456789, 'alexiordache@studlb.com');
select * from NewStudent
