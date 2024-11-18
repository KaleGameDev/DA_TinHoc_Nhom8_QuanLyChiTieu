CREATE TABLE [dbo].[User] (
    [UserId]      INT           IDENTITY (1, 1) NOT NULL,
    [Username]    NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

CREATE TABLE [dbo].[Plan] (
    [PlanId]      INT           IDENTITY (1, 1) NOT NULL,
    [PlanName]    NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR(MAX)  NOT NULL,  -- Thay Budget thành Description để lưu chuỗi dài
    [UserId]      INT            NOT NULL,
    CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED ([PlanId] ASC),
    CONSTRAINT [FK_Plan_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([UserId])
);

CREATE TABLE [dbo].[Category] (
    [CategoryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (50) NOT NULL,
    [IsIncome]     BIT           NOT NULL DEFAULT 0, -- 0 = Chi, 1 = Thu
    [UserId]       INT           NOT NULL, -- Thêm cột UserId để lưu ID người dùng tạo danh mục
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([CategoryId] ASC),
    CONSTRAINT [FK_Category_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User](UserId) -- Ràng buộc khóa ngoại với bảng User
);

CREATE TABLE [dbo].[Transaction] (
    [TransactionId]   INT             IDENTITY (1, 1) NOT NULL,
    [TransactionName] NVARCHAR (100)  NOT NULL,
    [Amount]          DECIMAL (18, 2) NOT NULL,
    [CategoryId]      INT             NOT NULL,
    [PlanId]          INT             NOT NULL,
    [UserId]          INT             NOT NULL, -- Thêm cột UserId
    [Date]            DATETIME        NOT NULL,
    [Notes]           NVARCHAR (200)  NULL,
    [TransactionType] BIT             NOT NULL DEFAULT 0, -- 0 = Chi, 1 = Thu
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    CONSTRAINT [FK_Transaction_Plan] FOREIGN KEY ([PlanId]) REFERENCES [dbo].[Plan] ([PlanId]),
    CONSTRAINT [FK_Transaction_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId]),
    CONSTRAINT [FK_Transaction_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]) -- Ràng buộc khóa ngoại với bảng User
);
