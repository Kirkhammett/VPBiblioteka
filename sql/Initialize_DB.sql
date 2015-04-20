-- Database creation
CREATE DATABASE `VPLibrary` /*!40100 COLLATE 'latin1_swedish_ci' */;
-- Initial creation of the Books table
CREATE TABLE `Books` (
	`id` SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	`Book_name` CHAR(50) NOT NULL,
	`Auth_name` CHAR(50) NOT NULL DEFAULT 'John',
	`Auth_surname` CHAR(50) NOT NULL DEFAULT 'Doe',
	`Publish_year` SMALLINT UNSIGNED NOT NULL,
	`Publish_house` TINYTEXT NOT NULL,
	`Book_description` TEXT NOT NULL,
	PRIMARY KEY (`Book_name`),
	INDEX `id` (`id`)
)
COMMENT='Table consisting of various books alongside with information about the authors, year of publishing and a succinct description of the books\' contents.'
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB;
