-- 1. Thêm 3 Tác giả
INSERT INTO authors (name, birth_date, bio)
VALUES
('Nguyễn Nhật Ánh', '1955-05-07', 'Một trong những nhà văn có số lượng tác phẩm bán chạy nhất Việt Nam, chuyên viết về lứa tuổi thanh thiếu niên.'),
('Tô Hoài', '1920-09-27', 'Nhà văn nổi tiếng với tác phẩm "Dế Mèn Phiêu Lưu Ký". Ông có nhiều đóng góp lớn cho văn học Việt Nam.'),
('Vũ Trọng Phụng', '1912-10-20', 'Được mệnh danh là "Ông vua phóng sự đất Bắc", nổi tiếng với các tác phẩm châm biếm, hiện thực sâu sắc.');

-- 2. Thêm 5 Khách hàng
INSERT INTO customers (full_name, email)
VALUES
('Trần Văn A', 'tran.a@example.com'),
('Nguyễn Thị B', 'nguyen.b@example.com'),
('Lê Văn C', 'le.c@example.com'),
('Phạm Thị D', 'pham.d@example.com'),
('Hoàng Văn E', 'hoang.e@example.com');

-- 3. Thêm 15 Cuốn sách (5 cuốn / tác giả)
-- Giả sử ID tác giả là 1: Nguyễn Nhật Ánh, 2: Tô Hoài, 3: Vũ Trọng Phụng

-- Sách của Nguyễn Nhật Ánh (author_id = 1)
INSERT INTO books (author_id, name, type, published_date, daily_rental_fee)
VALUES
(1, 'Mắt Biếc', 'Tiểu Thuyết', '1990-01-01', 1.50),
(1, 'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 'Tiểu Thuyết', '2010-01-01', 1.80),
(1, 'Cho Tôi Xin Một Vé Đi Tuổi Thơ', 'Truyện Dài', '2008-01-01', 1.60),
(1, 'Cô Gái Đến Từ Hôm Qua', 'Truyện Dài', '1989-01-01', 1.40),
(1, 'Kính Vạn Hoa', 'Truyện Dài', '1995-01-01', 2.00);

-- Sách của Tô Hoài (author_id = 2)
INSERT INTO books (author_id, name, type, published_date, daily_rental_fee)
VALUES
(2, 'Dế Mèn Phiêu Lưu Ký', 'Truyện Thiếu Nhi', '1941-01-01', 1.20),
(2, 'Truyện Tây Bắc', 'Tập Truyện', '1953-01-01', 1.30),
(2, 'O Chuột', 'Truyện Thiếu Nhi', '1960-01-01', 1.10),
(2, 'Cát Bụi Chân Ai', 'Hồi Ký', '1992-01-01', 1.50),
(2, 'Nhà Bà Nữ', 'Tiểu Thuyết', '1951-01-01', 1.40);

-- Sách của Vũ Trọng Phụng (author_id = 3)
INSERT INTO books (author_id, name, type, published_date, daily_rental_fee)
VALUES
(3, 'Số Đỏ', 'Tiểu Thuyết', '1936-01-01', 2.00),
(3, 'Giông Tố', 'Tiểu Thuyết', '1936-01-01', 1.80),
(3, 'Cơm Thầy Cơm Cô', 'Phóng Sự', '1932-01-01', 1.50),
(3, 'Làm Đĩ', 'Tiểu Thuyết', '1937-01-01', 1.70),
(3, 'Vỡ Đê', 'Tiểu Thuyết', '1936-01-01', 1.60);

-- 4. Thêm 5 Lượt Thuê Sách (cho 5 khách hàng khác nhau)
-- Giả sử ID sách được tạo tự động từ 1 đến 15, và ID khách hàng từ 1 đến 5.

-- Khách hàng 1 (Trần Văn A) thuê Sách 1 (Mắt Biếc)
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(1, 1, NOW(), NOW() + INTERVAL '14 day', 1.50, 'renting');

-- Khách hàng 2 (Nguyễn Thị B) thuê Sách 6 (Dế Mèn Phiêu Lưu Ký)
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(6, 2, NOW(), NOW() + INTERVAL '14 day', 1.20, 'renting');

-- Khách hàng 3 (Lê Văn C) thuê Sách 11 (Số Đỏ)
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(11, 3, NOW(), NOW() + INTERVAL '14 day', 2.00, 'renting');

-- Khách hàng 4 (Phạm Thị D) thuê Sách 2 (Tôi Thấy Hoa Vàng Trên Cỏ Xanh)
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(2, 4, NOW() - INTERVAL '3 day', NOW() + INTERVAL '11 day', 1.80, 'renting');

-- Khách hàng 5 (Hoàng Văn E) thuê Sách 7 (Truyện Tây Bắc)
INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
VALUES
(7, 5, NOW() - INTERVAL '1 day', NOW() + INTERVAL '13 day', 1.30, 'renting');

-- 5. Cập nhật cột 'current_customer_id' trong bảng 'books' cho 5 cuốn sách đang được thuê
UPDATE books SET current_customer_id = 1 WHERE id = 1;
UPDATE books SET current_customer_id = 2 WHERE id = 6;
UPDATE books SET current_customer_id = 3 WHERE id = 11;
UPDATE books SET current_customer_id = 4 WHERE id = 2;
UPDATE books SET current_customer_id = 5 WHERE id = 7;