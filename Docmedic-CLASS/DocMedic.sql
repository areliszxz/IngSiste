/*
 Navicat Premium Data Transfer

 Source Server         : Local
 Source Server Type    : MySQL
 Source Server Version : 50739 (5.7.39)
 Source Host           : localhost:8839
 Source Schema         : DocMedic

 Target Server Type    : MySQL
 Target Server Version : 50739 (5.7.39)
 File Encoding         : 65001

 Date: 01/12/2023 15:07:59
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for Ingreso
-- ----------------------------
DROP TABLE IF EXISTS `Ingreso`;
CREATE TABLE `Ingreso` (
  `codigo_ingreso` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_paciente` int(11) DEFAULT NULL,
  `codigo_medico` int(11) DEFAULT NULL,
  `numero_habitacion` int(11) DEFAULT NULL,
  `numero_cama` int(11) DEFAULT NULL,
  `fecha_ingreso` date DEFAULT NULL,
  PRIMARY KEY (`codigo_ingreso`),
  KEY `codigo_paciente` (`codigo_paciente`),
  KEY `codigo_medico` (`codigo_medico`),
  CONSTRAINT `codigo_medico` FOREIGN KEY (`codigo_medico`) REFERENCES `Medico` (`codigo`),
  CONSTRAINT `codigo_paciente` FOREIGN KEY (`codigo_paciente`) REFERENCES `Paciente` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Medico
-- ----------------------------
DROP TABLE IF EXISTS `Medico`;
CREATE TABLE `Medico` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `apellidos` varchar(255) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `especialidad` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo` (`codigo`,`nombre`,`apellidos`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for Paciente
-- ----------------------------
DROP TABLE IF EXISTS `Paciente`;
CREATE TABLE `Paciente` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `apellidos` varchar(255) DEFAULT NULL,
  `direccion` varchar(500) DEFAULT NULL,
  `poblacion` varchar(255) DEFAULT NULL,
  `provincia` varchar(500) DEFAULT NULL,
  `codigo_postal` int(11) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo` (`codigo`,`nombre`,`apellidos`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

SET FOREIGN_KEY_CHECKS = 1;
