﻿CREATE TABLE BlogVotes
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    BlogId INT NOT NULL,
    UserId INT NOT NULL,
    Upvotes INT DEFAULT 0,
    Downvotes INT DEFAULT 0,
    FOREIGN KEY (BlogId) REFERENCES Blogs(BlogId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

ALTER TABLE BlogVotes
ADD CreatedAt DATETIME DEFAULT GETDATE();