-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-05-2024 a las 20:30:14
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
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL,
  `medico` varchar(100) NOT NULL,
  `nombre_mascota` varchar(50) NOT NULL,
  `especie` enum('Perro','Gato','Otro') NOT NULL,
  `raza` varchar(50) NOT NULL,
  `propietario` varchar(100) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `sintomas` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_medico`
--

CREATE TABLE `historial_medico` (
  `ID` int(11) NOT NULL,
  `Nombre_Mascota` varchar(255) DEFAULT NULL,
  `Tipo_Vacuna` varchar(255) DEFAULT NULL,
  `Fecha_AplicacionV` datetime DEFAULT NULL,
  `Descripcion_Traumas` varchar(255) DEFAULT NULL,
  `Fecha_Accidente` datetime DEFAULT NULL,
  `Recibio_Tratamiento` enum('si','no') DEFAULT NULL,
  `EspecifiqueT` varchar(255) DEFAULT NULL,
  `Tipo_Desparasitante` varchar(255) DEFAULT NULL,
  `Fecha_AplicacionD` datetime DEFAULT NULL,
  `Algun_Medicamento` enum('si','no') DEFAULT NULL,
  `EspecifiqueM` varchar(255) DEFAULT NULL,
  `Alergias` enum('si','no') DEFAULT NULL,
  `EspecifiqueA` varchar(255) DEFAULT NULL,
  `Alguna_Cirugia` enum('si','no') DEFAULT NULL,
  `Fecha_Cirugia` datetime DEFAULT NULL,
  `EspecifiqueCirugia` varchar(255) DEFAULT NULL,
  `Cirujano` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_consultas`
--

CREATE TABLE `registro_consultas` (
  `ID` int(11) NOT NULL,
  `Nombre_Mascota` varchar(255) DEFAULT NULL,
  `Fecha_consulta` datetime DEFAULT NULL,
  `Consultas_anteriores` varchar(255) DEFAULT NULL,
  `Motivo` text DEFAULT NULL,
  `Examen_fisico` text DEFAULT NULL,
  `Diagnostico` text DEFAULT NULL,
  `Pruebas_realizadas` varchar(255) DEFAULT NULL,
  `Resultados` text DEFAULT NULL,
  `Medicamentos` text DEFAULT NULL,
  `Dosis` text DEFAULT NULL,
  `Como_Tomarlo` text DEFAULT NULL,
  `Dieta_recomendada` text DEFAULT NULL,
  `Cuidados_especiales` tinyint(1) DEFAULT NULL,
  `Especifique` text DEFAULT NULL,
  `Respuesta_tratamiento` text DEFAULT NULL,
  `Cambios_sintomas` text DEFAULT NULL,
  `Recomendaciones` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_entradas_salidas`
--

CREATE TABLE `registro_entradas_salidas` (
  `id_registro` int(11) NOT NULL,
  `usuario` int(11) DEFAULT NULL,
  `fecha_entrada` datetime DEFAULT NULL,
  `fecha_salida` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registro_entradas_salidas`
--

INSERT INTO `registro_entradas_salidas` (`id_registro`, `usuario`, `fecha_entrada`, `fecha_salida`) VALUES
(1, 0, '2024-05-23 19:28:44', '2024-05-24 10:25:03');

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
(1, 'Jose', 'perrito123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`id_cita`);

--
-- Indices de la tabla `datosduenio`
--
ALTER TABLE `datosduenio`
  ADD PRIMARY KEY (`id_duenio`);

--
-- Indices de la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  ADD PRIMARY KEY (`id_mascota`),
  ADD KEY `id_duenio` (`id_duenio`);

--
-- Indices de la tabla `historial_medico`
--
ALTER TABLE `historial_medico`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `registro_entradas_salidas`
--
ALTER TABLE `registro_entradas_salidas`
  ADD PRIMARY KEY (`id_registro`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `id_cita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `datosduenio`
--
ALTER TABLE `datosduenio`
  MODIFY `id_duenio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  MODIFY `id_mascota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `historial_medico`
--
ALTER TABLE `historial_medico`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `registro_entradas_salidas`
--
ALTER TABLE `registro_entradas_salidas`
  MODIFY `id_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `datosmascota`
--
ALTER TABLE `datosmascota`
  ADD CONSTRAINT `datosmascota_ibfk_1` FOREIGN KEY (`id_duenio`) REFERENCES `datosduenio` (`id_duenio`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
