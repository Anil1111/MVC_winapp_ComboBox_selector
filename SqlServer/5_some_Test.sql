-- -----------------------------------------------------
-- 6. PROCEDURE deleteTclientByid
-- -----------------------------------------------------
USE bd_combobox_crud
Go

SELECT * FROM tclient
EXEC deleteTclientByid @aidclient = 44