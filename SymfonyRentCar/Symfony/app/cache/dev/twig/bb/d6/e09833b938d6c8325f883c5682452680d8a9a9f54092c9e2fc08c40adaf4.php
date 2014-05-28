<?php

/* SdzRentCarBundle:RentCarViews:indexRentCar.html.twig */
class __TwigTemplate_bbd6e09833b938d6c8325f883c5682452680d8a9a9f54092c9e2fc08c40adaf4 extends Twig_Template
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
        // line 3
        echo "
<!DOCTYPE html>
<html>
    <head>
        <title>Bienvenue</title>
    </head>
    <body>
        <h1>Hello ";
        // line 10
        echo twig_escape_filter($this->env, (isset($context["nom"]) ? $context["nom"] : $this->getContext($context, "nom")), "html", null, true);
        echo "</h1>
        
        <p>
            bla bla bla bla
        </p>
    </body>
</html>";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:indexRentCar.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  28 => 10,  19 => 3,);
    }
}
