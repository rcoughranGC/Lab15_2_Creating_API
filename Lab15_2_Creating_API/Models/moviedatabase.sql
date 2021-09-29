create database moviedatabase;
use moviedatabase;


create table movies (
	id int not null auto_increment,
    Title varchar(20),
    genre varchar(20),
    primary key(id)
);

insert into movies (title, genre) values ('Die Hard', 'Action');
insert into movies (title, genre) values ('Predator', 'Action');
insert into movies (title, genre) values ('Terminator', 'Action');
insert into movies (title, genre) values ('Die Hard 2', 'Action');
insert into movies (title, genre) values ('Caddyshack', 'Comedy');
insert into movies (title, genre) values ('Ghostbusters', 'Comedy');
insert into movies (title, genre) values ('Tommy Boy', 'Comedy');
