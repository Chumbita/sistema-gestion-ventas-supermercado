-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-09-2024 a las 01:28:41
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `supermercado`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id`, `nombre`) VALUES
(1, 'Lácteos'),
(2, 'Bebidas'),
(3, 'Carnes'),
(4, 'Comestibles'),
(5, 'Panadería'),
(6, 'Frutas y Verduras'),
(7, 'Limpieza');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `marca` varchar(100) NOT NULL,
  `precio` double NOT NULL,
  `cantidad` int(100) NOT NULL,
  `fk_categorias` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`codigo`, `nombre`, `marca`, `precio`, `cantidad`, `fk_categorias`) VALUES
(1, 'Doritos', 'Doritos', 2000, 20, 4),
(2, 'Manteca', 'Sancor', 2500, 20, 1),
(3, 'Leche Entera', 'La Serenísima', 150, 46, 1),
(4, 'Yogurt Natural', 'Ser', 200, 30, 1),
(5, 'Queso Cremoso', 'Cremón', 450, 20, 1),
(6, 'Gaseosa Cola', 'Coca-Cola', 250, 92, 2),
(7, 'Jugo de Naranja', 'Cepita', 180, 60, 2),
(8, 'Vino Tinto', 'Trapiche', 850, 35, 2),
(9, 'Carne Picada', 'La Estancia', 900, 25, 3),
(10, 'Pechuga de Pollo', 'Granja Tres Arroyos', 700, 35, 3),
(11, 'Chorizo', 'Paladini', 600, 15, 3),
(12, 'Pan de Molde', 'Bimbo', 200, 80, 5),
(13, 'Medialunas', 'La Casa del Alfajor', 300, 50, 5),
(14, 'Facturas', 'Confitería del Sol', 400, 40, 5),
(15, 'Manzanas', 'Del Valle', 150, 60, 6),
(16, 'Bananas', 'Tropical', 100, 70, 6),
(17, 'Tomates', 'Huerta Fresca', 120, 90, 6),
(18, 'Lechuga', 'Campo Verde', 80, 75, 6),
(19, 'Zanahorias', 'El Ranchito', 110, 65, 6),
(20, 'Cerveza Rubia', 'Quilmes', 300, 120, 2),
(21, 'Salchichas', 'Vienísima', 400, 55, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `nombre`, `contraseña`) VALUES
(0, 'admin', 'Administrador', 'admin'),
(1, 'santicaldera', 'Santiago Calderón', 'santicaldera'),
(3, 'mextre', 'matias morebo', '420957'),
(4, 'chumbitaluciano', 'Luciano Chumbita', '321456987'),
(5, 'carlosolivera', 'Carlos Olivera', '1234'),
(6, 'mariocart', 'Mario Carrizo', 'mariocart'),
(7, 'aldo', 'Aldo Siciliano', 'admin123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
