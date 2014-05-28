<?php

/* SdzRentCarBundle:RentCarViews:IndexRentCar.html.twig */
class __TwigTemplate_26e3b89d3f6312af8c9064b3810c345c8e97954a2597d96344efaeb8d7a55b92 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = $this->env->loadTemplate("SdzRentCarBundle::layout.html.twig");

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'RentCarAppli_body' => array($this, 'block_RentCarAppli_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "SdzRentCarBundle::layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $this->parent->display($context, array_merge($this->blocks, $blocks));
    }

    // line 5
    public function block_title($context, array $blocks = array())
    {
        // line 6
        echo "  Accueil - ";
        $this->displayParentBlock("title", $context, $blocks);
        echo "
";
    }

    // line 9
    public function block_RentCarAppli_body($context, array $blocks = array())
    {
        // line 10
        echo "  
  <p>
      Bienvenue
  </p>
 
      <img src=\"http://localhost/Symfony/web/bundles/RentCar/images/mosaique cars.jpg\" alt=\"image d'accueil\" />
  

";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:IndexRentCar.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  42 => 10,  39 => 9,  32 => 6,  29 => 5,);
    }
}
