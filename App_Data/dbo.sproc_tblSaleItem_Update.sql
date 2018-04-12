CREATE PROCEDURE sproc_tblSaleItem_Update
	@ItemID int,
	@ItemPrice decimal,
	@Quantity int,
	@SaleID int,
	@DateAdded date

AS
	--update the record as specified by @ItemID value
	update tblSaleItem
	set ItemID=@ItemID,
		ItemPrice = @ItemPrice,
		Quantity = @Quantity,
		SaleID = @SaleID,
		DateAdded = @DateAdded

	where SaleID=@SaleID