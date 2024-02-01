﻿CREATE PROCEDURE [BFC].[usp_UploadDocument]
    @DocumentName VARCHAR(50),
    @DocumentImage IMAGE
AS
BEGIN
    DECLARE @LastInsertedVendorId INT;
    SET @LastInsertedVendorId = (SELECT IDENT_CURRENT('BFC.VendorDetails'));

    IF NOT EXISTS (SELECT 1 FROM [BFC].[DocumentDetails] WHERE [DocumentName] = @DocumentName)
    BEGIN
         INSERT INTO [BFC].[DocumentDetails] ([VendorId], [DocumentName], [DocumentImage])
            VALUES (@LastInsertedVendorId, @DocumentName, @DocumentImage);
    END
END;