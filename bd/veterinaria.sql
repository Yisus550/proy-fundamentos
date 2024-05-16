-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-05-2024 a las 04:41:16
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `veterinaria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datosduenio`
--

CREATE TABLE `datosduenio` (
  `id_duenio` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `datosduenio`
--

INSERT INTO `datosduenio` (`id_duenio`, `id_usuario`, `nombre`, `correo`, `direccion`, `apellido`, `telefono`) VALUES
(8, 8, 'Jose', 'jose@ejemplo.com', 'Calle 123', 'Perez', '1234567890');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datosmascota`
--

CREATE TABLE `datosmascota` (
  `id_mascota` int(11) NOT NULL,
  `id_duenio` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `especie` enum('Perro','Gato','Otro') DEFAULT NULL,
  `esterilizado` enum('Si','No') DEFAULT NULL,
  `raza` varchar(50) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `color` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `datosmascota`
--

INSERT INTO `datosmascota` (`id_mascota`, `id_duenio`, `nombre`, `sexo`, `fecha_nacimiento`, `especie`, `esterilizado`, `raza`, `edad`, `color`) VALUES
(5, 8, 'Benny', 'Macho', '2020-01-01', 'Perro', 'No', 'Labrador', 2, 'Cafe'),
(6, 8, 'Pinky', 'Hembra', '2019-05-15', 'Gato', 'Si', 'Siames', 1, 'Blanco');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_entradas_salidas`
--

CREATE TABLE `registro_entradas_salidas` (
  `id_registro` int(11) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `fecha_entrada` datetime DEFAULT NULL,
  `fecha_salida` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registro_entradas_salidas`
--

INSERT INTO `registro_entradas_salidas` (`id_registro`, `id_usuario`, `fecha_entrada`, `fecha_salida`) VALUES
(1, 8, '2024-05-10 05:56:18', NULL),
(2, 9, '2024-05-10 05:56:41', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `contrasena` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre_usuario`, `contrasena`) VALUES
(8, 'Jose', 'perrito123'),
(9, 'Jaime', 'ksdg465'),
(10, 'Pepe', 'ejemplo');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `datosduenio`
--
ALTER TABLE `datosduenio`
  ADD PRIMARY KEY (`id_duenio`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  ADD PRIMARY KEY (`id_mascota`),
  ADD KEY `id_duenio` (`id_duenio`);

--
-- Indices de la tabla `registro_entradas_salidas`
--
ALTER TABLE `registro_entradas_salidas`
  ADD PRIMARY KEY (`id_registro`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `datosduenio`
--
ALTER TABLE `datosduenio`
  MODIFY `id_duenio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  MODIFY `id_mascota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `registro_entradas_salidas`
--
ALTER TABLE `registro_entradas_salidas`
  MODIFY `id_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `datosduenio`
--
ALTER TABLE `datosduenio`
  ADD CONSTRAINT `datosduenio_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Filtros para la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  ADD CONSTRAINT `datosmascota_ibfk_1` FOREIGN KEY (`id_duenio`) REFERENCES `datosduenio` (`id_duenio`);

--
-- Filtros para la tabla `registro_entradas_salidas`
--
ALTER TABLE `registro_entradas_salidas`
  ADD CONSTRAINT `registro_entradas_salidas_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
