CREATE PROCEDURE sproc_tblSaleItem_Delete
--this stored procedure is situated in the data layer (App_Data) folder

--this stored procedure is used to delete a single record in the table tblSaleItem
--it accepts a single parameter @ItemID and returns no value

	--declare the parameter
	@ItemID int

AS
	--delete the record in tblSaleItem specified by the value of @ItemID
	delete from tblSaleItem where ItemID = @ItemID;