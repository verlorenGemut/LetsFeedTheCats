create table signup(
id_user int identity(1,1) not null,
user_email varchar(100) not null,
login_user varchar(50) not null,
password_user varchar(50) not null
);

insert into signup (user_email, login_user, password_user) values ('admin', 'admin', 'admin')

select * from signup