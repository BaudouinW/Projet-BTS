<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

namespace Sdz\RentCarBundle\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Sdz\RentCarBundle\Entity\Voiture;
use Sdz\RentCarBundle\Entity\VoitureLouer;
use Sdz\RentCarBundle\Form\VoitureType;
use Sdz\RentCarBundle\Form\VoitureLouerType;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\ParamConverter;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Template;

class RentCarController extends Controller 
{
    public function indexAction()
    {
        return $this->render('SdzRentCarBundle:RentCarViews:IndexRentCar.html.twig');
    }
    
    public function listeDispoAction()
    {
        $voiture = $this->getDoctrine()->getManager()->getRepository('SdzRentCarBundle:Voiture')->myFindAll();
            
            return $this->render('SdzRentCarBundle:RentCarViews:listeDispo.html.twig', array(
                'voiture' => $voiture
            )); 
    }
    
    public function listeLouerAction()
    {
        $voitureLouer = $this->getDoctrine()->getManager()->getRepository('SdzRentCarBundle:VoitureLouer')->myFindAllLouer();
            
            return $this->render('SdzRentCarBundle:RentCarViews:listeLouer.html.twig', array ('voitureLouer' => $voitureLouer));
    }
    
    
    
    public function louerAction()
    {
        $voitureLouer = new VoitureLouer();
        $form = $this->createForm(new VoitureLouerType(), $voitureLouer);
            
            $request = $this->getRequest();
                       
            if($request->getMethod() == 'POST') {
                $form->bind($request);
                
                if($form->isValid()){
                    
                    $em = $this->getDoctrine()->getManager();
                    $em->persist($voitureLouer);
                    $em->flush();
                    
                    return $this->redirect($this->generateUrl('sdzRentCarAppli_voirLouer', array('id' => $voitureLouer->getId())));
                }
            }
            $message = \Swift_Message::newInstance()
                ->setSubject('Email de récapitulatif de votre emprunt')
                ->setFrom('baudouin-wartel@live.fr')
                ->setTo($voitureLouer->getEmail())
                ->setBody('<html>'.
                            '<head>'.
                                '<meta charset="utf-8"/>'.
                            '</head>'.
                            '<body>'.
                                '<p> Bonjour </p>'.
        
                                 '<p>Voici le récapitulatif de votre demande d\'emprunt :'.
                                    '<strong>Véhicule louée</strong>:'.$voitureLouer->getVoiture(). '<br/>'.
                                    '<strong>Raison de l\'emprunt</strong>:'.$voitureLouer->getRaisonEmprunt().'</br>'.
                                    '<strong>Date de début de location</strong>:'.$voitureLouer->getDateDebut().' </br>'.
                                    '<strong>Date de fin de location</strong>:'.$voitureLouer->getDateFin().' </br>'.
                                '</p>'.
                            '</body>'.
                           '</html>',
                              'text/html'
        );
    
                $this->get('mailer')->send($message);
            
            
            return $this->render('SdzRentCarBundle:RentCarViews:louerVoiture.html.twig', array('voitureLouer' =>$voitureLouer, 'form' => $form->createView()));
    }
    
    public function ajouterVoitureAction()
    {
           $voiture = new Voiture();
           $form = $this->createForm(new VoitureType(), $voiture);
           
           $request = $this->getRequest();
           
           if($request->getMethod() == 'POST'){
               $form->bind($request);
               
               if($form->isValid()){
                   
                   $em = $this->getDoctrine()->getManager();
                   $em->persist($voiture);
                   $em->flush();
                   
                   return $this->redirect($this->generateUrl('sdzRentCarAppli_voir', array('id' => $voiture->getId())));
               }
           }
               
               return $this->render('SdzRentCarBundle:RentCarViews:ajouterVoiture.html.twig', array('form' => $form->createView(),
                   ));
        }
        
       
    }

