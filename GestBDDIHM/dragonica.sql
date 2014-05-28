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
-- Base de données: `dragonica`
--

-- --------------------------------------------------------

--
-- Structure de la table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `iditem` int(11) NOT NULL AUTO_INCREMENT,
  `Itemname` varchar(50) NOT NULL,
  `Description` text NOT NULL,
  `stat1` varchar(50) DEFAULT NULL,
  `stat2` varchar(50) DEFAULT NULL,
  `stat3` varchar(50) DEFAULT NULL,
  `stat4` varchar(50) DEFAULT NULL,
  `stat5` varchar(50) DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  `Classlimit` varchar(15) DEFAULT NULL,
  `Sellprice` varchar(50) NOT NULL,
  `price` varchar(50) NOT NULL,
  PRIMARY KEY (`iditem`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `items`
--

INSERT INTO `items` (`iditem`, `Itemname`, `Description`, `stat1`, `stat2`, `stat3`, `stat4`, `stat5`, `level`, `Classlimit`, `Sellprice`, `price`) VALUES
(1, 'Vieille fourrure', 'fourrure de loup abîmé', 'aucune', 'aucune', 'aucune', 'aucune', 'aucune', 0, 'Bête', '30 pièce de cuivre', '0'),
(2, 'Armure du loup', 'aucune', '+ 2 force', '+ 1 endurance', 'aucune', 'aucune', 'aucune', 8, 'aucune', '1 pièce d''argent', 'aucun'),
(3, 'Bottes du sanglier', 'aucune', '+ 2 agilité', '+ 1 endurance', 'aucune', 'aucune', 'aucune', 6, 'aucune', '80 pièce de cuivre', 'aucune'),
(4, 'Lance impérial', 'Lance de la garde impérial.', '+ 15 force', '+ 3% vitesse d''attaque', '+ 30 vitalité', 'aucune', 'aucune', 20, 'toutes', '60 pièce d''argent', 'non achetable');

-- --------------------------------------------------------

--
-- Structure de la table `monsteranddrop`
--

CREATE TABLE IF NOT EXISTS `monsteranddrop` (
  `idItem` int(11) NOT NULL,
  `idMonstre` int(11) NOT NULL,
  `TauxDrop` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `monsteranddrop`
--

INSERT INTO `monsteranddrop` (`idItem`, `idMonstre`, `TauxDrop`) VALUES
(1, 1, '15%'),
(2, 1, '15%'),
(3, 1, '15%'),
(2, 1, '5%'),
(1, 1, '15%'),
(3, 1, '2%'),
(4, 2, '5%');

-- --------------------------------------------------------

--
-- Structure de la table `monsterandskill`
--

CREATE TABLE IF NOT EXISTS `monsterandskill` (
  `idMonstre` int(11) NOT NULL,
  `idSkill` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `monsterandskill`
--

INSERT INTO `monsterandskill` (`idMonstre`, `idSkill`) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `monsters`
--

CREATE TABLE IF NOT EXISTS `monsters` (
  `idMonstre` int(11) NOT NULL AUTO_INCREMENT,
  `Monstrename` varchar(50) NOT NULL,
  `Level` int(11) NOT NULL,
  `PV` int(11) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Element` varchar(50) NOT NULL,
  `Description` text NOT NULL,
  `Map` varchar(50) NOT NULL,
  `PositionX` int(11) NOT NULL,
  `PositionY` int(11) NOT NULL,
  `PositionZ` int(11) NOT NULL,
  PRIMARY KEY (`idMonstre`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `monsters`
--

INSERT INTO `monsters` (`idMonstre`, `Monstrename`, `Level`, `PV`, `Type`, `Element`, `Description`, `Map`, `PositionX`, `PositionY`, `PositionZ`) VALUES
(1, 'loup gris', 12, 350, 'bête', 'normal', 'loup gris des montagnes etc...', 'Montagne de l''hiver', 50, 120, 70),
(2, 'Ours brun', 12, 520, 'bête', 'aucun', 'Ours brun des forêts.', 'forêt', 8, 486, 54);

-- --------------------------------------------------------

--
-- Structure de la table `skills`
--

CREATE TABLE IF NOT EXISTS `skills` (
  `idSkill` int(11) NOT NULL AUTO_INCREMENT,
  `Skillname` varchar(30) NOT NULL,
  `Classe` varchar(30) NOT NULL,
  `Level` smallint(6) NOT NULL,
  `Categorie` varchar(30) NOT NULL,
  `Element` varchar(30) NOT NULL,
  `TpsIncante` smallint(6) NOT NULL,
  `Portee` int(11) NOT NULL,
  `TpsEffet` int(11) NOT NULL,
  `idEffet` int(11) NOT NULL,
  `DegMin` int(11) NOT NULL,
  `DegMax` int(11) NOT NULL,
  `Cout` int(11) NOT NULL,
  `Description` text NOT NULL,
  PRIMARY KEY (`idSkill`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `skills`
--

INSERT INTO `skills` (`idSkill`, `Skillname`, `Classe`, `Level`, `Categorie`, `Element`, `TpsIncante`, `Portee`, `TpsEffet`, `idEffet`, `DegMin`, `DegMax`, `Cout`, `Description`) VALUES
(1, 'Charge', 'Guerrier', 8, 'corps à corps', 'corps à corps', 0, 25, 1, 2, 0, 0, 0, 'Charge la cible et lui inflige un effet d''étourdissement d''une durée de 1 sec'),
(2, 'Griffure', 'bête', 10, 'Corps à corps', 'normal', 0, 5, 0, 2, 10, 25, 10, 'Griffe la cible et lui inflige des dégâts de type normal');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
