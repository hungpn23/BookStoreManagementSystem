truncate table "books", "authors", "users" restart identity;

insert into authors (name, birth_date, short_bio) values
( 
    'george orwell', 
    '1903-06-25', 
    'english novelist, essayist, journalist and critic.'
),
( 
    'j.k. rowling', 
    '1965-07-31', 
    'british author and philanthropist. wrote harry potter.'
); 

insert into books (author_id, name, book_type, published_date, price) values
(
    1,
    '1984',
    'dystopia',
    '1949-06-08',
    15.99
),
(
    2,
    'harry potter and the philosopher''s stone',
    'fantasy',
    '1997-06-26',
    24.99
);

insert into users (username, password, fullname, email, is_active, is_admin) values
(
    'admin',
    'password',
    'Pham Ngoc Hung',
    'admin@bookstore.com',
    true, 
    true  
);