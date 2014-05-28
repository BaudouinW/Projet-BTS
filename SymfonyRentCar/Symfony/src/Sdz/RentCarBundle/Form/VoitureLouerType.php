<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace Sdz\RentCarBundle\Form;

use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolverInterface;


class VoitureLouerType extends AbstractType
{
        /**
     * @param FormBuilderInterface $builder
     * @param array $options
     */
    public function buildForm(FormBuilderInterface $builder, array $options)
    {
        $builder
            ->add('voiture','entity', array ('empty_value' => 'Choisissez une voiture', 'class' => 'SdzRentCarBundle:Voiture', 'property' => 'voitureNom', 'label' =>'Choisir le véhicule'))   
            ->add('nomEmploye',  'text', array('label' => 'Nom de l\' employé'))
            ->add('email', 'email', array('label' => 'Adresse email'))
            ->add('service', 'choice', array ('choices' => array ('empty_value' => 'Sélectionner votre service', 'Compta' => 'Compatabilité', '5C' => '5 continents', 'USA' => 'USA', 'Canada' => 'Canada', 'japon' => 'Japon'), 'label' => 'Service'))
            ->add('raisonEmprunt', 'textarea', array ('label' => 'Raison de l\'emprunt'))
            ->add('dateDebut',  'date',array ('label' => 'Date de début de location'))
            ->add('dateFin', 'date', array ('label' => 'Date de fin de location'))    
        ;
    }
    
    /**
     * @param OptionsResolverInterface $resolver
     */
    public function setDefaultOptions(OptionsResolverInterface $resolver)
    {
        $resolver->setDefaults(array(
            'data_class' => 'Sdz\RentCarBundle\Entity\VoitureLouer'
            ));
    }

    /**
     * @return string
     */
    public function getName()
    {
        return 'sdz_rentcarbundle_voiturelouer';
    }
   
}
