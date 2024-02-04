-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Янв 15 2024 г., 14:49
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `cursovayabdinsubd`
--

-- --------------------------------------------------------

--
-- Структура таблицы `department`
--

CREATE TABLE `department` (
  `department_id` int(11) NOT NULL,
  `department_name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `department_number_phone` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `enterprises_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `department`
--

INSERT INTO `department` (`department_id`, `department_name`, `department_number_phone`, `enterprises_id`) VALUES
(1, 'Отдел разработки', '+375(29)4536345', 1),
(2, 'Отдел проектов', '+375(29)4353343', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `employees`
--

CREATE TABLE `employees` (
  `employees_id` int(11) NOT NULL,
  `department_id` int(11) DEFAULT NULL,
  `employees_surname` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `employees_name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `employees_otchestvo` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `employees_number_phone` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `employees`
--

INSERT INTO `employees` (`employees_id`, `department_id`, `employees_surname`, `employees_name`, `employees_otchestvo`, `employees_number_phone`) VALUES
(1, 1, 'Хваль', 'Александр', 'Викторович', '+375(29)5637345'),
(2, 2, 'Степанов', 'Дмитрий', 'Викторович', '+375(29)5476364');

-- --------------------------------------------------------

--
-- Структура таблицы `enterprises`
--

CREATE TABLE `enterprises` (
  `enterprises_id` int(11) NOT NULL,
  `enterprises_name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `enterprises_adress` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `enterprises`
--

INSERT INTO `enterprises` (`enterprises_id`, `enterprises_name`, `enterprises_adress`) VALUES
(1, 'ООО Софтрайт', 'г. Минск, ул. Захарова, 50В'),
(3, 'ИВЦ Молодечно', 'ул.Ларино, д.78');

-- --------------------------------------------------------

--
-- Структура таблицы `gruppa`
--

CREATE TABLE `gruppa` (
  `gruppa_id` int(11) NOT NULL,
  `gruppa_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `gruppa_academic_year` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `speciality_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `gruppa`
--

INSERT INTO `gruppa` (`gruppa_id`, `gruppa_name`, `gruppa_academic_year`, `speciality_id`) VALUES
(5, 'СП405', '2023-09-01 00:00:00', 1),
(6, 'Б201', '2023-09-01 00:00:00', 4);

-- --------------------------------------------------------

--
-- Структура таблицы `referral_to_industrial_practice`
--

CREATE TABLE `referral_to_industrial_practice` (
  `practice_id` int(11) NOT NULL,
  `students_id` int(32) DEFAULT NULL,
  `employees_id` int(32) DEFAULT NULL,
  `types_id` int(32) DEFAULT NULL,
  `practice_mark` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `practice_date` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `referral_to_industrial_practice`
--

INSERT INTO `referral_to_industrial_practice` (`practice_id`, `students_id`, `employees_id`, `types_id`, `practice_mark`, `practice_date`) VALUES
(3, 2, 1, 1, '1', '1');

-- --------------------------------------------------------

--
-- Структура таблицы `speciality`
--

CREATE TABLE `speciality` (
  `speciality_id` int(11) NOT NULL,
  `speciality_name` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `speciality_specialization` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `speciality`
--

INSERT INTO `speciality` (`speciality_id`, `speciality_name`, `speciality_specialization`) VALUES
(1, 'Системное программирование', 'Программное обеспечение информационных технологий, системное программирование'),
(3, 'Правоведение', 'Правовое хозяйство, кадровая работа'),
(4, 'Бухгалтерский учет', 'Бухгалтерский учет');

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--

CREATE TABLE `students` (
  `students_id` int(11) NOT NULL,
  `students_surname` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `students_name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `students_otchestvo` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `students_number_phone` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `gruppa_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `students`
--

INSERT INTO `students` (`students_id`, `students_surname`, `students_name`, `students_otchestvo`, `students_number_phone`, `gruppa_id`) VALUES
(2, 'Радомский', 'Алексей', 'Дмитриевич', '+375(25)6499473', 5),
(4, '1', '1', '1', '1', 5),
(5, 'Иванов', 'Иван', 'Иванович', '+375(29)4353653', 6),
(6, 'Петров', 'Петр', 'Петрович', '+375(29)4245332', 6);

-- --------------------------------------------------------

--
-- Структура таблицы `types_of_practice`
--

CREATE TABLE `types_of_practice` (
  `types_id` int(11) NOT NULL,
  `typs_of_practice_name` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `typs_of_practice_date` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `types_of_practice_internship_period` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `types_of_practice_start_date` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `types_of_practice_end_date` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `types_of_practice_number` int(11) NOT NULL,
  `types_of_practice_supervisor` varchar(250) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `types_of_practice`
--

INSERT INTO `types_of_practice` (`types_id`, `typs_of_practice_name`, `typs_of_practice_date`, `types_of_practice_internship_period`, `types_of_practice_start_date`, `types_of_practice_end_date`, `types_of_practice_number`, `types_of_practice_supervisor`) VALUES
(1, 'технологическая практика', '2023-09-22', '39 недель, 288 часов', '2023-09-22', '2023-11-16', 4, 'Черепович Олег Антонович');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`department_id`),
  ADD KEY `enterprises_id` (`enterprises_id`);

--
-- Индексы таблицы `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employees_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Индексы таблицы `enterprises`
--
ALTER TABLE `enterprises`
  ADD PRIMARY KEY (`enterprises_id`);

--
-- Индексы таблицы `gruppa`
--
ALTER TABLE `gruppa`
  ADD PRIMARY KEY (`gruppa_id`),
  ADD KEY `speciality_id` (`speciality_id`);

--
-- Индексы таблицы `referral_to_industrial_practice`
--
ALTER TABLE `referral_to_industrial_practice`
  ADD PRIMARY KEY (`practice_id`),
  ADD KEY `students_id` (`students_id`),
  ADD KEY `employees_id` (`employees_id`),
  ADD KEY `types_id` (`types_id`);

--
-- Индексы таблицы `speciality`
--
ALTER TABLE `speciality`
  ADD PRIMARY KEY (`speciality_id`);

--
-- Индексы таблицы `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`students_id`),
  ADD KEY `gruppa_id` (`gruppa_id`);

--
-- Индексы таблицы `types_of_practice`
--
ALTER TABLE `types_of_practice`
  ADD PRIMARY KEY (`types_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `department`
--
ALTER TABLE `department`
  MODIFY `department_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `employees`
--
ALTER TABLE `employees`
  MODIFY `employees_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `enterprises`
--
ALTER TABLE `enterprises`
  MODIFY `enterprises_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `gruppa`
--
ALTER TABLE `gruppa`
  MODIFY `gruppa_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `referral_to_industrial_practice`
--
ALTER TABLE `referral_to_industrial_practice`
  MODIFY `practice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `speciality`
--
ALTER TABLE `speciality`
  MODIFY `speciality_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `students`
--
ALTER TABLE `students`
  MODIFY `students_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `types_of_practice`
--
ALTER TABLE `types_of_practice`
  MODIFY `types_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `department`
--
ALTER TABLE `department`
  ADD CONSTRAINT `department_ibfk_1` FOREIGN KEY (`enterprises_id`) REFERENCES `enterprises` (`enterprises_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `department` (`department_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `gruppa`
--
ALTER TABLE `gruppa`
  ADD CONSTRAINT `gruppa_ibfk_1` FOREIGN KEY (`speciality_id`) REFERENCES `speciality` (`speciality_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `referral_to_industrial_practice`
--
ALTER TABLE `referral_to_industrial_practice`
  ADD CONSTRAINT `referral_to_industrial_practice_ibfk_1` FOREIGN KEY (`students_id`) REFERENCES `students` (`students_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `referral_to_industrial_practice_ibfk_2` FOREIGN KEY (`employees_id`) REFERENCES `employees` (`employees_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `referral_to_industrial_practice_ibfk_3` FOREIGN KEY (`types_id`) REFERENCES `types_of_practice` (`types_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`gruppa_id`) REFERENCES `gruppa` (`gruppa_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
