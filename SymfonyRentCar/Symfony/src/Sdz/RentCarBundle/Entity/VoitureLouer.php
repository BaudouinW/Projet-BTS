<?php

namespace Sdz\RentCarBundle\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * VoitureLouer
 *
 * @ORM\Table()
 * @ORM\Entity(repositoryClass="Sdz\RentCarBundle\Entity\VoitureLouerRepository")
 */
class VoitureLouer
{
    
    /**
     * @ORM\ManyToOne(targetEntity="Sdz\RentCarBundle\Entity\Voiture")
     * @ORM\JoinColumn(nullable=false)
     */
    
    private $voiture;
    
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
     * @ORM\Column(name="nomEmploye", type="string", length=255)
     */
    private $nomEmploye;

    
    /**
     * @var string
     * 
     * @ORM\Column(name="service", type="string", length=255)
     */
    private $service;
    
    
    /**
     * @var string
     * 
     * @ORM\Column (name="raisonEmprunt", type="string", length=255)
     */
    private $raisonEmprunt;
    
    /**
     * @var string
     * 
     * @ORM\Column (name="email", type="string", length=255)
     */
    private $email;
    
    
    /**
     * @var \DateTime
     *
     * @ORM\Column(name="dateDebut", type="date")
     */
    private $dateDebut;
    
    public function _constructDD()
    {
        $this->dateDebut = new \Datetime();
    }

    /**
     * @var \DateTime
     *
     * @ORM\Column(name="dateFin", type="date")
     */
    private $dateFin;

   public function _contructDF()
   {
       $this->dateFin = new \Datetime();
   }

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
     * setNomEmploye
     * 
     * @param string $nomEmploye
     * @return VoitureLouer
     */
    public function setNomEmploye($nomEmploye)
    {
        $this->nomEmploye = $nomEmploye;
        
        return $nomEmploye;
    }
    
    /**
     * Get nomEmploye
     * 
     * @return string
     */
    public function getNomEmploye()
    {
        return $this->nomEmploye;
    }

    
    /**
     * set service
     * 
     * @param string $service
     * @return VoitureLouer
     */
    public function setService($service)
    {
        $this->service = $service;
        
        return $service;
    }
    
    /**
     * Get service
     * 
     * @return string
     */
    public function getService()
    {
        return $this->service;
    }
    
    /**
     * set raisonEmprunt
     * 
     * @param string $raisonEmprunt
     * @return VoitureLouer
     */
    public function setRaisonEmprunt($raisonEmprunt)
    {
        $this->raisonEmprunt = $raisonEmprunt;
        
        return $raisonEmprunt;
    }
    
    /**
     * get raisonEmprunt
     * 
     * @return string
     */
    public function getRaisonEmprunt()
    {
        return $this->raisonEmprunt;
    }
    
    /**
     * set email
     * 
     * @param string $email
     * @return VoitureLouer
     */
    public function setEmail($email)
    {
        $this->email = $email;
        
        return $email;
    }
    
    /**
     * get email
     * 
     * @return string
     */
    public function getEmail()
    {
        return $this->email;
    }
    
    /**
     * Set dateDebut
     *
     * @param \DateTime $dateDebut
     * @return VoitureLouer
     */
    public function setDateDebut(\Datetime $dateDebut)
    {
        $this->dateDebut = $dateDebut;

        return $this;
    }

    /**
     * Get dateDebut
     *
     * @return \DateTime 
     */
    public function getDateDebut()
    {
        return $this->dateDebut;
    }

    /**
     * Set dateFin
     *
     * @param \DateTime $dateFin
     * @return VoitureLouer
     */
    public function setDateFin(\Datetime $dateFin)
    {
        $this->dateFin = $dateFin;

        return $this;
    }

    /**
     * Get dateFin
     *
     * @return \DateTime 
     */
    public function getDateFin()
    {
        return $this->dateFin;
    }
    
    /**
   * Set voiture
   *
   * @param Sdz\RentCarBundle\Entity\Voiture $voiture
   */
  public function setVoiture(\Sdz\RentCarBundle\Entity\Voiture $voiture)
  {
    $this->voiture = $voiture;
  }

  /**
   * Get voiture
   *
   * @return Sdz\RentCarBundle\Entity\Voiture 
   */
  public function getVoiture()
  {
    return $this->voiture;
  }
}
