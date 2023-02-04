-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bazy_projekt
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bazy_projekt
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bazy_projekt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `bazy_projekt` ;

-- -----------------------------------------------------
-- Table `bazy_projekt`.`balances`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`balances` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`balances` (
  `id` INT NOT NULL,
  `group_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`countries`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`countries` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`countries` (
  `id_country` INT NOT NULL AUTO_INCREMENT,
  `country_name` VARCHAR(45) NOT NULL,
  `currency` VARCHAR(45) NOT NULL,
  `shortcut` VARCHAR(3) NOT NULL,
  PRIMARY KEY (`id_country`),
  UNIQUE INDEX `id_UNIQUE` (`id_country` ASC) VISIBLE,
  UNIQUE INDEX `country_name_UNIQUE` (`country_name` ASC) VISIBLE,
  UNIQUE INDEX `currency_UNIQUE` (`currency` ASC) VISIBLE,
  UNIQUE INDEX `shortcut_UNIQUE` (`shortcut` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`groups`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`groups` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`groups` (
  `group_id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL DEFAULT NULL,
  `owner_id` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`group_id`))
ENGINE = InnoDB
AUTO_INCREMENT = 23
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`receipt_type`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`receipt_type` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`receipt_type` (
  `receipt_type_id` INT NOT NULL AUTO_INCREMENT,
  `receipt_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`receipt_type_id`),
  UNIQUE INDEX `idreceipt_type_UNIQUE` (`receipt_type_id` ASC) VISIBLE,
  UNIQUE INDEX `receipt_name_UNIQUE` (`receipt_name` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`receipts`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`receipts` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`receipts` (
  `receipt_id` INT NOT NULL AUTO_INCREMENT,
  `paying_user_id` INT NOT NULL,
  `group_id` INT NOT NULL,
  `amount` DOUBLE(10,2) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `receipt_type_id` INT NOT NULL,
  `date` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`receipt_id`),
  UNIQUE INDEX `id_UNIQUE` (`receipt_id` ASC) VISIBLE,
  INDEX `receipt_type_id` (`receipt_type_id` ASC) VISIBLE,
  INDEX `group_id` (`group_id` ASC) VISIBLE,
  CONSTRAINT `receipts_ibfk_1`
    FOREIGN KEY (`receipt_type_id`)
    REFERENCES `bazy_projekt`.`receipt_type` (`receipt_type_id`),
  CONSTRAINT `receipts_ibfk_2`
    FOREIGN KEY (`group_id`)
    REFERENCES `bazy_projekt`.`groups` (`group_id`),
  CONSTRAINT `receipts_ibfk_3`
    FOREIGN KEY (`group_id`)
    REFERENCES `bazy_projekt`.`groups` (`group_id`))
ENGINE = InnoDB
AUTO_INCREMENT = 44
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`user_type`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`user_type` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`user_type` (
  `user_type_id` INT NOT NULL AUTO_INCREMENT,
  `user_type_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`user_type_id`),
  UNIQUE INDEX `user_type_id_UNIQUE` (`user_type_id` ASC) VISIBLE,
  UNIQUE INDEX `user_type_name_UNIQUE` (`user_type_name` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`users` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`users` (
  `user_id` INT NOT NULL AUTO_INCREMENT,
  `user_name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(64) NOT NULL,
  `first_name` VARCHAR(45) NULL DEFAULT NULL,
  `last_name` VARCHAR(45) NULL DEFAULT NULL,
  `user_type_id` INT NOT NULL DEFAULT '1',
  `id_country` INT NOT NULL DEFAULT '1',
  `creation_date` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `user_name_UNIQUE` (`user_name` ASC) VISIBLE,
  UNIQUE INDEX `id_UNIQUE` (`user_id` ASC) VISIBLE,
  INDEX `user_type_id_idx` (`user_type_id` ASC) VISIBLE,
  INDEX `id_country` (`id_country` ASC) VISIBLE,
  CONSTRAINT `users_ibfk_1`
    FOREIGN KEY (`user_type_id`)
    REFERENCES `bazy_projekt`.`user_type` (`user_type_id`),
  CONSTRAINT `users_ibfk_2`
    FOREIGN KEY (`id_country`)
    REFERENCES `bazy_projekt`.`countries` (`id_country`))
ENGINE = InnoDB
AUTO_INCREMENT = 20
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`user_group`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`user_group` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`user_group` (
  `user_id` INT NOT NULL,
  `group_id` INT NOT NULL,
  INDEX `user_id` (`user_id` ASC) VISIBLE,
  INDEX `group_id` (`group_id` ASC) VISIBLE,
  CONSTRAINT `user_group_ibfk_1`
    FOREIGN KEY (`user_id`)
    REFERENCES `bazy_projekt`.`users` (`user_id`),
  CONSTRAINT `user_group_ibfk_2`
    FOREIGN KEY (`group_id`)
    REFERENCES `bazy_projekt`.`groups` (`group_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bazy_projekt`.`user_receipt`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`user_receipt` ;

CREATE TABLE IF NOT EXISTS `bazy_projekt`.`user_receipt` (
  `user_id` INT NOT NULL,
  `receipt_id` INT NOT NULL,
  `amount` DOUBLE(10,2) NOT NULL,
  INDEX `users_idx` (`user_id` ASC) VISIBLE,
  INDEX `receipts_idx` (`receipt_id` ASC, `user_id` ASC) VISIBLE,
  CONSTRAINT `user_receipt_ibfk_1`
    FOREIGN KEY (`receipt_id`)
    REFERENCES `bazy_projekt`.`receipts` (`receipt_id`),
  CONSTRAINT `user_receipt_ibfk_2`
    FOREIGN KEY (`user_id`)
    REFERENCES `bazy_projekt`.`users` (`user_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bazy_projekt` ;

-- -----------------------------------------------------
-- Placeholder table for view `bazy_projekt`.`groups_view`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bazy_projekt`.`groups_view` (`id` INT, `name` INT, `owner` INT, `User count` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bazy_projekt`.`users_view`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bazy_projekt`.`users_view` (`user_id` INT, `user_name` INT, `password` INT, `first_name` INT, `last_name` INT, `user_type_id` INT, `id_country` INT, `creation_date` INT);

-- -----------------------------------------------------
-- procedure add_new_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`add_new_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `add_new_group`(in group_name VARCHAR(45), in owner_id INT)
BEGIN
    INSERT INTO `groups` (`name`, owner_id)
    VALUES (group_name, owner_id);

    INSERT INTO `user_group` (user_id, group_id)
    VALUES (owner_id, (SELECT LAST_INSERT_ID()));
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure add_new_receipt
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`add_new_receipt`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `add_new_receipt`(paying_user_id INT, group_id INT, amount DECIMAL(10,2), receipt_name VARCHAR(45), receipt_type_id INT)
BEGIN
	DECLARE paying_user_in_group INT;
    
	(SELECT count(*)
    INTO paying_user_in_group
    FROM `user_group` UG
    WHERE UG.user_id = user_id AND UG.group_id = group_id);
    
    IF paying_user_in_group > 0 AND amount > 0
    THEN 
		INSERT INTO receipts(paying_user_id, group_id, amount, `name`, receipt_type_id, `date`)
		VALUES (paying_user_id, group_id, amount, receipt_name, receipt_type_id, NOW());
	END IF;
    
    SELECT last_insert_id();
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure add_user_to_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`add_user_to_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `add_user_to_group`(user_id INT, group_id INT)
BEGIN

	DECLARE amount INT; 
    
    
    (SELECT count(*)
    INTO amount
    FROM `user_group` UG
    WHERE UG.user_id = user_id AND UG.group_id = group_id);

	IF amount = 0
	THEN
		INSERT INTO `user_group`(user_id, group_id)
		VALUES (user_id, group_id);
	END IF;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure add_user_to_receipt
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`add_user_to_receipt`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `add_user_to_receipt`(user_id INT, receipt_id INT, amount DECIMAL(10,2))
BEGIN
	insert into user_receipt(user_id, receipt_id, amount)
	values (user_id, receipt_id, amount);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure check_if_owner
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`check_if_owner`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `check_if_owner`(user_id INT, group_id INT)
BEGIN
	select count(*) 
    from `groups` G 
    where G.group_id = group_id 
    and G.owner_id = user_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure create_new_user
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`create_new_user`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `create_new_user`(user_name VARCHAR(45), `password` VARCHAR(64), first_name VARCHAR(45), last_name VARCHAR(45), user_type_id INT, country_id INT)
BEGIN
	insert into `users`(user_name, `password`, first_name, last_name, user_type_id, id_country, creation_date) 
    values(user_name, `password`, first_name, last_name, user_type_id, country_id, NOW());
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure delete_account
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`delete_account`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `delete_account`(user_id INT)
BEGIN
	delete from users U where U.user_id = user_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_group_owner
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_group_owner`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_group_owner`(group_id INT)
BEGIN
	select U.user_id, U.user_name, U.first_name, U.last_name
    from `groups` G
    join users U
    on G.owner_id = U.user_id
    where G.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_group_owner_name
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_group_owner_name`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_group_owner_name`(group_id INT)
BEGIN
	select U.user_name
    from `groups` G
    join users U
    on G.owner_id = U.user_id
    where G.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_receipts_in_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_receipts_in_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_receipts_in_group`(group_id INT)
BEGIN
	select R.receipt_id as `ReceiptId`, R.`name` as `Name`, R.amount as Amount, U.user_name as 'Paying', RT.receipt_name, R.`date` as `Date`
    from receipts R
    join users U
    on R.paying_user_id = U.user_id
    join `groups` G
    on R.group_id = G.group_id
    join receipt_type RT
    on R.receipt_type_id = RT.receipt_type_id
    where G.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_user_by_username
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_user_by_username`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_user_by_username`(user_name varchar(45))
BEGIN
select U.user_id as UserId, U.user_name as Username, U.`password` as `Password`,  
U.first_name as FirstName, U.last_name as LastName, U.user_type_id as UserType, 
U.id_country as IdCountry, U.creation_date as CreationDate
from users U 
where U.user_name = user_name;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_user_debt
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_user_debt`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_user_debt`(group_id INT, user_id INT, owning_user_id INT)
BEGIN
select coalesce ((select SUM(UR.amount)
from user_receipt UR
join receipts R on R.receipt_id = UR.receipt_id
join `groups` G on G.group_id = R.group_id	
join `users` U on U.user_id = R.paying_user_id
where UR.user_id = owning_user_id
and G.group_id = group_id
and R.paying_user_id = user_id), 0);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_user_groups
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_user_groups`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_user_groups`(user_id INT)
BEGIN
	select G.group_id as `GroupId`, G.`Name`
    from `user_group` UG
    join users U
    on UG.user_id = U.user_id
    join `groups` G
    on UG.group_id = G.group_id
    where UG.user_id = user_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_users_in_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_users_in_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_users_in_group`(group_id INT)
BEGIN
	select U.user_id as UserId, U.user_name as Username, U.first_name as FirstName, U.last_name as LastName
    from user_group G
    join users U
    on G.user_id = U.user_id
    where G.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_users_in_receipt
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_users_in_receipt`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_users_in_receipt`(receipt_id INT)
BEGIN
	select U.user_name as `User`, UR.amount as `Amount`
    from user_receipt UR
    join users U
    on UR.user_id = U.user_id
    join receipts R
    on UR.receipt_id = R.receipt_id
    where UR.receipt_id = receipt_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure get_users_password
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`get_users_password`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `get_users_password`(user_name VARCHAR(45))
BEGIN
	select `password` from users U where U.user_name = user_name;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure remove_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`remove_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `remove_group`(IN group_id INT)
BEGIN
	delete from `receipts` R where R.group_id = group_id;
	delete from `user_group` UG where UG.group_id = group_id;
	delete from `groups` G where G.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure remove_receipt_from_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`remove_receipt_from_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `remove_receipt_from_group`(receipt_id INT)
BEGIN
	delete from user_receipt UR where UR.receipt_id = receipt_id;
	delete from receipts R where R.receipt_id = receipt_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure remove_user_from_group
-- -----------------------------------------------------

USE `bazy_projekt`;
DROP procedure IF EXISTS `bazy_projekt`.`remove_user_from_group`;

DELIMITER $$
USE `bazy_projekt`$$
CREATE DEFINER=`exodus`@`%` PROCEDURE `remove_user_from_group`(user_id INT, group_id INT)
BEGIN
	update receipts R 
    join user_receipt UR 
    on UR.user_id = user_id
    set R.amount = R.amount - UR.amount
    where R.group_id = group_id;
    
    delete UR from user_receipt UR 
    join receipts R on R.group_id = group_id
    where UR.user_id = user_id;
    
    delete from receipts R 
    where R.paying_user_id = user_id 
    and R.group_id = group_id;
    
	delete from user_group UG 
    where UG.user_id = user_id 
    and UG.group_id = group_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- View `bazy_projekt`.`groups_view`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`groups_view`;
DROP VIEW IF EXISTS `bazy_projekt`.`groups_view` ;
USE `bazy_projekt`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`exodus`@`%` SQL SECURITY DEFINER VIEW `bazy_projekt`.`groups_view` AS select `G`.`group_id` AS `id`,`G`.`name` AS `name`,`U`.`user_name` AS `owner`,(select count(0) from `bazy_projekt`.`user_group` where (`bazy_projekt`.`user_group`.`group_id` = `G`.`group_id`)) AS `User count` from (`bazy_projekt`.`groups` `G` join `bazy_projekt`.`users` `U` on((`G`.`owner_id` = `U`.`user_id`)));

-- -----------------------------------------------------
-- View `bazy_projekt`.`users_view`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bazy_projekt`.`users_view`;
DROP VIEW IF EXISTS `bazy_projekt`.`users_view` ;
USE `bazy_projekt`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`exodus`@`%` SQL SECURITY DEFINER VIEW `bazy_projekt`.`users_view` AS select `U`.`user_id` AS `user_id`,`U`.`user_name` AS `user_name`,`U`.`password` AS `password`,`U`.`first_name` AS `first_name`,`U`.`last_name` AS `last_name`,`UT`.`user_type_name` AS `user_type_id`,`C`.`country_name` AS `id_country`,`U`.`creation_date` AS `creation_date` from ((`bazy_projekt`.`users` `U` join `bazy_projekt`.`countries` `C` on((`U`.`id_country` = `U`.`id_country`))) join `bazy_projekt`.`user_type` `UT` on((`U`.`user_type_id` = `UT`.`user_type_id`)));
USE `bazy_projekt`;

DELIMITER $$

USE `bazy_projekt`$$
DROP TRIGGER IF EXISTS `bazy_projekt`.`groups_BEFORE_DELETE` $$
USE `bazy_projekt`$$
CREATE
DEFINER=`exodus`@`%`
TRIGGER `bazy_projekt`.`groups_BEFORE_DELETE`
BEFORE DELETE ON `bazy_projekt`.`groups`
FOR EACH ROW
BEGIN
	delete from user_group UG where UG.group_id = OLD.group_id;
    
    delete from receipts R where R.group_id = OLD.group_id;
END$$


USE `bazy_projekt`$$
DROP TRIGGER IF EXISTS `bazy_projekt`.`receipts_BEFORE_DELETE` $$
USE `bazy_projekt`$$
CREATE
DEFINER=`exodus`@`%`
TRIGGER `bazy_projekt`.`receipts_BEFORE_DELETE`
BEFORE DELETE ON `bazy_projekt`.`receipts`
FOR EACH ROW
BEGIN
	delete from user_receipt where receipt_id = OLD.receipt_id;
END$$


USE `bazy_projekt`$$
DROP TRIGGER IF EXISTS `bazy_projekt`.`users_BEFORE_DELETE` $$
USE `bazy_projekt`$$
CREATE
DEFINER=`exodus`@`%`
TRIGGER `bazy_projekt`.`users_BEFORE_DELETE`
BEFORE DELETE ON `bazy_projekt`.`users`
FOR EACH ROW
BEGIN
	delete from user_group UG where UG.user_id = OLD.user_id;
    delete from user_receipt UR where UR.user_id = OLD.user_id;
END$$


USE `bazy_projekt`$$
DROP TRIGGER IF EXISTS `bazy_projekt`.`user_group_BEFORE_DELETE` $$
USE `bazy_projekt`$$
CREATE
DEFINER=`exodus`@`%`
TRIGGER `bazy_projekt`.`user_group_BEFORE_DELETE`
BEFORE DELETE ON `bazy_projekt`.`user_group`
FOR EACH ROW
BEGIN
	delete from receipts R where R.paying_user_id = OLD.user_id AND R.group_id = OLD.group_id;
    delete from user_receipt UR where UR.user_id = OLD.user_id AND (select group_id from receipts where receipts.receipt_id = UR.receipt_id) = OLD.group_id;
END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
