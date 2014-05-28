-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Client: 127.0.0.1
-- Généré le: Ven 16 Mai 2014 à 12:53
-- Version du serveur: 5.5.27-log
-- Version de PHP: 5.4.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `rentcarappli`
--

-- --------------------------------------------------------

--
-- Structure de la table `voiture`
--

CREATE TABLE IF NOT EXISTS `voiture` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `voitureNom` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `marque` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `boiteVitesse` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `typeEssence` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `description` longtext COLLATE utf8_unicode_ci NOT NULL,
  `nombreKilometre` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `dispo` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Contenu de la table `voiture`
--

INSERT INTO `voiture` (`id`, `voitureNom`, `marque`, `boiteVitesse`, `typeEssence`, `description`, `nombreKilometre`, `dispo`) VALUES
(1, 'Test', 'Test', 'Manuelle', 'Sans Plom 95', 'bo', 'bl', 'oui'),
(2, 'Golf 4', 'volkswagen', 'Manuelle', 'Diesel', '- Véhicule de tourisme\r\n- 5 portes\r\n- 4 places', '300000 km', 'oui');

-- --------------------------------------------------------

--
-- Structure de la table `voiturelouer`
--

CREATE TABLE IF NOT EXISTS `voiturelouer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `voiture_id` int(11) NOT NULL,
  `nomEmploye` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `service` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `raisonEmprunt` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `dateDebut` date NOT NULL,
  `dateFin` date NOT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_26815155181A8BA` (`voiture_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

--
-- Déclencheurs `voiturelouer`
--
DROP TRIGGER IF EXISTS `dispo`;
DELIMITER //
CREATE TRIGGER `dispo` AFTER DELETE ON `voiturelouer`
 FOR EACH ROW update voiture set dispo='oui' where voiture.id = old.voiture_id
//
DELIMITER ;
DROP TRIGGER IF EXISTS `undispo`;
DELIMITER //
CREATE TRIGGER `undispo` AFTER INSERT ON `voiturelouer`
 FOR EACH ROW update voiture set dispo='non' where voiture.id in (select voiture_id from voiturelouer)
//
DELIMITER ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `voiturelouer`
--
ALTER TABLE `voiturelouer`
  ADD CONSTRAINT `FK_26815155181A8BA` FOREIGN KEY (`voiture_id`) REFERENCES `voiture` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
