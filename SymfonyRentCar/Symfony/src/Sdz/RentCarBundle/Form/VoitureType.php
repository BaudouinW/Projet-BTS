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

class VoitureType extends AbstractType
{
        /**
     * @param FormBuilderInterface $builder
     * @param array $options
     */
    public function buildForm(FormBuilderInterface $builder, array $options)
    {
        $builder
            ->add('voitureNom',  'text', array('label' => 'Nom du véhicule'))
            ->add('marque',  'text')
            ->add('boiteVitesse',  'choice', array ('choices' => array ('empty_value' => 'Choisissez une option', 'Manuelle' => 'Manuelle', 'Automatique' => 'Automatique'), 'label' => 'Boîte de vitesse'))
            ->add('typeEssence',  'choice', array ('choices' => array ('empty_value' => 'Choisissez une option', 'Diesel' => 'Diesel', 'Sans Plomb 95' => 'Sans Plomb 95', 'Sans Plomb 98' => 'Sans Plomb 98'), 'label' => 'Type d\'essence'))
            ->add('description', 'textarea')
            ->add('nombreKilometre',  'text', array ('label' => 'Nombre de kilomètre'))
            ->add('dispo', 'hidden', array ('data' => 'oui'))
            
               
            
        ;
    }
    
    /**
     * @param OptionsResolverInterface $resolver
     */
    public function setDefaultOptions(OptionsResolverInterface $resolver)
    {
        $resolver->setDefaults(array(
            'data_class' => 'Sdz\RentCarBundle\Entity\Voiture'
        ));
    }

    /**
     * @return string
     */
    public function getName()
    {
        return 'sdz_rentcarbundle_voiture';
    }
}
