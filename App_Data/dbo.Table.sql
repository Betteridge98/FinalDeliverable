CREATE TABLE [dbo].[tblSaleItem] (
    [ItemID]    INT          NOT NULL,
    [ItemPrice] DECIMAL (18) NOT NULL,
    [Quantity]  INT          NOT NULL,
    [SaleID]    INT          NOT NULL,
    [DateAdded] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ItemID] ASC)
);