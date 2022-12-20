-- MySQL Script generated by MySQL Workbench
-- Thu Dec 16 17:02:41 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `mydb` ;

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8mb4 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Timetable`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Timetable` (
  `ID` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User` (
  `ID` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  `status` VARCHAR(45) NULL,
  `Feeder_ID` VARCHAR(45) NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Timetable data`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Timetable data` (
  `ID` INT NOT NULL,
  `weight` INT NULL,
  `Time` DATE NULL,
  `Timetable_ID` INT NULL,
  PRIMARY KEY (`ID`),
  INDEX `Timetable_Name_idx` (`Timetable_ID` ASC) VISIBLE,
  CONSTRAINT `Timetable_Name`
    FOREIGN KEY (`Timetable_ID`)
    REFERENCES `mydb`.`Timetable` (`ID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Feeder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Feeder` (
  `ID` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `value` INT NULL,
  `type` VARCHAR(45) NULL,
  `Timetable_ID` INT NULL,
  PRIMARY KEY (`ID`),
  INDEX `Timetable_idx` (`Timetable_ID` ASC) VISIBLE,
  CONSTRAINT `Timetable_ID`
    FOREIGN KEY (`Timetable_ID`)
    REFERENCES `mydb`.`Timetable` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Notes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Notes` (
  `ID` INT NOT NULL,
  `text` VARCHAR(45) NULL,
  `Feeder_ID` INT NULL,
  PRIMARY KEY (`ID`),
  INDEX `Feeder_ID_idx` (`Feeder_ID` ASC) VISIBLE,
  CONSTRAINT `Feeder_ID`
    FOREIGN KEY (`Feeder_ID`)
    REFERENCES `mydb`.`Feeder` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Log`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Log` (
  `ID` INT NOT NULL,
  `Event` VARCHAR(45) NULL,
  `Time` DATE NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Timetable`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User_Timetable` (
  `User_ID` INT NOT NULL,
  `Timetable_ID` INT NOT NULL,
  PRIMARY KEY (`User_ID`, `Timetable_ID`),
  INDEX `fk_User_Timetable_User1_idx` (`User_ID` ASC) VISIBLE,
  INDEX `fk_User_Timetable_Timetable1_idx` (`Timetable_ID` ASC) VISIBLE,
  CONSTRAINT `fk_User_Timetable_User1`
    FOREIGN KEY (`User_ID`)
    REFERENCES `mydb`.`User` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_Timetable_Timetable1`
    FOREIGN KEY (`Timetable_ID`)
    REFERENCES `mydb`.`Timetable` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Feeder`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User_Feeder` (
  `User_ID` INT NOT NULL,
  `Feeder_ID` INT NOT NULL,
  PRIMARY KEY (`User_ID`, `Feeder_ID`),
  INDEX `fk_User_Feeder_Feeder1_idx` (`Feeder_ID` ASC) VISIBLE,
  CONSTRAINT `fk_User_Feeder_User1`
    FOREIGN KEY (`User_ID`)
    REFERENCES `mydb`.`User` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_Feeder_Feeder1`
    FOREIGN KEY (`Feeder_ID`)
    REFERENCES `mydb`.`Feeder` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Log`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`User_Log` (
  `User_ID` INT NOT NULL,
  `Log_ID` INT NOT NULL,
  PRIMARY KEY (`User_ID`, `Log_ID`),
  INDEX `fk_User_Log_Log1_idx` (`Log_ID` ASC) VISIBLE,
  CONSTRAINT `fk_User_Log_User1`
    FOREIGN KEY (`User_ID`)
    REFERENCES `mydb`.`User` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_User_Log_Log1`
    FOREIGN KEY (`Log_ID`)
    REFERENCES `mydb`.`Log` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
