create database zoldzrt;

create table employees(
    id int not null primary key auto_increment,
    name varchar(50),
    city varchar(50),
    salary double
);

grant all privileges 
on zoldzrt.*
to zoldzrt@localhost
identified by 'titok';
