-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: mainstmdb
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `all_balance_product`
--

DROP TABLE IF EXISTS `all_balance_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `all_balance_product` (
  `barcode` varchar(60) NOT NULL,
  `Des` varchar(150) DEFAULT NULL,
  `brand` varchar(100) DEFAULT NULL,
  `cost` double DEFAULT NULL,
  `wholesale` double DEFAULT NULL,
  `retail` double DEFAULT NULL,
  `cm_price` double DEFAULT NULL,
  `weight` double DEFAULT NULL,
  `average_weight` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`barcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `all_balance_product`
--

LOCK TABLES `all_balance_product` WRITE;
/*!40000 ALTER TABLE `all_balance_product` DISABLE KEYS */;
/*!40000 ALTER TABLE `all_balance_product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `all_items`
--

DROP TABLE IF EXISTS `all_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `all_items` (
  `barcode` varchar(100) NOT NULL,
  `Des` varchar(250) DEFAULT NULL,
  `Av_Stock` int(11) DEFAULT NULL,
  `Brand` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`barcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `all_items`
--

LOCK TABLES `all_items` WRITE;
/*!40000 ALTER TABLE `all_items` DISABLE KEYS */;
/*!40000 ALTER TABLE `all_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `all_items_sptbl`
--

DROP TABLE IF EXISTS `all_items_sptbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `all_items_sptbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `all_items_barcode` varchar(100) NOT NULL,
  `cost` double DEFAULT NULL,
  `whprice` double DEFAULT NULL,
  `rprice` double DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `ExpireDate` date DEFAULT NULL,
  `CMshowprice` double DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_items_sptbl_all_items_idx` (`all_items_barcode`),
  CONSTRAINT `fk_items_sptbl_all_items` FOREIGN KEY (`all_items_barcode`) REFERENCES `all_items` (`barcode`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1036 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `all_items_sptbl`
--

LOCK TABLES `all_items_sptbl` WRITE;
/*!40000 ALTER TABLE `all_items_sptbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `all_items_sptbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `all_items_view`
--

DROP TABLE IF EXISTS `all_items_view`;
/*!50001 DROP VIEW IF EXISTS `all_items_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `all_items_view` AS SELECT 
 1 AS `barcode`,
 1 AS `Des`,
 1 AS `Av_Stock`,
 1 AS `Brand`,
 1 AS `id`,
 1 AS `all_items_barcode`,
 1 AS `cost`,
 1 AS `whprice`,
 1 AS `rprice`,
 1 AS `stock`,
 1 AS `ExpireDate`,
 1 AS `CMshowprice`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `bank`
--

DROP TABLE IF EXISTS `bank`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `bank` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Bank_Name` varchar(55) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bank`
--

LOCK TABLES `bank` WRITE;
/*!40000 ALTER TABLE `bank` DISABLE KEYS */;
INSERT INTO `bank` VALUES (1,'Bank');
/*!40000 ALTER TABLE `bank` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `brands`
--

DROP TABLE IF EXISTS `brands`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `brands` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brands`
--

LOCK TABLES `brands` WRITE;
/*!40000 ALTER TABLE `brands` DISABLE KEYS */;
/*!40000 ALTER TABLE `brands` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(145) DEFAULT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `TelNo` varchar(100) DEFAULT NULL,
  `Fax` varchar(100) DEFAULT NULL,
  `City` varchar(45) DEFAULT NULL,
  `RegDate` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Cash',NULL,NULL,NULL,NULL,'2022-03-16');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_chaque`
--

DROP TABLE IF EXISTS `customer_chaque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer_chaque` (
  `Chq_No` varchar(100) NOT NULL,
  `Customer_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Bank_id` int(11) NOT NULL,
  `Bank` varchar(45) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `Status` varchar(55) DEFAULT NULL,
  `Issue_Date` date DEFAULT NULL,
  `Close_Date` date DEFAULT NULL,
  PRIMARY KEY (`Chq_No`),
  KEY `fk_Customer_Chaque_Customer1_idx` (`Customer_id`),
  KEY `fk_Customer_Chaque_Bank1_idx` (`Bank_id`),
  CONSTRAINT `fk_Customer_Chaque_Bank1` FOREIGN KEY (`Bank_id`) REFERENCES `bank` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Customer_Chaque_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_chaque`
--

LOCK TABLES `customer_chaque` WRITE;
/*!40000 ALTER TABLE `customer_chaque` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer_chaque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_credit`
--

DROP TABLE IF EXISTS `customer_credit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer_credit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `Credit_Date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Customer_Credit_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Customer_Credit_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_credit`
--

LOCK TABLES `customer_credit` WRITE;
/*!40000 ALTER TABLE `customer_credit` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer_credit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_payments`
--

DROP TABLE IF EXISTS `customer_payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer_payments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `PDate` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Customer_Payments_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Customer_Payments_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_payments`
--

LOCK TABLES `customer_payments` WRITE;
/*!40000 ALTER TABLE `customer_payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer_payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daily_proft_tbl`
--

DROP TABLE IF EXISTS `daily_proft_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `daily_proft_tbl` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Inv_no` varchar(45) DEFAULT NULL,
  `itemid` int(11) DEFAULT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(200) DEFAULT NULL,
  `cost` double DEFAULT NULL,
  `qty` double DEFAULT NULL,
  `selling_price` double DEFAULT NULL,
  `cm_price` double DEFAULT NULL,
  `sel_date` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daily_proft_tbl`
--

LOCK TABLES `daily_proft_tbl` WRITE;
/*!40000 ALTER TABLE `daily_proft_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `daily_proft_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inv_no`
--

DROP TABLE IF EXISTS `inv_no`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `inv_no` (
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inv_no`
--

LOCK TABLES `inv_no` WRITE;
/*!40000 ALTER TABLE `inv_no` DISABLE KEYS */;
INSERT INTO `inv_no` VALUES (27);
/*!40000 ALTER TABLE `inv_no` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inv_no_2`
--

DROP TABLE IF EXISTS `inv_no_2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `inv_no_2` (
  `id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inv_no_2`
--

LOCK TABLES `inv_no_2` WRITE;
/*!40000 ALTER TABLE `inv_no_2` DISABLE KEYS */;
INSERT INTO `inv_no_2` VALUES (4);
/*!40000 ALTER TABLE `inv_no_2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchase` (
  `pid` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Supplier_id` int(11) NOT NULL,
  `SupName` varchar(250) DEFAULT NULL,
  `netAmount` double DEFAULT NULL,
  `netdiscount` double DEFAULT NULL,
  `NetDisAmount` double DEFAULT NULL,
  `GrandTotal` double DEFAULT NULL,
  PRIMARY KEY (`pid`),
  KEY `fk_Purchase_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Purchase_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase`
--

LOCK TABLES `purchase` WRITE;
/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_items`
--

DROP TABLE IF EXISTS `purchase_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchase_items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Purchase_pid` int(11) NOT NULL,
  `itemid` int(11) NOT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_table1_Purchase1_idx` (`Purchase_pid`),
  KEY `fk_Purchase_Items_all_items_sptbl1_idx` (`itemid`),
  CONSTRAINT `fk_Purchase_Items_all_items_sptbl1` FOREIGN KEY (`itemid`) REFERENCES `all_items_sptbl` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_table1_Purchase1` FOREIGN KEY (`Purchase_pid`) REFERENCES `purchase` (`pid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_items`
--

LOCK TABLES `purchase_items` WRITE;
/*!40000 ALTER TABLE `purchase_items` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_temp`
--

DROP TABLE IF EXISTS `purchase_temp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `purchase_temp` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Supplier_id` int(11) NOT NULL,
  `SupName` varchar(250) DEFAULT NULL,
  `itemid` int(11) DEFAULT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  `amount` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Temp_purchase_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Temp_purchase_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_temp`
--

LOCK TABLES `purchase_temp` WRITE;
/*!40000 ALTER TABLE `purchase_temp` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_temp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `purchase_view`
--

DROP TABLE IF EXISTS `purchase_view`;
/*!50001 DROP VIEW IF EXISTS `purchase_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `purchase_view` AS SELECT 
 1 AS `pid`,
 1 AS `Invno`,
 1 AS `billing_date`,
 1 AS `Supplier_id`,
 1 AS `SupName`,
 1 AS `netAmount`,
 1 AS `netdiscount`,
 1 AS `NetDisAmount`,
 1 AS `GrandTotal`,
 1 AS `id`,
 1 AS `Purchase_pid`,
 1 AS `itemid`,
 1 AS `barcode`,
 1 AS `des`,
 1 AS `qty`,
 1 AS `unit_price`,
 1 AS `cus_price`,
 1 AS `discount`,
 1 AS `amount`,
 1 AS `expire_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `selling`
--

DROP TABLE IF EXISTS `selling`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling` (
  `sid` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Customer_id` int(11) NOT NULL,
  `CusName` varchar(250) DEFAULT NULL,
  `netAmount` double DEFAULT NULL,
  `netdiscount` double DEFAULT NULL,
  `NetDisAmount` double DEFAULT NULL,
  `GrandTotal` double DEFAULT NULL,
  PRIMARY KEY (`sid`),
  KEY `fk_Selling_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Selling_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling`
--

LOCK TABLES `selling` WRITE;
/*!40000 ALTER TABLE `selling` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `selling_items`
--

DROP TABLE IF EXISTS `selling_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling_items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Selling_sid` int(11) NOT NULL,
  `itemid` int(11) NOT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` double DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Selling_items_Selling1_idx` (`Selling_sid`),
  CONSTRAINT `fk_Selling_items_Selling1` FOREIGN KEY (`Selling_sid`) REFERENCES `selling` (`sid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling_items`
--

LOCK TABLES `selling_items` WRITE;
/*!40000 ALTER TABLE `selling_items` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `selling_return`
--

DROP TABLE IF EXISTS `selling_return`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling_return` (
  `sid` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Customer_id` int(11) NOT NULL,
  `CusName` varchar(250) DEFAULT NULL,
  `netAmount` double DEFAULT NULL,
  `netdiscount` double DEFAULT NULL,
  `NetDisAmount` double DEFAULT NULL,
  `GrandTotal` double DEFAULT NULL,
  PRIMARY KEY (`sid`),
  KEY `fk_Selling_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Selling_Customer10` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling_return`
--

LOCK TABLES `selling_return` WRITE;
/*!40000 ALTER TABLE `selling_return` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling_return` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `selling_return_items_`
--

DROP TABLE IF EXISTS `selling_return_items_`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling_return_items_` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Selling_Return_sid` int(11) NOT NULL,
  `all_items_sptbl_id` int(11) NOT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Selling_Return_items__Selling_Return1_idx` (`Selling_Return_sid`),
  KEY `fk_Selling_Return_items__all_items_sptbl1_idx` (`all_items_sptbl_id`),
  CONSTRAINT `fk_Selling_Return_items__Selling_Return1` FOREIGN KEY (`Selling_Return_sid`) REFERENCES `selling_return` (`sid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Selling_Return_items__all_items_sptbl1` FOREIGN KEY (`all_items_sptbl_id`) REFERENCES `all_items_sptbl` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling_return_items_`
--

LOCK TABLES `selling_return_items_` WRITE;
/*!40000 ALTER TABLE `selling_return_items_` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling_return_items_` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `selling_return_view`
--

DROP TABLE IF EXISTS `selling_return_view`;
/*!50001 DROP VIEW IF EXISTS `selling_return_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `selling_return_view` AS SELECT 
 1 AS `sid`,
 1 AS `Invno`,
 1 AS `billing_date`,
 1 AS `Customer_id`,
 1 AS `CusName`,
 1 AS `netAmount`,
 1 AS `netdiscount`,
 1 AS `NetDisAmount`,
 1 AS `GrandTotal`,
 1 AS `id`,
 1 AS `Selling_Return_sid`,
 1 AS `all_items_sptbl_id`,
 1 AS `barcode`,
 1 AS `des`,
 1 AS `qty`,
 1 AS `unit_price`,
 1 AS `cus_price`,
 1 AS `discount`,
 1 AS `amount`,
 1 AS `expire_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `selling_temp_1`
--

DROP TABLE IF EXISTS `selling_temp_1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling_temp_1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Customer_id` int(11) NOT NULL,
  `CusName` varchar(250) DEFAULT NULL,
  `itemid` int(11) DEFAULT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` double DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Selling_Temp_1_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Selling_Temp_1_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling_temp_1`
--

LOCK TABLES `selling_temp_1` WRITE;
/*!40000 ALTER TABLE `selling_temp_1` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling_temp_1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `selling_temp_2`
--

DROP TABLE IF EXISTS `selling_temp_2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `selling_temp_2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Invno` varchar(60) DEFAULT NULL,
  `billing_date` datetime DEFAULT NULL,
  `Customer_id` int(11) NOT NULL,
  `CusName` varchar(250) DEFAULT NULL,
  `itemid` int(11) DEFAULT NULL,
  `barcode` varchar(100) DEFAULT NULL,
  `des` varchar(250) DEFAULT NULL,
  `qty` double DEFAULT NULL,
  `unit_price` double DEFAULT NULL,
  `cus_price` double DEFAULT NULL,
  `discount` double DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `expire_date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Selling_Temp_2_Customer1_idx` (`Customer_id`),
  CONSTRAINT `fk_Selling_Temp_2_Customer1` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `selling_temp_2`
--

LOCK TABLES `selling_temp_2` WRITE;
/*!40000 ALTER TABLE `selling_temp_2` DISABLE KEYS */;
/*!40000 ALTER TABLE `selling_temp_2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `selling_view`
--

DROP TABLE IF EXISTS `selling_view`;
/*!50001 DROP VIEW IF EXISTS `selling_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `selling_view` AS SELECT 
 1 AS `sid`,
 1 AS `Invno`,
 1 AS `billing_date`,
 1 AS `Customer_id`,
 1 AS `CusName`,
 1 AS `netAmount`,
 1 AS `netdiscount`,
 1 AS `NetDisAmount`,
 1 AS `GrandTotal`,
 1 AS `id`,
 1 AS `Selling_sid`,
 1 AS `itemid`,
 1 AS `barcode`,
 1 AS `des`,
 1 AS `qty`,
 1 AS `unit_price`,
 1 AS `cus_price`,
 1 AS `discount`,
 1 AS `amount`,
 1 AS `expire_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `supplier` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(145) DEFAULT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `TelNo` varchar(100) DEFAULT NULL,
  `Fax` varchar(100) DEFAULT NULL,
  `City` varchar(45) DEFAULT NULL,
  `RegDate` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_chaque`
--

DROP TABLE IF EXISTS `supplier_chaque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `supplier_chaque` (
  `Chq_No` varchar(100) NOT NULL,
  `Supplier_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Bank_id` int(11) NOT NULL,
  `Bank` varchar(45) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `Status` varchar(55) DEFAULT NULL,
  `Issue_Date` date DEFAULT NULL,
  `Close_Date` date DEFAULT NULL,
  PRIMARY KEY (`Chq_No`),
  KEY `fk_Supplier_Chaque_Bank1_idx` (`Bank_id`),
  KEY `fk_Supplier_Chaque_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Supplier_Chaque_Bank1` FOREIGN KEY (`Bank_id`) REFERENCES `bank` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Supplier_Chaque_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_chaque`
--

LOCK TABLES `supplier_chaque` WRITE;
/*!40000 ALTER TABLE `supplier_chaque` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier_chaque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_credit`
--

DROP TABLE IF EXISTS `supplier_credit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `supplier_credit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `Credit_Date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Supplier_Credit_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Supplier_Credit_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_credit`
--

LOCK TABLES `supplier_credit` WRITE;
/*!40000 ALTER TABLE `supplier_credit` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier_credit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_payments`
--

DROP TABLE IF EXISTS `supplier_payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `supplier_payments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_id` int(11) NOT NULL,
  `Name` varchar(150) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Amount` double DEFAULT NULL,
  `PDate` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Supplier_Payments_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Supplier_Payments_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_payments`
--

LOCK TABLES `supplier_payments` WRITE;
/*!40000 ALTER TABLE `supplier_payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier_payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlog`
--

DROP TABLE IF EXISTS `userlog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `userlog` (
  `Uid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(150) DEFAULT NULL,
  `password` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`Uid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlog`
--

LOCK TABLES `userlog` WRITE;
/*!40000 ALTER TABLE `userlog` DISABLE KEYS */;
INSERT INTO `userlog` VALUES (1,'Admin','d033e22ae348aeb5660fc2140aec35850c4da997'),(2,'KASUN','b15c1dad52e4e31e26fbbd027bb456b186df4867');
/*!40000 ALTER TABLE `userlog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `all_items_view`
--

/*!50001 DROP VIEW IF EXISTS `all_items_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `all_items_view` AS select `a`.`barcode` AS `barcode`,`a`.`Des` AS `Des`,`a`.`Av_Stock` AS `Av_Stock`,`a`.`Brand` AS `Brand`,`t`.`id` AS `id`,`t`.`all_items_barcode` AS `all_items_barcode`,`t`.`cost` AS `cost`,`t`.`whprice` AS `whprice`,`t`.`rprice` AS `rprice`,`t`.`stock` AS `stock`,`t`.`ExpireDate` AS `ExpireDate`,`t`.`CMshowprice` AS `CMshowprice` from (`all_items` `a` join `all_items_sptbl` `t`) where (`a`.`barcode` = `t`.`all_items_barcode`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchase_view`
--

/*!50001 DROP VIEW IF EXISTS `purchase_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `purchase_view` AS select `p`.`pid` AS `pid`,`p`.`Invno` AS `Invno`,`p`.`billing_date` AS `billing_date`,`p`.`Supplier_id` AS `Supplier_id`,`p`.`SupName` AS `SupName`,`p`.`netAmount` AS `netAmount`,`p`.`netdiscount` AS `netdiscount`,`p`.`NetDisAmount` AS `NetDisAmount`,`p`.`GrandTotal` AS `GrandTotal`,`i`.`id` AS `id`,`i`.`Purchase_pid` AS `Purchase_pid`,`i`.`itemid` AS `itemid`,`i`.`barcode` AS `barcode`,`i`.`des` AS `des`,`i`.`qty` AS `qty`,`i`.`unit_price` AS `unit_price`,`i`.`cus_price` AS `cus_price`,`i`.`discount` AS `discount`,`i`.`amount` AS `amount`,`i`.`expire_date` AS `expire_date` from (`purchase` `p` join `purchase_items` `i`) where (`p`.`pid` = `i`.`Purchase_pid`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `selling_return_view`
--

/*!50001 DROP VIEW IF EXISTS `selling_return_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `selling_return_view` AS select `s`.`sid` AS `sid`,`s`.`Invno` AS `Invno`,`s`.`billing_date` AS `billing_date`,`s`.`Customer_id` AS `Customer_id`,`s`.`CusName` AS `CusName`,`s`.`netAmount` AS `netAmount`,`s`.`netdiscount` AS `netdiscount`,`s`.`NetDisAmount` AS `NetDisAmount`,`s`.`GrandTotal` AS `GrandTotal`,`i`.`id` AS `id`,`i`.`Selling_Return_sid` AS `Selling_Return_sid`,`i`.`all_items_sptbl_id` AS `all_items_sptbl_id`,`i`.`barcode` AS `barcode`,`i`.`des` AS `des`,`i`.`qty` AS `qty`,`i`.`unit_price` AS `unit_price`,`i`.`cus_price` AS `cus_price`,`i`.`discount` AS `discount`,`i`.`amount` AS `amount`,`i`.`expire_date` AS `expire_date` from (`selling_return` `s` join `selling_return_items_` `i`) where (`s`.`sid` = `i`.`Selling_Return_sid`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `selling_view`
--

/*!50001 DROP VIEW IF EXISTS `selling_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `selling_view` AS select `s`.`sid` AS `sid`,`s`.`Invno` AS `Invno`,`s`.`billing_date` AS `billing_date`,`s`.`Customer_id` AS `Customer_id`,`s`.`CusName` AS `CusName`,`s`.`netAmount` AS `netAmount`,`s`.`netdiscount` AS `netdiscount`,`s`.`NetDisAmount` AS `NetDisAmount`,`s`.`GrandTotal` AS `GrandTotal`,`i`.`id` AS `id`,`i`.`Selling_sid` AS `Selling_sid`,`i`.`itemid` AS `itemid`,`i`.`barcode` AS `barcode`,`i`.`des` AS `des`,`i`.`qty` AS `qty`,`i`.`unit_price` AS `unit_price`,`i`.`cus_price` AS `cus_price`,`i`.`discount` AS `discount`,`i`.`amount` AS `amount`,`i`.`expire_date` AS `expire_date` from (`selling` `s` join `selling_items` `i`) where (`s`.`sid` = `i`.`Selling_sid`) */;
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

-- Dump completed on 2022-08-13 21:59:02
