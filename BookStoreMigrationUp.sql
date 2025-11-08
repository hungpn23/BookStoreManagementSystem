CREATE TABLE Authors(
    Id uuid NOT NULL PRIMARY KEY,
    Name varchar(64) NOT NULL,
    BirthDate timestamptz NOT NULL,
    ShortBio text NULL
);

CREATE TABLE Books(
    Id uuid NOT NULL PRIMARY KEY,
    AuthorId uuid NOT NULL,
    Name varchar(128) NOT NULL,
    Type int NOT NULL,
    PublishDate timestamptz NOT NULL,
    Price int NOT NULL,

    CONSTRAINT FK_Books_Authors_AuthorId 
        FOREIGN KEY (AuthorId) 
        REFERENCES Authors(Id) 
        ON DELETE CASCADE
);

CREATE TABLE Users(
    Id uuid NOT NULL PRIMARY KEY,
    UserName varchar(256) NOT NULL,
    PasswordHash text NOT NULL,
    FullName varchar(256) NULL,
    Email varchar(256) NULL,
    IsActive boolean NOT NULL,
    IsAdmin boolean NOT NULL
);