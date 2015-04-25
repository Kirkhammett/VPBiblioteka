-- Add genre column
ALTER TABLE `Books`
	ADD COLUMN `Genre` CHAR(50) NOT NULL AFTER `Book_description`;
-- Update existing to proper genre
UPDATE `VPLibrary`.`Books` SET `Genre`='Fantasy' WHERE  `id` BETWEEN 1 AND 5;