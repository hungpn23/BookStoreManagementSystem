ALTER TABLE Books
	DROP CONSTRAINT FK_Books_Authors_AuthorId;
GO

DROP TABLE Books;
GO

DROP TABLE Users;
GO

DROP TABLE Authors;
GO

PRINT 'Hoàn tất việc hoàn tác (revert).';