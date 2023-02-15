create table products
(id int primary key identity (1,1),
 "name" nvarchar (30)
 );
insert into products
values 
('TV'),
('computer'), 
('mouse');

create table categories
(id int primary key identity (1,1),
 "name" nvarchar (30)
 );

insert into categories
values 
('sony'),
('asus'),
('logitech');

create table products_categories
(products_id int foreign key references products(id),
 categories_id int foreign key references categories(id),
 );

insert into products_categories 
values
(1, 1), 
(2, 3), 
(3, 2);

select p."name", c."name"
from products p
left join products_categories p_c on p_c.products_id = p.id
left join categories c on p_c.categories_id = c.id




