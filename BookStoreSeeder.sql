-- Xóa dữ liệu cũ và khởi động lại ID, 'CASCADE' sẽ xóa các bảng liên quan
TRUNCATE TABLE "authors", "customers", "books", "book_rentals" RESTART IDENTITY CASCADE;

-- 1. Thêm tác giả
INSERT INTO authors (name, birth_date, short_bio) VALUES
(
    'George Orwell',
    '1903-06-25',
    'English novelist, essayist, journalist and critic.'
),
(
    'J.K. Rowling',
    '1965-07-31',
    'British author and philanthropist. Wrote Harry Potter.'
);

-- 2. Thêm khách hàng (thay vì users)
INSERT INTO customers (username, password, fullname, email, is_active) VALUES
(
    'customer1',
    'hashed_password_1', -- (Đã băm)
    'Nguyen Van A',
    'a@example.com',
    TRUE
),
(
    'customer2',
    'hashed_password_2', -- (Đã băm)
    'Tran Thi B',
    'b@example.com',
    TRUE
);
-- (Lưu ý: customer1 có ID = 1, customer2 có ID = 2)

-- 3. Thêm sách
INSERT INTO books (author_id, name, book_type, published_date, daily_rental_fee, current_renter_id) VALUES
(
    1, -- George Orwell
    '1984',
    'Dystopia',
    '1949-06-08',
    1.50, -- Phí thuê 1.50/ngày
    1     -- Sách này (ID 1) đang được thuê bởi customer1 (ID 1)
),
(
    2, -- J.K. Rowling
    'Harry Potter and the Philosopher''s Stone',
    'Fantasy',
    '1997-06-26',
    2.00, -- Phí thuê 2.00/ngày
    NULL  -- Sách này (ID 2) đang có sẵn để thuê
),
(
    1, -- George Orwell
    'Animal Farm',
    'Allegory',
    '1945-08-17',
    1.25,
    NULL  -- Sách này (ID 3) đang có sẵn để thuê
);

-- 4. Thêm lịch sử thuê (Phải khớp với trạng thái của bảng books)
-- (Vì sách '1984' (ID 1) đang được thuê bởi customer1 (ID 1))
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(
    1, -- book_id '1984'
    1, -- customer_id 'customer1'
    NOW() - INTERVAL '5 days', -- Thuê 5 ngày trước
    NOW() + INTERVAL '9 days', -- Hạn trả là 9 ngày nữa (tổng 14 ngày)
    1.50, -- Phí thuê tại thời điểm đó
    'renting' -- Trạng thái đang thuê
);