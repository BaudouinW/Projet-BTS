<?php

/* SdzRentCarBundle:RentCarViews:email.html.twig */
class __TwigTemplate_364102806f93e7d3f7a084254a75b5ff4a0abc6baf6e5c6f47bf03064b2eed75 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        // line 2
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"utf-8\"/>
    </head>
    <body>
        <p> Bonjour </p>
        
        <p>Voici le récapitulatif de votre demande d'emprunt :
        <strong>Véhicule louée</strong>: <br/>
        <strong>Raison de l'emprunt</strong>: </br>
        <strong>Date de début de location</strong>: </br>
        <strong>Date de fin de location</strong>: </br></p>
    </body>
</html>";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:email.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  19 => 2,);
    }
}
