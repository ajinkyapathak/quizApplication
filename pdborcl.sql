insert into login values(101,'aju','aju123','a');
insert into login values(102,'shu','shu123','s');

create table questions(
q_id number primary key,
question varchar2(100) not null,
opt1 varchar2(20),
opt2 varchar2(20),
opt3 varchar2(20),
opt4 varchar2(20),
ans number,
marks number
);

insert into questions values(1,'What is the capital of India','Mumbai','chandigarh','Delhi','Sangli',3,5);
insert into questions values(2,'solve : 2+2','3','4','5','6',2,2);
insert into questions values(3,'solve : 2*3','6','7','12','3',1,5);
insert into questions values(4,'choose correct spelling :','Computrrre','Komputer','Computer','Komputrre',3,5);
insert into questions values(5,'highest mountain peak','himalaya','k2','alps','kanchenjunga',1,5);
insert into questions values(6,'Who discoverd Penicillin ?','Jonas Salk','Frederck Benting','Alexander Fleming','Ronald Ross',3
,5);
insert into questions values(7,'Who directed "Raja Harishchandra" (1913) the first totally indigenous Indian feature film','Ardeshir Irani','Dadasaheb Phalke','V.Shantaram	Sohrab','Modi',2
,3);
insert into questions values(8,'Which of the following has rail coach factory?','Saharanpur','Rae Bareli','Chittaranjan','Nagpur',2,5);
insert into questions values(9,'Which comet appears after 76 years?','Hailey’s','Holmes','	Donati’s','	None of these	',1,5);
insert into questions values(10,'Common salt form sea water is obtained by the method of…?','Sublimation','Evaporation','Crystallisation','Filteration',2,5);


commit;
select * from login;