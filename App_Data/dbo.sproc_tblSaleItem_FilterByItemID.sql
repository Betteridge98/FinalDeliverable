CREATE PROCEDURE sproc_tblSaleItem_FilterByItemID
	--parameter to identify item to find
	@ItemID int

AS
	--select records from the table with matching item id
	SELECT * from tblSaleItem where ItemID = @ItemID;
RETURN 0