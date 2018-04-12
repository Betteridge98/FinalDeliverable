CREATE PROCEDURE sproc_tblSaleItem_Insert
--create parameters for the stored procedure
	@ItemID int,
	@ItemPrice decimal,
	@Quantity int,
	@SaleID int,
	@DateAdded date

AS
--insert the new record
	INSERT INTO tblSaleItem (ItemID, ItemPrice, Quantity, SaleID, DateAdded)
	values (@ItemID, @ItemPrice, @Quantity, @SaleID, @DateAdded)

	--return the primary key value of the new record
RETURN @@Identity