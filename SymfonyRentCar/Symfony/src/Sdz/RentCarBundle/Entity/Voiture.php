<?php

namespace Sdz\RentCarBundle\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * Voiture
 *
 * @ORM\Table()
 * @ORM\Entity(repositoryClass="Sdz\RentCarBundle\Entity\VoitureRepository")
 */
class Voiture
{
    /**
     * @var integer
     *
     * @ORM\Column(name="id", type="integer")
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="AUTO")
     */
    private $id;

    /**
     * @var string
     *
     * @ORM\Column(name="voitureNom", type="string", length=255)
     */
    private $voitureNom;

    /**
     * @var string
     *
     * @ORM\Column(name="marque", type="string", length=255)
     */
    private $marque;

    /**
     * @var string
     *
     * @ORM\Column(name="boiteVitesse", type="string", length=255)
     */
    private $boiteVitesse;

    /**
     * @var string
     *
     * @ORM\Column(name="typeEssence", type="string", length=255)
     */
    private $typeEssence;

    /**
     * @var string
     *
     * @ORM\Column(name="description", type="text")
     */
    private $description;

    /**
     * @var string
     *
     * @ORM\Column(name="nombreKilometre", type="string", length=255)
     */
    private $nombreKilometre;

    /**
     * @var string
     *
     * @ORM\Column(name="dispo", type="string", length=3)
     */
    private $dispo;


    /**
     * Get id
     *
     * @return integer 
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Set voitureNom
     *
     * @param string $voitureNom
     * @return Voiture
     */
    public function setVoitureNom($voitureNom)
    {
        $this->voitureNom = $voitureNom;

        return $this;
    }

    /**
     * Get voitureNom
     *
     * @return string 
     */
    public function getVoitureNom()
    {
        return $this->voitureNom;
    }
    
    
    /**
     * Set marque
     *
     * @param string $marque
     * @return Voiture
     */
    public function setMarque($marque)
    {
        $this->marque = $marque;

        return $this;
    }

    /**
     * Get marque
     *
     * @return string 
     */
    public function getMarque()
    {
        return $this->marque;
    }

    /**
     * Set boiteVitesse
     *
     * @param string $boiteVitesse
     * @return Voiture
     */
    public function setBoiteVitesse($boiteVitesse)
    {
        $this->boiteVitesse = $boiteVitesse;

        return $this;
    }

    /**
     * Get boiteVitesse
     *
     * @return string 
     */
    public function getBoiteVitesse()
    {
        return $this->boiteVitesse;
    }

    /**
     * Set typeEssence
     *
     * @param string $typeEssence
     * @return Voiture
     */
    public function setTypeEssence($typeEssence)
    {
        $this->typeEssence = $typeEssence;

        return $this;
    }

    /**
     * Get typeEssence
     *
     * @return string 
     */
    public function getTypeEssence()
    {
        return $this->typeEssence;
    }

    /**
     * Set description
     *
     * @param string $description
     * @return Voiture
     */
    public function setDescription($description)
    {
        $this->description = $description;

        return $this;
    }

    /**
     * Get description
     *
     * @return string 
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Set nombreKilometre
     *
     * @param string $nombreKilometre
     * @return Voiture
     */
    public function setNombreKilometre($nombreKilometre)
    {
        $this->nombreKilometre = $nombreKilometre;

        return $this;
    }

    /**
     * Get nombreKilometre
     *
     * @return string 
     */
    public function getNombreKilometre()
    {
        return $this->nombreKilometre;
    }

    /**
     * Set dispo
     *
     * @param string $dispo
     * @return Voiture
     */
    public function setDispo($dispo)
    {
        $this->dispo = $dispo;

        return $this;
    }

    /**
     * Get dispo
     *
     * @return string 
     */
    public function getDispo()
    {
        return $this->dispo;
    }
}
