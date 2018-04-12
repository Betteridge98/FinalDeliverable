CREATE PROCEDURE [dbo].sproc_tblSaleItem_FilterBySaleID
--this stored procedure uses the like function to find sale ID's that match the value
--stored in the parameter @SaleID
--the stored procedure doesn't return a value
	
	--declare the parameter as int
	@SaleID int

AS
	--selecgt all fields from any records that have a SaleID like this SaleID
	SELECT * from tblSaleItem where SaleID like @SaleID;
RETURN 0