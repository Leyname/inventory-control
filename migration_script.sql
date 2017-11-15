-- ----------------------------------------------------------------------------
-- MySQL Workbench Migration
-- Migrated Schemata: inventory_control_1
-- Source Schemata: inventory_control
-- Created: Mon Sep 25 22:23:51 2017
-- Workbench Version: 6.3.9
-- ----------------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Schema inventory_control_1
-- ----------------------------------------------------------------------------
DROP SCHEMA IF EXISTS `inventory_control_1` ;
CREATE SCHEMA IF NOT EXISTS `inventory_control_1` ;

-- ----------------------------------------------------------------------------
-- Table inventory_control_1.customers
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `inventory_control_1`.`customers` (
  `id_customer` INT(11) NOT NULL AUTO_INCREMENT,
  `name_customer` VARCHAR(20) NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `phone_number` VARCHAR(11) NOT NULL,
  `mail` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id_customer`),
  UNIQUE INDEX `id_customer_UNIQUE` (`id_customer` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name_customer` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;

-- ----------------------------------------------------------------------------
-- Table inventory_control_1.products
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `inventory_control_1`.`products` (
  `id_product` INT(11) NOT NULL AUTO_INCREMENT,
  `name_product` VARCHAR(20) NOT NULL,
  `quantity_in_stock` INT(10) UNSIGNED NOT NULL,
  `price` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id_product`),
  UNIQUE INDEX `idproducts_UNIQUE` (`id_product` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name_product` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 19
DEFAULT CHARACTER SET = utf8;

-- ----------------------------------------------------------------------------
-- Table inventory_control_1.providers
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `inventory_control_1`.`providers` (
  `id_provider` INT(11) NOT NULL AUTO_INCREMENT,
  `name_provider` VARCHAR(20) NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `phone_number` VARCHAR(11) NOT NULL,
  `mail` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id_provider`),
  UNIQUE INDEX `id_providers_UNIQUE` (`id_provider` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name_provider` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;

-- ----------------------------------------------------------------------------
-- Table inventory_control_1.purchase_of_products
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `inventory_control_1`.`purchase_of_products` (
  `id_purchase` INT(11) NOT NULL AUTO_INCREMENT,
  `id_product_purchase` INT(11) NOT NULL,
  `date` DATETIME(6) NOT NULL,
  `id_customer` INT(11) NOT NULL,
  `quantity_purchase` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id_purchase`),
  UNIQUE INDEX `id_purchase_UNIQUE` (`id_purchase` ASC),
  INDEX `id_product_idx` (`id_product_purchase` ASC),
  INDEX `id_customer_idx` (`id_customer` ASC),
  CONSTRAINT `id_customer`
    FOREIGN KEY (`id_customer`)
    REFERENCES `inventory_control_1`.`customers` (`id_customer`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `id_product_purchase`
    FOREIGN KEY (`id_product_purchase`)
    REFERENCES `inventory_control_1`.`products` (`id_product`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8;

-- ----------------------------------------------------------------------------
-- Table inventory_control_1.receipt_of_products
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `inventory_control_1`.`receipt_of_products` (
  `id_receipt` INT(11) NOT NULL AUTO_INCREMENT,
  `id_product_receipt` INT(11) NOT NULL,
  `date` DATETIME(6) NOT NULL,
  `id_provider` INT(11) NOT NULL,
  `quantity_receipt` INT(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id_receipt`),
  UNIQUE INDEX `id_receipt_UNIQUE` (`id_receipt` ASC),
  INDEX `id_product_idx` (`id_product_receipt` ASC),
  INDEX `id_provider_idx` (`id_provider` ASC),
  CONSTRAINT `id_product_receipt`
    FOREIGN KEY (`id_product_receipt`)
    REFERENCES `inventory_control_1`.`products` (`id_product`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `id_provider`
    FOREIGN KEY (`id_provider`)
    REFERENCES `inventory_control_1`.`providers` (`id_provider`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;
SET FOREIGN_KEY_CHECKS = 1;
