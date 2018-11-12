-- -----------------------------------------------------
-- 11. PROCEDURE selectqclientByAgency
-- -----------------------------------------------------
exec selectqclientByAgency @aAgency = 'MontRoyal NB'
exec selectqclientByAgency @aAgency ='Rosemont NB'
exec selectqclientByAgency @aAgency ='247 Beaubien'
exec selectqclientByAgency @aAgency ='Alexander NB'

-- -----------------------------------------------------
-- 12. PROCEDURE selectqclientByemployeeNumber
-- -----------------------------------------------------
exec selectqclientByemployeeNumber @aemployeeNummber = 'E1E1'
exec selectqclientByemployeeNumber @aemployeeNummber ='E3E3'
exec selectqclientByemployeeNumber @aemployeeNummber ='E8E8'
exec selectqclientByemployeeNumber @aemployeeNummber ='E11E11'