-- Create new customer table
CREATE TABLE `Orders` (
	`Cust_Ime` TINYTEXT NOT NULL,
	`Cust_Prezime` TINYTEXT NOT NULL,
	`Cust_Kniga` TINYTEXT NOT NULL,
	`Cust_Email` TINYTEXT NOT NULL,
	`Cust_Broj` TINYTEXT NULL
)
ENGINE=InnoDB
;
-- Grant SELECT and INSERT access to application user
GRANT SELECT, INSERT  ON TABLE `VPLibrary`.`Orders` TO 'Athena'@'%';
