CREATE DATABASE  IF NOT EXISTS `bazy_projekt` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bazy_projekt`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 138.2.129.96    Database: bazy_projekt
-- ------------------------------------------------------
-- Server version	8.0.31-0ubuntu0.20.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `balances`
--

DROP TABLE IF EXISTS `balances`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `balances` (
  `id` int NOT NULL,
  `group_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `balances`
--

LOCK TABLES `balances` WRITE;
/*!40000 ALTER TABLE `balances` DISABLE KEYS */;
/*!40000 ALTER TABLE `balances` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `countries`
--

DROP TABLE IF EXISTS `countries`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `countries` (
  `id_country` int NOT NULL AUTO_INCREMENT,
  `country_name` varchar(45) NOT NULL,
  `currency` varchar(45) NOT NULL,
  `shortcut` varchar(3) NOT NULL,
  PRIMARY KEY (`id_country`),
  UNIQUE KEY `id_UNIQUE` (`id_country`),
  UNIQUE KEY `country_name_UNIQUE` (`country_name`),
  UNIQUE KEY `currency_UNIQUE` (`currency`),
  UNIQUE KEY `shortcut_UNIQUE` (`shortcut`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `countries`
--

LOCK TABLES `countries` WRITE;
/*!40000 ALTER TABLE `countries` DISABLE KEYS */;
INSERT INTO `countries` VALUES (1,'Poland','PLN','PL');
/*!40000 ALTER TABLE `countries` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groups` (
  `group_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `owner_id` varchar(45) NOT NULL,
  PRIMARY KEY (`group_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (1,'Grupa nr. 1','1'),(2,'Grupa nr. 2','5'),(8,'okejka','1'),(10,'XDDD','1'),(11,'XDDDDD','1'),(12,'ASDFASDF','1'),(13,'aaa','1');
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `groups_view`
--

DROP TABLE IF EXISTS `groups_view`;
/*!50001 DROP VIEW IF EXISTS `groups_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `groups_view` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `owner`,
 1 AS `User count`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `receipt_type`
--

DROP TABLE IF EXISTS `receipt_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receipt_type` (
  `receipt_type_id` int NOT NULL AUTO_INCREMENT,
  `receipt_name` varchar(45) NOT NULL,
  PRIMARY KEY (`receipt_type_id`),
  UNIQUE KEY `idreceipt_type_UNIQUE` (`receipt_type_id`),
  UNIQUE KEY `receipt_name_UNIQUE` (`receipt_name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipt_type`
--

LOCK TABLES `receipt_type` WRITE;
/*!40000 ALTER TABLE `receipt_type` DISABLE KEYS */;
INSERT INTO `receipt_type` VALUES (1,'Food'),(2,'Gift');
/*!40000 ALTER TABLE `receipt_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receipts`
--

DROP TABLE IF EXISTS `receipts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receipts` (
  `receipt_id` int NOT NULL AUTO_INCREMENT,
  `paying_user_id` int NOT NULL,
  `group_id` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `name` varchar(45) NOT NULL,
  `receipt_type_id` int NOT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`receipt_id`),
  UNIQUE KEY `id_UNIQUE` (`receipt_id`),
  KEY `receipt_type_id` (`receipt_type_id`),
  KEY `group_id` (`group_id`),
  CONSTRAINT `receipts_ibfk_1` FOREIGN KEY (`receipt_type_id`) REFERENCES `receipt_type` (`receipt_type_id`),
  CONSTRAINT `receipts_ibfk_2` FOREIGN KEY (`group_id`) REFERENCES `groups` (`group_id`),
  CONSTRAINT `receipts_ibfk_3` FOREIGN KEY (`group_id`) REFERENCES `groups` (`group_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipts`
--

LOCK TABLES `receipts` WRITE;
/*!40000 ALTER TABLE `receipts` DISABLE KEYS */;
INSERT INTO `receipts` VALUES (1,1,1,100.10,'Za jedzenie',1,'2023-01-21 23:44:15'),(2,5,2,50.00,'Za prezent',2,'2023-01-21 23:44:16');
/*!40000 ALTER TABLE `receipts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_group`
--

DROP TABLE IF EXISTS `user_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_group` (
  `user_id` int NOT NULL,
  `group_id` int NOT NULL,
  KEY `user_id` (`user_id`),
  KEY `group_id` (`group_id`),
  CONSTRAINT `user_group_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`),
  CONSTRAINT `user_group_ibfk_2` FOREIGN KEY (`group_id`) REFERENCES `groups` (`group_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_group`
--

LOCK TABLES `user_group` WRITE;
/*!40000 ALTER TABLE `user_group` DISABLE KEYS */;
INSERT INTO `user_group` VALUES (1,1),(2,1),(3,1),(4,1),(6,2),(5,2);
/*!40000 ALTER TABLE `user_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_receipt`
--

DROP TABLE IF EXISTS `user_receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_receipt` (
  `user_id` int NOT NULL,
  `receipt_id` int NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  KEY `users_idx` (`user_id`),
  KEY `receipts_idx` (`receipt_id`,`user_id`),
  CONSTRAINT `user_receipt_ibfk_1` FOREIGN KEY (`receipt_id`) REFERENCES `receipts` (`receipt_id`),
  CONSTRAINT `user_receipt_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_receipt`
--

LOCK TABLES `user_receipt` WRITE;
/*!40000 ALTER TABLE `user_receipt` DISABLE KEYS */;
INSERT INTO `user_receipt` VALUES (2,1,50.00),(3,1,50.00),(6,2,50.00);
/*!40000 ALTER TABLE `user_receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_type`
--

DROP TABLE IF EXISTS `user_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_type` (
  `user_type_id` int NOT NULL AUTO_INCREMENT,
  `user_type_name` varchar(45) NOT NULL,
  PRIMARY KEY (`user_type_id`),
  UNIQUE KEY `user_type_id_UNIQUE` (`user_type_id`),
  UNIQUE KEY `user_type_name_UNIQUE` (`user_type_name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_type`
--

LOCK TABLES `user_type` WRITE;
/*!40000 ALTER TABLE `user_type` DISABLE KEYS */;
INSERT INTO `user_type` VALUES (1,'Użytkownik'),(2,'Vip');
/*!40000 ALTER TABLE `user_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `user_type_id` int NOT NULL DEFAULT '1',
  `id_country` int NOT NULL DEFAULT '1',
  `creation_date` date DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_name_UNIQUE` (`user_name`),
  UNIQUE KEY `id_UNIQUE` (`user_id`),
  KEY `user_type_id_idx` (`user_type_id`),
  KEY `id_country` (`id_country`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`user_type_id`) REFERENCES `user_type` (`user_type_id`),
  CONSTRAINT `users_ibfk_2` FOREIGN KEY (`id_country`) REFERENCES `countries` (`id_country`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'craksys','hasloo','Kamil','Kochan',1,1,'2023-01-21'),(2,'krystian','hasloo','Krystian','Kowalski',1,1,'2023-01-21'),(3,'piotr','hasloo','Piotr','Adamczyk',1,1,'2023-01-21'),(4,'marcin','hasloo','Marcin','Górski',1,1,'2023-01-21'),(5,'wiktoria','hasloo','Wiktoria','Nowak',1,1,'2023-01-21'),(6,'maciej','hasloo','Maciej','Maciejewicz',1,1,'2023-01-21');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `users_view`
--

DROP TABLE IF EXISTS `users_view`;
/*!50001 DROP VIEW IF EXISTS `users_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `users_view` AS SELECT 
 1 AS `user_id`,
 1 AS `user_name`,
 1 AS `password`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `user_type_id`,
 1 AS `id_country`,
 1 AS `creation_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `groups_view`
--

/*!50001 DROP VIEW IF EXISTS `groups_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`exodus`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `groups_view` AS select `G`.`group_id` AS `id`,`G`.`name` AS `name`,`U`.`user_name` AS `owner`,(select count(0) from `user_group` where (`user_group`.`group_id` = `G`.`group_id`)) AS `User count` from (`groups` `G` join `users` `U` on((`G`.`owner_id` = `U`.`user_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `users_view`
--

/*!50001 DROP VIEW IF EXISTS `users_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`exodus`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `users_view` AS select `U`.`user_id` AS `user_id`,`U`.`user_name` AS `user_name`,`U`.`password` AS `password`,`U`.`first_name` AS `first_name`,`U`.`last_name` AS `last_name`,`UT`.`user_type_name` AS `user_type_id`,`C`.`country_name` AS `id_country`,`U`.`creation_date` AS `creation_date` from ((`users` `U` join `countries` `C` on((`U`.`id_country` = `U`.`id_country`))) join `user_type` `UT` on((`U`.`user_type_id` = `UT`.`user_type_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-22  1:01:16
