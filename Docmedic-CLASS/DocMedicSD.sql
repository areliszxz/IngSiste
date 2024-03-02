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

 Date: 01/12/2023 15:08:22
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
-- Records of Ingreso
-- ----------------------------
BEGIN;
INSERT INTO `Ingreso` (`codigo_ingreso`, `codigo_paciente`, `codigo_medico`, `numero_habitacion`, `numero_cama`, `fecha_ingreso`) VALUES (1, 3, 2, 123, 1, '2020-12-01');
INSERT INTO `Ingreso` (`codigo_ingreso`, `codigo_paciente`, `codigo_medico`, `numero_habitacion`, `numero_cama`, `fecha_ingreso`) VALUES (2, 1, 5, 321, 2, '2023-02-01');
INSERT INTO `Ingreso` (`codigo_ingreso`, `codigo_paciente`, `codigo_medico`, `numero_habitacion`, `numero_cama`, `fecha_ingreso`) VALUES (3, 2, 2, 43, 34, '2001-02-01');
INSERT INTO `Ingreso` (`codigo_ingreso`, `codigo_paciente`, `codigo_medico`, `numero_habitacion`, `numero_cama`, `fecha_ingreso`) VALUES (4, 4, 2, 32, 2, '2023-08-01');
INSERT INTO `Ingreso` (`codigo_ingreso`, `codigo_paciente`, `codigo_medico`, `numero_habitacion`, `numero_cama`, `fecha_ingreso`) VALUES (5, 5, 1, 12, 9, '2004-09-29');
COMMIT;

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
-- Records of Medico
-- ----------------------------
BEGIN;
INSERT INTO `Medico` (`codigo`, `nombre`, `apellidos`, `telefono`, `especialidad`) VALUES (1, 'Juan', 'Lopez', '4422339658', 'OFT');
INSERT INTO `Medico` (`codigo`, `nombre`, `apellidos`, `telefono`, `especialidad`) VALUES (2, 'Francisco', 'Piña', '0180052154', 'Cirujano');
INSERT INTO `Medico` (`codigo`, `nombre`, `apellidos`, `telefono`, `especialidad`) VALUES (3, 'Maria', 'Cuña', '788555452', 'Ginecologia');
INSERT INTO `Medico` (`codigo`, `nombre`, `apellidos`, `telefono`, `especialidad`) VALUES (4, 'Veronica', 'Catalina', '5566778899', 'Instrumentista');
INSERT INTO `Medico` (`codigo`, `nombre`, `apellidos`, `telefono`, `especialidad`) VALUES (5, 'Selena', 'Grande', '9900998866', 'Emergencias');
COMMIT;

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

-- ----------------------------
-- Records of Paciente
-- ----------------------------
BEGIN;
INSERT INTO `Paciente` (`codigo`, `nombre`, `apellidos`, `direccion`, `poblacion`, `provincia`, `codigo_postal`, `telefono`, `fecha_nacimiento`) VALUES (1, 'Felipe', 'Ordas', 'Pueblo nuevo 12', 'Mexico', 'Querétaro', 90890, '9078564332', '1920-12-01');
INSERT INTO `Paciente` (`codigo`, `nombre`, `apellidos`, `direccion`, `poblacion`, `provincia`, `codigo_postal`, `telefono`, `fecha_nacimiento`) VALUES (2, 'Ramon', 'Sanchez', 'Barrio antiguo 16', 'Chicago', 'Querétaro', 19034, '8877553344', '1980-01-23');
INSERT INTO `Paciente` (`codigo`, `nombre`, `apellidos`, `direccion`, `poblacion`, `provincia`, `codigo_postal`, `telefono`, `fecha_nacimiento`) VALUES (3, 'Violetta', 'Cruz', 'Satelite 90', 'California', 'Querétaro', 98076, '8965438276', '1982-02-03');
INSERT INTO `Paciente` (`codigo`, `nombre`, `apellidos`, `direccion`, `poblacion`, `provincia`, `codigo_postal`, `telefono`, `fecha_nacimiento`) VALUES (4, 'Christina', 'Anaya', 'Polanco 23', 'Alaska', 'Querétaro', 76514, '2345123423', '1970-05-03');
INSERT INTO `Paciente` (`codigo`, `nombre`, `apellidos`, `direccion`, `poblacion`, `provincia`, `codigo_postal`, `telefono`, `fecha_nacimiento`) VALUES (5, 'Miguel', 'Rios', 'Carrillo puerto 24', 'Jurica', 'Querétaro', 21034, '4422338765', '1989-03-29');
COMMIT;

SET FOREIGN_KEY_CHECKS = 1;
